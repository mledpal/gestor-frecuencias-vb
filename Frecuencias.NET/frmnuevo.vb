Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmnuevo
	Inherits System.Windows.Forms.Form
	Dim estado As Object
	Dim guardada As Boolean
	Private Sub botnuevo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botnuevo.Click
		Dim actualizar As Object
		Dim resp As Object
		Dim khz As Object
		Dim mhz As Object
		Dim punto As Object
		Dim numreg As Object
		guardada = False
		Call frmFrecuencias.SituarBD()
		BD.Refresh()
		
		Dim Respuesta, Ayuda, Estilo, Mensaje, Título, Ctxt, MiCadena As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Mensaje. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Mensaje = "¿Desea continuar?"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Estilo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Estilo = MsgBoxStyle.YesNo + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Título. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Título = "Añadir Registro"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Título. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Estilo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: MsgBox No se admite el parámetro 'context' y se ha quitado. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="54413EB8-EB35-481C-89BE-32525CFC7903"'
		'UPGRADE_WARNING: MsgBox No se admite el parámetro 'helpfile' y se ha quitado. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="54413EB8-EB35-481C-89BE-32525CFC7903"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Respuesta. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Respuesta = MsgBox(Mensaje, Estilo, Título)
		
		If Respuesta = MsgBoxResult.Yes Then
			'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.BOF. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Not BD.Recordset.BOF = True Then
				'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.MoveLast. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				BD.Recordset.MoveLast()
				'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto numreg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				numreg = BD.Recordset("Registro")
			Else
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto numreg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				numreg = 1
			End If
			
			
			' Añadir Registro
			
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			punto = InStr(1, txtFrecuencia.Text, ".")
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			mhz = VB.Left(txtFrecuencia.Text, punto - 1)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			khz = Mid(txtFrecuencia.Text, punto + 1)
			
			If txtFrecuencia.Text = "" Or IsNumeric(mhz) = False Or IsNumeric(khz) = False Then
				MsgBox("Frecuencia Incorrecta", MsgBoxStyle.Critical, "ERROR GRAVE")
				Me.Close()
				Exit Sub
			End If
			
