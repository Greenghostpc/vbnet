Public Class Form1
    Dim x As Integer
    Dim test As Integer
    Dim home As Integer
    Dim final As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles testButton.Click
        x = test / 5
        testTextBox.Text = test
        Integer.TryParse(testTextBox.Text, test)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles homeworkButton.Click
        x = home / 3
        homeworkTextBox.Text = home
        Integer.TryParse(homeworkTextBox.Text, home)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles finalButton.Click
        x = final / 2
        finalTextBox.Text = final
        Integer.TryParse(finalTextBox.Text, final)
    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class


