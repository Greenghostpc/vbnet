Public Class Form1
    Private Sub tryParseButton_Click(sender As Object, e As EventArgs) Handles tryParseButton.Click
        Dim int As Integer 'declare an Integer'
        Integer.TryParse(integerTextBox.Text, int) 'put value into variable'
        integeroutputTextBox.Text = int
        If int > 0 Then
            integeroutputTextBox.BackColor = Color.Purple
        End If
        Dim dbl As Double
        Double.TryParse(doubleTextBox.Text, dbl)
        doubleoutputTextBox.Text = dbl
        Dim dec As Decimal
        Decimal.TryParse(decimalTextBox.Text, dec)
        decimaloutputTextBox.Text = dec
        Dim s As String
        s = stringTextBox.Text
        stringoutputTextBox.Text = s
    End Sub
End Class
