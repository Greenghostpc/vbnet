Public Class MyGradient
    Public Property x As Integer
    Public Property y As Integer
    Public Property Length As Integer
    Public Property Width As Integer
    Public Property Color1 As Color
    Public Property Color2 As Color
    Public Property fill As Boolean

    Public Sub Draw(e As PaintEventArgs)
        If fill Then
            Dim rect As New Rectangle(120, 10, 100, 50)
            Dim br As New Drawing2D.LinearGradientBrush(rect, Color1, Color2, Drawing2D.LinearGradientMode.ForwardDiagonal)
            e.Graphics.FillRectangle(br, x, y, Length, Width)
        Else
            e.Graphics.DrawRectangle(New Pen(Color1), x, y, Length, Width)
        End If
    End Sub
End Class
