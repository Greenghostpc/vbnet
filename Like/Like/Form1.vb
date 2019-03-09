Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text Like TextBox2.Text Then
            Me.BackColor = Color.Green
        Else
            Me.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As String
        s = InputBox("Enter a new word: ")
        TextBox3.Text = s
        For n As Integer = 0 To s.Length - 1
            d = d & "-"
        Next
    End Sub
End Class
