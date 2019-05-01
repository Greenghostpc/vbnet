Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim first As Decimal
        Dim second As Decimal
        Dim total As Decimal

        Decimal.TryParse(TextBox1.Text, first)
        Decimal.TryParse(TextBox2.Text, second)
        Try
            total = first / second

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Label1.Text = total
    End Sub
End Class
