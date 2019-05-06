Public Class MyRectangle
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
        If fill Then
            e.Graphics.FillRectangle(New SolidBrush(Color), x, y, Length, Width)
        Else
            e.Graphics.DrawRectangle(New Pen(Color), x, y, Length, Width)
        End If
    End Sub
End Class

