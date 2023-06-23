<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmexportar
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
	Public WithEvents BD As System.Windows.Forms.Label
	Public WithEvents botgenerar As System.Windows.Forms.Button
	Public WithEvents chkexport As System.Windows.Forms.CheckBox
	Public WithEvents chkcomprob As System.Windows.Forms.CheckBox
	Public WithEvents fraseleccion As System.Windows.Forms.GroupBox
	Public WithEvents optseleccionar As System.Windows.Forms.RadioButton
	Public WithEvents opttodos As System.Windows.Forms.RadioButton
	Public WithEvents fraexportar As System.Windows.Forms.GroupBox
	Public WithEvents botmem As System.Windows.Forms.Button
	Public WithEvents chkexportar As System.Windows.Forms.CheckBox
	Public WithEvents txtFrecuencia As System.Windows.Forms.TextBox
	Public WithEvents TxtLocalidad As System.Windows.Forms.TextBox
	Public WithEvents TxtObserv As System.Windows.Forms.TextBox
	Public WithEvents TxtMemoria As System.Windows.Forms.TextBox
	Public WithEvents TxtBanda As System.Windows.Forms.ComboBox
	Public WithEvents txtfecha As System.Windows.Forms.TextBox
	Public WithEvents botrepet As System.Windows.Forms.Button
	Public WithEvents chkcomprobado As System.Windows.Forms.CheckBox
	Public WithEvents Lbl1 As System.Windows.Forms.Label
	Public WithEvents Lbl2 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Registro As System.Windows.Forms.GroupBox
	Public WithEvents botvercomp As System.Windows.Forms.Button
	Public WithEvents _botselexporta_1 As System.Windows.Forms.Button
	Public WithEvents _botselexporta_0 As System.Windows.Forms.Button
	Public WithEvents txtexportar As System.Windows.Forms.TextBox
	Public WithEvents RegActual As System.Windows.Forms.TextBox
	Public WithEvents RegTotal As System.Windows.Forms.TextBox
	Public WithEvents txtira As System.Windows.Forms.TextBox
	Public WithEvents botir As System.Windows.Forms.Button
	Public WithEvents txtComprobado As System.Windows.Forms.TextBox
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents NumeroReg As System.Windows.Forms.GroupBox
	Public dialogoSave As System.Windows.Forms.SaveFileDialog
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents botselexporta As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmexportar))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.PB = New AxComctlLib.AxProgressBar
		Me.BD = New System.Windows.Forms.Label
		Me.botgenerar = New System.Windows.Forms.Button
		Me.fraexportar = New System.Windows.Forms.GroupBox
		Me.fraseleccion = New System.Windows.Forms.GroupBox
		Me.chkexport = New System.Windows.Forms.CheckBox
		Me.chkcomprob = New System.Windows.Forms.CheckBox
		Me.optseleccionar = New System.Windows.Forms.RadioButton
		Me.opttodos = New System.Windows.Forms.RadioButton
		Me.Registro = New System.Windows.Forms.GroupBox
		Me.botmem = New System.Windows.Forms.Button
		Me.chkexportar = New System.Windows.Forms.CheckBox
		Me.txtFrecuencia = New System.Windows.Forms.TextBox
		Me.TxtLocalidad = New System.Windows.Forms.TextBox
		Me.TxtObserv = New System.Windows.Forms.TextBox
		Me.TxtMemoria = New System.Windows.Forms.TextBox
		Me.TxtBanda = New System.Windows.Forms.ComboBox
		Me.txtfecha = New System.Windows.Forms.TextBox
		Me.botrepet = New System.Windows.Forms.Button
		Me.chkcomprobado = New System.Windows.Forms.CheckBox
		Me.Lbl1 = New System.Windows.Forms.Label
		Me.Lbl2 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.NumeroReg = New System.Windows.Forms.GroupBox
		Me.botvercomp = New System.Windows.Forms.Button
		Me._botselexporta_1 = New System.Windows.Forms.Button
		Me._botselexporta_0 = New System.Windows.Forms.Button
		Me.txtexportar = New System.Windows.Forms.TextBox
		Me.RegActual = New System.Windows.Forms.TextBox
		Me.RegTotal = New System.Windows.Forms.TextBox
		Me.txtira = New System.Windows.Forms.TextBox
		Me.botir = New System.Windows.Forms.Button
		Me.txtComprobado = New System.Windows.Forms.TextBox
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.dialogoSave = New System.Windows.Forms.SaveFileDialog
		Me.Label10 = New System.Windows.Forms.Label
		Me.botselexporta = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.fraexportar.SuspendLayout()
		Me.fraseleccion.SuspendLayout()
		Me.Registro.SuspendLayout()
		Me.NumeroReg.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.PB, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.botselexporta, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Exportar Registros"
		Me.ClientSize = New System.Drawing.Size(507, 285)
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
		Me.Name = "frmexportar"
		PB.OcxState = CType(resources.GetObject("PB.OcxState"), System.Windows.Forms.AxHost.State)
		Me.PB.Size = New System.Drawing.Size(209, 25)
		Me.PB.Location = New System.Drawing.Point(288, 256)
		Me.PB.TabIndex = 40
		Me.PB.Name = "PB"
		Me.BD.Text = "Frecuencias"
		Me.BD.Size = New System.Drawing.Size(315, 25)
		Me.BD.Location = New System.Drawing.Point(192, 224)
		Me.BD.BackColor = System.Drawing.Color.Red
		Me.BD.ForeColor = System.Drawing.Color.Black
		Me.BD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.BD.Text = "BD"
		Me.BD.Name = "BD"
		Me.botgenerar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botgenerar.Text = "GENERAR TXT"
		Me.botgenerar.Size = New System.Drawing.Size(89, 25)
		Me.botgenerar.Location = New System.Drawing.Point(192, 256)
		Me.botgenerar.TabIndex = 37
		Me.botgenerar.BackColor = System.Drawing.SystemColors.Control
		Me.botgenerar.CausesValidation = True
		Me.botgenerar.Enabled = True
		Me.botgenerar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botgenerar.Cursor = System.Windows.Forms.Cursors.Default
		Me.botgenerar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botgenerar.TabStop = True
		Me.botgenerar.Name = "botgenerar"
		Me.fraexportar.Text = "Exportar . . ."
		Me.fraexportar.Size = New System.Drawing.Size(185, 113)
		Me.fraexportar.Location = New System.Drawing.Point(0, 168)
		Me.fraexportar.TabIndex = 31
		Me.fraexportar.BackColor = System.Drawing.SystemColors.Control
		Me.fraexportar.Enabled = True
		Me.fraexportar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraexportar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraexportar.Visible = True
		Me.fraexportar.Padding = New System.Windows.Forms.Padding(0)
		Me.fraexportar.Name = "fraexportar"
		Me.fraseleccion.Text = "Seleccionar"
		Me.fraseleccion.Size = New System.Drawing.Size(169, 57)
		Me.fraseleccion.Location = New System.Drawing.Point(8, 48)
		Me.fraseleccion.TabIndex = 34
		Me.fraseleccion.BackColor = System.Drawing.SystemColors.Control
		Me.fraseleccion.Enabled = True
		Me.fraseleccion.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraseleccion.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraseleccion.Visible = True
		Me.fraseleccion.Padding = New System.Windows.Forms.Padding(0)
		Me.fraseleccion.Name = "fraseleccion"
		Me.chkexport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.chkexport.Text = "Exportar"
		Me.chkexport.Enabled = False
		Me.chkexport.Size = New System.Drawing.Size(65, 25)
		Me.chkexport.Location = New System.Drawing.Point(96, 24)
		Me.chkexport.Appearance = System.Windows.Forms.Appearance.Button
		Me.chkexport.TabIndex = 36
		Me.chkexport.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkexport.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkexport.BackColor = System.Drawing.SystemColors.Control
		Me.chkexport.CausesValidation = True
		Me.chkexport.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkexport.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkexport.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkexport.TabStop = True
		Me.chkexport.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkexport.Visible = True
		Me.chkexport.Name = "chkexport"
		Me.chkcomprob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.chkcomprob.Text = "Comprobado"
		Me.chkcomprob.Enabled = False
		Me.chkcomprob.Size = New System.Drawing.Size(81, 25)
		Me.chkcomprob.Location = New System.Drawing.Point(8, 24)
		Me.chkcomprob.Appearance = System.Windows.Forms.Appearance.Button
		Me.chkcomprob.TabIndex = 35
		Me.chkcomprob.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkcomprob.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkcomprob.BackColor = System.Drawing.SystemColors.Control
		Me.chkcomprob.CausesValidation = True
		Me.chkcomprob.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkcomprob.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkcomprob.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkcomprob.TabStop = True
		Me.chkcomprob.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkcomprob.Visible = True
		Me.chkcomprob.Name = "chkcomprob"
		Me.optseleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.optseleccionar.Text = "Seleccionados"
		Me.optseleccionar.Size = New System.Drawing.Size(97, 25)
		Me.optseleccionar.Location = New System.Drawing.Point(72, 16)
		Me.optseleccionar.Appearance = System.Windows.Forms.Appearance.Button
		Me.optseleccionar.TabIndex = 33
		Me.optseleccionar.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.optseleccionar.BackColor = System.Drawing.SystemColors.Control
		Me.optseleccionar.CausesValidation = True
		Me.optseleccionar.Enabled = True
		Me.optseleccionar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.optseleccionar.Cursor = System.Windows.Forms.Cursors.Default
		Me.optseleccionar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.optseleccionar.TabStop = True
		Me.optseleccionar.Checked = False
		Me.optseleccionar.Visible = True
		Me.optseleccionar.Name = "optseleccionar"
		Me.opttodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.opttodos.Text = "Todos"
		Me.opttodos.Size = New System.Drawing.Size(57, 25)
		Me.opttodos.Location = New System.Drawing.Point(8, 16)
		Me.opttodos.Appearance = System.Windows.Forms.Appearance.Button
		Me.opttodos.TabIndex = 32
		Me.opttodos.Checked = True
		Me.opttodos.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.opttodos.BackColor = System.Drawing.SystemColors.Control
		Me.opttodos.CausesValidation = True
		Me.opttodos.Enabled = True
		Me.opttodos.ForeColor = System.Drawing.SystemColors.ControlText
		Me.opttodos.Cursor = System.Windows.Forms.Cursors.Default
		Me.opttodos.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.opttodos.TabStop = True
		Me.opttodos.Visible = True
		Me.opttodos.Name = "opttodos"
		Me.Registro.Text = "Registro"
		Me.Registro.Size = New System.Drawing.Size(313, 249)
		Me.Registro.Location = New System.Drawing.Point(192, 0)
		Me.Registro.TabIndex = 10
		Me.Registro.BackColor = System.Drawing.SystemColors.Control
		Me.Registro.Enabled = True
		Me.Registro.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Registro.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Registro.Visible = True
		Me.Registro.Padding = New System.Windows.Forms.Padding(0)
		Me.Registro.Name = "Registro"
		Me.botmem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botmem.Text = "Mem"
		Me.botmem.Size = New System.Drawing.Size(81, 25)
		Me.botmem.Location = New System.Drawing.Point(224, 56)
		Me.botmem.TabIndex = 28
		Me.botmem.BackColor = System.Drawing.SystemColors.Control
		Me.botmem.CausesValidation = True
		Me.botmem.Enabled = True
		Me.botmem.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botmem.Cursor = System.Windows.Forms.Cursors.Default
		Me.botmem.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botmem.TabStop = True
		Me.botmem.Name = "botmem"
		Me.chkexportar.Text = "Exportar"
		Me.chkexportar.Size = New System.Drawing.Size(65, 25)
		Me.chkexportar.Location = New System.Drawing.Point(224, 200)
		Me.chkexportar.TabIndex = 25
		Me.chkexportar.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkexportar.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkexportar.BackColor = System.Drawing.SystemColors.Control
		Me.chkexportar.CausesValidation = True
		Me.chkexportar.Enabled = True
		Me.chkexportar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkexportar.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkexportar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkexportar.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkexportar.TabStop = True
		Me.chkexportar.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkexportar.Visible = True
		Me.chkexportar.Name = "chkexportar"
		Me.txtFrecuencia.AutoSize = False
		Me.txtFrecuencia.Size = New System.Drawing.Size(121, 25)
		Me.txtFrecuencia.Location = New System.Drawing.Point(96, 24)
		Me.txtFrecuencia.ReadOnly = True
		Me.txtFrecuencia.TabIndex = 18
		Me.txtFrecuencia.AcceptsReturn = True
		Me.txtFrecuencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtFrecuencia.BackColor = System.Drawing.SystemColors.Window
		Me.txtFrecuencia.CausesValidation = True
		Me.txtFrecuencia.Enabled = True
		Me.txtFrecuencia.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtFrecuencia.HideSelection = True
		Me.txtFrecuencia.Maxlength = 0
		Me.txtFrecuencia.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtFrecuencia.MultiLine = False
		Me.txtFrecuencia.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtFrecuencia.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtFrecuencia.TabStop = True
		Me.txtFrecuencia.Visible = True
		Me.txtFrecuencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtFrecuencia.Name = "txtFrecuencia"
		Me.TxtLocalidad.AutoSize = False
		Me.TxtLocalidad.Size = New System.Drawing.Size(113, 25)
		Me.TxtLocalidad.Location = New System.Drawing.Point(64, 176)
		Me.TxtLocalidad.ReadOnly = True
		Me.TxtLocalidad.TabIndex = 17
		Me.TxtLocalidad.AcceptsReturn = True
		Me.TxtLocalidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.TxtLocalidad.BackColor = System.Drawing.SystemColors.Window
		Me.TxtLocalidad.CausesValidation = True
		Me.TxtLocalidad.Enabled = True
		Me.TxtLocalidad.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxtLocalidad.HideSelection = True
		Me.TxtLocalidad.Maxlength = 0
		Me.TxtLocalidad.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtLocalidad.MultiLine = False
		Me.TxtLocalidad.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxtLocalidad.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.TxtLocalidad.TabStop = True
		Me.TxtLocalidad.Visible = True
		Me.TxtLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TxtLocalidad.Name = "TxtLocalidad"
		Me.TxtObserv.AutoSize = False
		Me.TxtObserv.Size = New System.Drawing.Size(209, 41)
		Me.TxtObserv.Location = New System.Drawing.Point(96, 88)
		Me.TxtObserv.ReadOnly = True
		Me.TxtObserv.Maxlength = 50
		Me.TxtObserv.MultiLine = True
		Me.TxtObserv.TabIndex = 16
		Me.TxtObserv.AcceptsReturn = True
		Me.TxtObserv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.TxtObserv.BackColor = System.Drawing.SystemColors.Window
		Me.TxtObserv.CausesValidation = True
		Me.TxtObserv.Enabled = True
		Me.TxtObserv.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxtObserv.HideSelection = True
		Me.TxtObserv.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtObserv.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxtObserv.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.TxtObserv.TabStop = True
		Me.TxtObserv.Visible = True
		Me.TxtObserv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TxtObserv.Name = "TxtObserv"
		Me.TxtMemoria.AutoSize = False
		Me.TxtMemoria.Size = New System.Drawing.Size(121, 25)
		Me.TxtMemoria.Location = New System.Drawing.Point(96, 56)
		Me.TxtMemoria.ReadOnly = True
		Me.TxtMemoria.Maxlength = 2
		Me.TxtMemoria.TabIndex = 15
		Me.TxtMemoria.AcceptsReturn = True
		Me.TxtMemoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.TxtMemoria.BackColor = System.Drawing.SystemColors.Window
		Me.TxtMemoria.CausesValidation = True
		Me.TxtMemoria.Enabled = True
		Me.TxtMemoria.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxtMemoria.HideSelection = True
		Me.TxtMemoria.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtMemoria.MultiLine = False
		Me.TxtMemoria.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxtMemoria.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.TxtMemoria.TabStop = True
		Me.TxtMemoria.Visible = True
		Me.TxtMemoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TxtMemoria.Name = "TxtMemoria"
		Me.TxtBanda.Size = New System.Drawing.Size(81, 21)
		Me.TxtBanda.Location = New System.Drawing.Point(224, 176)
		Me.TxtBanda.Items.AddRange(New Object(){"2 m", "27 Mhz", "70 cm", "900 Mhz", "CB", "HF", "SHF", "UHF", "VHF"})
		Me.TxtBanda.Sorted = True
		Me.TxtBanda.TabIndex = 14
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
		Me.txtfecha.AutoSize = False
		Me.txtfecha.Size = New System.Drawing.Size(73, 25)
		Me.txtfecha.Location = New System.Drawing.Point(96, 136)
		Me.txtfecha.ReadOnly = True
		Me.txtfecha.TabIndex = 13
		Me.txtfecha.AcceptsReturn = True
		Me.txtfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtfecha.BackColor = System.Drawing.SystemColors.Window
		Me.txtfecha.CausesValidation = True
		Me.txtfecha.Enabled = True
		Me.txtfecha.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtfecha.HideSelection = True
		Me.txtfecha.Maxlength = 0
		Me.txtfecha.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtfecha.MultiLine = False
		Me.txtfecha.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtfecha.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtfecha.TabStop = True
		Me.txtfecha.Visible = True
		Me.txtfecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtfecha.Name = "txtfecha"
		Me.botrepet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botrepet.Text = "+ R -"
		Me.botrepet.Size = New System.Drawing.Size(81, 25)
		Me.botrepet.Location = New System.Drawing.Point(224, 24)
		Me.botrepet.TabIndex = 12
		Me.botrepet.BackColor = System.Drawing.SystemColors.Control
		Me.botrepet.CausesValidation = True
		Me.botrepet.Enabled = True
		Me.botrepet.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botrepet.Cursor = System.Windows.Forms.Cursors.Default
		Me.botrepet.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botrepet.TabStop = True
		Me.botrepet.Name = "botrepet"
		Me.chkcomprobado.Text = "Comprobada"
		Me.chkcomprobado.Size = New System.Drawing.Size(81, 25)
		Me.chkcomprobado.Location = New System.Drawing.Point(224, 136)
		Me.chkcomprobado.TabIndex = 11
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
		Me.Lbl1.Text = "Frecuencia  :"
		Me.Lbl1.Size = New System.Drawing.Size(65, 17)
		Me.Lbl1.Location = New System.Drawing.Point(24, 24)
		Me.Lbl1.TabIndex = 24
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
		Me.Lbl2.Text = "Memoria :"
		Me.Lbl2.Size = New System.Drawing.Size(49, 17)
		Me.Lbl2.Location = New System.Drawing.Point(40, 56)
		Me.Lbl2.TabIndex = 23
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
		Me.Label2.Text = "Observaciones :"
		Me.Label2.Size = New System.Drawing.Size(81, 17)
		Me.Label2.Location = New System.Drawing.Point(8, 88)
		Me.Label2.TabIndex = 22
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
		Me.Label3.Text = "Localidad :"
		Me.Label3.Size = New System.Drawing.Size(57, 17)
		Me.Label3.Location = New System.Drawing.Point(8, 176)
		Me.Label3.TabIndex = 21
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
		Me.Label1.Text = "Banda :"
		Me.Label1.Size = New System.Drawing.Size(41, 17)
		Me.Label1.Location = New System.Drawing.Point(184, 176)
		Me.Label1.TabIndex = 20
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
		Me.Label6.Text = "Fecha :"
		Me.Label6.Size = New System.Drawing.Size(41, 17)
		Me.Label6.Location = New System.Drawing.Point(48, 136)
		Me.Label6.TabIndex = 19
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
		Me.NumeroReg.Text = "Registros"
		Me.NumeroReg.Size = New System.Drawing.Size(185, 161)
		Me.NumeroReg.Location = New System.Drawing.Point(0, 0)
		Me.NumeroReg.TabIndex = 0
		Me.NumeroReg.BackColor = System.Drawing.SystemColors.Control
		Me.NumeroReg.Enabled = True
		Me.NumeroReg.ForeColor = System.Drawing.SystemColors.ControlText
		Me.NumeroReg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.NumeroReg.Visible = True
		Me.NumeroReg.Padding = New System.Windows.Forms.Padding(0)
		Me.NumeroReg.Name = "NumeroReg"
		Me.botvercomp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botvercomp.Text = ">"
		Me.botvercomp.Size = New System.Drawing.Size(17, 17)
		Me.botvercomp.Location = New System.Drawing.Point(112, 72)
		Me.botvercomp.TabIndex = 39
		Me.botvercomp.BackColor = System.Drawing.SystemColors.Control
		Me.botvercomp.CausesValidation = True
		Me.botvercomp.Enabled = True
		Me.botvercomp.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botvercomp.Cursor = System.Windows.Forms.Cursors.Default
		Me.botvercomp.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botvercomp.TabStop = True
		Me.botvercomp.Name = "botvercomp"
		Me._botselexporta_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._botselexporta_1.Text = "N"
		Me._botselexporta_1.Size = New System.Drawing.Size(17, 17)
		Me._botselexporta_1.Location = New System.Drawing.Point(136, 96)
		Me._botselexporta_1.TabIndex = 30
		Me._botselexporta_1.BackColor = System.Drawing.SystemColors.Control
		Me._botselexporta_1.CausesValidation = True
		Me._botselexporta_1.Enabled = True
		Me._botselexporta_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._botselexporta_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._botselexporta_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._botselexporta_1.TabStop = True
		Me._botselexporta_1.Name = "_botselexporta_1"
		Me._botselexporta_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._botselexporta_0.Text = "T"
		Me._botselexporta_0.Size = New System.Drawing.Size(17, 17)
		Me._botselexporta_0.Location = New System.Drawing.Point(112, 96)
		Me._botselexporta_0.TabIndex = 29
		Me._botselexporta_0.BackColor = System.Drawing.SystemColors.Control
		Me._botselexporta_0.CausesValidation = True
		Me._botselexporta_0.Enabled = True
		Me._botselexporta_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._botselexporta_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._botselexporta_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._botselexporta_0.TabStop = True
		Me._botselexporta_0.Name = "_botselexporta_0"
		Me.txtexportar.AutoSize = False
		Me.txtexportar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtexportar.BackColor = System.Drawing.SystemColors.Info
		Me.txtexportar.ForeColor = System.Drawing.Color.Blue
		Me.txtexportar.Size = New System.Drawing.Size(41, 19)
		Me.txtexportar.Location = New System.Drawing.Point(64, 96)
		Me.txtexportar.ReadOnly = True
		Me.txtexportar.TabIndex = 26
		Me.txtexportar.AcceptsReturn = True
		Me.txtexportar.CausesValidation = True
		Me.txtexportar.Enabled = True
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
		Me.RegActual.AutoSize = False
		Me.RegActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.RegActual.BackColor = System.Drawing.SystemColors.Info
		Me.RegActual.Size = New System.Drawing.Size(65, 19)
		Me.RegActual.Location = New System.Drawing.Point(64, 16)
		Me.RegActual.ReadOnly = True
		Me.RegActual.TabIndex = 5
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
		Me.RegTotal.AutoSize = False
		Me.RegTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.RegTotal.BackColor = System.Drawing.SystemColors.Info
		Me.RegTotal.ForeColor = System.Drawing.Color.Blue
		Me.RegTotal.Size = New System.Drawing.Size(65, 19)
		Me.RegTotal.Location = New System.Drawing.Point(64, 128)
		Me.RegTotal.ReadOnly = True
		Me.RegTotal.TabIndex = 4
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
		Me.txtira.AutoSize = False
		Me.txtira.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtira.Size = New System.Drawing.Size(41, 17)
		Me.txtira.Location = New System.Drawing.Point(64, 40)
		Me.txtira.Maxlength = 5
		Me.txtira.TabIndex = 3
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
		Me.botir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botir.Text = ">"
		Me.botir.Enabled = False
		Me.botir.Size = New System.Drawing.Size(17, 17)
		Me.botir.Location = New System.Drawing.Point(112, 40)
		Me.botir.TabIndex = 2
		Me.botir.BackColor = System.Drawing.SystemColors.Control
		Me.botir.CausesValidation = True
		Me.botir.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botir.Cursor = System.Windows.Forms.Cursors.Default
		Me.botir.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botir.TabStop = True
		Me.botir.Name = "botir"
		Me.txtComprobado.AutoSize = False
		Me.txtComprobado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtComprobado.BackColor = System.Drawing.SystemColors.Info
		Me.txtComprobado.ForeColor = System.Drawing.Color.Blue
		Me.txtComprobado.Size = New System.Drawing.Size(41, 19)
		Me.txtComprobado.Location = New System.Drawing.Point(64, 72)
		Me.txtComprobado.ReadOnly = True
		Me.txtComprobado.TabIndex = 1
		Me.txtComprobado.AcceptsReturn = True
		Me.txtComprobado.CausesValidation = True
		Me.txtComprobado.Enabled = True
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
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label9.Text = "Export"
		Me.Label9.Size = New System.Drawing.Size(31, 13)
		Me.Label9.Location = New System.Drawing.Point(24, 96)
		Me.Label9.TabIndex = 27
		Me.Label9.BackColor = System.Drawing.SystemColors.Control
		Me.Label9.Enabled = True
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.Visible = True
		Me.Label9.AutoSize = True
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me.Label4.Text = "Numero:"
		Me.Label4.Size = New System.Drawing.Size(41, 17)
		Me.Label4.Location = New System.Drawing.Point(24, 16)
		Me.Label4.TabIndex = 9
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
		Me.Label5.Text = "Total :"
		Me.Label5.Size = New System.Drawing.Size(33, 17)
		Me.Label5.Location = New System.Drawing.Point(24, 128)
		Me.Label5.TabIndex = 8
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
		Me.Label7.Text = "Ir a :"
		Me.Label7.Size = New System.Drawing.Size(25, 17)
		Me.Label7.Location = New System.Drawing.Point(40, 40)
		Me.Label7.TabIndex = 7
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
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label8.Text = "Compr"
		Me.Label8.Size = New System.Drawing.Size(31, 13)
		Me.Label8.Location = New System.Drawing.Point(24, 72)
		Me.Label8.TabIndex = 6
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.Enabled = True
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = True
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me.dialogoSave.DefaultExt = "RGF"
		Me.dialogoSave.FileName = "Frecuencias.rgf"
		Me.dialogoSave.Filter = "LOG | *.log ; Registro | *.rgf"
		Me.dialogoSave.FilterIndex = 2
		Me.dialogoSave.InitialDirectory = "C:\"
		Me.Label10.Text = "Actualizando Datos"
		Me.Label10.Size = New System.Drawing.Size(223, 29)
		Me.Label10.Location = New System.Drawing.Point(240, 96)
		Me.Label10.TabIndex = 38
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label10.BackColor = System.Drawing.SystemColors.Control
		Me.Label10.Enabled = True
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.UseMnemonic = True
		Me.Label10.Visible = True
		Me.Label10.AutoSize = True
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label10.Name = "Label10"
		Me.Controls.Add(PB)
		Me.Controls.Add(BD)
		Me.Controls.Add(botgenerar)
		Me.Controls.Add(fraexportar)
		Me.Controls.Add(Registro)
		Me.Controls.Add(NumeroReg)
		Me.Controls.Add(Label10)
		Me.fraexportar.Controls.Add(fraseleccion)
		Me.fraexportar.Controls.Add(optseleccionar)
		Me.fraexportar.Controls.Add(opttodos)
		Me.fraseleccion.Controls.Add(chkexport)
		Me.fraseleccion.Controls.Add(chkcomprob)
		Me.Registro.Controls.Add(botmem)
		Me.Registro.Controls.Add(chkexportar)
		Me.Registro.Controls.Add(txtFrecuencia)
		Me.Registro.Controls.Add(TxtLocalidad)
		Me.Registro.Controls.Add(TxtObserv)
		Me.Registro.Controls.Add(TxtMemoria)
		Me.Registro.Controls.Add(TxtBanda)
		Me.Registro.Controls.Add(txtfecha)
		Me.Registro.Controls.Add(botrepet)
		Me.Registro.Controls.Add(chkcomprobado)
		Me.Registro.Controls.Add(Lbl1)
		Me.Registro.Controls.Add(Lbl2)
		Me.Registro.Controls.Add(Label2)
		Me.Registro.Controls.Add(Label3)
		Me.Registro.Controls.Add(Label1)
		Me.Registro.Controls.Add(Label6)
		Me.NumeroReg.Controls.Add(botvercomp)
		Me.NumeroReg.Controls.Add(_botselexporta_1)
		Me.NumeroReg.Controls.Add(_botselexporta_0)
		Me.NumeroReg.Controls.Add(txtexportar)
		Me.NumeroReg.Controls.Add(RegActual)
		Me.NumeroReg.Controls.Add(RegTotal)
		Me.NumeroReg.Controls.Add(txtira)
		Me.NumeroReg.Controls.Add(botir)
		Me.NumeroReg.Controls.Add(txtComprobado)
		Me.NumeroReg.Controls.Add(Label9)
		Me.NumeroReg.Controls.Add(Label4)
		Me.NumeroReg.Controls.Add(Label5)
		Me.NumeroReg.Controls.Add(Label7)
		Me.NumeroReg.Controls.Add(Label8)
		Me.botselexporta.SetIndex(_botselexporta_1, CType(1, Short))
		Me.botselexporta.SetIndex(_botselexporta_0, CType(0, Short))
		CType(Me.botselexporta, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PB, System.ComponentModel.ISupportInitialize).EndInit()
		Me.fraexportar.ResumeLayout(False)
		Me.fraseleccion.ResumeLayout(False)
		Me.Registro.ResumeLayout(False)
		Me.NumeroReg.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class