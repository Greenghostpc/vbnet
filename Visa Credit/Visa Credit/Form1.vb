Public Class Form1
    Dim credit As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim firstDigits As String
        Dim firstDigit As String
        Dim secondDigit As String
        Dim thirdDigit As String
        Dim fourthDigit As String
        Dim newSecondDigit As Integer
        Dim newFourthDigit As Integer
        Dim numFirstDigit As Integer
        Dim numSecondDigit As Integer
        Dim numThirdDigit As Integer
        Dim numFourthDigit As Integer
        Dim fifthNumber As String
        Dim fifthDigit As String

        firstDigits = TextBox2.Text
        firstDigit = firstDigits.Substring(0, 1)
        secondDigit = firstDigits.Substring(1, 1)
        thirdDigit = firstDigits.Substring(2, 1)
        fourthDigit = firstDigits.Substring(3, 1)
        numFirstDigit = Integer.Parse(firstDigit)
        numSecondDigit = Integer.Parse(secondDigit)
        numThirdDigit = Integer.Parse(thirdDigit)
        numFourthDigit = Integer.Parse(fourthDigit)
        newSecondDigit = numSecondDigit * 2
        newFourthDigit = numFourthDigit * 2
        fifthNumber = numFirstDigit + newSecondDigit + numThirdDigit + newFourthDigit

        fifthDigit = fifthNumber.Substring((fifthNumber.Length - 1), 1)
        TextBox1.Text = firstDigits + fifthDigit

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        If TextBox2.Text Like TextBox3.Text Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If

    End Sub
End Class
