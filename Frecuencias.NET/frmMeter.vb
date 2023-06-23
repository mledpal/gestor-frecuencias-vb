Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmFrecuencias
	Inherits System.Windows.Forms.Form
	Dim Memorias(50) As Byte
	Dim Valor As Boolean
	Dim grabar As Boolean
	'UPGRADE_ISSUE: El evento Data BD.Reposition no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub BD_Reposition()
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.RecordCount. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RegTotal.Text = bd.Recordset.RecordCount
		botactualiza.Enabled = False
		
	End Sub
	Private Sub botacerca_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botacerca.Click
		frmAbout.Visible = True
	End Sub
	
	Private Sub botactualiza_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botactualiza.Click
		Dim MEMORIA As Object
		Dim reg As Object
		Dim cadenamem As Object
		Dim Respuesta, Ayuda, Estilo, Mensaje, Título, Ctxt, MiCadena As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Mensaje. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Mensaje = "¿Desea continuar?"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Estilo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Estilo = MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton1
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Título. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Título = "Actualizar Registro"
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Título. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Estilo. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: MsgBox No se admite el parámetro 'context' y se ha quitado. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="54413EB8-EB35-481C-89BE-32525CFC7903"'
		'UPGRADE_WARNING: MsgBox No se admite el parámetro 'helpfile' y se ha quitado. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="54413EB8-EB35-481C-89BE-32525CFC7903"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Respuesta. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Respuesta = MsgBox(Mensaje, Estilo, Título)
		
		If Respuesta = MsgBoxResult.Yes Then
			
			If txtFrecuencia.Text = "" Then
				MsgBox("Introduzca una frecuencia", MsgBoxStyle.Critical, "Frecuencia No Válida")
				grabar = False
			Else
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.Edit. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				bd.Recordset.Edit()
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				bd.Recordset(("Frecuencia")) = txtFrecuencia.Text
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.Update. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				bd.Recordset.Update()
				GoTo Mensaje
				Exit Sub
			End If
			
			
			If TxtMemoria.Text = "" Then TxtMemoria.Text = "0"
			
			If IsNumeric(TxtMemoria.Text) = False Then
				MsgBox("Valor no válido", MsgBoxStyle.Critical)
				grabar = False
			End If
			
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenamem. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cadenamem = "Memoria=" & TxtMemoria.Text
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.FindFirst. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			bd.Recordset.FindFirst(cadenamem)
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.NoMatch. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If bd.Recordset.NoMatch = False Then
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto reg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				reg = bd.Recordset("Registro")
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto reg. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MsgBox("La Memoria Esta siendo Utilizada por el registro : " & Str(reg), MsgBoxStyle.Critical)
				grabar = False
				Exit Sub
			End If
			
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto MEMORIA. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			MEMORIA = CShort(TxtMemoria.Text)
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto MEMORIA. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If MEMORIA >= 0 And MEMORIA <= 50 Then
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.Edit. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				bd.Recordset.Edit()
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				bd.Recordset(("Memoria")) = TxtMemoria.Text
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.Update. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				bd.Recordset.Update()
				GoTo Mensaje
				Exit Sub
			Else
				MsgBox("Solo dispone de las memorias 1 a 50 y la auxiliar 0", MsgBoxStyle.Information)
				Exit Sub
			End If
			
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.Edit. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			bd.Recordset.Edit()
			grabar = True
			
			If TxtBanda.Text = "" Then TxtBanda.Text = "2 m"
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			bd.Recordset(("Banda")) = TxtBanda.Text
			
			If TxtLocalidad.Text = "" Then TxtLocalidad.Text = "N/A"
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			bd.Recordset(("Localidad")) = TxtLocalidad.Text
			
			If txtfecha.Text = "" Then txtfecha.Text = CStr(Today)
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			bd.Recordset(("Fecha")) = CDate(txtfecha.Text)
			
			If TxtObserv.Text = "" Then TxtObserv.Text = "N/A"
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			bd.Recordset(("Observaciones")) = TxtObserv.Text
			
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			bd.Recordset(("Comprobado")) = chkcomprobado.CheckState
			
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			If IsNumeric(txtr.Text) = True Then bd.Recordset(("R")) = txtr.Text
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			If IsNumeric(txts.Text) = True Then bd.Recordset(("S")) = txts.Text
			
			If grabar = True Then
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.Update. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				bd.Recordset.Update()
Mensaje: 
				MsgBox("Frecuencia Modificada con Éxito", MsgBoxStyle.Information)
			End If
		Else
			grabar = False
		End If
		botactualiza.Enabled = False
	End Sub
	
	Private Sub botborrar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botborrar.Click
		Dim actualizar As Object
		On Error Resume Next
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
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.Delete. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			bd.Recordset.Delete()
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.MoveFirst. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			bd.Recordset.MoveFirst()
			bd.Refresh()
			Call frmOptions.botorden_Click(Nothing, New System.EventArgs())
		Else
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto actualizar. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			actualizar = False
		End If
		If Err.Number = 3021 Then MsgBox("No hay ningun registro para borrar", MsgBoxStyle.Information)
	End Sub
	
	Private Sub botbusca_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botbusca.Click
		'UPGRADE_NOTE: modal se actualizó a modal_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim modal_Renamed As Object
		VB6.ShowForm(frmbuscar, (modal_Renamed))
	End Sub
	
	Private Sub botir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botir.Click
		Dim Criterio As Object
		If Len(txtira.Text) > 0 And IsNumeric(txtira.Text) Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Criterio. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Criterio = "Registro=" & txtira.Text
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.FindFirst. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			bd.Recordset.FindFirst(Criterio)
			
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.NoMatch. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If bd.Recordset.NoMatch = True Then
				MsgBox("No Existe el Registro Indicado", MsgBoxStyle.Critical)
			End If
		Else
			MsgBox("Valor Introducido No Válido", MsgBoxStyle.Critical)
		End If
		txtira.Text = ""
		botir.Enabled = False
	End Sub
	
	Private Sub botmem_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botmem.Click
		'UPGRADE_NOTE: modal se actualizó a modal_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim modal_Renamed As Object
		VB6.ShowForm(frmmapamemoria, (modal_Renamed))
	End Sub
	
	Private Sub botopciones_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botopciones.Click
		'UPGRADE_NOTE: modal se actualizó a modal_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim modal_Renamed As Object
		frmOptions.Visible = True
		VB6.ShowForm(frmOptions, (modal_Renamed))
	End Sub
	
	Sub botrepet_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botrepet.Click
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
	
	'UPGRADE_WARNING: El evento chkcomprobado.CheckStateChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkcomprobado_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkcomprobado.CheckStateChanged
		botactualiza.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: Form evento frmFrecuencias.Activate tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Sub frmFrecuencias_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		
		On Error Resume Next
		Call SituarBD()
		bd.Refresh()
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.MoveLast. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		bd.Recordset.MoveLast()
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.MoveFirst. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		bd.Recordset.MoveFirst()
		
	End Sub
	
	Private Sub frmFrecuencias_GotFocus(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.GotFocus
		'UPGRADE_WARNING: Form evento frmFrecuencias.Activated tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
		frmFrecuencias_Activated(Me, New System.EventArgs())
	End Sub
	
	Sub frmFrecuencias_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		On Error Resume Next
		frminicio.Close()
		frmAbout.Close()
		frmborrarbd.Close()
		frmbuscar.Close()
		frmnuevo.Close()
		frmOptions.Close()
		frmResultados.Close()
		frmrepetidores.Close()
		frmexportar.Close()
		frmimportar.Close()
		frmmapamemoria.Close()
		Me.Visible = False
		Me.Close()
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.Close. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		bd.Recordset.Close()
		
	End Sub
	
	
	
	'UPGRADE_WARNING: El evento txtctcss.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtctcss_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtctcss.SelectedIndexChanged
		botactualiza.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: El evento txtdcs.SelectedIndexChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtdcs_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtdcs.SelectedIndexChanged
		botactualiza.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: El evento txtFrecuencia.TextChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtFrecuencia_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFrecuencia.TextChanged
		Dim khz As Object
		Dim mhz As Object
		Dim datos As Object
		
		On Error Resume Next
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto datos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		datos = bd.Recordset("Frecuencia")
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto datos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mhz = VB.Left(datos, 3)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto datos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		khz = VB.Right(datos, 4)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto khz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto mhz. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto datos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		datos = mhz + "." + khz
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto datos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		txtFrecuencia.Text = datos
		
	End Sub
	
	Private Sub botnuevo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botnuevo.Click
		'UPGRADE_NOTE: modal se actualizó a modal_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim modal_Renamed As Object
		frmnuevo.Visible = True
		VB6.ShowForm(frmnuevo, (modal_Renamed))
	End Sub
	
	Private Sub txtFrecuencia_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFrecuencia.Click
		botactualiza.Enabled = True
	End Sub
	
	Private Sub txtir_Click()
		botir.Enabled = True
	End Sub
	
	'UPGRADE_WARNING: El evento txtira.TextChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtira_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtira.TextChanged
		botir.Enabled = True
		VB6.SetDefault(botir, True)
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
	
	'UPGRADE_ISSUE: El evento Data BD.Error no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub BD_Error(ByRef DataErr As Short, ByRef Response As Short)
		On Error Resume Next
		If Err.Number = 3021 Then
			MsgBox("No hay almacenado ningun registro en la Base de Datos actualmente", MsgBoxStyle.Information)
		End If
		
		If Err.Number = 3045 Then
			MsgBox("El Gestor esta cargado y ejecutandose actualmente", MsgBoxStyle.Information)
			End
		End If
		
		If Err.Number = 3356 Then
			MsgBox("Hay alguna aplicacion usando la base de datos actualmente. Cierrela y reinicie esta aplicacion", MsgBoxStyle.Information)
			End
		End If
		
	End Sub
	
	Sub Mostrar(ByRef Valor As Boolean)
		Dim botcerrar As Object
		Dim botabrir As Object
		
		botnuevo.Enabled = Valor
		botbusca.Enabled = Valor
		botactualiza.Enabled = Valor
		botborrar.Enabled = Valor
		botacerca.Enabled = Valor
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto botabrir.Visible. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		botabrir.Visible = Not (Valor)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto botcerrar.Visible. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		botcerrar.Visible = Valor
		'registro.Visible = Valor
		NumeroReg.Visible = Valor
		bd.Visible = Valor
		
		If Valor = True Then
			bd.Refresh()
		Else
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.Close. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			bd.Recordset.Close()
			Me.Close()
			End
		End If
		
	End Sub
	
	Public Sub SituarBD()
		Dim basedatos As String
		
		basedatos = My.Application.Info.DirectoryPath & "\frecuencias.mdb"
		'UPGRADE_ISSUE: Data propiedad bd.DatabaseName no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		bd.DatabaseName = basedatos
		'UPGRADE_ISSUE: Data propiedad bd.DefaultType no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		bd.DefaultType = 2
		'UPGRADE_ISSUE: Data propiedad bd.Connect no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		bd.Connect = "Access"
		'UPGRADE_ISSUE: Data propiedad bd.RecordsetType no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		bd.RecordsetType = 1
		'UPGRADE_ISSUE: Data propiedad bd.RecordSource no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		bd.RecordSource = "Frecuencias"
		bd.Refresh()
		
		'UPGRADE_ISSUE: Data propiedad bd.DatabaseName no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		Me.bd.DatabaseName = basedatos
		'UPGRADE_ISSUE: Data propiedad bd.DatabaseName no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		frmborrarbd.bd.DatabaseName = basedatos
		'UPGRADE_ISSUE: Data propiedad bd.DatabaseName no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		frmnuevo.bd.DatabaseName = basedatos
		'UPGRADE_ISSUE: Data propiedad bd.DatabaseName no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		frmOptions.bd.DatabaseName = basedatos
		'UPGRADE_ISSUE: Data propiedad bd.DatabaseName no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		frmResultados.bd.DatabaseName = basedatos
		'UPGRADE_ISSUE: Data propiedad bd.DatabaseName no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		frmbuscar.bd.DatabaseName = basedatos
		'UPGRADE_ISSUE: Data propiedad bd.DatabaseName no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		frmrepetidores.bd.DatabaseName = basedatos
		'UPGRADE_ISSUE: Data propiedad bd.DatabaseName no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		frmexportar.bd.DatabaseName = basedatos
		'UPGRADE_ISSUE: Data propiedad bd.DatabaseName no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		frmmapamemoria.bd.DatabaseName = basedatos
		'UPGRADE_ISSUE: Data propiedad bd.DatabaseName no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		frmimportar.bd.DatabaseName = basedatos
		'UPGRADE_ISSUE: Data propiedad bd.DatabaseName no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		frmborrarbd.bd.DatabaseName = basedatos
		
	End Sub
	
	Private Sub txtr_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtr.Click
		botactualiza.Enabled = True
	End Sub
	
	Private Sub txts_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txts.Click
		botactualiza.Enabled = True
	End Sub
End Class