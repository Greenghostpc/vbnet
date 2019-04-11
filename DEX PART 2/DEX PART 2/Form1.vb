Public Class Form1
    Private Sub FilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilesToolStripMenuItem.Click

    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Form2.ShowDialog()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New Form2
        If f.ShowDialog = DialogResult.OK Then
            'add code here
        End If
    End Sub
End Class
