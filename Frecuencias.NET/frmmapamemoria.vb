Option Strict Off
Option Explicit On
Friend Class frmmapamemoria
	Inherits System.Windows.Forms.Form
	'UPGRADE_WARNING: Form evento frmmapamemoria.Activate tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmmapamemoria_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		Dim cadena As Object
		Dim m As Object
		Dim ocupadas As Object
		Dim libres As Object
		Call frmFrecuencias.SituarBD()
		BD.Refresh()
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto libres. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		libres = 0
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ocupadas. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ocupadas = 0
		For m = 0 To 49
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto m. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadena. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			cadena = "Memoria=" & Str(m + 1)
			'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.FindFirst. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			BD.Recordset.FindFirst(cadena)
			'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.NoMatch. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If BD.Recordset.NoMatch = True Then
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto libres. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				libres = libres + 1
				lblmemoria(m).Font = VB6.FontChangeBold(lblmemoria(m).Font, True)
				lblmemoria(m).ForeColor = System.Drawing.Color.Blue
			Else
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ocupadas. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				ocupadas = ocupadas + 1
				lblmemoria(m).ForeColor = System.Drawing.Color.Red
			End If
		Next m
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto libres. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BE.Panels.Item(1).Text = "Libres :" & Str(libres)
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto ocupadas. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BE.Panels.Item(2).Text = "Ocupadas :" & Str(ocupadas)
	End Sub
	
	Private Sub lblmemoria_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lblmemoria.Click
		Dim Index As Short = lblmemoria.GetIndex(eventSender)
		'UPGRADE_NOTE: modal se actualizó a modal_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim modal_Renamed As Object
		Dim cadenabusqueda As Object
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto cadenabusqueda. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cadenabusqueda = "Memoria=" & Str(Index + 1)
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.FindFirst. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		BD.Recordset.FindFirst(cadenabusqueda)
		'UPGRADE_ISSUE: Data propiedad BD.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto BD.Recordset.NoMatch. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If BD.Recordset.NoMatch = False Then
			Modulo.grabar((cadenabusqueda))
			VB6.ShowForm(frmResultados, (modal_Renamed))
		Else
			frmnuevo.TxtMemoria.Text = CStr(Index + 1)
			frmnuevo.Show()
		End If
	End Sub
End Class