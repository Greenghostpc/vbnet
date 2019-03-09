Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Declare Variable
        Dim num As Integer
        'Get Value From Form
        Integer.TryParse(inputTextBox.Text, num)
        'Put Value On Form
        outputLabel.Text = num * 5280

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Declare Variable
        Dim num2 As Integer
        'Get Value From Form
        Integer.TryParse(inputPartTwoTextBox.Text, num2)
        'Put Value On Form
        outputPartTwoLabel.Text = num2 * 1760

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Declare Variable
        Dim num3 As Integer
        'Get Value From Form
        Integer.TryParse(inputPartThreeTextBox.Text, num3)
        'Put Value On Form
        outputPartThreeLabel.Text = num3 * 1609.34
    End Sub
End Class
