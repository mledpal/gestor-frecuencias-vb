<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmOptions
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
	Public WithEvents Command4 As System.Windows.Forms.Button
	Public WithEvents Command3 As System.Windows.Forms.Button
	Public WithEvents Command2 As System.Windows.Forms.Button
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents txttotal As System.Windows.Forms.TextBox
	Public WithEvents txtexportar As System.Windows.Forms.TextBox
	Public WithEvents txtComprobado As System.Windows.Forms.TextBox
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents framdatos As System.Windows.Forms.GroupBox
	Public WithEvents BD As System.Windows.Forms.Label
	Public WithEvents botañade As System.Windows.Forms.Button
	Public WithEvents botborrar As System.Windows.Forms.Button
	Public WithEvents botload As System.Windows.Forms.Button
	Public WithEvents botgenera As System.Windows.Forms.Button
	Public WithEvents botorden As System.Windows.Forms.Button
	Public WithEvents fraSample4 As System.Windows.Forms.GroupBox
	Public WithEvents _picOptions_3 As System.Windows.Forms.Panel
	Public WithEvents fraSample3 As System.Windows.Forms.GroupBox
	Public WithEvents _picOptions_2 As System.Windows.Forms.Panel
	Public dialogoOpen As System.Windows.Forms.OpenFileDialog
	Public WithEvents fraSample2 As System.Windows.Forms.GroupBox
	Public WithEvents _picOptions_1 As System.Windows.Forms.Panel
	Public WithEvents Progreso As AxComctlLib.AxProgressBar
	Public WithEvents picOptions As Microsoft.VisualBasic.Compatibility.VB6.PanelArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmOptions))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Command4 = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Command3 = New System.Windows.Forms.Button
		Me.Command2 = New System.Windows.Forms.Button
		Me.Command1 = New System.Windows.Forms.Button
		Me.framdatos = New System.Windows.Forms.GroupBox
		Me.txttotal = New System.Windows.Forms.TextBox
		Me.txtexportar = New System.Windows.Forms.TextBox
		Me.txtComprobado = New System.Windows.Forms.TextBox
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.BD = New System.Windows.Forms.Label
		Me.botañade = New System.Windows.Forms.Button
		Me.botborrar = New System.Windows.Forms.Button
		Me.botload = New System.Windows.Forms.Button
		Me.botgenera = New System.Windows.Forms.Button
		Me.botorden = New System.Windows.Forms.Button
		Me._picOptions_3 = New System.Windows.Forms.Panel
		Me.fraSample4 = New System.Windows.Forms.GroupBox
		Me._picOptions_2 = New System.Windows.Forms.Panel
		Me.fraSample3 = New System.Windows.Forms.GroupBox
		Me._picOptions_1 = New System.Windows.Forms.Panel
		Me.fraSample2 = New System.Windows.Forms.GroupBox
		Me.dialogoOpen = New System.Windows.Forms.OpenFileDialog
		Me.Progreso = New AxComctlLib.AxProgressBar
		Me.picOptions = New Microsoft.VisualBasic.Compatibility.VB6.PanelArray(components)
		Me.Frame1.SuspendLayout()
		Me.framdatos.SuspendLayout()
		Me._picOptions_3.SuspendLayout()
		Me._picOptions_2.SuspendLayout()
		Me._picOptions_1.SuspendLayout()
		Me.fraSample2.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.Progreso, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.picOptions, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Opciones"
		Me.ClientSize = New System.Drawing.Size(258, 246)
		Me.Location = New System.Drawing.Point(171, 100)
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmOptions"
		Me.Command4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command4.Text = "Configurar"
		Me.Command4.Enabled = False
		Me.Command4.Size = New System.Drawing.Size(73, 17)
		Me.Command4.Location = New System.Drawing.Point(152, 136)
		Me.Command4.TabIndex = 23
		Me.Command4.BackColor = System.Drawing.SystemColors.Control
		Me.Command4.CausesValidation = True
		Me.Command4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command4.TabStop = True
		Me.Command4.Name = "Command4"
		Me.Frame1.Text = "ACTUALIZACIONES"
		Me.Frame1.Size = New System.Drawing.Size(129, 153)
		Me.Frame1.Location = New System.Drawing.Point(128, 8)
		Me.Frame1.TabIndex = 19
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.Command3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command3.Text = "Desde Internet"
		Me.Command3.Size = New System.Drawing.Size(113, 25)
		Me.Command3.Location = New System.Drawing.Point(8, 96)
		Me.Command3.TabIndex = 22
		Me.Command3.BackColor = System.Drawing.SystemColors.Control
		Me.Command3.CausesValidation = True
		Me.Command3.Enabled = True
		Me.Command3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command3.TabStop = True
		Me.Command3.Name = "Command3"
		Me.Command2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command2.Text = "Desde MDB . . ."
		Me.Command2.Enabled = False
		Me.Command2.Size = New System.Drawing.Size(113, 25)
		Me.Command2.Location = New System.Drawing.Point(8, 56)
		Me.Command2.TabIndex = 21
		Me.Command2.BackColor = System.Drawing.SystemColors.Control
		Me.Command2.CausesValidation = True
		Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command2.TabStop = True
		Me.Command2.Name = "Command2"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Desde RGF . . ."
		Me.Command1.Enabled = False
		Me.Command1.Size = New System.Drawing.Size(113, 25)
		Me.Command1.Location = New System.Drawing.Point(8, 24)
		Me.Command1.TabIndex = 20
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.framdatos.Text = "Informacion"
		Me.framdatos.Size = New System.Drawing.Size(249, 57)
		Me.framdatos.Location = New System.Drawing.Point(8, 168)
		Me.framdatos.TabIndex = 11
		Me.framdatos.BackColor = System.Drawing.SystemColors.Control
		Me.framdatos.Enabled = True
		Me.framdatos.ForeColor = System.Drawing.SystemColors.ControlText
		Me.framdatos.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.framdatos.Visible = True
		Me.framdatos.Padding = New System.Windows.Forms.Padding(0)
		Me.framdatos.Name = "framdatos"
		Me.txttotal.AutoSize = False
		Me.txttotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txttotal.BackColor = System.Drawing.SystemColors.Info
		Me.txttotal.Size = New System.Drawing.Size(73, 19)
		Me.txttotal.Location = New System.Drawing.Point(168, 32)
		Me.txttotal.ReadOnly = True
		Me.txttotal.TabIndex = 16
		Me.txttotal.AcceptsReturn = True
		Me.txttotal.CausesValidation = True
		Me.txttotal.Enabled = True
		Me.txttotal.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txttotal.HideSelection = True
		Me.txttotal.Maxlength = 0
		Me.txttotal.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txttotal.MultiLine = False
		Me.txttotal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txttotal.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txttotal.TabStop = True
		Me.txttotal.Visible = True
		Me.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txttotal.Name = "txttotal"
		Me.txtexportar.AutoSize = False
		Me.txtexportar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtexportar.BackColor = System.Drawing.SystemColors.Info
		Me.txtexportar.Size = New System.Drawing.Size(73, 19)
		Me.txtexportar.Location = New System.Drawing.Point(88, 32)
		Me.txtexportar.ReadOnly = True
		Me.txtexportar.TabIndex = 14
		Me.txtexportar.AcceptsReturn = True
		Me.txtexportar.CausesValidation = True
		Me.txtexportar.Enabled = True
		Me.txtexportar.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtexportar.HideSelection = True
		Me.txtexportar.Maxlength = 0
		Me.txtexportar.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtexportar.MultiLine = False
		Me.txtexportar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtexportar.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtexportar.TabStop = True
		Me.txtexportar.Visible = True
		Me.txtexportar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtexportar.Name = "txtexportar"
		Me.txtComprobado.AutoSize = False
		Me.txtComprobado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtComprobado.BackColor = System.Drawing.SystemColors.Info
		Me.txtComprobado.Size = New System.Drawing.Size(73, 19)
		Me.txtComprobado.Location = New System.Drawing.Point(8, 32)
		Me.txtComprobado.ReadOnly = True
		Me.txtComprobado.TabIndex = 12
		Me.txtComprobado.AcceptsReturn = True
		Me.txtComprobado.CausesValidation = True
		Me.txtComprobado.Enabled = True
		Me.txtComprobado.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtComprobado.HideSelection = True
		Me.txtComprobado.Maxlength = 0
		Me.txtComprobado.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtComprobado.MultiLine = False
		Me.txtComprobado.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtComprobado.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtComprobado.TabStop = True
		Me.txtComprobado.Visible = True
		Me.txtComprobado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtComprobado.Name = "txtComprobado"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label3.Text = "Total"
		Me.Label3.Size = New System.Drawing.Size(73, 17)
		Me.Label3.Location = New System.Drawing.Point(168, 16)
		Me.Label3.TabIndex = 17
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
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label2.Text = "Exportables"
		Me.Label2.Size = New System.Drawing.Size(73, 17)
		Me.Label2.Location = New System.Drawing.Point(88, 16)
		Me.Label2.TabIndex = 15
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
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label4.Text = "Comprobados"
		Me.Label4.Size = New System.Drawing.Size(73, 17)
		Me.Label4.Location = New System.Drawing.Point(8, 16)
		Me.Label4.TabIndex = 13
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
		Me.BD.Text = "Frecuencias"
		Me.BD.Size = New System.Drawing.Size(258, 25)
		Me.BD.Location = New System.Drawing.Point(0, 221)
		Me.BD.Visible = False
		Me.BD.BackColor = System.Drawing.Color.Red
		Me.BD.ForeColor = System.Drawing.Color.Black
		Me.BD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.BD.Text = "BD"
		Me.BD.Name = "BD"
		Me.botañade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botañade.Text = "Añadir TXT"
		Me.botañade.Size = New System.Drawing.Size(113, 25)
		Me.botañade.Location = New System.Drawing.Point(8, 104)
		Me.botañade.TabIndex = 10
		Me.botañade.BackColor = System.Drawing.SystemColors.Control
		Me.botañade.CausesValidation = True
		Me.botañade.Enabled = True
		Me.botañade.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botañade.Cursor = System.Windows.Forms.Cursors.Default
		Me.botañade.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botañade.TabStop = True
		Me.botañade.Name = "botañade"
		Me.botborrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botborrar.BackColor = System.Drawing.SystemColors.Control
		Me.botborrar.Text = "Reset . . ."
		Me.botborrar.Size = New System.Drawing.Size(113, 25)
		Me.botborrar.Location = New System.Drawing.Point(8, 136)
		Me.botborrar.TabIndex = 9
		Me.botborrar.CausesValidation = True
		Me.botborrar.Enabled = True
		Me.botborrar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botborrar.Cursor = System.Windows.Forms.Cursors.Default
		Me.botborrar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botborrar.TabStop = True
		Me.botborrar.Name = "botborrar"
		Me.botload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botload.Text = "Cargar TXT"
		Me.botload.Size = New System.Drawing.Size(113, 25)
		Me.botload.Location = New System.Drawing.Point(8, 72)
		Me.botload.TabIndex = 8
		Me.botload.BackColor = System.Drawing.SystemColors.Control
		Me.botload.CausesValidation = True
		Me.botload.Enabled = True
		Me.botload.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botload.Cursor = System.Windows.Forms.Cursors.Default
		Me.botload.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botload.TabStop = True
		Me.botload.Name = "botload"
		Me.botgenera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botgenera.Text = "Generar TXT . . ."
		Me.botgenera.Size = New System.Drawing.Size(113, 25)
		Me.botgenera.Location = New System.Drawing.Point(8, 40)
		Me.botgenera.TabIndex = 7
		Me.botgenera.BackColor = System.Drawing.SystemColors.Control
		Me.botgenera.CausesValidation = True
		Me.botgenera.Enabled = True
		Me.botgenera.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botgenera.Cursor = System.Windows.Forms.Cursors.Default
		Me.botgenera.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botgenera.TabStop = True
		Me.botgenera.Name = "botgenera"
		Me.botorden.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botorden.Text = "Ordenar Nº Registro"
		Me.botorden.Size = New System.Drawing.Size(113, 25)
		Me.botorden.Location = New System.Drawing.Point(8, 8)
		Me.botorden.TabIndex = 6
		Me.botorden.BackColor = System.Drawing.SystemColors.Control
		Me.botorden.CausesValidation = True
		Me.botorden.Enabled = True
		Me.botorden.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botorden.Cursor = System.Windows.Forms.Cursors.Default
		Me.botorden.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botorden.TabStop = True
		Me.botorden.Name = "botorden"
		Me._picOptions_3.Size = New System.Drawing.Size(379, 252)
		Me._picOptions_3.Location = New System.Drawing.Point(-1333, 32)
		Me._picOptions_3.TabIndex = 2
		Me._picOptions_3.TabStop = False
		Me._picOptions_3.Dock = System.Windows.Forms.DockStyle.None
		Me._picOptions_3.BackColor = System.Drawing.SystemColors.Control
		Me._picOptions_3.CausesValidation = True
		Me._picOptions_3.Enabled = True
		Me._picOptions_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picOptions_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._picOptions_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picOptions_3.Visible = True
		Me._picOptions_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._picOptions_3.Name = "_picOptions_3"
		Me.fraSample4.Text = "Ejemplo 4"
		Me.fraSample4.Size = New System.Drawing.Size(137, 119)
		Me.fraSample4.Location = New System.Drawing.Point(140, 56)
		Me.fraSample4.TabIndex = 5
		Me.fraSample4.BackColor = System.Drawing.SystemColors.Control
		Me.fraSample4.Enabled = True
		Me.fraSample4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSample4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSample4.Visible = True
		Me.fraSample4.Padding = New System.Windows.Forms.Padding(0)
		Me.fraSample4.Name = "fraSample4"
		Me._picOptions_2.Size = New System.Drawing.Size(379, 252)
		Me._picOptions_2.Location = New System.Drawing.Point(-1333, 32)
		Me._picOptions_2.TabIndex = 1
		Me._picOptions_2.TabStop = False
		Me._picOptions_2.Dock = System.Windows.Forms.DockStyle.None
		Me._picOptions_2.BackColor = System.Drawing.SystemColors.Control
		Me._picOptions_2.CausesValidation = True
		Me._picOptions_2.Enabled = True
		Me._picOptions_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picOptions_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._picOptions_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picOptions_2.Visible = True
		Me._picOptions_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._picOptions_2.Name = "_picOptions_2"
		Me.fraSample3.Text = "Ejemplo 3"
		Me.fraSample3.Size = New System.Drawing.Size(137, 119)
		Me.fraSample3.Location = New System.Drawing.Point(103, 45)
		Me.fraSample3.TabIndex = 4
		Me.fraSample3.BackColor = System.Drawing.SystemColors.Control
		Me.fraSample3.Enabled = True
		Me.fraSample3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSample3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSample3.Visible = True
		Me.fraSample3.Padding = New System.Windows.Forms.Padding(0)
		Me.fraSample3.Name = "fraSample3"
		Me._picOptions_1.Size = New System.Drawing.Size(379, 252)
		Me._picOptions_1.Location = New System.Drawing.Point(-1333, 32)
		Me._picOptions_1.TabIndex = 0
		Me._picOptions_1.TabStop = False
		Me._picOptions_1.Dock = System.Windows.Forms.DockStyle.None
		Me._picOptions_1.BackColor = System.Drawing.SystemColors.Control
		Me._picOptions_1.CausesValidation = True
		Me._picOptions_1.Enabled = True
		Me._picOptions_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._picOptions_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._picOptions_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._picOptions_1.Visible = True
		Me._picOptions_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._picOptions_1.Name = "_picOptions_1"
		Me.fraSample2.Text = "Ejemplo 2"
		Me.fraSample2.Size = New System.Drawing.Size(137, 119)
		Me.fraSample2.Location = New System.Drawing.Point(43, 20)
		Me.fraSample2.TabIndex = 3
		Me.fraSample2.BackColor = System.Drawing.SystemColors.Control
		Me.fraSample2.Enabled = True
		Me.fraSample2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraSample2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraSample2.Visible = True
		Me.fraSample2.Padding = New System.Windows.Forms.Padding(0)
		Me.fraSample2.Name = "fraSample2"
		Me.dialogoOpen.DefaultExt = "RGF"
		Me.dialogoOpen.FileName = "Frecuencias.RGF"
		Me.dialogoOpen.Filter = " Registro | *.log ; Registro Gestor | *.RGF"
		Me.dialogoOpen.FilterIndex = 2
		Me.dialogoOpen.InitialDirectory = "C:\"
		Progreso.OcxState = CType(resources.GetObject("Progreso.OcxState"), System.Windows.Forms.AxHost.State)
		Me.Progreso.Size = New System.Drawing.Size(249, 17)
		Me.Progreso.Location = New System.Drawing.Point(8, 224)
		Me.Progreso.TabIndex = 18
		Me.Progreso.Name = "Progreso"
		Me.Controls.Add(Command4)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(framdatos)
		Me.Controls.Add(BD)
		Me.Controls.Add(botañade)
		Me.Controls.Add(botborrar)
		Me.Controls.Add(botload)
		Me.Controls.Add(botgenera)
		Me.Controls.Add(botorden)
		Me.Controls.Add(_picOptions_3)
		Me.Controls.Add(_picOptions_2)
		Me.Controls.Add(_picOptions_1)
		Me.Controls.Add(Progreso)
		Me.Frame1.Controls.Add(Command3)
		Me.Frame1.Controls.Add(Command2)
		Me.Frame1.Controls.Add(Command1)
		Me.framdatos.Controls.Add(txttotal)
		Me.framdatos.Controls.Add(txtexportar)
		Me.framdatos.Controls.Add(txtComprobado)
		Me.framdatos.Controls.Add(Label3)
		Me.framdatos.Controls.Add(Label2)
		Me.framdatos.Controls.Add(Label4)
		Me._picOptions_3.Controls.Add(fraSample4)
		Me._picOptions_2.Controls.Add(fraSample3)
		Me._picOptions_1.Controls.Add(fraSample2)
		Me.picOptions.SetIndex(_picOptions_3, CType(3, Short))
		Me.picOptions.SetIndex(_picOptions_2, CType(2, Short))
		Me.picOptions.SetIndex(_picOptions_1, CType(1, Short))
		CType(Me.picOptions, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Progreso, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame1.ResumeLayout(False)
		Me.framdatos.ResumeLayout(False)
		Me._picOptions_3.ResumeLayout(False)
		Me._picOptions_2.ResumeLayout(False)
		Me._picOptions_1.ResumeLayout(False)
		Me.fraSample2.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class