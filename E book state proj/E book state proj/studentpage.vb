Public Class studentpage
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim stubookview As New studentviewbooks
        studentviewbooks.ShowDialog()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        StudentLogin.Show()
        Me.Close()
    End Sub
End Class