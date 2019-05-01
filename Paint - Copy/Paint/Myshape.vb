Public Class Myshape
    Public Property x As Integer
    Public Property y As Integer
    Public Property length As Integer
    Public Property width As Integer
    Public Property color As Color
    Public Property fill As Boolean

    Public Property gravityx As Integer
    Public Property gravityy As Integer
    Public Property gravity As Boolean


    Public Sub draw(e As PaintEventArgs)
        If gravity Then
            x = x + gravityx
            y = y + gravityy
        End If
        Dim points(2) As Point
        points(0) = New Point(x, y)
        points(1) = New Point(x, y - width)
        ' points(2) = New Point(x - length, y - width)
        points(2) = New Point(0, 0)
        If fill Then
            '  e.Graphics.FillPolygon(New SolidBrush(color), points)
            e.Graphics.FillPie(New SolidBrush(color), x, y, length, width, 45, 135)
        Else
            e.Graphics.DrawPolygon(New Pen(color), points)

        End If
    End Sub
End Class
