Option Strict Off
Option Explicit On
Friend Class frmactualizar
	Inherits System.Windows.Forms.Form
	Private Sub botactualizar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botactualizar.Click
		Dim n As Object
		
		On Error Resume Next
		
		Call frmFrecuencias.SituarBD()
		Dim Frec As Object
		Dim Criterio As String
		Dim nuevos, viejos As Object
		Dim total As Short
		
		BDR.Recordset.MoveFirst()
		PB.Max = BDR.Recordset.RecordCount
		For n = 1 To BDR.Recordset.RecordCount
			
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Frec = BDR.Recordset.Fields("Frecuencia").Value
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Criterio = "Frecuencia=" & Chr(39) & CStr(Frec) & Chr(39)
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.FindFirst. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			bd.Recordset.FindFirst(Criterio)
			
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.NoMatch. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If bd.Recordset.NoMatch Then
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.AddNew. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				bd.Recordset.AddNew()
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				bd.Recordset(("Frecuencia")) = BDR.Recordset.Fields("Frecuencia").Value
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				bd.Recordset(("Memoria")) = CShort(BDR.Recordset.Fields("Memoria").Value)
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				bd.Recordset(("Observaciones")) = BDR.Recordset.Fields("Observaciones").Value
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				bd.Recordset(("Localidad")) = BDR.Recordset.Fields("Localidad").Value
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				bd.Recordset(("Banda")) = BDR.Recordset.Fields("Banda").Value
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				bd.Recordset(("Fecha")) = BDR.Recordset.Fields("Fecha").Value
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				bd.Recordset(("Exportar")) = BDR.Recordset.Fields("Exportar").Value
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				bd.Recordset(("Comprobado")) = BDR.Recordset.Fields("Comprobado").Value
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				bd.Recordset(("Mhz")) = BDR.Recordset.Fields("Mhz").Value
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				bd.Recordset(("Khz")) = BDR.Recordset.Fields("Khz").Value
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				bd.Recordset(("S")) = CShort(BDR.Recordset.Fields("S").Value)
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				bd.Recordset(("R")) = CShort(BDR.Recordset.Fields("R").Value)
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				bd.Recordset(("CTCSS")) = BDR.Recordset.Fields("CTCSS").Value
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				bd.Recordset(("DCS")) = BDR.Recordset.Fields("DCS").Value
				'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.Update. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				bd.Recordset.Update()
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto nuevos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				nuevos = nuevos + 1
			Else
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto viejos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				viejos = viejos + 1
			End If
			
			total = total + 1
			PB.Value = total
			BDR.Recordset.MoveNext()
			
		Next n
		
		Call frmFrecuencias.SituarBD()
		bd.Refresh()
		
		Call frmOptions.botorden_Click(Nothing, New System.EventArgs())
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto nuevos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		MsgBox("Base de datos actualizada con éxito. Se han añadido " & CStr(nuevos) & " registros.")
		Me.Close()
		frmOptions.Close()
	End Sub
	
	Private Sub botcomprobar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botcomprobar.Click
		Dim n As Object
		bd.Refresh()
		BDR.Refresh()
		On Error Resume Next
		
		Call frmFrecuencias.SituarBD()
		Dim Frec As Object
		Dim Criterio As String
		Dim nuevos, viejos As Object
		Dim total As Short
		
		BDR.Recordset.MoveFirst()
		PB.Max = BDR.Recordset.RecordCount
		For n = 1 To BDR.Recordset.RecordCount
			
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Frec = BDR.Recordset.Fields("Frecuencia").Value
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto Frec. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Criterio = "Frecuencia=" & Chr(39) & CStr(Frec) & Chr(39)
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.FindFirst. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			bd.Recordset.FindFirst(Criterio)
			
			'UPGRADE_ISSUE: Data propiedad bd.Recordset no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto bd.Recordset.NoMatch. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If bd.Recordset.NoMatch Then
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto nuevos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				nuevos = nuevos + 1
			Else
				'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto viejos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				viejos = viejos + 1
			End If
			
			total = total + 1
			PB.Value = total
			BDR.Recordset.MoveNext()
			
		Next n
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto nuevos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If nuevos > 0 Then
			'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto nuevos. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			MsgBox("Se han encontrado " & CStr(nuevos) & " nuevas frecuencias.", MsgBoxStyle.Information)
		Else
			MsgBox("No se han encontrado frecuencias nuevas en el servidor")
			botactualizar.Enabled = False
		End If
		PB.Value = 0
	End Sub
	
	Private Sub botconectar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botconectar.Click
		On Error Resume Next
		BDR.ConnectionString = "DRIVER={MySQL ODBC 3.51 Driver}; SERVER=" & CStr(txtservidor.Text) & "; DATABASE=frecuencias; UID=" & CStr(txtusuario.Text) & "; PWD=" & CStr(txtpassword.Text) & ";"
		BDR.Refresh()
		If BDR.Recordset.RecordCount > 0 Then
			MsgBox("CONECTADO a base de datos con : " & CStr(BDR.Recordset.RecordCount) & " registros")
			botcomprobar.Enabled = True
			botactualizar.Enabled = True
		Else
			MsgBox("Error en acceso a base de datos", MsgBoxStyle.Exclamation)
		End If
		
	End Sub
	
	Private Sub botprobar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botprobar.Click
		On Error GoTo Fallo_conexion
		BDR.ConnectionString = "DRIVER={MySQL ODBC 3.51 Driver}; SERVER=" & CStr(txtservidor.Text) & "; DATABASE=frecuencias; UID=" & CStr(txtusuario.Text) & "; PWD=" & CStr(txtpassword.Text) & ";"
		BDR.Refresh()
		MsgBox("Conexion OK. La base de datos contiene " & CStr(BDR.Recordset.RecordCount) & " registros.")
		Exit Sub
Fallo_conexion: 
		MsgBox(Err.Description, MsgBoxStyle.Information)
	End Sub
	
	Private Sub botsalir_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles botsalir.Click
		'UPGRADE_NOTE: modal se actualizó a modal_Renamed. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim modal_Renamed As Object
		VB6.ShowForm(frmOptions, modal_Renamed)
		Me.Close()
	End Sub
End Class