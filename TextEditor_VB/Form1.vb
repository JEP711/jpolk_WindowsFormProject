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
		End If
		If OceanToolStripMenuItem.CheckState = CheckState.Unchecked Then
			MenuStrip1.BackColor = System.Drawing.SystemColors.Control
			MenuStrip1.ForeColor = System.Drawing.SystemColors.MenuText
			Me.BackColor = System.Drawing.SystemColors.Control
			rtbMainBody.BackColor = System.Drawing.SystemColors.Window
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
End Class
