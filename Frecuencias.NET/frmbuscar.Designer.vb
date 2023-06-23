<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmbuscar
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
	Public WithEvents txtobservaciones As System.Windows.Forms.TextBox
	Public WithEvents chklocalidad As System.Windows.Forms.CheckBox
	Public WithEvents chkmemoria As System.Windows.Forms.CheckBox
	Public WithEvents BD As System.Windows.Forms.Label
	Public WithEvents txtfecha As System.Windows.Forms.TextBox
	Public WithEvents botbusca As System.Windows.Forms.Button
	Public WithEvents txtFrecuencia As System.Windows.Forms.TextBox
	Public WithEvents TxtLocalidad As System.Windows.Forms.TextBox
	Public WithEvents TxtMemoria As System.Windows.Forms.TextBox
	Public WithEvents TxtBanda As System.Windows.Forms.ComboBox
	Public WithEvents chkobservaciones As System.Windows.Forms.CheckBox
	Public WithEvents chkcomprobado As System.Windows.Forms.CheckBox
	Public WithEvents chkBanda As System.Windows.Forms.CheckBox
	Public WithEvents chkfecha As System.Windows.Forms.CheckBox
	Public WithEvents chkFrecuencia As System.Windows.Forms.CheckBox
	Public WithEvents Opciones As System.Windows.Forms.GroupBox
	Public WithEvents Label As System.Windows.Forms.Label
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmbuscar))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.txtobservaciones = New System.Windows.Forms.TextBox
		Me.chklocalidad = New System.Windows.Forms.CheckBox
		Me.chkmemoria = New System.Windows.Forms.CheckBox
		Me.BD = New System.Windows.Forms.Label
		Me.txtfecha = New System.Windows.Forms.TextBox
		Me.botbusca = New System.Windows.Forms.Button
		Me.txtFrecuencia = New System.Windows.Forms.TextBox
		Me.TxtLocalidad = New System.Windows.Forms.TextBox
		Me.TxtMemoria = New System.Windows.Forms.TextBox
		Me.TxtBanda = New System.Windows.Forms.ComboBox
		Me.Opciones = New System.Windows.Forms.GroupBox
		Me.chkobservaciones = New System.Windows.Forms.CheckBox
		Me.chkcomprobado = New System.Windows.Forms.CheckBox
		Me.chkBanda = New System.Windows.Forms.CheckBox
		Me.chkfecha = New System.Windows.Forms.CheckBox
		Me.chkFrecuencia = New System.Windows.Forms.CheckBox
		Me.Label = New System.Windows.Forms.Label
		Me.Opciones.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Busqueda"
		Me.ClientSize = New System.Drawing.Size(283, 253)
		Me.Location = New System.Drawing.Point(3, 22)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmbuscar"
		Me.txtobservaciones.AutoSize = False
		Me.txtobservaciones.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtobservaciones.Size = New System.Drawing.Size(121, 27)
		Me.txtobservaciones.Location = New System.Drawing.Point(144, 152)
		Me.txtobservaciones.TabIndex = 15
		Me.txtobservaciones.AcceptsReturn = True
		Me.txtobservaciones.BackColor = System.Drawing.SystemColors.Window
		Me.txtobservaciones.CausesValidation = True
		Me.txtobservaciones.Enabled = True
		Me.txtobservaciones.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtobservaciones.HideSelection = True
		Me.txtobservaciones.ReadOnly = False
		Me.txtobservaciones.Maxlength = 0
		Me.txtobservaciones.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtobservaciones.MultiLine = False
		Me.txtobservaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtobservaciones.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtobservaciones.TabStop = True
		Me.txtobservaciones.Visible = True
		Me.txtobservaciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtobservaciones.Name = "txtobservaciones"
		Me.chklocalidad.Text = "Localidad"
		Me.chklocalidad.Size = New System.Drawing.Size(97, 17)
		Me.chklocalidad.Location = New System.Drawing.Point(16, 88)
		Me.chklocalidad.TabIndex = 8
		Me.chklocalidad.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chklocalidad.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chklocalidad.BackColor = System.Drawing.SystemColors.Control
		Me.chklocalidad.CausesValidation = True
		Me.chklocalidad.Enabled = True
		Me.chklocalidad.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chklocalidad.Cursor = System.Windows.Forms.Cursors.Default
		Me.chklocalidad.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chklocalidad.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chklocalidad.TabStop = True
		Me.chklocalidad.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chklocalidad.Visible = True
		Me.chklocalidad.Name = "chklocalidad"
		Me.chkmemoria.Text = "Memoria"
		Me.chkmemoria.Size = New System.Drawing.Size(97, 17)
		Me.chkmemoria.Location = New System.Drawing.Point(16, 56)
		Me.chkmemoria.TabIndex = 7
		Me.chkmemoria.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkmemoria.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkmemoria.BackColor = System.Drawing.SystemColors.Control
		Me.chkmemoria.CausesValidation = True
		Me.chkmemoria.Enabled = True
		Me.chkmemoria.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkmemoria.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkmemoria.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkmemoria.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkmemoria.TabStop = True
		Me.chkmemoria.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkmemoria.Visible = True
		Me.chkmemoria.Name = "chkmemoria"
		Me.BD.Text = "Frecuencias"
		Me.BD.Size = New System.Drawing.Size(283, 25)
		Me.BD.Location = New System.Drawing.Point(0, 228)
		Me.BD.Visible = False
		Me.BD.BackColor = System.Drawing.Color.Red
		Me.BD.ForeColor = System.Drawing.Color.Black
		Me.BD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.BD.Text = "BD"
		Me.BD.Name = "BD"
		Me.txtfecha.AutoSize = False
		Me.txtfecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtfecha.Size = New System.Drawing.Size(121, 27)
		Me.txtfecha.Location = New System.Drawing.Point(144, 120)
		Me.txtfecha.TabIndex = 4
		Me.txtfecha.AcceptsReturn = True
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
		Me.botbusca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botbusca.Text = "Ejecutar Busqueda"
		Me.AcceptButton = Me.botbusca
		Me.botbusca.Size = New System.Drawing.Size(129, 33)
		Me.botbusca.Location = New System.Drawing.Point(144, 216)
		Me.botbusca.TabIndex = 11
		Me.botbusca.BackColor = System.Drawing.SystemColors.Control
		Me.botbusca.CausesValidation = True
		Me.botbusca.Enabled = True
		Me.botbusca.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botbusca.Cursor = System.Windows.Forms.Cursors.Default
		Me.botbusca.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botbusca.TabStop = True
		Me.botbusca.Name = "botbusca"
		Me.txtFrecuencia.AutoSize = False
		Me.txtFrecuencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtFrecuencia.Size = New System.Drawing.Size(121, 27)
		Me.txtFrecuencia.Location = New System.Drawing.Point(144, 24)
		Me.txtFrecuencia.Maxlength = 8
		Me.txtFrecuencia.TabIndex = 1
		Me.txtFrecuencia.AcceptsReturn = True
		Me.txtFrecuencia.BackColor = System.Drawing.SystemColors.Window
		Me.txtFrecuencia.CausesValidation = True
		Me.txtFrecuencia.Enabled = True
		Me.txtFrecuencia.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtFrecuencia.HideSelection = True
		Me.txtFrecuencia.ReadOnly = False
		Me.txtFrecuencia.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtFrecuencia.MultiLine = False
		Me.txtFrecuencia.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtFrecuencia.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtFrecuencia.TabStop = True
		Me.txtFrecuencia.Visible = True
		Me.txtFrecuencia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtFrecuencia.Name = "txtFrecuencia"
		Me.TxtLocalidad.AutoSize = False
		Me.TxtLocalidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.TxtLocalidad.Size = New System.Drawing.Size(121, 27)
		Me.TxtLocalidad.Location = New System.Drawing.Point(144, 88)
		Me.TxtLocalidad.TabIndex = 3
		Me.TxtLocalidad.AcceptsReturn = True
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
		Me.TxtMemoria.AutoSize = False
		Me.TxtMemoria.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.TxtMemoria.Size = New System.Drawing.Size(121, 25)
		Me.TxtMemoria.Location = New System.Drawing.Point(144, 56)
		Me.TxtMemoria.Maxlength = 2
		Me.TxtMemoria.TabIndex = 2
		Me.TxtMemoria.AcceptsReturn = True
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
		Me.TxtBanda.Size = New System.Drawing.Size(121, 21)
		Me.TxtBanda.IntegralHeight = False
		Me.TxtBanda.Location = New System.Drawing.Point(144, 184)
		Me.TxtBanda.Items.AddRange(New Object(){"2 m", "27 Mhz", "70 cm", "900 Mhz", "CB", "HF", "SHF", "UHF", "VHF"})
		Me.TxtBanda.Sorted = True
		Me.TxtBanda.TabIndex = 5
		Me.TxtBanda.BackColor = System.Drawing.SystemColors.Window
		Me.TxtBanda.CausesValidation = True
		Me.TxtBanda.Enabled = True
		Me.TxtBanda.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxtBanda.Cursor = System.Windows.Forms.Cursors.Default
		Me.TxtBanda.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxtBanda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.TxtBanda.TabStop = True
		Me.TxtBanda.Visible = True
		Me.TxtBanda.Name = "TxtBanda"
		Me.Opciones.Text = "Buscar por . . ."
		Me.Opciones.Size = New System.Drawing.Size(129, 249)
		Me.Opciones.Location = New System.Drawing.Point(8, 0)
		Me.Opciones.TabIndex = 0
		Me.Opciones.BackColor = System.Drawing.SystemColors.Control
		Me.Opciones.Enabled = True
		Me.Opciones.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Opciones.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Opciones.Visible = True
		Me.Opciones.Padding = New System.Windows.Forms.Padding(0)
		Me.Opciones.Name = "Opciones"
		Me.chkobservaciones.Text = "Observaciones"
		Me.chkobservaciones.Size = New System.Drawing.Size(97, 25)
		Me.chkobservaciones.Location = New System.Drawing.Point(8, 152)
		Me.chkobservaciones.TabIndex = 14
		Me.chkobservaciones.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkobservaciones.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkobservaciones.BackColor = System.Drawing.SystemColors.Control
		Me.chkobservaciones.CausesValidation = True
		Me.chkobservaciones.Enabled = True
		Me.chkobservaciones.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkobservaciones.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkobservaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkobservaciones.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkobservaciones.TabStop = True
		Me.chkobservaciones.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkobservaciones.Visible = True
		Me.chkobservaciones.Name = "chkobservaciones"
		Me.chkcomprobado.Text = "Comprobado"
		Me.chkcomprobado.Size = New System.Drawing.Size(97, 17)
		Me.chkcomprobado.Location = New System.Drawing.Point(8, 224)
		Me.chkcomprobado.TabIndex = 13
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
		Me.chkBanda.Text = "Banda"
		Me.chkBanda.Size = New System.Drawing.Size(97, 17)
		Me.chkBanda.Location = New System.Drawing.Point(8, 192)
		Me.chkBanda.TabIndex = 10
		Me.chkBanda.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkBanda.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkBanda.BackColor = System.Drawing.SystemColors.Control
		Me.chkBanda.CausesValidation = True
		Me.chkBanda.Enabled = True
		Me.chkBanda.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkBanda.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkBanda.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkBanda.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkBanda.TabStop = True
		Me.chkBanda.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkBanda.Visible = True
		Me.chkBanda.Name = "chkBanda"
		Me.chkfecha.Text = "Fecha"
		Me.chkfecha.Size = New System.Drawing.Size(97, 17)
		Me.chkfecha.Location = New System.Drawing.Point(8, 120)
		Me.chkfecha.TabIndex = 9
		Me.chkfecha.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkfecha.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkfecha.BackColor = System.Drawing.SystemColors.Control
		Me.chkfecha.CausesValidation = True
		Me.chkfecha.Enabled = True
		Me.chkfecha.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkfecha.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkfecha.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkfecha.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkfecha.TabStop = True
		Me.chkfecha.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkfecha.Visible = True
		Me.chkfecha.Name = "chkfecha"
		Me.chkFrecuencia.Text = "Frecuencia"
		Me.chkFrecuencia.Size = New System.Drawing.Size(97, 17)
		Me.chkFrecuencia.Location = New System.Drawing.Point(8, 24)
		Me.chkFrecuencia.TabIndex = 6
		Me.chkFrecuencia.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chkFrecuencia.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkFrecuencia.BackColor = System.Drawing.SystemColors.Control
		Me.chkFrecuencia.CausesValidation = True
		Me.chkFrecuencia.Enabled = True
		Me.chkFrecuencia.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chkFrecuencia.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkFrecuencia.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chkFrecuencia.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkFrecuencia.TabStop = True
		Me.chkFrecuencia.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.chkFrecuencia.Visible = True
		Me.chkFrecuencia.Name = "chkFrecuencia"
		Me.Label.Size = New System.Drawing.Size(3, 13)
		Me.Label.Location = New System.Drawing.Point(8, 192)
		Me.Label.TabIndex = 12
		Me.Label.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label.BackColor = System.Drawing.SystemColors.Control
		Me.Label.Enabled = True
		Me.Label.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label.UseMnemonic = True
		Me.Label.Visible = True
		Me.Label.AutoSize = True
		Me.Label.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label.Name = "Label"
		Me.Controls.Add(txtobservaciones)
		Me.Controls.Add(chklocalidad)
		Me.Controls.Add(chkmemoria)
		Me.Controls.Add(BD)
		Me.Controls.Add(txtfecha)
		Me.Controls.Add(botbusca)
		Me.Controls.Add(txtFrecuencia)
		Me.Controls.Add(TxtLocalidad)
		Me.Controls.Add(TxtMemoria)
		Me.Controls.Add(TxtBanda)
		Me.Controls.Add(Opciones)
		Me.Controls.Add(Label)
		Me.Opciones.Controls.Add(chkobservaciones)
		Me.Opciones.Controls.Add(chkcomprobado)
		Me.Opciones.Controls.Add(chkBanda)
		Me.Opciones.Controls.Add(chkfecha)
		Me.Opciones.Controls.Add(chkFrecuencia)
		Me.Opciones.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class