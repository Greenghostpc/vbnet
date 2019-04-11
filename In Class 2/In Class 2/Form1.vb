Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim american As Decimal
        Dim british As Decimal
        Dim mexican As Decimal
        Dim canadian As Decimal
        Dim japanese As Decimal

        Decimal.TryParse(americanTextBox.Text, american)
        Decimal.TryParse(britishTextBox.Text, british)
        Decimal.TryParse(mexicanTextBox.Text, mexican)
        Decimal.TryParse(canadianTextBox.Text, canadian)
        Decimal.TryParse(japaneseTextBox.Text, japanese)


        british = american * 0.77
        britishTextBox.Text = british

        mexican = american * 19.11
        mexicanTextBox.Text = mexican

        canadian = american * 1.29
        canadianTextBox.Text = canadian

        japanese = american * 113.81
        japaneseTextBox.Text = japanese
        britishTextBox.Text = FormatCurrency(british)
        canadianTextBox.Text = FormatCurrency(canadian)
        mexicanTextBox.Text = FormatCurrency(mexican)
        japaneseTextBox.Text = FormatCurrency(japanese)
    End Sub
End Class
