Public Class Form1
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click

        Dim coft As Decimal
        Dim pott As Decimal
        Dim flt As Decimal

        Decimal.TryParse(coftTextBox.Text, coft)
        Decimal.TryParse(percentoftiptextbox.Text, pott)
        Decimal.TryParse(finalpricelabel.Text, flt)
        flt = (coft) * (1 + (pott / 100))
        finalpricelabel.Text = flt
        finalpricelabel.Visible = True

    End Sub
End Class
