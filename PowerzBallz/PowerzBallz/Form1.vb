Public Class Form1
    Dim money As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rg As New Random
        Label1.Text = rg.Next(1, 11)
        money = money - 1
        If TextBox1.Text = Label1.Text Then
            Me.BackColor = Color.Green
        Else
            Me.BackColor = DefaultBackColor
        End If
        Label2.Text = money
    End Sub
End Class
