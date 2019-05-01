Public Class Form1
    Dim money As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        money = money - 2
        Dim rg As New Random
        Label1.Text = rg.Next(1, 71)
        If Label1.Text = TextBox1.Text Then
            Me.BackColor = Color.Green
            money = money + 139
        Else
            Me.BackColor = DefaultBackColor
        End If
        Label2.Text = money
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        money = 20
    End Sub
End Class
