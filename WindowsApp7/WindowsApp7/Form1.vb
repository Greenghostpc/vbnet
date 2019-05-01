Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstNum As Integer
        Dim secondNum As Integer
        Dim answer As Integer

        Integer.TryParse(firstTextBox.Text, firstNum)
        Integer.TryParse(secondTextBox.Text, secondNum)

        answer = firstNum + secondNum
        answerLabel.Text = answer
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim firstNum As Integer
        Dim secondNum As Integer
        Dim answer As Integer

        Integer.TryParse(firstTextBox.Text, firstNum)
        Integer.TryParse(secondTextBox.Text, secondNum)

        answer = firstNum - secondNum
        answerLabel.Text = answer
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim firstNum As Integer
        Dim secondNum As Integer
        Dim answer As Integer

        Integer.TryParse(firstTextBox.Text, firstNum)
        Integer.TryParse(secondTextBox.Text, secondNum)

        answer = firstNum * secondNum
        answerLabel.Text = answer
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim firstNum As Integer
        Dim secondNum As Integer
        Dim answer As Integer

        Integer.TryParse(firstTextBox.Text, firstNum)
        Integer.TryParse(secondTextBox.Text, secondNum)

        answer = firstNum / secondNum
        answerLabel.Text = answer
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        firstTextBox.Clear()
        secondTextBox.Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class
