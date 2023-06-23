<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmrepetidores
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
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents _txtrep_4 As System.Windows.Forms.TextBox
	Public WithEvents _txtrep_5 As System.Windows.Forms.TextBox
	Public WithEvents _botver_4 As System.Windows.Forms.Button
	Public WithEvents _botver_5 As System.Windows.Forms.Button
	Public WithEvents botguardar As System.Windows.Forms.Button
	Public WithEvents _botver_1 As System.Windows.Forms.Button
	Public WithEvents _botver_2 As System.Windows.Forms.Button
	Public WithEvents _botver_3 As System.Windows.Forms.Button
	Public WithEvents _botver_0 As System.Windows.Forms.Button
	Public WithEvents txtfrecuencia As System.Windows.Forms.TextBox
	Public WithEvents BD As System.Windows.Forms.Label
	Public WithEvents _txtrep_3 As System.Windows.Forms.TextBox
	Public WithEvents _txtrep_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtrep_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtrep_0 As System.Windows.Forms.TextBox
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents _numreg_4 As System.Windows.Forms.Label
	Public WithEvents _numreg_5 As System.Windows.Forms.Label
	Public WithEvents _numreg_3 As System.Windows.Forms.Label
	Public WithEvents _numreg_2 As System.Windows.Forms.Label
	Public WithEvents _numreg_1 As System.Windows.Forms.Label
	Public WithEvents _numreg_0 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents lbl1 As System.Windows.Forms.Label
	Public WithEvents botver As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents numreg As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents txtrep As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmrepetidores))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Command2 = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me._txtrep_4 = New System.Windows.Forms.TextBox
		Me._txtrep_5 = New System.Windows.Forms.TextBox
		Me._botver_4 = New System.Windows.Forms.Button
		Me._botver_5 = New System.Windows.Forms.Button
		Me.botguardar = New System.Windows.Forms.Button
		Me._botver_1 = New System.Windows.Forms.Button
		Me._botver_2 = New System.Windows.Forms.Button
		Me._botver_3 = New System.Windows.Forms.Button
		Me._botver_0 = New System.Windows.Forms.Button
		Me.txtfrecuencia = New System.Windows.Forms.TextBox
		Me.BD = New System.Windows.Forms.Label
		Me._txtrep_3 = New System.Windows.Forms.TextBox
		Me._txtrep_2 = New System.Windows.Forms.TextBox
		Me._txtrep_1 = New System.Windows.Forms.TextBox
		Me._txtrep_0 = New System.Windows.Forms.TextBox
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me._numreg_4 = New System.Windows.Forms.Label
		Me._numreg_5 = New System.Windows.Forms.Label
		Me._numreg_3 = New System.Windows.Forms.Label
		Me._numreg_2 = New System.Windows.Forms.Label
		Me._numreg_1 = New System.Windows.Forms.Label
		Me._numreg_0 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.lbl1 = New System.Windows.Forms.Label
		Me.botver = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.numreg = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.txtrep = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.botver, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.numreg, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtrep, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Lista de Repetidores Posibles"
		Me.ClientSize = New System.Drawing.Size(332, 260)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.MaximizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmrepetidores"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command2.Text = "Ver Cercanas"
		Me.Command2.Size = New System.Drawing.Size(97, 25)
		Me.Command2.Location = New System.Drawing.Point(232, 40)
		Me.Command2.TabIndex = 27
		Me.Command2.BackColor = System.Drawing.SystemColors.Control
		Me.Command2.CausesValidation = True
		Me.Command2.Enabled = True
		Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command2.TabStop = True
		Me.Command2.Name = "Command2"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Otra Frecuencia"
		Me.Command1.Size = New System.Drawing.Size(97, 25)
		Me.Command1.Location = New System.Drawing.Point(120, 40)
		Me.Command1.TabIndex = 26
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me._txtrep_4.AutoSize = False
		Me._txtrep_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtrep_4.Size = New System.Drawing.Size(105, 25)
		Me._txtrep_4.Location = New System.Drawing.Point(120, 200)
		Me._txtrep_4.ReadOnly = True
		Me._txtrep_4.TabIndex = 21
		Me._txtrep_4.AcceptsReturn = True
		Me._txtrep_4.BackColor = System.Drawing.SystemColors.Window
		Me._txtrep_4.CausesValidation = True
		Me._txtrep_4.Enabled = True
		Me._txtrep_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtrep_4.HideSelection = True
		Me._txtrep_4.Maxlength = 0
		Me._txtrep_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtrep_4.MultiLine = False
		Me._txtrep_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtrep_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtrep_4.TabStop = True
		Me._txtrep_4.Visible = True
		Me._txtrep_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtrep_4.Name = "_txtrep_4"
		Me._txtrep_5.AutoSize = False
		Me._txtrep_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtrep_5.Size = New System.Drawing.Size(105, 25)
		Me._txtrep_5.Location = New System.Drawing.Point(120, 232)
		Me._txtrep_5.ReadOnly = True
		Me._txtrep_5.TabIndex = 20
		Me._txtrep_5.AcceptsReturn = True
		Me._txtrep_5.BackColor = System.Drawing.SystemColors.Window
		Me._txtrep_5.CausesValidation = True
		Me._txtrep_5.Enabled = True
		Me._txtrep_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtrep_5.HideSelection = True
		Me._txtrep_5.Maxlength = 0
		Me._txtrep_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtrep_5.MultiLine = False
		Me._txtrep_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtrep_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtrep_5.TabStop = True
		Me._txtrep_5.Visible = True
		Me._txtrep_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtrep_5.Name = "_txtrep_5"
		Me._botver_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._botver_4.Text = "Ver"
		Me._botver_4.Enabled = False
		Me._botver_4.Size = New System.Drawing.Size(49, 25)
		Me._botver_4.Location = New System.Drawing.Point(280, 200)
		Me._botver_4.TabIndex = 19
		Me._botver_4.BackColor = System.Drawing.SystemColors.Control
		Me._botver_4.CausesValidation = True
		Me._botver_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._botver_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._botver_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._botver_4.TabStop = True
		Me._botver_4.Name = "_botver_4"
		Me._botver_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._botver_5.Text = "Ver"
		Me._botver_5.Enabled = False
		Me._botver_5.Size = New System.Drawing.Size(49, 25)
		Me._botver_5.Location = New System.Drawing.Point(280, 232)
		Me._botver_5.TabIndex = 18
		Me._botver_5.BackColor = System.Drawing.SystemColors.Control
		Me._botver_5.CausesValidation = True
		Me._botver_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._botver_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._botver_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._botver_5.TabStop = True
		Me._botver_5.Name = "_botver_5"
		Me.botguardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botguardar.Text = "Guardar"
		Me.botguardar.Size = New System.Drawing.Size(97, 25)
		Me.botguardar.Location = New System.Drawing.Point(8, 40)
		Me.botguardar.TabIndex = 17
		Me.botguardar.Visible = False
		Me.botguardar.BackColor = System.Drawing.SystemColors.Control
		Me.botguardar.CausesValidation = True
		Me.botguardar.Enabled = True
		Me.botguardar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botguardar.Cursor = System.Windows.Forms.Cursors.Default
		Me.botguardar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botguardar.TabStop = True
		Me.botguardar.Name = "botguardar"
		Me._botver_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._botver_1.Text = "Ver"
		Me._botver_1.Enabled = False
		Me._botver_1.Size = New System.Drawing.Size(49, 25)
		Me._botver_1.Location = New System.Drawing.Point(280, 104)
		Me._botver_1.TabIndex = 12
		Me._botver_1.BackColor = System.Drawing.SystemColors.Control
		Me._botver_1.CausesValidation = True
		Me._botver_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._botver_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._botver_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._botver_1.TabStop = True
		Me._botver_1.Name = "_botver_1"
		Me._botver_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._botver_2.Text = "Ver"
		Me._botver_2.Enabled = False
		Me._botver_2.Size = New System.Drawing.Size(49, 25)
		Me._botver_2.Location = New System.Drawing.Point(280, 136)
		Me._botver_2.TabIndex = 11
		Me._botver_2.BackColor = System.Drawing.SystemColors.Control
		Me._botver_2.CausesValidation = True
		Me._botver_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._botver_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._botver_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._botver_2.TabStop = True
		Me._botver_2.Name = "_botver_2"
		Me._botver_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._botver_3.Text = "Ver"
		Me._botver_3.Enabled = False
		Me._botver_3.Size = New System.Drawing.Size(49, 25)
		Me._botver_3.Location = New System.Drawing.Point(280, 168)
		Me._botver_3.TabIndex = 10
		Me._botver_3.BackColor = System.Drawing.SystemColors.Control
		Me._botver_3.CausesValidation = True
		Me._botver_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._botver_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._botver_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._botver_3.TabStop = True
		Me._botver_3.Name = "_botver_3"
		Me._botver_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._botver_0.Text = "Ver"
		Me._botver_0.Enabled = False
		Me._botver_0.Size = New System.Drawing.Size(49, 25)
		Me._botver_0.Location = New System.Drawing.Point(280, 72)
		Me._botver_0.TabIndex = 9
		Me._botver_0.BackColor = System.Drawing.SystemColors.Control
		Me._botver_0.CausesValidation = True
		Me._botver_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._botver_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._botver_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._botver_0.TabStop = True
		Me._botver_0.Name = "_botver_0"
		Me.txtfrecuencia.AutoSize = False
		Me.txtfrecuencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtfrecuencia.BackColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me.txtfrecuencia.ForeColor = System.Drawing.Color.Green
		Me.txtfrecuencia.Size = New System.Drawing.Size(321, 25)
		Me.txtfrecuencia.Location = New System.Drawing.Point(8, 8)
		Me.txtfrecuencia.ReadOnly = True
		Me.txtfrecuencia.TabIndex = 8
		Me.txtfrecuencia.AcceptsReturn = True
		Me.txtfrecuencia.CausesValidation = True
		Me.txtfrecuencia.Enabled = True
		Me.txtfrecuencia.HideSelection = True
		Me.txtfrecuencia.Maxlength = 0
		Me.txtfrecuencia.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtfrecuencia.MultiLine = False
		Me.txtfrecuencia.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtfrecuencia.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtfrecuencia.TabStop = True
		Me.txtfrecuencia.Visible = True
		Me.txtfrecuencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtfrecuencia.Name = "txtfrecuencia"
		Me.BD.Text = "Frecuencias"
		Me.BD.Size = New System.Drawing.Size(332, 25)
		Me.BD.Location = New System.Drawing.Point(0, 235)
		Me.BD.Visible = False
		Me.BD.BackColor = System.Drawing.Color.Red
		Me.BD.ForeColor = System.Drawing.Color.Black
		Me.BD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.BD.Text = "BD"
		Me.BD.Name = "BD"
		Me._txtrep_3.AutoSize = False
		Me._txtrep_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtrep_3.Size = New System.Drawing.Size(105, 25)
		Me._txtrep_3.Location = New System.Drawing.Point(120, 168)
		Me._txtrep_3.ReadOnly = True
		Me._txtrep_3.TabIndex = 7
		Me._txtrep_3.AcceptsReturn = True
		Me._txtrep_3.BackColor = System.Drawing.SystemColors.Window
		Me._txtrep_3.CausesValidation = True
		Me._txtrep_3.Enabled = True
		Me._txtrep_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtrep_3.HideSelection = True
		Me._txtrep_3.Maxlength = 0
		Me._txtrep_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtrep_3.MultiLine = False
		Me._txtrep_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtrep_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtrep_3.TabStop = True
		Me._txtrep_3.Visible = True
		Me._txtrep_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtrep_3.Name = "_txtrep_3"
		Me._txtrep_2.AutoSize = False
		Me._txtrep_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtrep_2.Size = New System.Drawing.Size(105, 25)
		Me._txtrep_2.Location = New System.Drawing.Point(120, 136)
		Me._txtrep_2.ReadOnly = True
		Me._txtrep_2.TabIndex = 6
		Me._txtrep_2.AcceptsReturn = True
		Me._txtrep_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtrep_2.CausesValidation = True
		Me._txtrep_2.Enabled = True
		Me._txtrep_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtrep_2.HideSelection = True
		Me._txtrep_2.Maxlength = 0
		Me._txtrep_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtrep_2.MultiLine = False
		Me._txtrep_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtrep_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtrep_2.TabStop = True
		Me._txtrep_2.Visible = True
		Me._txtrep_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtrep_2.Name = "_txtrep_2"
		Me._txtrep_1.AutoSize = False
		Me._txtrep_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtrep_1.Size = New System.Drawing.Size(105, 25)
		Me._txtrep_1.Location = New System.Drawing.Point(120, 104)
		Me._txtrep_1.ReadOnly = True
		Me._txtrep_1.TabIndex = 5
		Me._txtrep_1.AcceptsReturn = True
		Me._txtrep_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtrep_1.CausesValidation = True
		Me._txtrep_1.Enabled = True
		Me._txtrep_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtrep_1.HideSelection = True
		Me._txtrep_1.Maxlength = 0
		Me._txtrep_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtrep_1.MultiLine = False
		Me._txtrep_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtrep_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtrep_1.TabStop = True
		Me._txtrep_1.Visible = True
		Me._txtrep_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtrep_1.Name = "_txtrep_1"
		Me._txtrep_0.AutoSize = False
		Me._txtrep_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtrep_0.Size = New System.Drawing.Size(105, 25)
		Me._txtrep_0.Location = New System.Drawing.Point(120, 72)
		Me._txtrep_0.ReadOnly = True
		Me._txtrep_0.TabIndex = 4
		Me._txtrep_0.AcceptsReturn = True
		Me._txtrep_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtrep_0.CausesValidation = True
		Me._txtrep_0.Enabled = True
		Me._txtrep_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtrep_0.HideSelection = True
		Me._txtrep_0.Maxlength = 0
		Me._txtrep_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtrep_0.MultiLine = False
		Me._txtrep_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtrep_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtrep_0.TabStop = True
		Me._txtrep_0.Visible = True
		Me._txtrep_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtrep_0.Name = "_txtrep_0"
		Me.Label7.Text = "Repetidor + 7.6 Khz"
		Me.Label7.Size = New System.Drawing.Size(97, 17)
		Me.Label7.Location = New System.Drawing.Point(8, 200)
		Me.Label7.TabIndex = 25
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Label4.Text = "Repetidor - 7.6 Khz"
		Me.Label4.Size = New System.Drawing.Size(97, 17)
		Me.Label4.Location = New System.Drawing.Point(8, 232)
		Me.Label4.TabIndex = 24
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me._numreg_4.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._numreg_4.Size = New System.Drawing.Size(33, 25)
		Me._numreg_4.Location = New System.Drawing.Point(232, 200)
		Me._numreg_4.TabIndex = 23
		Me._numreg_4.BackColor = System.Drawing.SystemColors.Control
		Me._numreg_4.Enabled = True
		Me._numreg_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._numreg_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._numreg_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._numreg_4.UseMnemonic = True
		Me._numreg_4.Visible = True
		Me._numreg_4.AutoSize = False
		Me._numreg_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._numreg_4.Name = "_numreg_4"
		Me._numreg_5.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._numreg_5.Size = New System.Drawing.Size(33, 25)
		Me._numreg_5.Location = New System.Drawing.Point(232, 232)
		Me._numreg_5.TabIndex = 22
		Me._numreg_5.BackColor = System.Drawing.SystemColors.Control
		Me._numreg_5.Enabled = True
		Me._numreg_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._numreg_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._numreg_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._numreg_5.UseMnemonic = True
		Me._numreg_5.Visible = True
		Me._numreg_5.AutoSize = False
		Me._numreg_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._numreg_5.Name = "_numreg_5"
		Me._numreg_3.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._numreg_3.Size = New System.Drawing.Size(33, 25)
		Me._numreg_3.Location = New System.Drawing.Point(232, 168)
		Me._numreg_3.TabIndex = 16
		Me._numreg_3.BackColor = System.Drawing.SystemColors.Control
		Me._numreg_3.Enabled = True
		Me._numreg_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._numreg_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._numreg_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._numreg_3.UseMnemonic = True
		Me._numreg_3.Visible = True
		Me._numreg_3.AutoSize = False
		Me._numreg_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._numreg_3.Name = "_numreg_3"
		Me._numreg_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._numreg_2.Size = New System.Drawing.Size(33, 25)
		Me._numreg_2.Location = New System.Drawing.Point(232, 136)
		Me._numreg_2.TabIndex = 15
		Me._numreg_2.BackColor = System.Drawing.SystemColors.Control
		Me._numreg_2.Enabled = True
		Me._numreg_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._numreg_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._numreg_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._numreg_2.UseMnemonic = True
		Me._numreg_2.Visible = True
		Me._numreg_2.AutoSize = False
		Me._numreg_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._numreg_2.Name = "_numreg_2"
		Me._numreg_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._numreg_1.Size = New System.Drawing.Size(33, 25)
		Me._numreg_1.Location = New System.Drawing.Point(232, 104)
		Me._numreg_1.TabIndex = 14
		Me._numreg_1.BackColor = System.Drawing.SystemColors.Control
		Me._numreg_1.Enabled = True
		Me._numreg_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._numreg_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._numreg_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._numreg_1.UseMnemonic = True
		Me._numreg_1.Visible = True
		Me._numreg_1.AutoSize = False
		Me._numreg_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._numreg_1.Name = "_numreg_1"
		Me._numreg_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._numreg_0.Size = New System.Drawing.Size(33, 25)
		Me._numreg_0.Location = New System.Drawing.Point(232, 72)
		Me._numreg_0.TabIndex = 13
		Me._numreg_0.BackColor = System.Drawing.SystemColors.Control
		Me._numreg_0.Enabled = True
		Me._numreg_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._numreg_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._numreg_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._numreg_0.UseMnemonic = True
		Me._numreg_0.Visible = True
		Me._numreg_0.AutoSize = False
		Me._numreg_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._numreg_0.Name = "_numreg_0"
		Me.Label3.Text = "Repetidor - 600 Khz"
		Me.Label3.Size = New System.Drawing.Size(97, 17)
		Me.Label3.Location = New System.Drawing.Point(8, 104)
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
		Me.Label2.Text = "Repetidor + 4.6 Mhz"
		Me.Label2.Size = New System.Drawing.Size(97, 17)
		Me.Label2.Location = New System.Drawing.Point(8, 136)
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
		Me.Label1.Text = "Repetidor - 4.6 Mhz"
		Me.Label1.Size = New System.Drawing.Size(97, 17)
		Me.Label1.Location = New System.Drawing.Point(8, 168)
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
		Me.lbl1.Text = "Repetidor + 600 Khz"
		Me.lbl1.Size = New System.Drawing.Size(97, 17)
		Me.lbl1.Location = New System.Drawing.Point(8, 72)
		Me.lbl1.TabIndex = 0
		Me.lbl1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbl1.BackColor = System.Drawing.SystemColors.Control
		Me.lbl1.Enabled = True
		Me.lbl1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbl1.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbl1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbl1.UseMnemonic = True
		Me.lbl1.Visible = True
		Me.lbl1.AutoSize = False
		Me.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbl1.Name = "lbl1"
		Me.Controls.Add(Command2)
		Me.Controls.Add(Command1)
		Me.Controls.Add(_txtrep_4)
		Me.Controls.Add(_txtrep_5)
		Me.Controls.Add(_botver_4)
		Me.Controls.Add(_botver_5)
		Me.Controls.Add(botguardar)
		Me.Controls.Add(_botver_1)
		Me.Controls.Add(_botver_2)
		Me.Controls.Add(_botver_3)
		Me.Controls.Add(_botver_0)
		Me.Controls.Add(txtfrecuencia)
		Me.Controls.Add(BD)
		Me.Controls.Add(_txtrep_3)
		Me.Controls.Add(_txtrep_2)
		Me.Controls.Add(_txtrep_1)
		Me.Controls.Add(_txtrep_0)
		Me.Controls.Add(Label7)
		Me.Controls.Add(Label4)
		Me.Controls.Add(_numreg_4)
		Me.Controls.Add(_numreg_5)
		Me.Controls.Add(_numreg_3)
		Me.Controls.Add(_numreg_2)
		Me.Controls.Add(_numreg_1)
		Me.Controls.Add(_numreg_0)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Controls.Add(lbl1)
		Me.botver.SetIndex(_botver_4, CType(4, Short))
		Me.botver.SetIndex(_botver_5, CType(5, Short))
		Me.botver.SetIndex(_botver_1, CType(1, Short))
		Me.botver.SetIndex(_botver_2, CType(2, Short))
		Me.botver.SetIndex(_botver_3, CType(3, Short))
		Me.botver.SetIndex(_botver_0, CType(0, Short))
		Me.numreg.SetIndex(_numreg_4, CType(4, Short))
		Me.numreg.SetIndex(_numreg_5, CType(5, Short))
		Me.numreg.SetIndex(_numreg_3, CType(3, Short))
		Me.numreg.SetIndex(_numreg_2, CType(2, Short))
		Me.numreg.SetIndex(_numreg_1, CType(1, Short))
		Me.numreg.SetIndex(_numreg_0, CType(0, Short))
		Me.txtrep.SetIndex(_txtrep_4, CType(4, Short))
		Me.txtrep.SetIndex(_txtrep_5, CType(5, Short))
		Me.txtrep.SetIndex(_txtrep_3, CType(3, Short))
		Me.txtrep.SetIndex(_txtrep_2, CType(2, Short))
		Me.txtrep.SetIndex(_txtrep_1, CType(1, Short))
		Me.txtrep.SetIndex(_txtrep_0, CType(0, Short))
		CType(Me.txtrep, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.numreg, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.botver, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class