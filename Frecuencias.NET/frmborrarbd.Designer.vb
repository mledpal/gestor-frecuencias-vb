<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmborrarbd
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
	Public WithEvents txtllave3 As System.Windows.Forms.TextBox
	Public WithEvents botgenera As System.Windows.Forms.Button
	Public WithEvents botcancela As System.Windows.Forms.Button
	Public WithEvents botseguir As System.Windows.Forms.Button
	Public WithEvents txtllave2 As System.Windows.Forms.TextBox
	Public WithEvents lbl As System.Windows.Forms.Label
	Public WithEvents txtllave As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
	'Se puede modificar mediante el Diseñador de Windows Forms.
	'No lo modifique con el editor de código.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmborrarbd))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.bd = New System.Windows.Forms.Label
		Me.txtllave3 = New System.Windows.Forms.TextBox
		Me.botgenera = New System.Windows.Forms.Button
		Me.botcancela = New System.Windows.Forms.Button
		Me.botseguir = New System.Windows.Forms.Button
		Me.txtllave2 = New System.Windows.Forms.TextBox
		Me.lbl = New System.Windows.Forms.Label
		Me.txtllave = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Text = "Borrar Base Datos"
		Me.ClientSize = New System.Drawing.Size(253, 157)
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
		Me.Name = "frmborrarbd"
		Me.bd.Text = "BD"
		Me.bd.Size = New System.Drawing.Size(253, 25)
		Me.bd.Location = New System.Drawing.Point(0, 132)
		Me.bd.BackColor = System.Drawing.Color.Red
		Me.bd.ForeColor = System.Drawing.Color.Black
		Me.bd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.bd.Text = "bd"
		Me.bd.Name = "bd"
		Me.txtllave3.AutoSize = False
		Me.txtllave3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtllave3.Size = New System.Drawing.Size(81, 19)
		Me.txtllave3.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.txtllave3.Location = New System.Drawing.Point(136, 104)
		Me.txtllave3.PasswordChar = ChrW(42)
		Me.txtllave3.TabIndex = 7
		Me.txtllave3.Visible = False
		Me.txtllave3.AcceptsReturn = True
		Me.txtllave3.BackColor = System.Drawing.SystemColors.Window
		Me.txtllave3.CausesValidation = True
		Me.txtllave3.Enabled = True
		Me.txtllave3.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtllave3.HideSelection = True
		Me.txtllave3.ReadOnly = False
		Me.txtllave3.Maxlength = 0
		Me.txtllave3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtllave3.MultiLine = False
		Me.txtllave3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtllave3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtllave3.TabStop = True
		Me.txtllave3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtllave3.Name = "txtllave3"
		Me.botgenera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botgenera.Text = "Generar Llave"
		Me.botgenera.Size = New System.Drawing.Size(97, 25)
		Me.botgenera.Location = New System.Drawing.Point(8, 8)
		Me.botgenera.TabIndex = 5
		Me.botgenera.BackColor = System.Drawing.SystemColors.Control
		Me.botgenera.CausesValidation = True
		Me.botgenera.Enabled = True
		Me.botgenera.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botgenera.Cursor = System.Windows.Forms.Cursors.Default
		Me.botgenera.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botgenera.TabStop = True
		Me.botgenera.Name = "botgenera"
		Me.botcancela.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CancelButton = Me.botcancela
		Me.botcancela.Text = "Salir"
		Me.AcceptButton = Me.botcancela
		Me.botcancela.Size = New System.Drawing.Size(65, 25)
		Me.botcancela.Location = New System.Drawing.Point(184, 8)
		Me.botcancela.TabIndex = 4
		Me.botcancela.BackColor = System.Drawing.SystemColors.Control
		Me.botcancela.CausesValidation = True
		Me.botcancela.Enabled = True
		Me.botcancela.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botcancela.Cursor = System.Windows.Forms.Cursors.Default
		Me.botcancela.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botcancela.TabStop = True
		Me.botcancela.Name = "botcancela"
		Me.botseguir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.botseguir.Text = "¿Seguir?"
		Me.botseguir.Enabled = False
		Me.botseguir.Size = New System.Drawing.Size(65, 25)
		Me.botseguir.Location = New System.Drawing.Point(112, 8)
		Me.botseguir.TabIndex = 3
		Me.botseguir.Visible = False
		Me.botseguir.BackColor = System.Drawing.SystemColors.Control
		Me.botseguir.CausesValidation = True
		Me.botseguir.ForeColor = System.Drawing.SystemColors.ControlText
		Me.botseguir.Cursor = System.Windows.Forms.Cursors.Default
		Me.botseguir.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.botseguir.TabStop = True
		Me.botseguir.Name = "botseguir"
		Me.txtllave2.AutoSize = False
		Me.txtllave2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtllave2.Enabled = False
		Me.txtllave2.Size = New System.Drawing.Size(81, 19)
		Me.txtllave2.Location = New System.Drawing.Point(136, 72)
		Me.txtllave2.Maxlength = 6
		Me.txtllave2.TabIndex = 2
		Me.txtllave2.AcceptsReturn = True
		Me.txtllave2.BackColor = System.Drawing.SystemColors.Window
		Me.txtllave2.CausesValidation = True
		Me.txtllave2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtllave2.HideSelection = True
		Me.txtllave2.ReadOnly = False
		Me.txtllave2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtllave2.MultiLine = False
		Me.txtllave2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtllave2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtllave2.TabStop = True
		Me.txtllave2.Visible = True
		Me.txtllave2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtllave2.Name = "txtllave2"
		Me.lbl.Text = "Llave Seguridad"
		Me.lbl.Size = New System.Drawing.Size(89, 17)
		Me.lbl.Location = New System.Drawing.Point(16, 104)
		Me.lbl.TabIndex = 8
		Me.lbl.Visible = False
		Me.lbl.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lbl.BackColor = System.Drawing.SystemColors.Control
		Me.lbl.Enabled = True
		Me.lbl.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lbl.Cursor = System.Windows.Forms.Cursors.Default
		Me.lbl.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lbl.UseMnemonic = True
		Me.lbl.AutoSize = False
		Me.lbl.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lbl.Name = "lbl"
		Me.txtllave.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.txtllave.Size = New System.Drawing.Size(81, 17)
		Me.txtllave.Location = New System.Drawing.Point(136, 48)
		Me.txtllave.TabIndex = 6
		Me.txtllave.BackColor = System.Drawing.SystemColors.Control
		Me.txtllave.Enabled = True
		Me.txtllave.ForeColor = System.Drawing.SystemColors.ControlText
		Me.txtllave.Cursor = System.Windows.Forms.Cursors.Default
		Me.txtllave.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtllave.UseMnemonic = True
		Me.txtllave.Visible = True
		Me.txtllave.AutoSize = False
		Me.txtllave.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtllave.Name = "txtllave"
		Me.Label2.Text = "Introduzca Llave:"
		Me.Label2.Size = New System.Drawing.Size(89, 17)
		Me.Label2.Location = New System.Drawing.Point(16, 72)
		Me.Label2.TabIndex = 1
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
		Me.Label1.Text = "Clave Generada:"
		Me.Label1.Size = New System.Drawing.Size(89, 17)
		Me.Label1.Location = New System.Drawing.Point(24, 48)
		Me.Label1.TabIndex = 0
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
		Me.Controls.Add(bd)
		Me.Controls.Add(txtllave3)
		Me.Controls.Add(botgenera)
		Me.Controls.Add(botcancela)
		Me.Controls.Add(botseguir)
		Me.Controls.Add(txtllave2)
		Me.Controls.Add(lbl)
		Me.Controls.Add(txtllave)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class