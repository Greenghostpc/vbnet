Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    End Sub

    Private Sub StudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentsToolStripMenuItem.Click
        Dim frmstudent As New Form2
        Me.Hide()
        frmstudent.ShowDialog()
        Me.Show()
        MessageBox.Show(frmstudent.TextBox1.Text)

    End Sub
End Class
