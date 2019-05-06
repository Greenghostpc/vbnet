Public Class Fractions
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim d As Integer
        Dim f1 As Fraction
        Dim f2 As Fraction
        Dim answer As Fraction
        Integer.TryParse(TextBox1.Text, n)
        Integer.TryParse(TextBox2.Text, d)
        f1 = New Fraction(n, d)
        Integer.TryParse(TextBox3.Text, n)
        Integer.TryParse(TextBox4.Text, d)
        f2 = New Fraction(n, d)
        answer = f1.multiply(f2)
        TextBox5.Text = answer.numer
        TextBox6.Text = answer.denom
        Select Case ComboBox1.Text
            Case "*"
                answer = f1.multiply(f2)
            Case "/"
                answer = f1.divide(f2)
            Case Else
                answer = New Fraction(0, 0)
        End Select
    End Sub
End Class