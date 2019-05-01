Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nums As Integer
        Integer.TryParse(TextBox1.Text, nums)

        For n As Integer = 1 To nums
            ListBox1.Items.Add(n)
        Next

    End Sub
End Class
