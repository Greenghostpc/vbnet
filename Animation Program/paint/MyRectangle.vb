Public Class myrectangle
    Public Property x As Integer
    Public Property y As Integer
    Public Property length As Integer
    Public Property width As Integer
    Public Property color As Color
    Public Property fill As Boolean


    Public Sub paint(e As Graphics)
        If fill Then
            e.FillRectangle(New SolidBrush(color), x, y, length, width)
        Else
            e.DrawRectangle(New Pen(color), x, y, length, width)
        End If
    End Sub

End Class
