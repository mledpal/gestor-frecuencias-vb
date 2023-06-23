<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmimportar
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
	Public WithEvents PB As AxComctlLib.AxProgressBar
	Public WithEvents opttodos As System.Windows.Forms.RadioButton
	Public WithEvents optseleccionar As System.Windows.Forms.RadioButton
	Public WithEvents chkcomprob As System.Windows.Forms.CheckBox
	Public WithEvents chkexport As System.Windows.Forms.CheckBox
	Public WithEvents fraseleccion As System.Windows.Forms.GroupBox
	Public WithEvents fraexportar As System.Windows.Forms.GroupBox
	Public WithEvents botimportar As System.Windows.Forms.Button
	Public dialogoOpen As System.Windows.Forms.OpenFileDialog
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmimportar))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.bd = New System.Windows.Forms.Label
		Me.PB = New AxComctlLib.AxProgressBar
		Me.fraexportar = New System.Windows.Forms.GroupBox
		Me.opttodos = New System.Windows.Forms.RadioButton
		Me.optseleccionar = New System.Windows.Forms.RadioButton
		Me.fraseleccion = New System.Windows.Forms.GroupBox
		Me.chkcomprob = New System.Windows.Forms.CheckBox
		Me.chkexport = New System.Windows.Forms.CheckBox
		Me.botimportar = New System.Windows.Forms.Button
		Me.dialogoOpen = New System.Windows.Forms.OpenFileDialog
		Me.fraexportar.SuspendLayout()
		Me.fraseleccion.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.PB, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Text = "Añadir  Registros"
		Me.ClientSize = New System.Drawing.Size(211, 147)
		Me.Location = New System.Drawing.Point(4, 23)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
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
		Me.Name = "frmimportar"
		Me.bd.Text = "BD"
		Me.bd.Size = New System.Drawing.Size(76, 20)
		Me.bd.Location = New System.Drawing.Point(0, 128)
		Me.bd.Visible = False
		Me.bd.BackColor = System.Drawing.Color.Red
		Me.bd.ForeColor = System.Drawing.Color.Black
		Me.bd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bd.Text = "bd"
		Me.bd.Name = "bd"
		PB.OcxState = CType(resources.GetObject("PB.OcxState"), System.Windows.Forms.AxHost.State)
		Me.PB.Size = New System.Drawing.Size(17, 65)
		Me.PB.Location = New System.Drawing.Point(184, 16)
		Me.PB.TabIndex = 7
		Me.PB.Name = "PB"
		Me.fraexportar.Text = "Importar . . ."
		Me.fraexportar.Size = New System.Drawing.Size(185, 113)
		Me.fraexportar.Location = New System.Drawing.Point(0, 0)
		Me.fraexportar.TabIndex = 1
		Me.fraexportar.BackColor = System.Drawing.SystemColors.Control
		Me.fraexportar.Enabled = True
		Me.fraexportar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraexportar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraexportar.Visible = True
		Me.fraexportar.Padding = New System.Windows.Forms.Padding(0)
		Me.fraexportar.Name = "fraexportar"
		Me.opttodos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.opttodos.Text = "Todos"
		Me.opttodos.Size = New System.Drawing.Size(57, 25)
		Me.opttodos.Location = New System.Drawing.Point(8, 16)
		Me.opttodos.Appearance = System.Windows.Forms.Appearance.Button
		Me.opttodos.TabIndex = 6
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
		Me.optseleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.optseleccionar.Text = "Seleccionados"
		Me.optseleccionar.Size = New System.Drawing.Size(97, 25)
		Me.optseleccionar.Location = New System.Drawing.Point(80, 16)
		Me.optseleccionar.Appearance = System.Windows.Forms.Appearance.Button
		Me.optseleccionar.TabIndex = 5
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
		Me.fraseleccion.Text = "Seleccionar"
		Me.fraseleccion.Size = New System.Drawing.Size(169, 57)
		Me.fraseleccion.Location = New System.Drawing.Point(8, 48)
		Me.fraseleccion.TabIndex = 2
		Me.fraseleccion.BackColor = System.Drawing.SystemColors.Control
		Me.fraseleccion.Enabled = True
		Me.fraseleccion.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fraseleccion.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.fraseleccion.Visible = True
		Me.fraseleccion.Padding = New System.Windows.Forms.Padding(0)
		Me.fraseleccion.Name = "fraseleccion"
		Me.chkcomprob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.chkcomprob.Text = "Comprobado"
		Me.chkcomprob.Enabled = False
		Me.chkcomprob.Size = New System.Drawing.Size(81, 25)
		Me.chkcomprob.Location = New System.Drawing.Point(8, 24)
		Me.chkcomprob.Appearance = System.Windows.Forms.Appearance.Button
		Me.chkcomprob.TabIndex = 4
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
		Me.chkexport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.chkexport.Text = "Exportar"
		Me.chkexport.Enabled = False
		Me.chkexport.Size = New System.Drawing.Size(65, 25)
		Me.chkexport.Location = New System.Drawing.Point(96, 24)
		Me.chkexport.Appearance = System.Windows.Forms.Appearance.Button
		Me.chkexport.TabIndex = 3
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
		Me.botimportar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botimportar.Text = "IMPORTAR TXT"
		Me.botimportar.Size = New System.Drawing.Size(177, 25)
		Me.botimportar.Location = New System.Drawing.Point(8, 120)
		Me.botimportar.TabIndex = 0
		Me.botimportar.BackColor = System.Drawing.SystemColors.Control
		Me.botimportar.CausesValidation = True
		Me.botimportar.Enabled = True
		Me.botimportar.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botimportar.Cursor = System.Windows.Forms.Cursors.Default
		Me.botimportar.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botimportar.TabStop = True
		Me.botimportar.Name = "botimportar"
		Me.dialogoOpen.DefaultExt = "RGF"
		Me.dialogoOpen.FileName = "Frecuencias.RGF"
		Me.dialogoOpen.Filter = " Registro | *.log ; Registro Gestor | *.RGF"
		Me.dialogoOpen.FilterIndex = 2
		Me.dialogoOpen.InitialDirectory = "C:\"
		Me.Controls.Add(bd)
		Me.Controls.Add(PB)
		Me.Controls.Add(fraexportar)
		Me.Controls.Add(botimportar)
		Me.fraexportar.Controls.Add(opttodos)
		Me.fraexportar.Controls.Add(optseleccionar)
		Me.fraexportar.Controls.Add(fraseleccion)
		Me.fraseleccion.Controls.Add(chkcomprob)
		Me.fraseleccion.Controls.Add(chkexport)
		CType(Me.PB, System.ComponentModel.ISupportInitialize).EndInit()
		Me.fraexportar.ResumeLayout(False)
		Me.fraseleccion.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class