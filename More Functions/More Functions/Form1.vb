Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s1 As Integer
        Dim s2 As Integer
        Dim s3 As Integer
        Integer.TryParse(TextBox1.Text, s1)
        Integer.TryParse(TextBox2.Text, s2)
        Integer.TryParse(TextBox3.Text, s3)
        Label4.Text = perimeter(s1, s2, s3)
    End Sub
    Function perimeter(s1 As Integer, s2 As Integer, s3 As Integer) As Decimal
        Return s1 + s2 + s3
    End Function
    Function area(s1 As Integer, s2 As Integer, s3 As Integer) As Decimal
        Dim s As Integer
        s = perimeter(s1, s2, s3) / 2
        area = Math.Sqrt(s * (s - s1) * (s - s2) * (s - s3))
    End Function
    Sub getboth(s1 As Integer, s2 As Integer, s3 As Integer, ByRef a As Decimal, ByRef p As Decimal)
        a = area(s1, s2, s3)
        p = perimeter(s1, s2, s3)
    End Sub
End Class
