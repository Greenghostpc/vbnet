Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabel2.Text = "Ready"
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFolderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFolderToolStripMenuItem.Click
        FolderBrowserDialog1.ShowDialog()
    End Sub
End Class
