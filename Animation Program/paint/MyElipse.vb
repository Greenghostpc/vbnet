Public Class MyEllipse
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
        If fill Then
            e.Graphics.FillEllipse(New SolidBrush(color), x, y, length, width)
        Else
            e.Graphics.DrawEllipse(New Pen(color), x, y, length, width)
        End If
    End Sub

End Class
