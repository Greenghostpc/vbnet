Public Class Form1
    Private Sub tryParseButton_Click(sender As Object, e As EventArgs) Handles tryParseButton.Click
        Dim int As Integer 'Declare an Integer
        Integer.TryParse(integerTextBox.Text, int) 'put value into variable
        intoutputTextBox.Text = int

        Dim dbl As Integer
        Double.TryParse(doubleTextBox.Text, dbl)
        doubleOutputTextBox.Text = dbl

        Dim dec As Decimal
        Decimal.TryParse(decimalTextBox.Text, dec)
        decOutputTextBox.Text = dec

        Dim s As String
        s = stringTextBox.Text
        stringOutputTextBox.Text = s
    End Sub
End Class
