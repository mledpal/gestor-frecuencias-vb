Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmResultados
	Inherits System.Windows.Forms.Form
	Dim Criterio As String
	Dim cadenabusqueda As String
	
	Private Sub botactualiza_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botactualiza.Click
		Dim actualizar As Object
		Dim Frecuencia As Object
		Dim khz As Object
		Dim mhz As Object
		Dim punto As Object
		Dim Frec As Object
		Dim r As Object
		
		cadenabusqueda = ""
		Dim Respuesta, Ayuda, Estilo, Mensaje, Título, Ctxt, MiCadena As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Mensaje. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Mensaje = "¿Desea continuar?"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Estilo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Estilo = MsgBoxStyle.YesNo + MsgBoxStyle.Information + MsgBoxStyle.DefaultButton1
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Título. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Título = "Actualizar Registro"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Título. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Estilo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: MsgBox No se admite el parámetro 'context' y se ha quitado. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="54413EB8-EB35-481C-89BE-32525CFC7903"'
		'UPGRADE_WARNING: MsgBox No se admite el parámetro 'helpfile' y se ha quitado. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="54413EB8-EB35-481C-89BE-32525CFC7903"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Respuesta. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Respuesta = MsgBox(Mensaje, Estilo, Título)
		
		If Respuesta = MsgBoxResult.Yes Then
			'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.Edit. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			BD.Recordset.Edit()
			
			If txtFrecuencia.Text = "" Then
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto r. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				r = MsgBox("Introduzca una frecuencia", MsgBoxStyle.Critical, "ERROR GRAVE")
			Else
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Frec = txtFrecuencia.Text
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				punto = InStr(Frec, ".")
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				mhz = VB.Left(Frec, punto - 1)
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto punto. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				khz = Mid(Frec, punto + 1)
				
				Select Case Len(mhz)
					Case 0
						'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						mhz = "000"
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
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frecuencia. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				txtFrecuencia.Text = Frecuencia
				'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frecuencia. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				BD.Recordset(("Frecuencia")) = Frecuencia
			End If
			
			If TxtMemoria.Text = "" Then TxtMemoria.Text = ""
			'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			BD.Recordset(("Memoria")) = CShort(TxtMemoria.Text)
			
			If txtfecha.Text = "" Then txtfecha.Text = CStr(Today)
			'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			BD.Recordset(("Fecha")) = CDate(txtfecha.Text)
			
			If TxtBanda.Text = "" Then TxtBanda.Text = "2 m"
			'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			BD.Recordset(("Banda")) = TxtBanda.Text
			
			If TxtLocalidad.Text = "" Then TxtLocalidad.Text = "N/A"
			'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			BD.Recordset(("Localidad")) = TxtLocalidad.Text
			
			If TxtObserv.Text = "" Then TxtObserv.Text = "N/A"
			'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			BD.Recordset(("Observaciones")) = TxtObserv.Text
			
			If IsNumeric(txtr.Text) = False Then txtr.Text = "0"
			If IsNumeric(txts.Text) = False Then txts.Text = "0"
			
			'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			BD.Recordset(("R")) = txtr.Text
			'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			BD.Recordset(("S")) = txts.Text
			
			'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			BD.Recordset(("DCS")) = txtdcs.Text
			'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			BD.Recordset(("CTCSS")) = txtctcss.Text
			
			'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			BD.Recordset(("Comprobado")) = chkcomprobado.CheckState
			
			'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.Update. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			BD.Recordset.Update()
			MsgBox("Registro Actualizado con éxito", MsgBoxStyle.Information)
		Else
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto actualizar. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			actualizar = False
		End If
		botactualiza.Enabled = False
		Call Me.Form_Activate()
	End Sub
	
	Private Sub botant_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botant.Click
		botactualiza.Enabled = False
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto leer(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Criterio = leer()
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.FindPrevious. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BD.Recordset.FindPrevious(Criterio)
	End Sub
	
	Private Sub botborrar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botborrar.Click
		Dim actualizar As Object
		Dim Respuesta, Ayuda, Estilo, Mensaje, Título, Ctxt, MiCadena As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Mensaje. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Mensaje = "¿Desea continuar?"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Estilo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Estilo = MsgBoxStyle.YesNo + MsgBoxStyle.Critical + MsgBoxStyle.DefaultButton2
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Título. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Título = "Borrar Registro"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Título. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Estilo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: MsgBox No se admite el parámetro 'context' y se ha quitado. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="54413EB8-EB35-481C-89BE-32525CFC7903"'
		'UPGRADE_WARNING: MsgBox No se admite el parámetro 'helpfile' y se ha quitado. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="54413EB8-EB35-481C-89BE-32525CFC7903"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Respuesta. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Respuesta = MsgBox(Mensaje, Estilo, Título)
		
		If Respuesta = MsgBoxResult.Yes Then
			'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.Delete. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			BD.Recordset.Delete()
			'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.MoveFirst. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			BD.Recordset.MoveFirst()
			BD.Refresh()
			Call frmOptions.botorden_Click(Nothing, New System.EventArgs())
			
			Call Me.Form_Activate()
		Else
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto actualizar. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			actualizar = False
		End If
	End Sub
	
	Private Sub botfirst_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botfirst.Click
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto leer(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Criterio = leer()
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.FindFirst. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BD.Recordset.FindFirst(Criterio)
		botactualiza.Enabled = False
	End Sub
	
	Private Sub botinicio_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botinicio.Click
		
		frmFrecuencias.txtira.Text = NumReg.Text
		cadenabusqueda = ""
		Modulo.grabar((cadenabusqueda))
		Me.Close()
		frmFrecuencias.Visible = True
		
		
	End Sub
	
	Private Sub botlast_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botlast.Click
		botactualiza.Enabled = False
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto leer(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Criterio = leer()
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.FindLast. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BD.Recordset.FindLast(Criterio)
	End Sub
	
	Private Sub botmem_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botmem.Click
		'UPGRADE_NOTE: modal se actualizó a modal_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim modal_Renamed As Object
		VB6.ShowForm(frmmapamemoria, (modal_Renamed))
	End Sub
	
	Private Sub botnueva_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botnueva.Click
		'UPGRADE_NOTE: modal se actualizó a modal_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim modal_Renamed As Object
		cadenabusqueda = ""
		Modulo.grabar((cadenabusqueda))
		Me.Close()
		frmbuscar.Visible = True
		VB6.ShowForm(frmbuscar, (modal_Renamed))
	End Sub
	
	Private Sub botrepet_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botrepet.Click
		'UPGRADE_NOTE: modal se actualizó a modal_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim modal_Renamed As Object
		Dim cadena As Object
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadena. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cadena = VB.Right(txtFrecuencia.Text, 9)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadena. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cadena = VB.Left(cadena, 8)
		Modulo.grabarFrec((cadena))
		VB6.ShowForm(frmrepetidores, (modal_Renamed))
		
	End Sub
	
	Private Sub BotSig_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles BotSig.Click
		botactualiza.Enabled = False
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto leer(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Criterio = leer()
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.FindNext. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BD.Recordset.FindNext(Criterio)
	End Sub
	
	Private Sub chkcomprobado_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkcomprobado.Enter
		botactualiza.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: Form evento frmResultados.Activate tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Sub frmResultados_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		Dim Registros As Object
		Call frmFrecuencias.SituarBD()
		BD.Refresh()
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto leer(). Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Criterio = leer()
		Me.Text = "Resultados de : " & Criterio
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.FindFirst. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BD.Recordset.FindFirst(Criterio)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Registros. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Registros = 0
		Do 
			'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.FindNext. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			BD.Recordset.FindNext(Criterio)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Registros. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Registros = Registros + 1
			'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.NoMatch. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Loop While BD.Recordset.NoMatch = False
		
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.FindFirst. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BD.Recordset.FindFirst(Criterio)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Registros. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtencontrados.Text = Registros
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Registros. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If CShort(Registros) > 1 Then
			botfirst.Enabled = True
			botlast.Enabled = True
		End If
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Registros. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If CShort(Registros) = 1 Then
			BotSig.Enabled = False
			botant.Enabled = False
		End If
		
	End Sub
	
	'UPGRADE_WARNING: El evento txtdcs.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtdcs_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtdcs.SelectedIndexChanged
		botactualiza.Enabled = True
	End Sub
	
	
	'UPGRADE_WARNING: El evento txtctcss.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtctcss_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtctcss.SelectedIndexChanged
		botactualiza.Enabled = True
	End Sub
	
	Private Sub txtFrecuencia_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFrecuencia.Click
		botactualiza.Enabled = True
	End Sub
	
	Private Sub TxtMemoria_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtMemoria.Click
		botactualiza.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: El evento TxtBanda.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TxtBanda_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtBanda.SelectedIndexChanged
		botactualiza.Enabled = True
	End Sub
	
	Private Sub TxtObserv_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtObserv.Click
		botactualiza.Enabled = True
	End Sub
	
	Private Sub TxtLocalidad_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtLocalidad.Click
		botactualiza.Enabled = True
	End Sub
	
	Private Sub txtfecha_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtfecha.Click
		botactualiza.Enabled = True
	End Sub
	
	Private Sub txtr_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtr.Click
		botactualiza.Enabled = True
	End Sub
	
	Private Sub txts_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txts.Click
		botactualiza.Enabled = True
	End Sub
End Class