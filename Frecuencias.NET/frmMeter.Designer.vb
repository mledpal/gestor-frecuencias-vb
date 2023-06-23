<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmFrecuencias
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
	Public WithEvents bd As System.Windows.Forms.Label
	Public WithEvents botopciones As System.Windows.Forms.Button
	Public WithEvents txtdcs As System.Windows.Forms.ComboBox
	Public WithEvents txtctcss As System.Windows.Forms.ComboBox
	Public WithEvents txts As System.Windows.Forms.TextBox
	Public WithEvents txtr As System.Windows.Forms.TextBox
	Public WithEvents botmem As System.Windows.Forms.Button
	Public WithEvents chkcomprobado As System.Windows.Forms.CheckBox
	Public WithEvents botrepet As System.Windows.Forms.Button
	Public WithEvents txtfecha As System.Windows.Forms.TextBox
	Public WithEvents TxtBanda As System.Windows.Forms.ComboBox
	Public WithEvents TxtMemoria As System.Windows.Forms.TextBox
	Public WithEvents TxtObserv As System.Windows.Forms.TextBox
	Public WithEvents TxtLocalidad As System.Windows.Forms.TextBox
	Public WithEvents txtFrecuencia As System.Windows.Forms.TextBox
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Lbl2 As System.Windows.Forms.Label
	Public WithEvents Lbl1 As System.Windows.Forms.Label
	Public WithEvents _registro_0 As System.Windows.Forms.GroupBox
	Public WithEvents botir As System.Windows.Forms.Button
	Public WithEvents txtira As System.Windows.Forms.TextBox
	Public WithEvents RegTotal As System.Windows.Forms.TextBox
	Public WithEvents RegActual As System.Windows.Forms.TextBox
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents NumeroReg As System.Windows.Forms.GroupBox
	Public WithEvents botbusca As System.Windows.Forms.Button
	Public WithEvents botborrar As System.Windows.Forms.Button
	Public WithEvents botacerca As System.Windows.Forms.Button
	Public WithEvents botactualiza As System.Windows.Forms.Button
	Public WithEvents botnuevo As System.Windows.Forms.Button
	Public WithEvents registro As Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFrecuencias))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.bd = New System.Windows.Forms.Label
		Me.botopciones = New System.Windows.Forms.Button
		Me._registro_0 = New System.Windows.Forms.GroupBox
		Me.txtdcs = New System.Windows.Forms.ComboBox
		Me.txtctcss = New System.Windows.Forms.ComboBox
		Me.txts = New System.Windows.Forms.TextBox
		Me.txtr = New System.Windows.Forms.TextBox
		Me.botmem = New System.Windows.Forms.Button
		Me.chkcomprobado = New System.Windows.Forms.CheckBox
		Me.botrepet = New System.Windows.Forms.Button
		Me.txtfecha = New System.Windows.Forms.TextBox
		Me.TxtBanda = New System.Windows.Forms.ComboBox
		Me.TxtMemoria = New System.Windows.Forms.TextBox
		Me.TxtObserv = New System.Windows.Forms.TextBox
		Me.TxtLocalidad = New System.Windows.Forms.TextBox
		Me.txtFrecuencia = New System.Windows.Forms.TextBox
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Lbl2 = New System.Windows.Forms.Label
		Me.Lbl1 = New System.Windows.Forms.Label
		Me.NumeroReg = New System.Windows.Forms.GroupBox
		Me.botir = New System.Windows.Forms.Button
		Me.txtira = New System.Windows.Forms.TextBox
		Me.RegTotal = New System.Windows.Forms.TextBox
		Me.RegActual = New System.Windows.Forms.TextBox
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.botbusca = New System.Windows.Forms.Button
		Me.botborrar = New System.Windows.Forms.Button
		Me.botacerca = New System.Windows.Forms.Button
		Me.botactualiza = New System.Windows.Forms.Button
		Me.botnuevo = New System.Windows.Forms.Button
		Me.registro = New Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(components)
		Me._registro_0.SuspendLayout()
		Me.NumeroReg.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.registro, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Gestor de Frecuencias by MiguelDJ v 1.3 (2006)"
		Me.ClientSize = New System.Drawing.Size(588, 228)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.Icon = CType(resources.GetObject("frmFrecuencias.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmFrecuencias"
		Me.bd.Text = "BD"
		Me.bd.Size = New System.Drawing.Size(588, 25)
		Me.bd.Location = New System.Drawing.Point(0, 203)
		Me.bd.BackColor = System.Drawing.Color.Red
		Me.bd.ForeColor = System.Drawing.Color.Black
		Me.bd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bd.Text = "bd"
		Me.bd.Name = "bd"
		Me.botopciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botopciones.Text = "Opciones"
		Me.botopciones.Size = New System.Drawing.Size(65, 25)
		Me.botopciones.Location = New System.Drawing.Point(88, 176)
		Me.botopciones.TabIndex = 26
		Me.botopciones.BackColor = System.Drawing.SystemColors.Control
		Me.botopciones.CausesValidation = True
		Me.botopciones.Enabled = True
		Me.botopciones.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botopciones.Cursor = System.Windows.Forms.Cursors.Default
		Me.botopciones.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botopciones.TabStop = True
		Me.botopciones.Name = "botopciones"
		Me._registro_0.Text = "Registro"
		Me._registro_0.Size = New System.Drawing.Size(425, 201)
		Me._registro_0.Location = New System.Drawing.Point(160, 0)
		Me._registro_0.TabIndex = 10
		Me._registro_0.BackColor = System.Drawing.SystemColors.Control
		Me._registro_0.Enabled = True
		Me._registro_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._registro_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._registro_0.Visible = True
		Me._registro_0.Padding = New System.Windows.Forms.Padding(0)
		Me._registro_0.Name = "_registro_0"
		Me.txtdcs.Size = New System.Drawing.Size(57, 21)
		Me.txtdcs.Location = New System.Drawing.Point(360, 168)
		Me.txtdcs.Items.AddRange(New Object(){"-----", "023", "025", "026", "031", "032", "036", "043", "047", "051", "053", "054", "065", "071", "072", "073", "074", "114", "115", "116", "122", "125", "131", "132", "134", "143", "145", "152", "155", "156", "162", "165", "172", "174", "205", "212", "223", "225", "226", "243", "244", "245", "246", "251", "252", "255", "261", "263", "265", "266", "271", "274", "306", "311", "315", "325", "331", "332", "343", "346", "351", "356", "364", "365", "371", "411", "412", "413", "423", "431", "432", "445", "446", "452", "454", "455", "462", "464", "465", "466", "503", "406", "516", "523", "526", "532", "546", "565", "606", "612", "624", "627", "631", "632", "654", "662", "664", "703", "712", "723", "731", "732", "734", "743", "743", "754"})
		Me.txtdcs.TabIndex = 37
		Me.txtdcs.BackColor = System.Drawing.SystemColors.Window
		Me.txtdcs.CausesValidation = True
		Me.txtdcs.Enabled = True
		Me.txtdcs.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtdcs.IntegralHeight = True
		Me.txtdcs.Cursor = System.Windows.Forms.Cursors.Default
		Me.txtdcs.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtdcs.Sorted = False
		Me.txtdcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.txtdcs.TabStop = True
		Me.txtdcs.Visible = True
		Me.txtdcs.Name = "txtdcs"
		Me.txtctcss.Size = New System.Drawing.Size(57, 21)
		Me.txtctcss.Location = New System.Drawing.Point(360, 144)
		Me.txtctcss.Items.AddRange(New Object(){"-----", "67.0", "69.3", "71.9", "74.4", "77.0", "79.7", "82.5", "85.4", "88.5", "91.5", "94.8", "97.4", "100.0", "103.5", "107.2", "110.9", "114.8", "118.8", "123.0", "127.3", "127.3", "131.8", "136.5", "141.3", "146.2", "151.4", "156.7", "159.8", "162.2", "165.5", "167.9", "171.3", "173.8", "177.3", "179.9", "183.5", "186.2", "189.9", "192.8", "196.6", "199.5", "203.5", "206.5", "210.7", "218.1", "225.7", "229.1", "233.6", "241.8", "250.3", "254.1"})
		Me.txtctcss.TabIndex = 36
		Me.txtctcss.BackColor = System.Drawing.SystemColors.Window
		Me.txtctcss.CausesValidation = True
		Me.txtctcss.Enabled = True
		Me.txtctcss.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtctcss.IntegralHeight = True
		Me.txtctcss.Cursor = System.Windows.Forms.Cursors.Default
		Me.txtctcss.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtctcss.Sorted = False
		Me.txtctcss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.txtctcss.TabStop = True
		Me.txtctcss.Visible = True
		Me.txtctcss.Name = "txtctcss"
		Me.txts.AutoSize = False
		Me.txts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txts.Size = New System.Drawing.Size(57, 19)
		Me.txts.Location = New System.Drawing.Point(360, 88)
		Me.txts.TabIndex = 31
		Me.txts.AcceptsReturn = True
		Me.txts.BackColor = System.Drawing.SystemColors.Window
		Me.txts.CausesValidation = True
		Me.txts.Enabled = True
		Me.txts.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txts.HideSelection = True
		Me.txts.ReadOnly = False
		Me.txts.Maxlength = 0
		Me.txts.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txts.MultiLine = False
		Me.txts.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txts.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txts.TabStop = True
		Me.txts.Visible = True
		Me.txts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txts.Name = "txts"
		Me.txtr.AutoSize = False
		Me.txtr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtr.Size = New System.Drawing.Size(57, 19)
		Me.txtr.Location = New System.Drawing.Point(360, 112)
		Me.txtr.TabIndex = 30
		Me.txtr.AcceptsReturn = True
		Me.txtr.BackColor = System.Drawing.SystemColors.Window
		Me.txtr.CausesValidation = True
		Me.txtr.Enabled = True
		Me.txtr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtr.HideSelection = True
		Me.txtr.ReadOnly = False
		Me.txtr.Maxlength = 0
		Me.txtr.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtr.MultiLine = False
		Me.txtr.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtr.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtr.TabStop = True
		Me.txtr.Visible = True
		Me.txtr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtr.Name = "txtr"
		Me.botmem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botmem.Text = "Mem"
		Me.botmem.Size = New System.Drawing.Size(81, 25)
		Me.botmem.Location = New System.Drawing.Point(224, 56)
		Me.botmem.TabIndex = 29
		Me.botmem.BackColor = System.Drawing.SystemColors.Control
		Me.botmem.CausesValidation = True
		Me.botmem.Enabled = True
		Me.botmem.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botmem.Cursor = System.Windows.Forms.Cursors.Default
		Me.botmem.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botmem.TabStop = True
		Me.botmem.Name = "botmem"
		Me.chkcomprobado.Text = "Comprobada"
		Me.chkcomprobado.Size = New System.Drawing.Size(81, 25)
		Me.chkcomprobado.Location = New System.Drawing.Point(336, 16)
		Me.chkcomprobado.TabIndex = 28
		Me.chkcomprobado.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkcomprobado.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkcomprobado.BackColor = System.Drawing.SystemColors.Control
		Me.chkcomprobado.CausesValidation = True
		Me.chkcomprobado.Enabled = True
		Me.chkcomprobado.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkcomprobado.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkcomprobado.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkcomprobado.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkcomprobado.TabStop = True
		Me.chkcomprobado.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkcomprobado.Visible = True
		Me.chkcomprobado.Name = "chkcomprobado"
		Me.botrepet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botrepet.Text = "+ R -"
		Me.botrepet.Size = New System.Drawing.Size(81, 25)
		Me.botrepet.Location = New System.Drawing.Point(224, 24)
		Me.botrepet.TabIndex = 27
		Me.botrepet.BackColor = System.Drawing.SystemColors.Control
		Me.botrepet.CausesValidation = True
		Me.botrepet.Enabled = True
		Me.botrepet.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botrepet.Cursor = System.Windows.Forms.Cursors.Default
		Me.botrepet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botrepet.TabStop = True
		Me.botrepet.Name = "botrepet"
		Me.txtfecha.AutoSize = False
		Me.txtfecha.Size = New System.Drawing.Size(73, 25)
		Me.txtfecha.Location = New System.Drawing.Point(96, 168)
		Me.txtfecha.TabIndex = 22
		Me.txtfecha.AcceptsReturn = True
		Me.txtfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtfecha.BackColor = System.Drawing.SystemColors.Window
		Me.txtfecha.CausesValidation = True
		Me.txtfecha.Enabled = True
		Me.txtfecha.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtfecha.HideSelection = True
		Me.txtfecha.ReadOnly = False
		Me.txtfecha.Maxlength = 0
		Me.txtfecha.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtfecha.MultiLine = False
		Me.txtfecha.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtfecha.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtfecha.TabStop = True
		Me.txtfecha.Visible = True
		Me.txtfecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtfecha.Name = "txtfecha"
		Me.TxtBanda.Size = New System.Drawing.Size(81, 21)
		Me.TxtBanda.Location = New System.Drawing.Point(224, 168)
		Me.TxtBanda.Items.AddRange(New Object(){"2 m", "27 Mhz", "70 cm", "900 Mhz", "CB", "HF", "SHF", "UHF", "VHF"})
		Me.TxtBanda.Sorted = True
		Me.TxtBanda.TabIndex = 20
		Me.TxtBanda.BackColor = System.Drawing.SystemColors.Window
		Me.TxtBanda.CausesValidation = True
		Me.TxtBanda.Enabled = True
		Me.TxtBanda.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxtBanda.IntegralHeight = True
		Me.TxtBanda.Cursor = System.Windows.Forms.Cursors.Default
		Me.TxtBanda.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxtBanda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.TxtBanda.TabStop = True
		Me.TxtBanda.Visible = True
		Me.TxtBanda.Name = "TxtBanda"
		Me.TxtMemoria.AutoSize = False
		Me.TxtMemoria.Size = New System.Drawing.Size(121, 25)
		Me.TxtMemoria.Location = New System.Drawing.Point(96, 56)
		Me.TxtMemoria.Maxlength = 2
		Me.TxtMemoria.TabIndex = 14
		Me.TxtMemoria.AcceptsReturn = True
		Me.TxtMemoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.TxtMemoria.BackColor = System.Drawing.SystemColors.Window
		Me.TxtMemoria.CausesValidation = True
		Me.TxtMemoria.Enabled = True
		Me.TxtMemoria.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxtMemoria.HideSelection = True
		Me.TxtMemoria.ReadOnly = False
		Me.TxtMemoria.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtMemoria.MultiLine = False
		Me.TxtMemoria.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxtMemoria.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.TxtMemoria.TabStop = True
		Me.TxtMemoria.Visible = True
		Me.TxtMemoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TxtMemoria.Name = "TxtMemoria"
		Me.TxtObserv.AutoSize = False
		Me.TxtObserv.Size = New System.Drawing.Size(209, 41)
		Me.TxtObserv.Location = New System.Drawing.Point(96, 88)
		Me.TxtObserv.Maxlength = 100
		Me.TxtObserv.MultiLine = True
		Me.TxtObserv.TabIndex = 13
		Me.TxtObserv.AcceptsReturn = True
		Me.TxtObserv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.TxtObserv.BackColor = System.Drawing.SystemColors.Window
		Me.TxtObserv.CausesValidation = True
		Me.TxtObserv.Enabled = True
		Me.TxtObserv.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxtObserv.HideSelection = True
		Me.TxtObserv.ReadOnly = False
		Me.TxtObserv.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtObserv.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxtObserv.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.TxtObserv.TabStop = True
		Me.TxtObserv.Visible = True
		Me.TxtObserv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TxtObserv.Name = "TxtObserv"
		Me.TxtLocalidad.AutoSize = False
		Me.TxtLocalidad.Size = New System.Drawing.Size(161, 25)
		Me.TxtLocalidad.Location = New System.Drawing.Point(96, 136)
		Me.TxtLocalidad.TabIndex = 12
		Me.TxtLocalidad.AcceptsReturn = True
		Me.TxtLocalidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.TxtLocalidad.BackColor = System.Drawing.SystemColors.Window
		Me.TxtLocalidad.CausesValidation = True
		Me.TxtLocalidad.Enabled = True
		Me.TxtLocalidad.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxtLocalidad.HideSelection = True
		Me.TxtLocalidad.ReadOnly = False
		Me.TxtLocalidad.Maxlength = 0
		Me.TxtLocalidad.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtLocalidad.MultiLine = False
		Me.TxtLocalidad.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxtLocalidad.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.TxtLocalidad.TabStop = True
		Me.TxtLocalidad.Visible = True
		Me.TxtLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TxtLocalidad.Name = "TxtLocalidad"
		Me.txtFrecuencia.AutoSize = False
		Me.txtFrecuencia.Size = New System.Drawing.Size(121, 25)
		Me.txtFrecuencia.Location = New System.Drawing.Point(96, 24)
		Me.txtFrecuencia.TabIndex = 11
		Me.txtFrecuencia.AcceptsReturn = True
		Me.txtFrecuencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtFrecuencia.BackColor = System.Drawing.SystemColors.Window
		Me.txtFrecuencia.CausesValidation = True
		Me.txtFrecuencia.Enabled = True
		Me.txtFrecuencia.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtFrecuencia.HideSelection = True
		Me.txtFrecuencia.ReadOnly = False
		Me.txtFrecuencia.Maxlength = 0
		Me.txtFrecuencia.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtFrecuencia.MultiLine = False
		Me.txtFrecuencia.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtFrecuencia.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtFrecuencia.TabStop = True
		Me.txtFrecuencia.Visible = True
		Me.txtFrecuencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtFrecuencia.Name = "txtFrecuencia"
		Me.Label11.Text = "DCS"
		Me.Label11.Size = New System.Drawing.Size(33, 17)
		Me.Label11.Location = New System.Drawing.Point(312, 168)
		Me.Label11.TabIndex = 35
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label11.BackColor = System.Drawing.SystemColors.Control
		Me.Label11.Enabled = True
		Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label11.UseMnemonic = True
		Me.Label11.Visible = True
		Me.Label11.AutoSize = False
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label11.Name = "Label11"
		Me.Label10.Text = "CTCSS"
		Me.Label10.Size = New System.Drawing.Size(41, 17)
		Me.Label10.Location = New System.Drawing.Point(312, 144)
		Me.Label10.TabIndex = 34
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label10.BackColor = System.Drawing.SystemColors.Control
		Me.Label10.Enabled = True
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.UseMnemonic = True
		Me.Label10.Visible = True
		Me.Label10.AutoSize = False
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label10.Name = "Label10"
		Me.Label8.Text = "Señal: "
		Me.Label8.Size = New System.Drawing.Size(33, 17)
		Me.Label8.Location = New System.Drawing.Point(312, 88)
		Me.Label8.TabIndex = 33
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.Enabled = True
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me.Label9.Text = "Radio:"
		Me.Label9.Size = New System.Drawing.Size(33, 17)
		Me.Label9.Location = New System.Drawing.Point(312, 112)
		Me.Label9.TabIndex = 32
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label9.BackColor = System.Drawing.SystemColors.Control
		Me.Label9.Enabled = True
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.Visible = True
		Me.Label9.AutoSize = False
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me.Label6.Text = "Fecha :"
		Me.Label6.Size = New System.Drawing.Size(41, 17)
		Me.Label6.Location = New System.Drawing.Point(48, 168)
		Me.Label6.TabIndex = 21
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Label1.Text = "Banda :"
		Me.Label1.Size = New System.Drawing.Size(41, 17)
		Me.Label1.Location = New System.Drawing.Point(184, 168)
		Me.Label1.TabIndex = 19
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
		Me.Label3.Text = "Localidad :"
		Me.Label3.Size = New System.Drawing.Size(57, 17)
		Me.Label3.Location = New System.Drawing.Point(40, 136)
		Me.Label3.TabIndex = 18
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
		Me.Label2.Text = "Observaciones :"
		Me.Label2.Size = New System.Drawing.Size(81, 17)
		Me.Label2.Location = New System.Drawing.Point(8, 88)
		Me.Label2.TabIndex = 17
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
		Me.Lbl2.Text = "Memoria :"
		Me.Lbl2.Size = New System.Drawing.Size(49, 17)
		Me.Lbl2.Location = New System.Drawing.Point(40, 56)
		Me.Lbl2.TabIndex = 16
		Me.Lbl2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Lbl2.BackColor = System.Drawing.SystemColors.Control
		Me.Lbl2.Enabled = True
		Me.Lbl2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Lbl2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Lbl2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Lbl2.UseMnemonic = True
		Me.Lbl2.Visible = True
		Me.Lbl2.AutoSize = False
		Me.Lbl2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Lbl2.Name = "Lbl2"
		Me.Lbl1.Text = "Frecuencia  :"
		Me.Lbl1.Size = New System.Drawing.Size(65, 17)
		Me.Lbl1.Location = New System.Drawing.Point(24, 24)
		Me.Lbl1.TabIndex = 15
		Me.Lbl1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Lbl1.BackColor = System.Drawing.SystemColors.Control
		Me.Lbl1.Enabled = True
		Me.Lbl1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Lbl1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Lbl1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Lbl1.UseMnemonic = True
		Me.Lbl1.Visible = True
		Me.Lbl1.AutoSize = False
		Me.Lbl1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Lbl1.Name = "Lbl1"
		Me.NumeroReg.Text = "Registros"
		Me.NumeroReg.Size = New System.Drawing.Size(145, 105)
		Me.NumeroReg.Location = New System.Drawing.Point(8, 0)
		Me.NumeroReg.TabIndex = 5
		Me.NumeroReg.BackColor = System.Drawing.SystemColors.Control
		Me.NumeroReg.Enabled = True
		Me.NumeroReg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.NumeroReg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.NumeroReg.Visible = True
		Me.NumeroReg.Padding = New System.Windows.Forms.Padding(0)
		Me.NumeroReg.Name = "NumeroReg"
		Me.botir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botir.Text = ">"
		Me.botir.Enabled = False
		Me.botir.Size = New System.Drawing.Size(17, 17)
		Me.botir.Location = New System.Drawing.Point(104, 40)
		Me.botir.TabIndex = 25
		Me.botir.BackColor = System.Drawing.SystemColors.Control
		Me.botir.CausesValidation = True
		Me.botir.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botir.Cursor = System.Windows.Forms.Cursors.Default
		Me.botir.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botir.TabStop = True
		Me.botir.Name = "botir"
		Me.txtira.AutoSize = False
		Me.txtira.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtira.Size = New System.Drawing.Size(41, 17)
		Me.txtira.Location = New System.Drawing.Point(56, 40)
		Me.txtira.Maxlength = 5
		Me.txtira.TabIndex = 24
		Me.txtira.AcceptsReturn = True
		Me.txtira.BackColor = System.Drawing.SystemColors.Window
		Me.txtira.CausesValidation = True
		Me.txtira.Enabled = True
		Me.txtira.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtira.HideSelection = True
		Me.txtira.ReadOnly = False
		Me.txtira.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtira.MultiLine = False
		Me.txtira.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtira.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtira.TabStop = True
		Me.txtira.Visible = True
		Me.txtira.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtira.Name = "txtira"
		Me.RegTotal.AutoSize = False
		Me.RegTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.RegTotal.BackColor = System.Drawing.SystemColors.Info
		Me.RegTotal.ForeColor = System.Drawing.Color.Blue
		Me.RegTotal.Size = New System.Drawing.Size(65, 19)
		Me.RegTotal.Location = New System.Drawing.Point(56, 72)
		Me.RegTotal.ReadOnly = True
		Me.RegTotal.TabIndex = 9
		Me.RegTotal.AcceptsReturn = True
		Me.RegTotal.CausesValidation = True
		Me.RegTotal.Enabled = True
		Me.RegTotal.HideSelection = True
		Me.RegTotal.Maxlength = 0
		Me.RegTotal.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.RegTotal.MultiLine = False
		Me.RegTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.RegTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.RegTotal.TabStop = True
		Me.RegTotal.Visible = True
		Me.RegTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.RegTotal.Name = "RegTotal"
		Me.RegActual.AutoSize = False
		Me.RegActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.RegActual.BackColor = System.Drawing.SystemColors.Info
		Me.RegActual.Size = New System.Drawing.Size(65, 19)
		Me.RegActual.Location = New System.Drawing.Point(56, 16)
		Me.RegActual.ReadOnly = True
		Me.RegActual.TabIndex = 8
		Me.RegActual.AcceptsReturn = True
		Me.RegActual.CausesValidation = True
		Me.RegActual.Enabled = True
		Me.RegActual.ForeColor = System.Drawing.SystemColors.WindowText
		Me.RegActual.HideSelection = True
		Me.RegActual.Maxlength = 0
		Me.RegActual.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.RegActual.MultiLine = False
		Me.RegActual.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.RegActual.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.RegActual.TabStop = True
		Me.RegActual.Visible = True
		Me.RegActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.RegActual.Name = "RegActual"
		Me.Label7.Text = "Ir a :"
		Me.Label7.Size = New System.Drawing.Size(25, 17)
		Me.Label7.Location = New System.Drawing.Point(24, 40)
		Me.Label7.TabIndex = 23
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
		Me.Label5.Text = "Total :"
		Me.Label5.Size = New System.Drawing.Size(33, 17)
		Me.Label5.Location = New System.Drawing.Point(16, 72)
		Me.Label5.TabIndex = 7
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label4.Text = "Numero:"
		Me.Label4.Size = New System.Drawing.Size(41, 17)
		Me.Label4.Location = New System.Drawing.Point(8, 16)
		Me.Label4.TabIndex = 6
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
		Me.botbusca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botbusca.Text = "Buscar"
		Me.botbusca.Size = New System.Drawing.Size(65, 25)
		Me.botbusca.Location = New System.Drawing.Point(88, 112)
		Me.botbusca.TabIndex = 4
		Me.botbusca.BackColor = System.Drawing.SystemColors.Control
		Me.botbusca.CausesValidation = True
		Me.botbusca.Enabled = True
		Me.botbusca.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botbusca.Cursor = System.Windows.Forms.Cursors.Default
		Me.botbusca.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botbusca.TabStop = True
		Me.botbusca.Name = "botbusca"
		Me.botborrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botborrar.Text = "Eliminar"
		Me.botborrar.Size = New System.Drawing.Size(65, 25)
		Me.botborrar.Location = New System.Drawing.Point(88, 144)
		Me.botborrar.TabIndex = 3
		Me.botborrar.BackColor = System.Drawing.SystemColors.Control
		Me.botborrar.CausesValidation = True
		Me.botborrar.Enabled = True
		Me.botborrar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botborrar.Cursor = System.Windows.Forms.Cursors.Default
		Me.botborrar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botborrar.TabStop = True
		Me.botborrar.Name = "botborrar"
		Me.botacerca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botacerca.Text = "Informacion"
		Me.botacerca.Size = New System.Drawing.Size(65, 25)
		Me.botacerca.Location = New System.Drawing.Point(8, 176)
		Me.botacerca.TabIndex = 2
		Me.botacerca.BackColor = System.Drawing.SystemColors.Control
		Me.botacerca.CausesValidation = True
		Me.botacerca.Enabled = True
		Me.botacerca.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botacerca.Cursor = System.Windows.Forms.Cursors.Default
		Me.botacerca.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botacerca.TabStop = True
		Me.botacerca.Name = "botacerca"
		Me.botactualiza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botactualiza.Text = "Actualizar"
		Me.botactualiza.Enabled = False
		Me.botactualiza.Size = New System.Drawing.Size(65, 25)
		Me.botactualiza.Location = New System.Drawing.Point(8, 144)
		Me.botactualiza.TabIndex = 1
		Me.botactualiza.BackColor = System.Drawing.SystemColors.Control
		Me.botactualiza.CausesValidation = True
		Me.botactualiza.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botactualiza.Cursor = System.Windows.Forms.Cursors.Default
		Me.botactualiza.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botactualiza.TabStop = True
		Me.botactualiza.Name = "botactualiza"
		Me.botnuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botnuevo.Text = "Nuevo"
		Me.botnuevo.Size = New System.Drawing.Size(65, 25)
		Me.botnuevo.Location = New System.Drawing.Point(8, 112)
		Me.botnuevo.TabIndex = 0
		Me.botnuevo.BackColor = System.Drawing.SystemColors.Control
		Me.botnuevo.CausesValidation = True
		Me.botnuevo.Enabled = True
		Me.botnuevo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botnuevo.Cursor = System.Windows.Forms.Cursors.Default
		Me.botnuevo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botnuevo.TabStop = True
		Me.botnuevo.Name = "botnuevo"
		Me.Controls.Add(bd)
		Me.Controls.Add(botopciones)
		Me.Controls.Add(_registro_0)
		Me.Controls.Add(NumeroReg)
		Me.Controls.Add(botbusca)
		Me.Controls.Add(botborrar)
		Me.Controls.Add(botacerca)
		Me.Controls.Add(botactualiza)
		Me.Controls.Add(botnuevo)
		Me._registro_0.Controls.Add(txtdcs)
		Me._registro_0.Controls.Add(txtctcss)
		Me._registro_0.Controls.Add(txts)
		Me._registro_0.Controls.Add(txtr)
		Me._registro_0.Controls.Add(botmem)
		Me._registro_0.Controls.Add(chkcomprobado)
		Me._registro_0.Controls.Add(botrepet)
		Me._registro_0.Controls.Add(txtfecha)
		Me._registro_0.Controls.Add(TxtBanda)
		Me._registro_0.Controls.Add(TxtMemoria)
		Me._registro_0.Controls.Add(TxtObserv)
		Me._registro_0.Controls.Add(TxtLocalidad)
		Me._registro_0.Controls.Add(txtFrecuencia)
		Me._registro_0.Controls.Add(Label11)
		Me._registro_0.Controls.Add(Label10)
		Me._registro_0.Controls.Add(Label8)
		Me._registro_0.Controls.Add(Label9)
		Me._registro_0.Controls.Add(Label6)
		Me._registro_0.Controls.Add(Label1)
		Me._registro_0.Controls.Add(Label3)
		Me._registro_0.Controls.Add(Label2)
		Me._registro_0.Controls.Add(Lbl2)
		Me._registro_0.Controls.Add(Lbl1)
		Me.NumeroReg.Controls.Add(botir)
		Me.NumeroReg.Controls.Add(txtira)
		Me.NumeroReg.Controls.Add(RegTotal)
		Me.NumeroReg.Controls.Add(RegActual)
		Me.NumeroReg.Controls.Add(Label7)
		Me.NumeroReg.Controls.Add(Label5)
		Me.NumeroReg.Controls.Add(Label4)
		Me.registro.SetIndex(_registro_0, CType(0, Short))
		CType(Me.registro, System.ComponentModel.ISupportInitialize).EndInit()
		Me._registro_0.ResumeLayout(False)
		Me.NumeroReg.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class