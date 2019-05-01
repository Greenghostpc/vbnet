Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hwgrade As Decimal
        Dim csgrade As Decimal
        Dim tgrade As Decimal
        Dim fgrade As Decimal
        Dim hwgradepog As Decimal
        Dim csgradepog As Decimal
        Dim tgradepog As Decimal


        Decimal.TryParse(homeworkTextbox.Text, hwgrade)
        Decimal.TryParse(cwTextBox.Text, csgrade)
        Decimal.TryParse(tgradeTextBox.Text, tgrade)
        Decimal.TryParse(Fgradelabel.Text, fgrade)
        Decimal.TryParse(TextBox4.Text, hwgradepog)
        Decimal.TryParse(Textbox5.Text, csgradepog)
        Decimal.TryParse(TextBox6.Text, tgradepog)

        fgrade = ((hwgrade * hwgradepog) + (csgrade * csgradepog) + (tgrade * tgradepog)) / 100
        Fgradelabel.Text = fgrade
        Fgradelabel.Visible = True

    End Sub
End Class
