Option Strict Off
Option Explicit On
Friend Class frmborrarbd
	Inherits System.Windows.Forms.Form
	Dim TXT As Registro
	Dim llave As Integer
	Dim llave2 As Integer
	
	Private Sub botcancela_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botcancela.Click
		Me.Close()
		Me.Visible = False
	End Sub
	
	Private Sub botgenera_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botgenera.Click
		
		'bd.Refresh
		Randomize()
		llave = Int(Rnd() * 999999) + 1
		txtllave.Text = CStr(llave)
		txtllave2.Enabled = True
		botseguir.Visible = True
		botgenera.Enabled = False
		
	End Sub
	
	Private Sub botseguir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botseguir.Click
		llave2 = CInt(txtllave2.Text)
		If CStr(llave) = CStr(llave2) Then
			Call borrar()
			Me.Close()
		Else
			MsgBox("La Llave no es la correcta")
			Me.Close()
		End If
	End Sub
	
	Sub borrar()
		On Error GoTo FALLO
		bd.Refresh()
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.MoveFirst. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		bd.Recordset.MoveFirst()
		Do 
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.Delete. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			bd.Recordset.Delete()
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.MoveNext. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			bd.Recordset.MoveNext()
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.EOF. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Loop While bd.Recordset.EOF = False
		
		Call nuevoregvacio()
		bd.Refresh()
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.FindFirst. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		bd.Recordset.FindFirst("Observaciones='Borreme'")
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.Delete. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		bd.Recordset.Delete()
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.MoveFirst. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		bd.Recordset.MoveFirst()
		MsgBox("Base de Datos Reinicializada", MsgBoxStyle.Exclamation)
		GoTo SIGUE
		
FALLO: 
		Select Case Err.Number
			Case 3021
				MsgBox("No Hay Ningun registro")
		End Select
		
SIGUE: 
		
	End Sub
	
	Private Sub frmborrarbd_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		bd.Refresh()
	End Sub
	
	'UPGRADE_WARNING: El evento txtllave2.TextChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtllave2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtllave2.TextChanged
		If txtllave2.Text = txtllave.Text Then
			botseguir.Enabled = True
		End If
		
	End Sub
	
	'UPGRADE_WARNING: El evento txtllave3.TextChanged se puede desencadenar cuando se inicializa el formulario. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtllave3_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtllave3.TextChanged
		If Len(txtllave3.Text) > 8 Then
			botseguir.Enabled = True
		Else
			botseguir.Enabled = False
		End If
		
	End Sub
	Sub nuevoregvacio()
		
		Call frmFrecuencias.SituarBD()
		bd.Refresh()
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.AddNew. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		bd.Recordset.AddNew()
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		bd.Recordset(("Registro")) = 0
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		bd.Recordset(("frecuencia")) = "000.000"
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		bd.Recordset(("Memoria")) = 0
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		bd.Recordset(("Observaciones")) = "Borreme"
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		bd.Recordset(("Localidad")) = "Borreme"
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		bd.Recordset(("Banda")) = "2 m"
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		bd.Recordset(("Fecha")) = Today
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		bd.Recordset(("Comprobado")) = False
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		bd.Recordset(("Exportar")) = False
		'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.Update. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		bd.Recordset.Update()
		
	End Sub
End Class