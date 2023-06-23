<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmactualizar
#Region "Código generado por el Diseñador de Windows Forms "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'Llamada necesaria para el Diseñador de Windows Forms.
		InitializeComponent()
	End Sub
	'Form invalida a Dispose para limpiar la lista de componentes.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Requerido por el Diseñador de Windows Forms
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents PB As AxComctlLib.AxProgressBar
	Public WithEvents BDR As VB6.ADODC
	Public WithEvents botsalir As System.Windows.Forms.Button
	Public WithEvents botactualizar As System.Windows.Forms.Button
	Public WithEvents botcomprobar As System.Windows.Forms.Button
	Public WithEvents botconectar As System.Windows.Forms.Button
	Public WithEvents botprobar As System.Windows.Forms.Button
	Public WithEvents txtservidor As System.Windows.Forms.TextBox
	Public WithEvents txtpassword As System.Windows.Forms.TextBox
	Public WithEvents txtusuario As System.Windows.Forms.TextBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents bd As System.Windows.Forms.Label
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmactualizar))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.PB = New AxComctlLib.AxProgressBar
		Me.BDR = New VB6.ADODC
		Me.botsalir = New System.Windows.Forms.Button
		Me.botactualizar = New System.Windows.Forms.Button
		Me.botcomprobar = New System.Windows.Forms.Button
		Me.botconectar = New System.Windows.Forms.Button
		Me.botprobar = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.txtservidor = New System.Windows.Forms.TextBox
		Me.txtpassword = New System.Windows.Forms.TextBox
		Me.txtusuario = New System.Windows.Forms.TextBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.bd = New System.Windows.Forms.Label
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.PB, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Actualización por Internet"
		Me.ClientSize = New System.Drawing.Size(337, 163)
		Me.Location = New System.Drawing.Point(4, 30)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmactualizar"
		PB.OcxState = CType(resources.GetObject("PB.OcxState"), System.Windows.Forms.AxHost.State)
		Me.PB.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.PB.Size = New System.Drawing.Size(337, 25)
		Me.PB.Location = New System.Drawing.Point(0, 93)
		Me.PB.TabIndex = 12
		Me.PB.Name = "PB"
		Me.BDR.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.BDR.Size = New System.Drawing.Size(337, 22)
		Me.BDR.Location = New System.Drawing.Point(0, 118)
		Me.BDR.Visible = 0
		Me.BDR.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		Me.BDR.ConnectionTimeout = 15
		Me.BDR.CommandTimeout = 30
		Me.BDR.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		Me.BDR.LockType = ADODB.LockTypeEnum.adLockOptimistic
		Me.BDR.CommandType = ADODB.CommandTypeEnum.adCmdUnknown
		Me.BDR.CacheSize = 50
		Me.BDR.MaxRecords = 0
		Me.BDR.BOFAction = Microsoft.VisualBasic.Compatibility.VB6.ADODC.BOFActionEnum.adDoMoveFirst
		Me.BDR.EOFAction = Microsoft.VisualBasic.Compatibility.VB6.ADODC.EOFActionEnum.adDoMoveLast
		Me.BDR.BackColor = System.Drawing.SystemColors.Window
		Me.BDR.ForeColor = System.Drawing.SystemColors.WindowText
		Me.BDR.Orientation = Microsoft.VisualBasic.Compatibility.VB6.ADODC.OrientationEnum.adHorizontal
		Me.BDR.Enabled = True
		Me.BDR.UserName = ""
		Me.BDR.RecordSource = "Select * From Frecuencias Order by Registro"
		Me.BDR.Text = "Base de Datos Remota"
		Me.BDR.ConnectionString = ""
		Me.BDR.Name = "BDR"
		Me.botsalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botsalir.Text = "Salir"
		Me.botsalir.Size = New System.Drawing.Size(97, 25)
		Me.botsalir.Location = New System.Drawing.Point(232, 112)
		Me.botsalir.TabIndex = 11
		Me.botsalir.BackColor = System.Drawing.SystemColors.Control
		Me.botsalir.CausesValidation = True
		Me.botsalir.Enabled = True
		Me.botsalir.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botsalir.Cursor = System.Windows.Forms.Cursors.Default
		Me.botsalir.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botsalir.TabStop = True
		Me.botsalir.Name = "botsalir"
		Me.botactualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botactualizar.Text = "Actualizar"
		Me.botactualizar.Enabled = False
		Me.botactualizar.Size = New System.Drawing.Size(97, 25)
		Me.botactualizar.Location = New System.Drawing.Point(232, 80)
		Me.botactualizar.TabIndex = 10
		Me.botactualizar.BackColor = System.Drawing.SystemColors.Control
		Me.botactualizar.CausesValidation = True
		Me.botactualizar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botactualizar.Cursor = System.Windows.Forms.Cursors.Default
		Me.botactualizar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botactualizar.TabStop = True
		Me.botactualizar.Name = "botactualizar"
		Me.botcomprobar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botcomprobar.Text = "Comprobar BD"
		Me.botcomprobar.Enabled = False
		Me.botcomprobar.Size = New System.Drawing.Size(97, 25)
		Me.botcomprobar.Location = New System.Drawing.Point(232, 48)
		Me.botcomprobar.TabIndex = 9
		Me.botcomprobar.BackColor = System.Drawing.SystemColors.Control
		Me.botcomprobar.CausesValidation = True
		Me.botcomprobar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botcomprobar.Cursor = System.Windows.Forms.Cursors.Default
		Me.botcomprobar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botcomprobar.TabStop = True
		Me.botcomprobar.Name = "botcomprobar"
		Me.botconectar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botconectar.Text = "Conectar"
		Me.botconectar.Size = New System.Drawing.Size(97, 25)
		Me.botconectar.Location = New System.Drawing.Point(232, 16)
		Me.botconectar.TabIndex = 8
		Me.botconectar.BackColor = System.Drawing.SystemColors.Control
		Me.botconectar.CausesValidation = True
		Me.botconectar.Enabled = True
		Me.botconectar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botconectar.Cursor = System.Windows.Forms.Cursors.Default
		Me.botconectar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botconectar.TabStop = True
		Me.botconectar.Name = "botconectar"
		Me.botprobar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botprobar.Text = "Probar Conexión"
		Me.botprobar.Size = New System.Drawing.Size(97, 17)
		Me.botprobar.Location = New System.Drawing.Point(64, 112)
		Me.botprobar.TabIndex = 7
		Me.botprobar.BackColor = System.Drawing.SystemColors.Control
		Me.botprobar.CausesValidation = True
		Me.botprobar.Enabled = True
		Me.botprobar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botprobar.Cursor = System.Windows.Forms.Cursors.Default
		Me.botprobar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botprobar.TabStop = True
		Me.botprobar.Name = "botprobar"
		Me.Frame1.Text = "Datos de Conexión"
		Me.Frame1.Size = New System.Drawing.Size(217, 129)
		Me.Frame1.Location = New System.Drawing.Point(8, 8)
		Me.Frame1.TabIndex = 0
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.txtservidor.AutoSize = False
		Me.txtservidor.Size = New System.Drawing.Size(137, 19)
		Me.txtservidor.Location = New System.Drawing.Point(72, 72)
		Me.txtservidor.TabIndex = 6
		Me.txtservidor.AcceptsReturn = True
		Me.txtservidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtservidor.BackColor = System.Drawing.SystemColors.Window
		Me.txtservidor.CausesValidation = True
		Me.txtservidor.Enabled = True
		Me.txtservidor.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtservidor.HideSelection = True
		Me.txtservidor.ReadOnly = False
		Me.txtservidor.Maxlength = 0
		Me.txtservidor.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtservidor.MultiLine = False
		Me.txtservidor.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtservidor.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtservidor.TabStop = True
		Me.txtservidor.Visible = True
		Me.txtservidor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtservidor.Name = "txtservidor"
		Me.txtpassword.AutoSize = False
		Me.txtpassword.Size = New System.Drawing.Size(137, 19)
		Me.txtpassword.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtpassword.Location = New System.Drawing.Point(72, 48)
		Me.txtpassword.PasswordChar = ChrW(42)
		Me.txtpassword.TabIndex = 5
		Me.txtpassword.AcceptsReturn = True
		Me.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtpassword.BackColor = System.Drawing.SystemColors.Window
		Me.txtpassword.CausesValidation = True
		Me.txtpassword.Enabled = True
		Me.txtpassword.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtpassword.HideSelection = True
		Me.txtpassword.ReadOnly = False
		Me.txtpassword.Maxlength = 0
		Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtpassword.MultiLine = False
		Me.txtpassword.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtpassword.TabStop = True
		Me.txtpassword.Visible = True
		Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtpassword.Name = "txtpassword"
		Me.txtusuario.AutoSize = False
		Me.txtusuario.Size = New System.Drawing.Size(137, 19)
		Me.txtusuario.Location = New System.Drawing.Point(72, 24)
		Me.txtusuario.TabIndex = 4
		Me.txtusuario.AcceptsReturn = True
		Me.txtusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtusuario.BackColor = System.Drawing.SystemColors.Window
		Me.txtusuario.CausesValidation = True
		Me.txtusuario.Enabled = True
		Me.txtusuario.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtusuario.HideSelection = True
		Me.txtusuario.ReadOnly = False
		Me.txtusuario.Maxlength = 0
		Me.txtusuario.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtusuario.MultiLine = False
		Me.txtusuario.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtusuario.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtusuario.TabStop = True
		Me.txtusuario.Visible = True
		Me.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtusuario.Name = "txtusuario"
		Me.Label3.Text = "Servidor :"
		Me.Label3.Size = New System.Drawing.Size(49, 17)
		Me.Label3.Location = New System.Drawing.Point(8, 72)
		Me.Label3.TabIndex = 3
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label2.Text = "Password:"
		Me.Label2.Size = New System.Drawing.Size(57, 17)
		Me.Label2.Location = New System.Drawing.Point(8, 48)
		Me.Label2.TabIndex = 2
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.SystemColors.Control
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.Text = "Usuario:"
		Me.Label1.Size = New System.Drawing.Size(41, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 24)
		Me.Label1.TabIndex = 1
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.SystemColors.Control
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.bd.Text = "Base de Datos Local"
		Me.bd.Size = New System.Drawing.Size(337, 23)
		Me.bd.Location = New System.Drawing.Point(0, 140)
		Me.bd.Visible = False
		Me.bd.BackColor = System.Drawing.Color.Red
		Me.bd.ForeColor = System.Drawing.Color.Black
		Me.bd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bd.Text = "bd"
		Me.bd.Name = "bd"
		Me.Controls.Add(PB)
		Me.Controls.Add(BDR)
		Me.Controls.Add(botsalir)
		Me.Controls.Add(botactualizar)
		Me.Controls.Add(botcomprobar)
		Me.Controls.Add(botconectar)
		Me.Controls.Add(botprobar)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(bd)
		Me.Frame1.Controls.Add(txtservidor)
		Me.Frame1.Controls.Add(txtpassword)
		Me.Frame1.Controls.Add(txtusuario)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label1)
		CType(Me.PB, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class