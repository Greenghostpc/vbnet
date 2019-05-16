Public Class Form1
    Dim number(4) As String
    Dim number1(4) As Integer
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Integer
        Dim result As String

        'Step 1
        number(0) = TextBox1.Text.Substring(0, 1)
        number(1) = TextBox1.Text.Substring(1, 1)
        number(2) = TextBox1.Text.Substring(2, 1)
        number(3) = TextBox1.Text.Substring(3, 1)
        Integer.TryParse(number(0), number1(0))
        Integer.TryParse(number(1), number1(1))
        Integer.TryParse(number(2), number1(2))
        Integer.TryParse(number(3), number1(3))

        'Step 2
        number(1) = number(1) * 2
        number(3) = number(3) * 2

        'Step 3
        total = (number(0) + number(1) + number(2) + number(3))
        result = total
        result = result.Substring(1, 1)

        'Step 4
        TextBox2.Text = TextBox1.Text & result
    End Sub

    Private Sub ExitToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class