Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As String

        s = TextBox1.Text.Substring(8, 1) ' First two characters
        TextBox2.Text = TextBox1.Text.IndexOf("7")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
