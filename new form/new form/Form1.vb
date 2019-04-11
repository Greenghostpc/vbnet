Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button10.Click
        Dim b As Button
        b = TryCast(sender, Button)
        TextBox1.Text += b.Text
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim nums(4) As Integer
        For i = 0 To nums.GetUpperBound(0)
            nums(i) = i
        Next
        TextBox1.Text = nums.Sum
    End Sub
End Class
