Option Strict Off
Option Explicit On
Module Modulo
	
	Dim Memorias(50) As Byte
	Dim archivo As String
	Dim bdlocation As String
	Structure registro
		'UPGRADE_NOTE: registro se actualizó a registro_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim registro_Renamed As Short
		Dim Frecuencia As String
		Dim MEMORIA As Byte
		'UPGRADE_WARNING: El tamaño de la cadena de longitud fija debe caber en el búfer. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="3C1E4426-0B80-443E-B943-0627CD55D48B"'
		<VBFixedString(100),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray,SizeConst:=100)> Public Observaciones() As Char
		'UPGRADE_WARNING: El tamaño de la cadena de longitud fija debe caber en el búfer. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="3C1E4426-0B80-443E-B943-0627CD55D48B"'
		<VBFixedString(20),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray,SizeConst:=20)> Public Localidad() As Char
		'UPGRADE_WARNING: El tamaño de la cadena de longitud fija debe caber en el búfer. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="3C1E4426-0B80-443E-B943-0627CD55D48B"'
		<VBFixedString(10),System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray,SizeConst:=10)> Public Banda() As Char
		Dim Fecha As Date
		Dim Comprobado As Boolean
		Dim Exportar As Boolean
		Dim mhz As String
		Dim khz As String
		Dim r As Byte
		Dim s As Byte
	End Structure
	
	Public Function leer() As Object
		archivo = Environ("TEMP") & "\busca.tmp"
		FileOpen(1, archivo, OpenMode.Input)
		Input(1, leer)
		FileClose(1)
	End Function
	
	Sub grabar(ByRef cadena As String)
		archivo = Environ("TEMP") & "\busca.tmp"
		FileOpen(1, archivo, OpenMode.Output)
		WriteLine(1, cadena)
		FileClose(1)
	End Sub
	Public Function LeerFrec() As Object
		archivo = Environ("TEMP") & "\frecuencia.tmp"
		FileOpen(1, archivo, OpenMode.Input)
		Input(1, LeerFrec)
		FileClose(1)
	End Function
	
	Sub grabarFrec(ByRef cadena As String)
		archivo = Environ("TEMP") & "\frecuencia.tmp"
		FileOpen(1, archivo, OpenMode.Output)
		WriteLine(1, cadena)
		FileClose(1)
	End Sub
	Sub CopiaSeguridad()
		FileCopy(CStr(My.Application.Info.DirectoryPath & "\frecuencias.mdb"), Environ("TEMP"))
	End Sub
End Module