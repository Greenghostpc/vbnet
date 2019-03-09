Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstNum As Integer
        Dim secondNum As Integer
        Dim answer As Integer

        Integer.TryParse(firsttextBox.Text, firstNum)
        Integer.TryParse(secondTextBox.Text, secondNum)

        answer = firstNum + secondNum
        AnswerLabel.Text = answer
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim firstNum As Integer
        Dim secondNum As Integer
        Dim answer As Integer

        Integer.TryParse(firsttextBox.Text, firstNum)
        Integer.TryParse(secondTextBox.Text, secondNum)

        answer = firstNum * secondNum
        AnswerLabel.Text = answer
    End Sub
End Class
