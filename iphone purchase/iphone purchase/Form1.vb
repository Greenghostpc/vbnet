Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim firstNum As Integer
        Dim secondNum As Integer
        Dim answer As Integer

        Integer.TryParse(FirstNumber.Text, firstNum)
        Integer.TryParse(Number.Text, secondNum)

        answer = firstNum * secondNum
        AnswerLabel.Text = answer
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles AnswerLabel.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SecondNumber_Click(sender As Object, e As EventArgs) Handles Number.Click

    End Sub
End Class
