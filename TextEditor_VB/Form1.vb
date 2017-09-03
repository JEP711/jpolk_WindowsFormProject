Imports System.IO
Public Class Form1
	Private Sub MidnightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem.Click
		If DarkToolStripMenuItem.CheckState = CheckState.Checked Then
			MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark
			MenuStrip1.ForeColor = System.Drawing.Color.WhiteSmoke
			Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
			rtbMainBody.BackColor = System.Drawing.SystemColors.MenuText
			rtbMainBody.ForeColor = System.Drawing.SystemColors.HighlightText
		End If
		If DarkToolStripMenuItem.CheckState = CheckState.Unchecked Then
			MenuStrip1.BackColor = System.Drawing.SystemColors.Control
			MenuStrip1.ForeColor = System.Drawing.SystemColors.MenuText
			Me.BackColor = System.Drawing.SystemColors.Control
			rtbMainBody.BackColor = System.Drawing.SystemColors.Window
			rtbMainBody.ForeColor = System.Drawing.SystemColors.MenuText
		End If
		If AutumnToolStripMenuItem.CheckState = CheckState.Checked Then
			DarkToolStripMenuItem.CheckState = CheckState.Unchecked
			MenuStrip1.BackColor = System.Drawing.Color.Maroon
			MenuStrip1.ForeColor = System.Drawing.Color.Orange
			Me.BackColor = System.Drawing.Color.Maroon
			rtbMainBody.BackColor = System.Drawing.Color.Khaki
			rtbMainBody.ForeColor = System.Drawing.Color.SaddleBrown
		End If
		If OceanToolStripMenuItem.CheckState = CheckState.Checked Then
			DarkToolStripMenuItem.CheckState = CheckState.Unchecked
			MenuStrip1.BackColor = System.Drawing.Color.MidnightBlue
			MenuStrip1.ForeColor = System.Drawing.Color.LemonChiffon
			Me.BackColor = System.Drawing.Color.MidnightBlue
			rtbMainBody.BackColor = System.Drawing.Color.PaleTurquoise
		End If
	End Sub

	Private Sub AutumnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutumnToolStripMenuItem.Click
		If AutumnToolStripMenuItem.CheckState = CheckState.Checked Then
			MenuStrip1.BackColor = System.Drawing.Color.Maroon
			MenuStrip1.ForeColor = System.Drawing.Color.Orange
			Me.BackColor = System.Drawing.Color.Maroon
			rtbMainBody.BackColor = System.Drawing.Color.Khaki
			rtbMainBody.ForeColor = System.Drawing.Color.SaddleBrown
		End If
		If AutumnToolStripMenuItem.CheckState = CheckState.Unchecked Then
			MenuStrip1.BackColor = System.Drawing.SystemColors.Control
			MenuStrip1.ForeColor = System.Drawing.SystemColors.MenuText
			Me.BackColor = System.Drawing.SystemColors.Control
			rtbMainBody.BackColor = System.Drawing.SystemColors.Window
			rtbMainBody.ForeColor = System.Drawing.SystemColors.MenuText
		End If
		If DarkToolStripMenuItem.CheckState = CheckState.Checked Then
			AutumnToolStripMenuItem.CheckState = CheckState.Unchecked
			MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark
			MenuStrip1.ForeColor = System.Drawing.Color.WhiteSmoke
			Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
			rtbMainBody.BackColor = System.Drawing.SystemColors.MenuText
			rtbMainBody.ForeColor = System.Drawing.SystemColors.HighlightText
		End If
		If OceanToolStripMenuItem.CheckState = CheckState.Checked Then
			AutumnToolStripMenuItem.CheckState = CheckState.Unchecked
			MenuStrip1.BackColor = System.Drawing.Color.MidnightBlue
			MenuStrip1.ForeColor = System.Drawing.Color.LemonChiffon
			Me.BackColor = System.Drawing.Color.MidnightBlue
			rtbMainBody.BackColor = System.Drawing.Color.PaleTurquoise
		End If
	End Sub

	Private Sub OceanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OceanToolStripMenuItem.Click
		If OceanToolStripMenuItem.CheckState = CheckState.Checked Then
			MenuStrip1.BackColor = System.Drawing.Color.MidnightBlue
			MenuStrip1.ForeColor = System.Drawing.Color.LemonChiffon
			Me.BackColor = System.Drawing.Color.MidnightBlue
			rtbMainBody.BackColor = System.Drawing.Color.PaleTurquoise
			rtbMainBody.ForeColor = System.Drawing.SystemColors.MenuText
		End If
		If OceanToolStripMenuItem.CheckState = CheckState.Unchecked Then
			MenuStrip1.BackColor = System.Drawing.SystemColors.Control
			MenuStrip1.ForeColor = System.Drawing.SystemColors.MenuText
			Me.BackColor = System.Drawing.SystemColors.Control
			rtbMainBody.BackColor = System.Drawing.SystemColors.Window
			rtbMainBody.ForeColor = System.Drawing.SystemColors.MenuText
		End If
		If DarkToolStripMenuItem.CheckState = CheckState.Checked Then
			OceanToolStripMenuItem.CheckState = CheckState.Unchecked
			MenuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark
			MenuStrip1.ForeColor = System.Drawing.Color.WhiteSmoke
			Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
			rtbMainBody.BackColor = System.Drawing.SystemColors.MenuText
			rtbMainBody.ForeColor = System.Drawing.SystemColors.HighlightText
		End If
		If AutumnToolStripMenuItem.CheckState = CheckState.Checked Then
			OceanToolStripMenuItem.CheckState = CheckState.Unchecked
			MenuStrip1.BackColor = System.Drawing.Color.Maroon
			MenuStrip1.ForeColor = System.Drawing.Color.Orange
			Me.BackColor = System.Drawing.Color.Maroon
			rtbMainBody.BackColor = System.Drawing.Color.Khaki
			rtbMainBody.ForeColor = System.Drawing.Color.SaddleBrown
		End If
	End Sub

	Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
		If WordWrapToolStripMenuItem.CheckState = CheckState.Checked Then
			rtbMainBody.WordWrap = True
		End If
		If WordWrapToolStripMenuItem.CheckState = CheckState.Unchecked Then
			rtbMainBody.WordWrap = False
		End If
	End Sub

	Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
		FontDialog1.ShowDialog()
		ColorDialog1.ShowDialog()
		rtbMainBody.Font = FontDialog1.Font
		rtbMainBody.ForeColor = ColorDialog1.Color
	End Sub

	Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
		MessageBox.Show("This is a general text editor" & vbNewLine &
						"Open, Save, and Edit your text files" & vbNewLine &
						"Author: James Polk" & vbNewLine &
						"Version: 1.0" & vbNewLine &
						"Course: Web Developer Boot Camp")
	End Sub

	Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
		Dim UserFile = OpenFileDialog1.FileName
		Dim UserFileRead = New StreamReader(UserFile)

		If OpenFileDialog1.ShowDialog = DialogResult.OK Then
			OpenToolStripMenuItem.CheckState = CheckState.Checked
		End If

		While Not UserFileRead.EndOfStream
			rtbMainBody.Text += UserFileRead.ReadLine
		End While

		UserFileRead.Close()

		Me.Text = OpenFileDialog1.SafeFileName
	End Sub

	Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
		With SaveFileDialog1
			.Title = "Save File"
			.Filter = "Text Files | *.txt"
			.DefaultExt = ".txt"
			.OverwritePrompt = True
		End With

		If SaveFileDialog1.ShowDialog = DialogResult.OK Then
			rtbMainBody.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
			SaveAsToolStripMenuItem.CheckState = CheckState.Checked
		End If
	End Sub

	Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
		If OpenToolStripMenuItem.Checked Then
			rtbMainBody.SaveFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
		ElseIf SaveAsToolStripMenuItem.Checked Then
			rtbMainBody.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
		ElseIf OpenToolStripMenuItem.CheckState = CheckState.Unchecked AndAlso SaveAsToolStripMenuItem.CheckState = CheckState.Unchecked Then
			With SaveFileDialog1
				.Title = "Save File"
				.Filter = "Text Files | *.txt"
				.DefaultExt = ".txt"
				.OverwritePrompt = True
			End With

			If SaveFileDialog1.ShowDialog = DialogResult.OK Then
				rtbMainBody.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
			End If
		End If

	End Sub


End Class
