Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As String

        'First two characters
        s = TextBox1.Text.Substring(0, 2)

        TextBox2.Text = s
    End Sub
End Class
