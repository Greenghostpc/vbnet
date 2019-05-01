Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, d As Integer
        Dim f1, f2, answer As Fraction
        Integer.TryParse(TextBox1.Text, n)
        Integer.TryParse(TextBox2.Text, d)
        f1 = New Fraction(n, d)
        Integer.TryParse(TextBox3.Text, n)
        Integer.TryParse(TextBox4.Text, d)
        f2 = New Fraction(n, d)
        Select Case ComboBox1.Text
            Case "*"
                answer = f1.multiply(f2)
            Case "/"
                answer = f1.divide(f2)
            Case "+"
                answer = f1.add(f2)
            Case "-"
                answer = f1.subtract(f2)
            Case Else
                answer = New Fraction(0, 0)

        End Select
        TextBox5.Text = answer.numer
        TextBox6.Text = answer.denom
    End Sub
End Class
