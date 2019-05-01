Public Class Form1
    Dim x As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x = x / 5
        TextBox1.Text = x
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        x = x / 3
        TextBox1.Text = x
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        x = x / 2
        TextBox1.Text = x
    End Sub
End Class
