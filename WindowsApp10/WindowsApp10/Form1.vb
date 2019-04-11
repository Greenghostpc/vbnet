Public Class Form1
    Private Sub mileButton_Click(sender As Object, e As EventArgs) Handles mileButton.Click
        Dim miles As Decimal
        Decimal.TryParse(inputTextBox.Text, miles)
        miles = miles * 5280
        answerlabel.Text = miles
    End Sub

    Private Sub yardsButton_Click(sender As Object, e As EventArgs) Handles yardsButton.Click
        Dim yards As Decimal
        Decimal.TryParse(inputTextBox.Text, yards)
        yards = yards * 3
        answerlabel.Text = yards
    End Sub

    Private Sub metersButton_Click(sender As Object, e As EventArgs) Handles metersButton.Click
        Dim meters As Decimal
        Decimal.TryParse(inputTextBox.Text, meters)
        meters = meters * 3.28084
        answerlabel.Text = meters
    End Sub
End Class
