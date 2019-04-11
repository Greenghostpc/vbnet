Public Class Form1
    Dim str As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        str = TextBox1.Text
        Label1.Text = str.Contains(TextBox2.Text)
    End Sub
End Class
