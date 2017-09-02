<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FindAndReplaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.WordWrapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ThemeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DarkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AutumnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.OceanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.rtbMainBody = New System.Windows.Forms.RichTextBox()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
		Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(453, 28)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
		Me.FileToolStripMenuItem.Text = "File"
		'
		'OpenToolStripMenuItem
		'
		Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
		Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
		Me.OpenToolStripMenuItem.Text = "Open"
		'
		'SaveToolStripMenuItem
		'
		Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
		Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
		Me.SaveToolStripMenuItem.Text = "Save"
		'
		'SaveAsToolStripMenuItem
		'
		Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
		Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
		Me.SaveAsToolStripMenuItem.Text = "Save as"
		'
		'EditToolStripMenuItem
		'
		Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindToolStripMenuItem, Me.FindAndReplaceToolStripMenuItem, Me.FontToolStripMenuItem, Me.WordWrapToolStripMenuItem})
		Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
		Me.EditToolStripMenuItem.Size = New System.Drawing.Size(47, 24)
		Me.EditToolStripMenuItem.Text = "Edit"
		'
		'FindToolStripMenuItem
		'
		Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
		Me.FindToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
		Me.FindToolStripMenuItem.Text = "Find"
		'
		'FindAndReplaceToolStripMenuItem
		'
		Me.FindAndReplaceToolStripMenuItem.Name = "FindAndReplaceToolStripMenuItem"
		Me.FindAndReplaceToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
		Me.FindAndReplaceToolStripMenuItem.Text = "Find and Replace"
		'
		'FontToolStripMenuItem
		'
		Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
		Me.FontToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
		Me.FontToolStripMenuItem.Text = "Font"
		'
		'WordWrapToolStripMenuItem
		'
		Me.WordWrapToolStripMenuItem.CheckOnClick = True
		Me.WordWrapToolStripMenuItem.Name = "WordWrapToolStripMenuItem"
		Me.WordWrapToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
		Me.WordWrapToolStripMenuItem.Text = "Word Wrap"
		'
		'ViewToolStripMenuItem
		'
		Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ThemeToolStripMenuItem})
		Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
		Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
		Me.ViewToolStripMenuItem.Text = "View"
		'
		'ThemeToolStripMenuItem
		'
		Me.ThemeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DarkToolStripMenuItem, Me.AutumnToolStripMenuItem, Me.OceanToolStripMenuItem})
		Me.ThemeToolStripMenuItem.Name = "ThemeToolStripMenuItem"
		Me.ThemeToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
		Me.ThemeToolStripMenuItem.Text = "Theme"
		'
		'DarkToolStripMenuItem
		'
		Me.DarkToolStripMenuItem.CheckOnClick = True
		Me.DarkToolStripMenuItem.Name = "DarkToolStripMenuItem"
		Me.DarkToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
		Me.DarkToolStripMenuItem.Text = "Dark"
		'
		'AutumnToolStripMenuItem
		'
		Me.AutumnToolStripMenuItem.CheckOnClick = True
		Me.AutumnToolStripMenuItem.Name = "AutumnToolStripMenuItem"
		Me.AutumnToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
		Me.AutumnToolStripMenuItem.Text = "Autumn"
		'
		'OceanToolStripMenuItem
		'
		Me.OceanToolStripMenuItem.CheckOnClick = True
		Me.OceanToolStripMenuItem.Name = "OceanToolStripMenuItem"
		Me.OceanToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
		Me.OceanToolStripMenuItem.Text = "Ocean"
		'
		'HelpToolStripMenuItem
		'
		Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
		Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
		Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
		Me.HelpToolStripMenuItem.Text = "Help"
		'
		'AboutToolStripMenuItem
		'
		Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
		Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
		Me.AboutToolStripMenuItem.Text = "About"
		'
		'rtbMainBody
		'
		Me.rtbMainBody.AcceptsTab = True
		Me.rtbMainBody.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.rtbMainBody.BackColor = System.Drawing.SystemColors.Window
		Me.rtbMainBody.ForeColor = System.Drawing.SystemColors.MenuText
		Me.rtbMainBody.Location = New System.Drawing.Point(12, 28)
		Me.rtbMainBody.Name = "rtbMainBody"
		Me.rtbMainBody.Size = New System.Drawing.Size(429, 340)
		Me.rtbMainBody.TabIndex = 1
		Me.rtbMainBody.Text = ""
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ClientSize = New System.Drawing.Size(453, 380)
		Me.Controls.Add(Me.rtbMainBody)
		Me.Controls.Add(Me.MenuStrip1)
		Me.ForeColor = System.Drawing.SystemColors.ControlText
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FindAndReplaceToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents WordWrapToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ThemeToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents rtbMainBody As RichTextBox
	Friend WithEvents DarkToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents AutumnToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents OceanToolStripMenuItem As ToolStripMenuItem
End Class
