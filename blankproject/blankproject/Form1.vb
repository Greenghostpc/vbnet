Public Class Form1
    Private Sub colorButton_Click(sender As Object, e As EventArgs) Handles colorButton.Click
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color
    End Sub

    Private Sub fontButton_Click(sender As Object, e As EventArgs) Handles fontButton.Click
        FontDialog1.ShowDialog()
        Me.Font = FontDialog1.Font
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.BackColor = sender.BackColor
    End Sub
End Class
