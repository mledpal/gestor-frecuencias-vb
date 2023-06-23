Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmAbout
	Inherits System.Windows.Forms.Form
	
	' Opciones de seguridad de clave del Registro...
	Const READ_CONTROL As Integer = &H20000
	Const KEY_QUERY_VALUE As Integer = &H1
	Const KEY_SET_VALUE As Integer = &H2
	Const KEY_CREATE_SUB_KEY As Integer = &H4
	Const KEY_ENUMERATE_SUB_KEYS As Integer = &H8
	Const KEY_NOTIFY As Integer = &H10
	Const KEY_CREATE_LINK As Integer = &H20
	Const KEY_ALL_ACCESS As Double = KEY_QUERY_VALUE + KEY_SET_VALUE + KEY_CREATE_SUB_KEY + KEY_ENUMERATE_SUB_KEYS + KEY_NOTIFY + KEY_CREATE_LINK + READ_CONTROL
	
	' Tipos ROOT de clave del Registro...
	Const HKEY_LOCAL_MACHINE As Integer = &H80000002
	Const ERROR_SUCCESS As Short = 0
	Const REG_SZ As Short = 1 ' Cadena Unicode terminada en valor nulo
	Const REG_DWORD As Short = 4 ' Número de 32 bits
	
	Const gREGKEYSYSINFOLOC As String = "SOFTWARE\Microsoft\Shared Tools Location"
	Const gREGVALSYSINFOLOC As String = "MSINFO"
	Const gREGKEYSYSINFO As String = "SOFTWARE\Microsoft\Shared Tools\MSINFO"
	Const gREGVALSYSINFO As String = "PATH"
	
	Private Declare Function RegOpenKeyEx Lib "advapi32"  Alias "RegOpenKeyExA"(ByVal hKey As Integer, ByVal lpSubKey As String, ByVal ulOptions As Integer, ByVal samDesired As Integer, ByRef phkResult As Integer) As Integer
	Private Declare Function RegQueryValueEx Lib "advapi32"  Alias "RegQueryValueExA"(ByVal hKey As Integer, ByVal lpValueName As String, ByVal lpReserved As Integer, ByRef lpType As Integer, ByVal lpData As String, ByRef lpcbData As Integer) As Integer
	Private Declare Function RegCloseKey Lib "advapi32" (ByVal hKey As Integer) As Integer
	
	
	Private Sub cmdSysInfo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSysInfo.Click
		Call StartSysInfo()
	End Sub
	
	Private Sub cmdOK_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.Click
		Me.Close()
	End Sub
	
	Private Sub frmAbout_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.Text = "Acerca de " & My.Application.Info.Title
		lblversion.Text = "Versión " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Revision
		lblTitle.Text = My.Application.Info.Title
	End Sub
	
	Public Sub StartSysInfo()
		On Error GoTo SysInfoErr
		
		Dim rc As Integer
		Dim SysInfoPath As String
		
		' Intentar obtener ruta de acceso y nombre del programa de Info. del sistema a partir del Registro...
		If GetKeyValue(HKEY_LOCAL_MACHINE, gREGKEYSYSINFO, gREGVALSYSINFO, SysInfoPath) Then
			' Intentar obtener sólo ruta del programa de Info. del sistema a partir del Registro...
		ElseIf GetKeyValue(HKEY_LOCAL_MACHINE, gREGKEYSYSINFOLOC, gREGVALSYSINFOLOC, SysInfoPath) Then 
			' Validar la existencia de versión conocida de 32 bits del archivo
			'UPGRADE_WARNING: Dir tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If (Dir(SysInfoPath & "\MSINFO32.EXE") <> "") Then
				SysInfoPath = SysInfoPath & "\MSINFO32.EXE"
				
				' Error: no se puede encontrar el archivo...
			Else
				GoTo SysInfoErr
			End If
			' Error: no se puede encontrar la entrada del Registro...
		Else
			GoTo SysInfoErr
		End If
		
		Call Shell(SysInfoPath, AppWinStyle.NormalFocus)
		
		Exit Sub
SysInfoErr: 
		MsgBox("La información del sistema no está disponible en este momento", MsgBoxStyle.OKOnly)
	End Sub
	
	Public Function GetKeyValue(ByRef KeyRoot As Integer, ByRef KeyName As String, ByRef SubKeyRef As String, ByRef KeyVal As String) As Boolean
		Dim i As Integer ' Contador de bucle
		Dim rc As Integer ' Código de retorno
		Dim hKey As Integer ' Controlador de una clave de Registro abierta
		Dim hDepth As Integer '
		Dim KeyValType As Integer ' Tipo de datos de una clave de Registro
		Dim tmpVal As String ' Almacenamiento temporal para un valor de clave de Registro
		Dim KeyValSize As Integer ' Tamaño de variable de clave de Registro
		'------------------------------------------------------------
		' Abrir clave de registro bajo KeyRoot {HKEY_LOCAL_MACHINE...}
		'------------------------------------------------------------
		rc = RegOpenKeyEx(KeyRoot, KeyName, 0, KEY_ALL_ACCESS, hKey) ' Abrir clave de Registro
		
		If (rc <> ERROR_SUCCESS) Then GoTo GetKeyError ' Error de controlador...
		
		tmpVal = New String(Chr(0), 1024) ' Asignar espacio de variable
		KeyValSize = 1024 ' Marcar tamaño de variable
		
		'------------------------------------------------------------
		' Obtener valor de clave de Registro...
		'------------------------------------------------------------
		rc = RegQueryValueEx(hKey, SubKeyRef, 0, KeyValType, tmpVal, KeyValSize) ' Obtener o crear valor de clave
		
		If (rc <> ERROR_SUCCESS) Then GoTo GetKeyError ' Controlar errores
		
		If (Asc(Mid(tmpVal, KeyValSize, 1)) = 0) Then ' Win95 agregar cadena terminada en valor nulo...
			tmpVal = VB.Left(tmpVal, KeyValSize - 1) ' Encontrado valor nulo, se va a quitar de la cadena
		Else ' En WinNT las cadenas no terminan en valor nulo...
			tmpVal = VB.Left(tmpVal, KeyValSize) ' No se ha encontrado valor nulo, sólo se va a extraer la cadena
		End If
		'------------------------------------------------------------
		' Determinar tipo de valor de clave para conversión...
		'------------------------------------------------------------
		Select Case KeyValType ' Buscar tipos de datos...
			Case REG_SZ ' Tipo de datos String de clave de Registro
				KeyVal = tmpVal ' Copiar valor de cadena
			Case REG_DWORD ' Tipo de datos Double Word de clave del Registro
				For i = Len(tmpVal) To 1 Step -1 ' Convertir cada bit
					KeyVal = KeyVal & Hex(Asc(Mid(tmpVal, i, 1))) ' Generar valor carácter a carácter
				Next 
				KeyVal = VB6.Format("&h" & KeyVal) ' Convertir Double Word a cadena
		End Select
		
		GetKeyValue = True ' Se ha devuelto correctamente
		rc = RegCloseKey(hKey) ' Cerrar clave de Registro
		Exit Function ' Salir
		
GetKeyError: ' Borrar después de que se produzca un error...
		KeyVal = "" ' Establecer valor a cadena vacía
		GetKeyValue = False ' Fallo de retorno
		rc = RegCloseKey(hKey) ' Cerrar clave de Registro
	End Function
End Class