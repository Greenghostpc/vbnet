Public Class Form1
    Private Sub StudentLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentLoginToolStripMenuItem.Click
        Dim frmstudent As New StudentLogin
        Me.Hide()
        frmstudent.ShowDialog()
    End Sub

    Private Sub TeacherLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeacherLoginToolStripMenuItem.Click
        Dim frmstudent As New TeacherLogin
        Me.Hide()
        frmstudent.ShowDialog()
    End Sub

    Private Sub AdministratorLoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministratorLoginToolStripMenuItem.Click
        Dim frmstudent As New AdministratorLogin
        Me.Hide()
        frmstudent.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
