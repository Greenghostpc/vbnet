Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declares a variable called total
        Dim total As Decimal
        'Gets the value from the form and puts it in total
        Decimal.TryParse(TextBox1.Text, total)

        'Declares a variable called total
        Dim tip As Decimal
        'Gets the value from the form and puts it in total
        Decimal.TryParse(TextBox2.Text, tip)

        'Does a calculation
        Dim grandTotal As Decimal
        grandTotal = total * (1 + tip)

        'This displays the result as a currency with two decimal places
        grandTotalLabel.Text = grandTotal.ToString("C2")
    End Sub
End Class
