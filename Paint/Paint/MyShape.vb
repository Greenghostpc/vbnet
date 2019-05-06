Public Class MyShape
    Public Property x As Integer
    Public Property y As Integer
    Public Property Length As Integer
    Public Property Width As Integer
    Public Property Color As Color
    Public Property fill As Boolean
    Public Property gravityx As Integer
    Public Property gravityy As Integer
    Public Property gravity As Boolean

    Public Sub Draw(e As PaintEventArgs)
        If gravity Then
            x = x + gravityx
            y = y + gravityy
        End If
        Dim points(2) As Point
        points(0) = New Point(x, y)
        points(1) = New Point(x, y - Width)
        points(2) = New Point(x - Length, y)
        If fill Then
            e.Graphics.FillPie(New SolidBrush(Color), x, y, Width, Length, 45, 135)
        Else
            e.Graphics.DrawPolygon(New Pen(Color), points)
        End If
    End Sub
End Class
