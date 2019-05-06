Public Class Form1
    Dim b As barrel
    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click
        Dim r, h As Decimal
        Decimal.TryParse(radiusTextBox.Text, r)
        Decimal.TryParse(heightTextBox.Text, h)
        b = New barrel(r, h)
        contentsTextBox.Text = b.contents
    End Sub

    Private Sub fillButton_Click(sender As Object, e As EventArgs) Handles fillButton.Click
        Dim fillamt As Decimal
        Decimal.TryParse(fillTextBox.Text, fillamt)
        b.fill(fillamt)
        contentsTextBox.Text = b.contents
    End Sub

    Private Sub drainButton_Click(sender As Object, e As EventArgs) Handles drainButton.Click
        Dim drainamt As Decimal
        Decimal.TryParse(drainTextBox.Text, drainamt)
        b.drain(drainamt)
        contentsTextBox.Text = b.contents
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Fractions.Show()
    End Sub
End Class
