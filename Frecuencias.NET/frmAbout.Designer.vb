<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAbout
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
	Public WithEvents picIcon As System.Windows.Forms.PictureBox
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents cmdSysInfo As System.Windows.Forms.Button
	Public WithEvents foto As System.Windows.Forms.PictureBox
	Public WithEvents _Line1_1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents lblDescription As System.Windows.Forms.Label
	Public WithEvents lblTitle As System.Windows.Forms.Label
	Public WithEvents _Line1_0 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents lblVersion As System.Windows.Forms.Label
	Public WithEvents lblDisclaimer As System.Windows.Forms.Label
	Public WithEvents Line1 As LineShapeArray
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAbout))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.picIcon = New System.Windows.Forms.PictureBox
		Me.cmdOK = New System.Windows.Forms.Button
		Me.cmdSysInfo = New System.Windows.Forms.Button
		Me.foto = New System.Windows.Forms.PictureBox
		Me._Line1_1 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.lblDescription = New System.Windows.Forms.Label
		Me.lblTitle = New System.Windows.Forms.Label
		Me._Line1_0 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.lblVersion = New System.Windows.Forms.Label
		Me.lblDisclaimer = New System.Windows.Forms.Label
		Me.Line1 = New LineShapeArray(components)
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.Line1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.Text = "Acerca de Gestor Frecuencias by MiguelDJ"
		Me.ClientSize = New System.Drawing.Size(396, 237)
		Me.Location = New System.Drawing.Point(156, 129)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmAbout"
		Me.picIcon.Size = New System.Drawing.Size(36, 36)
		Me.picIcon.Location = New System.Drawing.Point(16, 16)
		Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
		Me.picIcon.TabIndex = 1
		Me.picIcon.Dock = System.Windows.Forms.DockStyle.None
		Me.picIcon.BackColor = System.Drawing.SystemColors.Control
		Me.picIcon.CausesValidation = True
		Me.picIcon.Enabled = True
		Me.picIcon.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picIcon.Cursor = System.Windows.Forms.Cursors.Default
		Me.picIcon.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picIcon.TabStop = True
		Me.picIcon.Visible = True
		Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.picIcon.Name = "picIcon"
		Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CancelButton = Me.cmdOK
		Me.cmdOK.Text = "Aceptar"
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.Size = New System.Drawing.Size(100, 23)
		Me.cmdOK.Location = New System.Drawing.Point(288, 175)
		Me.cmdOK.TabIndex = 0
		Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOK.CausesValidation = True
		Me.cmdOK.Enabled = True
		Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOK.TabStop = True
		Me.cmdOK.Name = "cmdOK"
		Me.cmdSysInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSysInfo.Text = "&Info. del sistema..."
		Me.cmdSysInfo.Size = New System.Drawing.Size(99, 23)
		Me.cmdSysInfo.Location = New System.Drawing.Point(288, 205)
		Me.cmdSysInfo.TabIndex = 2
		Me.cmdSysInfo.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSysInfo.CausesValidation = True
		Me.cmdSysInfo.Enabled = True
		Me.cmdSysInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSysInfo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSysInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSysInfo.TabStop = True
		Me.cmdSysInfo.Name = "cmdSysInfo"
		Me.foto.Size = New System.Drawing.Size(94, 104)
		Me.foto.Location = New System.Drawing.Point(288, 48)
		Me.foto.Image = CType(resources.GetObject("foto.Image"), System.Drawing.Image)
		Me.foto.Enabled = True
		Me.foto.Cursor = System.Windows.Forms.Cursors.Default
		Me.foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal
		Me.foto.Visible = True
		Me.foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.foto.Name = "foto"
		Me._Line1_1.BorderColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me._Line1_1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._Line1_1.X1 = 6
		Me._Line1_1.X2 = 354
		Me._Line1_1.Y1 = 113
		Me._Line1_1.Y2 = 113
		Me._Line1_1.BorderWidth = 1
		Me._Line1_1.Visible = True
		Me._Line1_1.Name = "_Line1_1"
		Me.lblDescription.Text = "Programa para gestionar las frecuencias de radio. Tiene un buscador incluido y se pueden exportar e importar desde un txt como copia de seguridad (beta)."
		Me.lblDescription.ForeColor = System.Drawing.Color.Black
		Me.lblDescription.Size = New System.Drawing.Size(211, 78)
		Me.lblDescription.Location = New System.Drawing.Point(64, 75)
		Me.lblDescription.TabIndex = 3
		Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDescription.BackColor = System.Drawing.SystemColors.Control
		Me.lblDescription.Enabled = True
		Me.lblDescription.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDescription.UseMnemonic = True
		Me.lblDescription.Visible = True
		Me.lblDescription.AutoSize = False
		Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDescription.Name = "lblDescription"
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblTitle.Text = "Gestor de Frecuencias"
		Me.lblTitle.ForeColor = System.Drawing.Color.Black
		Me.lblTitle.Size = New System.Drawing.Size(259, 24)
		Me.lblTitle.Location = New System.Drawing.Point(70, 16)
		Me.lblTitle.TabIndex = 5
		Me.lblTitle.BackColor = System.Drawing.SystemColors.Control
		Me.lblTitle.Enabled = True
		Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTitle.UseMnemonic = True
		Me.lblTitle.Visible = True
		Me.lblTitle.AutoSize = False
		Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblTitle.Name = "lblTitle"
		Me._Line1_0.BorderColor = System.Drawing.Color.White
		Me._Line1_0.BorderWidth = 2
		Me._Line1_0.X1 = 7
		Me._Line1_0.X2 = 354
		Me._Line1_0.Y1 = 114
		Me._Line1_0.Y2 = 114
		Me._Line1_0.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me._Line1_0.Visible = True
		Me._Line1_0.Name = "_Line1_0"
		Me.lblVersion.Text = "Versión 1.3 beta"
		Me.lblVersion.Size = New System.Drawing.Size(211, 15)
		Me.lblVersion.Location = New System.Drawing.Point(70, 52)
		Me.lblVersion.TabIndex = 6
		Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblVersion.BackColor = System.Drawing.SystemColors.Control
		Me.lblVersion.Enabled = True
		Me.lblVersion.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblVersion.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblVersion.UseMnemonic = True
		Me.lblVersion.Visible = True
		Me.lblVersion.AutoSize = False
		Me.lblVersion.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblVersion.Name = "lblVersion"
		Me.lblDisclaimer.Text = "Advertencia: Este programa esta 100% libre de virus. Funciona bajo XP. Si este programa no lo has obtenido de la web (www.migueldj.org) no me hago cargo de posibles daños a tu equipo. Mi mail es software@migueldj.org"
		Me.lblDisclaimer.ForeColor = System.Drawing.Color.Black
		Me.lblDisclaimer.Size = New System.Drawing.Size(258, 71)
		Me.lblDisclaimer.Location = New System.Drawing.Point(16, 167)
		Me.lblDisclaimer.TabIndex = 4
		Me.lblDisclaimer.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblDisclaimer.BackColor = System.Drawing.SystemColors.Control
		Me.lblDisclaimer.Enabled = True
		Me.lblDisclaimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDisclaimer.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDisclaimer.UseMnemonic = True
		Me.lblDisclaimer.Visible = True
		Me.lblDisclaimer.AutoSize = False
		Me.lblDisclaimer.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDisclaimer.Name = "lblDisclaimer"
		Me.Controls.Add(picIcon)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(cmdSysInfo)
		Me.Controls.Add(foto)
		Me.ShapeContainer1.Shapes.Add(_Line1_1)
		Me.Controls.Add(lblDescription)
		Me.Controls.Add(lblTitle)
		Me.ShapeContainer1.Shapes.Add(_Line1_0)
		Me.Controls.Add(lblVersion)
		Me.Controls.Add(lblDisclaimer)
		Me.Controls.Add(ShapeContainer1)
		Me.Line1.SetIndex(_Line1_1, CType(1, Short))
		Me.Line1.SetIndex(_Line1_0, CType(0, Short))
		CType(Me.Line1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class