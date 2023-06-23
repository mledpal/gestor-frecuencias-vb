Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmrepetidores
	Inherits System.Windows.Forms.Form
	Dim mhz, khz As Object
	Dim frecu As Decimal
	Dim rep(5) As Object
	Dim otrafrec As String
	Dim cadenasbusqueda(5) As String
	
	Sub verrepetidores()
		Dim khzs As Object
		Dim mhzs As Object
		Dim coma As Object
		Dim n As Object
		Dim punto As Object
		Dim Frecuencia As Object
		On Error Resume Next
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Modulo.LeerFrec(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frecuencia. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Frecuencia = Modulo.LeerFrec()
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frecuencia. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Frecuencia = Mid(Frecuencia, 1, 8)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frecuencia. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtFrecuencia.Text = Frecuencia
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frecuencia. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		punto = InStr(Frecuencia, ".")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frecuencia. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mhz = VB.Left(Frecuencia, punto - 1)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frecuencia. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		khz = Mid(Frecuencia, punto + 1)
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		frecu = mhz + (khz / 10000)
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rep(0). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rep(0) = CStr(frecu + 0.6)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rep(1). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rep(1) = CStr(frecu - 0.6)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rep(2). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rep(2) = CStr(frecu + 4.6)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rep(3). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rep(3) = CStr(frecu - 4.6)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rep(4). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rep(4) = CStr(frecu + 7.6)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rep(5). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rep(5) = CStr(frecu - 7.6)
		
		For n = 0 To 5
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rep(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto coma. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			coma = InStr(rep(n), ",")
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto coma. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rep(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhzs. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			mhzs = VB.Left(rep(n), coma - 1)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto coma. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rep(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khzs. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			khzs = Mid(rep(n), coma + 1)
			
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhzs. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Len(mhzs) = 0 Then mhzs = "000"
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhzs. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Len(mhzs) = 1 Then mhzs = "00" + mhzs
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhzs. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Len(mhzs) = 2 Then mhzs = "0" + mhzs
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khzs. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Len(khzs) = 0 Then khzs = "0000"
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khzs. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Len(khzs) = 1 Then khzs = khzs + "000"
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khzs. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Len(khzs) = 2 Then khzs = khzs + "00"
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khzs. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Len(khzs) = 3 Then khzs = khzs + "0"
			
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khzs. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhzs. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rep(n). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			rep(n) = mhzs + "." + khzs
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rep(n). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			txtrep(n).Text = rep(n)
		Next n
		
		For n = 0 To 5
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto rep(n). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cadenasbusqueda(n) = "Frecuencia=" & Chr(39) + rep(n) + Chr(39)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto n. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.FindFirst. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			bd.Recordset.FindFirst(cadenasbusqueda(n))
			
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.NoMatch. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If bd.Recordset.NoMatch = False Then
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				NumReg(n).Text = bd.Recordset("Registro")
				txtrep(n).BackColor = System.Drawing.Color.Blue
				txtrep(n).ForeColor = System.Drawing.Color.Yellow
				botver(n).Enabled = True
			Else
				NumReg(n).Text = "No"
			End If
			
		Next n
		
	End Sub
	
	Private Sub botguardar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botguardar.Click
		'UPGRADE_NOTE: modal se actualizó a modal_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim modal_Renamed As Object
		Dim opcion As Object
		Dim frecuenciabuscada As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Modulo.LeerFrec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto frecuenciabuscada. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		frecuenciabuscada = Modulo.LeerFrec
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto opcion. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		opcion = MsgBox("¿Desea Añadir dicha Frecuencia?", MsgBoxStyle.YesNo, "Añadir Frecuencia")
		
		If opcion = MsgBoxResult.Yes Then
			Me.Close()
			VB6.ShowForm(frmnuevo, (modal_Renamed))
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto frecuenciabuscada. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			frmnuevo.txtFrecuencia.Text = frecuenciabuscada
			frmnuevo.TxtObserv.Text = "Nueva Busqueda"
		End If
		
		botguardar.Visible = False
		
	End Sub
	
	Private Sub botver_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botver.Click
		Dim Index As Short = botver.GetIndex(eventSender)
		'UPGRADE_NOTE: modal se actualizó a modal_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim modal_Renamed As Object
		Modulo.grabar((cadenasbusqueda(Index)))
		VB6.ShowForm(frmResultados, (modal_Renamed))
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Dim punto As Object
		
		otrafrec = InputBox("Otra frecuencia para comprobar repetidores", "Frecuencia")
		
		
		If otrafrec = "" Then
			MsgBox("No Ha introducido ninguna frecuencia", MsgBoxStyle.Information)
			Exit Sub
		End If
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		punto = InStr(1, otrafrec, ".")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mhz = VB.Left(otrafrec, punto - 1)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		khz = Mid(otrafrec, punto + 1)
		
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
			otrafrec = mhz + "." + khz
		Else
			
		End If
		
		
		Modulo.grabarFrec((otrafrec))
		
		Call frmFrecuencias.SituarBD()
		bd.Refresh()
		Call verrepetidores()
		
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		'UPGRADE_NOTE: modal se actualizó a modal_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim modal_Renamed As Object
		Dim cadenabusqueda As Object
		Dim limiti As Object
		Dim limits As Object
		Dim punto As Object
		Dim Frecuencia As Object
		'desplazamiento = InputBox("Introduzca el AB para búsqueda", "Ancho de banda de búsqueda")
		
		' Busqueda en un AB de 50 khz
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frecuencia. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Frecuencia = txtFrecuencia.Text
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frecuencia. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		punto = InStr(1, Frecuencia, ".")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frecuencia. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mhz = VB.Left(Frecuencia, punto - 1)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frecuencia. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		khz = Mid(Frecuencia, punto + 1)
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto limits. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		limits = khz + 50
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto limiti. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		limiti = khz - 50
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto limits. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto limiti. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenabusqueda. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cadenabusqueda = "Mhz=" & Chr(39) & CStr(mhz) & Chr(39) & " and ( khz>" & Chr(39) & CStr(limiti) & Chr(39) & " and khz<" & Chr(39) & CStr(limits) & Chr(39) & ")"
		
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.FindFirst. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		bd.Recordset.FindFirst(cadenabusqueda)
		
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.NoMatch. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Not bd.Recordset.NoMatch Then
			Modulo.grabar((cadenabusqueda))
			Me.Close()
			VB6.ShowForm(frmResultados, (modal_Renamed))
		Else
			MsgBox("No hay frecuencias cercanas en un margen de 50 Khz")
		End If
		
	End Sub
	
	'UPGRADE_WARNING: Form evento frmrepetidores.Activate tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Sub frmrepetidores_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		Call frmFrecuencias.SituarBD()
		bd.Refresh()
		Call verrepetidores()
	End Sub
	
	Private Sub frmrepetidores_GotFocus(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.GotFocus
		Call frmFrecuencias.SituarBD()
		bd.Refresh()
		Call verrepetidores()
	End Sub
	
	Sub adaptar(ByRef mhzs As Object, ByRef khzs As String)
		
		Select Case Len(mhzs)
			Case 1
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhzs. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				mhzs = "00" + mhzs
			Case 2
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhzs. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				mhzs = "0" + mhzs
		End Select
		
		Select Case Len(khzs)
			Case 0
				khzs = "0000"
			Case 1
				khzs = khzs & "000"
			Case 2
				khzs = khzs & "00"
			Case 3
				khzs = khzs & "0"
		End Select
	End Sub
End Class