Public Class Form1
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub FowardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FowardToolStripMenuItem.Click
        WebBrowser1.GoForward()
    End Sub
End Class
