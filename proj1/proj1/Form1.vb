Public Class Form1
    Dim first As Decimal
    Dim second As Decimal
    Dim total As Decimal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Decimal.TryParse(TextBox1.Text, first)
        Decimal.TryParse(TextBox2.Text, second)

        total = first * second
        Label2.Text = total
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Decimal.TryParse(TextBox1.Text, first)
        Decimal.TryParse(TextBox2.Text, second)

        total = first + second
        Label2.Text = total
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Decimal.TryParse(TextBox1.Text, first)
        Decimal.TryParse(TextBox2.Text, second)

        total = first - second
        Label2.Text = total
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Decimal.TryParse(TextBox1.Text, first)
        Decimal.TryParse(TextBox2.Text, second)

        total = first / second
        Label2.Text = total
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If total > 0 Then
            Me.BackColor = Color.AliceBlue
        Else
            Me.BackColor = Color.PaleVioletRed
        End If
        Label2.Enabled = False
        Select Case second > -100
            Case second > 0
                MessageBox.Show("Ha")

        End Select

    End Sub
End Class