MEMORIA: 
			If IsNumeric(TxtMemoria.Text) = False Then
				MsgBox("La Memoria Introducida no es correcta :" & TxtMemoria.Text, MsgBoxStyle.Information)
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto resp. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				resp = MsgBox("¿Desea Introducir una memoria correcta?", MsgBoxStyle.YesNo)
				If resp = MsgBoxResult.Yes Then
					TxtMemoria.Text = InputBox("Introduzca Memoria : ", "Nueva Memoria")
					GoTo MEMORIA
				Else
					TxtMemoria.Text = "0"
				End If
			End If
			
			Call Me.txtFrecuencia_Change()
			
			If TxtLocalidad.Text = "" Then TxtLocalidad.Text = "N/A"
			If TxtObserv.Text = "" Then TxtObserv.Text = "N/A"
			If IsNumeric(txtr.Text) = False Then txtr.Text = CStr(0)
			If IsNumeric(txts.Text) = False Then txts.Text = CStr(0)
			
			Call guardar()
			If guardada = True Then
				MsgBox("Frecuencia Añadida con Éxito", MsgBoxStyle.Information)
			Else
				MsgBox("Operacion Cancelada", MsgBoxStyle.Exclamation)
			End If
		Else
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto actualizar. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			actualizar = False
		End If
		Me.Visible = False
		Me.Close()
	End Sub
	
	'UPGRADE_WARNING: Form evento frmnuevo.Activate tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmnuevo_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		Dim ultimoregistro As Object
		On Error Resume Next
		BD.Refresh()
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.MoveLast. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BD.Recordset.MoveLast()
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ultimoregistro. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ultimoregistro = BD.Recordset("Registro")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ultimoregistro. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtregistro.Text = CStr(ultimoregistro + 1)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto estado. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		estado = False
	End Sub
	
	
	
	
	'UPGRADE_WARNING: El evento txtFrecuencia.TextChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Sub txtFrecuencia_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFrecuencia.TextChanged
		Dim mhz As Object
		Dim punto As Object
		Dim datos As Object
		Dim fraregistro As Object
		Dim numreg As Object
		On Error Resume Next
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto estado. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If estado = False Then
			BD.Refresh()
			'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.MoveLast. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			BD.Recordset.MoveLast()
			'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto numreg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			numreg = BD.Recordset("Registro") + 1
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto fraregistro.Caption. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto numreg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			fraregistro.Caption = "Registro " & CStr(numreg)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto estado. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			estado = True
		End If
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto datos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		datos = txtFrecuencia.Text
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto datos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		punto = InStr(datos, ".")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto datos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mhz = CShort(Trim(Mid(datos, 1, punto)))
		
		TxtBanda.Text = SelecBanda
		
	End Sub
	Function Frecuencia() As Object
		Dim khz As Object
		Dim mhz As Object
		Dim punto As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		punto = InStr(1, txtFrecuencia.Text, ".")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mhz = VB.Left(txtFrecuencia.Text, punto - 1)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		khz = Mid(txtFrecuencia.Text, punto + 1)
		
		If IsNumeric(mhz) = True And IsNumeric(khz) = True Then
			Select Case Len(mhz)
				Case 1
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					mhz = "00" + mhz
				Case 2
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					mhz = "0" + mhz
			End Select
			
			Select Case Len(khz)
				Case 0
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					khz = "0000"
				Case 1
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					khz = khz + "000"
				Case 2
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					khz = khz + "00"
				Case 3
					'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					khz = khz + "0"
			End Select
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frecuencia. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Frecuencia = mhz + "." + khz
		Else
			
		End If
	End Function
	
	Sub guardar()
		Dim khz As Object
		Dim mhz As Object
		Dim buscamem As Object
		Dim buscafrec As Object
		Dim numreg As Object
		On Error Resume Next
		Call frmFrecuencias.SituarBD()
		BD.Refresh()
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.MoveLast. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BD.Recordset.MoveLast()
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto numreg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		numreg = BD.Recordset("Registro")
		
		'Busca la frecuencia y la memoria en la base de datos
		'y si ya existe genera un mensaje de error
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto buscafrec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		buscafrec = "Frecuencia=" & Chr(39) + Frecuencia + Chr(39)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto buscamem. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		buscamem = "Memoria=" & TxtMemoria.Text
		
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.FindFirst. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BD.Recordset.FindFirst(buscafrec)
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.NoMatch. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If BD.Recordset.NoMatch = False Then
			Call MsgError(1)
			Exit Sub
			Me.Close()
		End If
		
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.FindFirst. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BD.Recordset.FindFirst(buscamem)
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.NoMatch. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If BD.Recordset.NoMatch = False And TxtMemoria.Text <> "0" Then
			Call MsgError(2)
			Me.Close()
			Exit Sub
		End If
		
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.AddNew. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BD.Recordset.AddNew()
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frecuencia. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BD.Recordset(("Frecuencia")) = Frecuencia
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		BD.Recordset(("Memoria")) = CByte(TxtMemoria.Text)
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		BD.Recordset(("Localidad")) = TxtLocalidad.Text
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		BD.Recordset(("Observaciones")) = TxtObserv.Text
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto SelecBanda. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BD.Recordset(("Banda")) = SelecBanda
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		BD.Recordset(("Fecha")) = Today
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto numreg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BD.Recordset(("Registro")) = numreg + 1
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		BD.Recordset(("Comprobado")) = chkcomprobado.CheckState
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		BD.Recordset(("R")) = txtr.Text
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		BD.Recordset(("S")) = txts.Text
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		BD.Recordset(("CTCSS")) = txtctcss.Text
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		BD.Recordset(("DCS")) = txtdcs.Text
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		BD.Recordset(("Exportar")) = True
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BD.Recordset(("Mhz")) = mhz
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BD.Recordset(("khz")) = khz
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.Update. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BD.Recordset.Update()
		
		guardada = True
	End Sub
	
	Sub MsgError(ByRef ErrNum As Short)
		Dim reg As Object
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto reg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		reg = BD.Recordset("Registro")
		Select Case ErrNum
			Case 1
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto reg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MsgBox("La Frecuencia ya existe en el registro " & CStr(reg))
			Case 2
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto reg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MsgBox("La Memoria esta ocupada por la frecuencia del registro " & CStr(reg))
		End Select
		guardada = False
		Exit Sub
		Me.Close()
	End Sub
	
	Function SelecBanda() As Object
		Dim mhz As Object
		Dim punto As Object
		Dim datos As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto datos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		datos = txtFrecuencia.Text
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto datos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		punto = InStr(datos, ".")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto datos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mhz = CShort(Trim(Mid(datos, 1, punto)))
		
		Select Case mhz
			Case 120 To 200
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto SelecBanda. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				SelecBanda = "2 m"
				
			Case 300 To 500
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto SelecBanda. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				SelecBanda = "70 cm"
				
			Case Is > 800
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto SelecBanda. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				SelecBanda = "900 Mhz"
				
			Case 20 To 40
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto SelecBanda. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				SelecBanda = "27 Mhz"
				
			Case Else
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto SelecBanda. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				SelecBanda = "2 m"
		End Select
	End Function
End Class