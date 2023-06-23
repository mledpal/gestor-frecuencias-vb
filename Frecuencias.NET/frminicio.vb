Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frminicio
	Inherits System.Windows.Forms.Form
	Private Sub frminicio_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim lineacomando As Object
		
		'UPGRADE_ISSUE: App propiedad App.PrevInstance no se actualizó. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="076C26E5-B7A9-4E77-B69C-B4448DF39E58"'
		If App.PrevInstance = True Then
			Timer_Renamed.Enabled = False
			MsgBox("Ya existe una copia del programa abierta", MsgBoxStyle.OKOnly)
			End
		End If
		
		lblversion.Text = "Versión " & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & My.Application.Info.Version.Revision
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto lineacomando. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lineacomando = VB.Command()
		
		'UPGRADE_WARNING: No se puede resolver la propiedad predeterminada del objeto lineacomando. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If UCase(VB.Left(VB.Right(lineacomando, 4), 3)) = "RGF" Then
			MsgBox(lineacomando)
		End If
		
	End Sub
	
	
	Private Sub Timer_Renamed_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer_Renamed.Tick
		Dim delay As Object
		frmFrecuencias.Visible = True
		For delay = 1 To 2000
		Next delay
		'UPGRADE_ISSUE: No se admite Load instrucción. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
		Load(frmAbout)
		'UPGRADE_ISSUE: No se admite Load instrucción. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
		Load(frmborrarbd)
		'UPGRADE_ISSUE: No se admite Load instrucción. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
		Load(frmbuscar)
		'UPGRADE_ISSUE: No se admite Load instrucción. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
		Load(frmFrecuencias)
		'UPGRADE_ISSUE: No se admite Load instrucción. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
		Load(frmnuevo)
		'UPGRADE_ISSUE: No se admite Load instrucción. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
		Load(frmOptions)
		'UPGRADE_ISSUE: No se admite Load instrucción. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
		Load(frmResultados)
		'UPGRADE_ISSUE: No se admite Load instrucción. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
		Load(frmrepetidores)
		Me.Close()
		Call frmFrecuencias.SituarBD()
	End Sub
End Class