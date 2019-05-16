Public Class My_Gradient
    Public Property y As Integer
    Public Property x As Integer
    Public Property length As Integer
    Public Property width As Integer
    Public Property color1 As Color
    Public Property color2 As Color
    Public Property fill As Boolean



    Public Sub draw(e As PaintEventArgs)
        If fill Then
            Dim rect As New Rectangle(120, 10, 100, 50)
            Dim br As New Drawing2D.LinearGradientBrush(rect, color1, color2, Drawing2D.LinearGradientMode.ForwardDiagonal)

            e.Graphics.FillRectangle(br, x, y, length, width)
        Else
            e.Graphics.DrawRectangle(New Pen(color1), x, y, length, width)
        End If

    End Sub

End Class
