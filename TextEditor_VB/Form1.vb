Imports System.IO
Public Class Form1
	Private Sub MidnightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem.Click
		If DarkToolStripMenuItem.CheckState = CheckState.Checked Then 'Dark Theme
			MenuStrip1.BackColor = System.Drawing.SystemColors.Desktop
			MenuStrip1.ForeColor = System.Drawing.Color.WhiteSmoke
			Me.BackColor = System.Drawing.SystemColors.Desktop
			rtbMainBody.BackColor = System.Drawing.Color.LightGray
		End If

		If DarkToolStripMenuItem.CheckState = CheckState.Unchecked Then 'Revert to standard
			MenuStrip1.BackColor = System.Drawing.SystemColors.Control
			MenuStrip1.ForeColor = System.Drawing.SystemColors.MenuText
			Me.BackColor = System.Drawing.SystemColors.Control
			rtbMainBody.BackColor = System.Drawing.SystemColors.Window
		End If

		AutumnToolStripMenuItem.CheckState = CheckState.Unchecked
		OceanToolStripMenuItem.CheckState = CheckState.Unchecked
	End Sub

	Private Sub AutumnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutumnToolStripMenuItem.Click
		If AutumnToolStripMenuItem.CheckState = CheckState.Checked Then 'Autumn Theme
			MenuStrip1.BackColor = System.Drawing.Color.Maroon
			MenuStrip1.ForeColor = System.Drawing.Color.Orange
			Me.BackColor = System.Drawing.Color.Maroon
			rtbMainBody.BackColor = System.Drawing.Color.Khaki
		End If

		If AutumnToolStripMenuItem.CheckState = CheckState.Unchecked Then
			MenuStrip1.BackColor = System.Drawing.SystemColors.Control
			MenuStrip1.ForeColor = System.Drawing.SystemColors.MenuText
			Me.BackColor = System.Drawing.SystemColors.Control
			rtbMainBody.BackColor = System.Drawing.SystemColors.Window
		End If

		DarkToolStripMenuItem.CheckState = CheckState.Unchecked
		OceanToolStripMenuItem.CheckState = CheckState.Unchecked
	End Sub

	Private Sub OceanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OceanToolStripMenuItem.Click
		If OceanToolStripMenuItem.CheckState = CheckState.Checked Then 'Ocean theme
			MenuStrip1.BackColor = System.Drawing.Color.MidnightBlue
			MenuStrip1.ForeColor = System.Drawing.Color.LemonChiffon
			Me.BackColor = System.Drawing.Color.MidnightBlue
			rtbMainBody.BackColor = System.Drawing.Color.PaleTurquoise
		End If

		If OceanToolStripMenuItem.CheckState = CheckState.Unchecked Then
			MenuStrip1.BackColor = System.Drawing.SystemColors.Control
			MenuStrip1.ForeColor = System.Drawing.SystemColors.MenuText
			Me.BackColor = System.Drawing.SystemColors.Control
			rtbMainBody.BackColor = System.Drawing.SystemColors.Window
		End If

		DarkToolStripMenuItem.CheckState = CheckState.Unchecked
		AutumnToolStripMenuItem.CheckState = CheckState.Unchecked
	End Sub

	Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
		If WordWrapToolStripMenuItem.CheckState = CheckState.Checked Then 'Simple if statements for word wrap
			rtbMainBody.WordWrap = True
		End If
		If WordWrapToolStripMenuItem.CheckState = CheckState.Unchecked Then
			rtbMainBody.WordWrap = False
		End If
	End Sub

	Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
		FontDialog1.ShowDialog()                    'select font and color whenever you click Font menu item
		ColorDialog1.ShowDialog()
		rtbMainBody.Font = FontDialog1.Font         'Sets changes to rich text box
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
		With OpenFileDialog1                'Code based off example in book
			.Title = "Open File"
			.Filter = "Text Files | *.txt"
			.FileName = ""
			.CheckFileExists = vbTrue
		End With

		If OpenFileDialog1.ShowDialog = DialogResult.OK Then
			rtbMainBody.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
			OpenToolStripMenuItem.CheckState = CheckState.Checked 'checkstate added as defensive coding for
			Me.Text = OpenFileDialog1.SafeFileName                  'Save as function
		End If
	End Sub

	Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
		With SaveFileDialog1                    'Code based off example in book
			.Title = "Save File"
			.Filter = "Text Files | *.txt"
			.DefaultExt = ".txt"
			.OverwritePrompt = True
		End With

		If SaveFileDialog1.ShowDialog = DialogResult.OK Then
			rtbMainBody.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
			SaveAsToolStripMenuItem.CheckState = CheckState.Checked
			Me.Text = Path.GetFileName(SaveFileDialog1.FileName) 'SafeFileName not available for SavefileDialog
		End If
	End Sub

	Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
		If OpenToolStripMenuItem.Checked Then
			rtbMainBody.SaveFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
		ElseIf SaveAsToolStripMenuItem.Checked Then
			rtbMainBody.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
		ElseIf OpenToolStripMenuItem.CheckState = CheckState.Unchecked AndAlso SaveAsToolStripMenuItem.CheckState = CheckState.Unchecked Then
			With SaveFileDialog1
				.Title = "Save File"                    'Checkstate allows Save to act has save as if 
				.Filter = "Text Files | *.txt"          'Open or Save as have not been used
				.DefaultExt = ".txt"
				.OverwritePrompt = True
			End With

			If SaveFileDialog1.ShowDialog = DialogResult.OK Then
				rtbMainBody.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
				Me.Text = Path.GetFileName(SaveFileDialog1.FileName)
				SaveAsToolStripMenuItem.CheckState = CheckState.Checked
			End If
		End If
	End Sub

	Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
		Dim Message, Title, UserInput As String 'Variables needed for Input Box
		Dim FindKeyword As String
		Message = "Type Keyword for Search below:" & vbNewLine & "*Search target must be a whole word*"
		Title = "Find"
		UserInput = ""

		FindKeyword = InputBox(Message, Title, UserInput, 400, 150) 'Stores user input

		If FindKeyword IsNot "" Then 'Finds Keyword and selects it if present
			Dim WordLength = FindKeyword.Length
			Dim Position = rtbMainBody.Find(FindKeyword, 0, RichTextBoxFinds.WholeWord)
			Try
				rtbMainBody.Select(Position, WordLength)  'If keyword is not present in in txtbox, Position is
			Catch ex As Exception                           'assigned a negative value and breaks code
				MessageBox.Show("Search Target not present in document")    'Could be handled with If statement as well
			End Try
		End If
	End Sub

	Private Sub FindAndReplaceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindAndReplaceToolStripMenuItem.Click
		Dim FMessage, Title, FindInput As String
		Dim FindKeyword As String
		FMessage = "Type Keyword for Search below:" & vbNewLine & "*Search target must be a whole word*"
		Title = "Find and Replace"
		FindInput = ""

		FindKeyword = InputBox(FMessage, Title, FindInput, 400, 150)

		Dim RMessage, ReplaceInput As String
		Dim ReplaceKeyWord As String
		RMessage = "Type Keyword for Replace below:"
		ReplaceInput = ""

		ReplaceKeyWord = InputBox(RMessage, Title, ReplaceInput, 400, 150)

		If ReplaceKeyWord & FindKeyword IsNot "" Then
			Dim FWordLength = FindKeyword.Length
			Dim RWordLength = ReplaceKeyWord.Length
			Dim FPosition = rtbMainBody.Find(FindKeyword, 0, RichTextBoxFinds.WholeWord)

			While FPosition >= 0
				If RWordLength > FWordLength Then
					rtbMainBody.Text = rtbMainBody.Text.Remove(FPosition, FWordLength)
					rtbMainBody.Text = rtbMainBody.Text.Insert(FPosition, ReplaceKeyWord)
				ElseIf FindKeyword.Equals(ReplaceKeyWord) Then
					MessageBox.Show("Find Keyword and Replace Keyword" & vbNewLine &
									"             are the same word..." & vbNewLine &
									"                      (-____-)")
					Exit While
				Else
					rtbMainBody.Select(FPosition, FWordLength)
					rtbMainBody.SelectedText = ReplaceKeyWord
				End If
				FPosition = rtbMainBody.Find(FindKeyword, FPosition + RWordLength, RichTextBoxFinds.WholeWord)
			End While
		End If
	End Sub
End Class
