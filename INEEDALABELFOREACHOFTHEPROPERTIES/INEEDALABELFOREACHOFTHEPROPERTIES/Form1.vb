Public Class Form1
    Dim WithEvents c As New Car
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c.carColor = Color.Blue
        c.make = "Tesla"
        c.model = "Roadster"
        c.MPG = 20
        c.fuel = 10
        showcar(c)
        c.drive(101)
    End Sub
    Sub showcar(x As Car)
        TextBox3.Text = x.make
        TextBox1.Text = x.MPG
        TextBox2.BackColor = x.carColor
        TextBox4.Text = x.fuel
        TextBox5.Text = x.model
    End Sub

    Private Sub c_Outofgas() Handles c.Outofgas
        Me.Close()
    End Sub
End Class
