Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub fnameTextBox_TextChanged(sender As Object, e As EventArgs) Handles lnameTextBox.TextChanged, fnameTextBox.TextChanged, emailTextBox.TextChanged
        If lnameTextBox.Text <> "" And fnameTextBox.Text <> "" And emailTextBox.Text <> "" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub
End Class