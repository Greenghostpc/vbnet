Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s1 As Integer
        Dim s2 As Integer
        Dim s3 As Integer
        Integer.TryParse(Side1TextBox.Text, s1)
        Integer.TryParse(Side2TextBox.Text, s2)
        Integer.TryParse(Side3TextBox.Text, s3)
        Dim a As Integer
        Dim p As Integer
        Getboth(s1, s2, s3, a, p)
        pLabel.Text = perimeter(s1, s2, s3)
        aLabel.Text = area(s1, s2, s3)
    End Sub
    Function perimeter(s1 As Integer,
                       s2 As Integer,
                       s3 As Integer) As Integer
        Return s1 + s2 + s3
    End Function
    Function area(s1 As Integer, s2 As Integer, s3 As Integer) As Decimal
        Dim s As Decimal
        s = perimeter(s1, s2, s3) / 2
        Return Math.Sqrt(s * (s - s1) * (s - s2) * (s - s3))
    End Function
    Sub Getboth(s1 As Integer, s2 As Integer, s3 As Integer,
                 ByRef p As Decimal,
                 ByRef a As Decimal)
        p = perimeter(s1, s2, s3)
        a = area(s1, s2, s3)
    End Sub
End Class
