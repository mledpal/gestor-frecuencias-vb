<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frminicio
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
	Public WithEvents Timer_Renamed As System.Windows.Forms.Timer
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents lblversion As System.Windows.Forms.Label
	Public WithEvents image As System.Windows.Forms.Panel
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frminicio))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.image = New System.Windows.Forms.Panel
		Me.Timer_Renamed = New System.Windows.Forms.Timer(components)
		Me.Label1 = New System.Windows.Forms.Label
		Me.lblversion = New System.Windows.Forms.Label
		Me.image.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Text = "Gestor de Frecuencias"
		Me.ClientSize = New System.Drawing.Size(404, 301)
		Me.Location = New System.Drawing.Point(0, 0)
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frminicio"
		Me.image.Size = New System.Drawing.Size(404, 304)
		Me.image.Location = New System.Drawing.Point(0, 0)
		Me.image.BackgroundImage = CType(resources.GetObject("image.BackgroundImage"), System.Drawing.Image)
		Me.image.TabIndex = 0
		Me.image.Dock = System.Windows.Forms.DockStyle.None
		Me.image.BackColor = System.Drawing.SystemColors.Control
		Me.image.CausesValidation = True
		Me.image.Enabled = True
		Me.image.ForeColor = System.Drawing.SystemColors.ControlText
		Me.image.Cursor = System.Windows.Forms.Cursors.Default
		Me.image.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.image.TabStop = True
		Me.image.Visible = True
		Me.image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.image.Name = "image"
		Me.Timer_Renamed.Interval = 1000
		Me.Timer_Renamed.Enabled = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Text = "CYBERNETICA 2006"
		Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Size = New System.Drawing.Size(131, 19)
		Me.Label1.Location = New System.Drawing.Point(16, 168)
		Me.Label1.TabIndex = 2
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = True
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.lblversion.BackColor = System.Drawing.Color.Blue
		Me.lblversion.ForeColor = System.Drawing.Color.Yellow
		Me.lblversion.Size = New System.Drawing.Size(69, 13)
		Me.lblversion.Location = New System.Drawing.Point(0, 0)
		Me.lblversion.TabIndex = 1
		Me.lblversion.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblversion.Enabled = True
		Me.lblversion.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblversion.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblversion.UseMnemonic = True
		Me.lblversion.Visible = True
		Me.lblversion.AutoSize = False
		Me.lblversion.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblversion.Name = "lblversion"
		Me.Controls.Add(image)
		Me.image.Controls.Add(Label1)
		Me.image.Controls.Add(lblversion)
		Me.image.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class