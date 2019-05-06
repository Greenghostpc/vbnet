Public Class Yeeeet

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                movehorizontal(-10, PictureBox2)
            Case Keys.Right
                movehorizontal(10, PictureBox2)
            Case Keys.Up
                movevertical(-10, PictureBox2)
            Case Keys.Down
                movevertical(10, PictureBox2)
        End Select
    End Sub
    Sub movehorizontal(dist As Integer, p As PictureBox)
        p.Location = New Point(p.Location.X + dist, p.Location.Y)
    End Sub
    Sub movevertical(dist As Integer, p As PictureBox)
        p.Location = New Point(p.Location.X, p.Location.Y + dist)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim collision As Boolean = False

        For Each PictureBox In Me.Controls
            If PictureBox IsNot PictureBox1 AndAlso PictureBox1.Bounds.IntersectsWith(PictureBox.Bounds) Then
                collision = True
                Exit For
            End If
        Next
        If collision Then
            Me.BackColor = Color.Red
        Else
            Me.BackColor = Color.White
        End If
    End Sub


End Class
