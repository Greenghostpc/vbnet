Public Class Form1
    Dim pictures(3) As PictureBox
    Dim points(1000) As Point
    Dim index As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pictures(0) = PictureBox1
        pictures(1) = PictureBox2
        pictures(2) = PictureBox3
        pictures(3) = PictureBox4
    End Sub

    Sub MoveHorizontal(dist As Integer, p As PictureBox)
        p.Location = New Point(p.Location.X + dist, p.Location.Y)
    End Sub

    Sub MoveVertical(dist As Integer, p As PictureBox)
        p.Location = New Point(p.Location.X, p.Location.Y + dist)
    End Sub

    Sub RotatePicture(r)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim r As New Random
        For Each p In pictures
            MoveHorizontal(r.Next(-10, 11), p)
            MoveVertical(r.Next(-10, 11), p)
        Next
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
