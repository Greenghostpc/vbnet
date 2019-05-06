Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub viewColorButton_Click(sender As Object, e As EventArgs) Handles viewColorButton.Click
        Dim inputRed As Integer
        Dim inputGreen As Integer
        Dim inputBlue As Integer
        Integer.TryParse(redTextBox.Text, inputRed)
        Integer.TryParse(greenTextBox.Text, inputGreen)
        Integer.TryParse(blueTextBox.Text, inputBlue)
        colorPictureBox.BackColor =
            Color.FromArgb(inputRed, inputBlue, inputGreen)
    End Sub
End Class
