Public Class Form1
    Dim pictures(3) As PictureBox
    Dim goals(1) As PictureBox
    Dim r As New Random
    Dim points(1000) As Point
    Dim index As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pictures(0) = guy4
        pictures(1) = guy1
        pictures(2) = guy3
        pictures(3) = guy2
        goals(1) = goal1
        goals(0) = goal2
    End Sub
    Sub MoveHorizontal(dist As Integer, p As PictureBox)
        p.Location = New Point(p.Location.X + dist, p.Location.Y)
    End Sub
    Sub MoveVertical(dist As Integer, p As PictureBox)
        p.Location = New Point(p.Location.X, p.Location.Y + dist)
    End Sub
    Sub RotatePicture(r)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        For Each pict In pictures
            MoveHorizontal(10, pictures(0))
            rotatePicture(RotateFlipType.Rotate90FlipX, pict)
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For Each pict In pictures
            MoveVertical(r.Next(0, 1), pict)
            MoveHorizontal(r.Next(-1, 1), pict)
        Next
        Static direction As Integer = 5

        If guy1.Location.Y < 0 Then
            direction = 5
        ElseIf guy1.Location.Y > 170 Then
            direction = -5
        End If

        MoveVertical(direction, guy1)
        Debug.Print(guy1.Location.Y)

        If guy4.Location.Y < 0 Then
            direction = 5
        ElseIf guy4.Location.Y > 170 Then
            direction = -5
        End If

        MoveVertical(direction, guy4)

        If guy3.Location.Y < 0 Then
            direction = 5
        ElseIf guy3.Location.Y > 170 Then
            direction = -5
        End If

        MoveVertical(direction, guy3)

        If guy2.Location.Y < 0 Then
            direction = 5
        ElseIf guy2.Location.Y > 170 Then
            direction = -5
        End If

        MoveVertical(direction, guy2)


    End Sub
    Sub rotatePicture(r As RotateFlipType, p As PictureBox)
        p.Image.RotateFlip(r)
        Me.Refresh()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                MoveHorizontal(-10, Avatar)
            Case Keys.Right
                MoveHorizontal(10, Avatar)
            Case Keys.Up
                MoveVertical(-10, Avatar)
            Case Keys.Down
                MoveVertical(10, Avatar)
            Case Keys.J
                Timer3.Enabled = True
        End Select
        points(index) = Avatar.Location
        index += 1
        SoccerBallCollision()
        SoccerBallgoal()

        If Avatar.Bounds.IntersectsWith(Label1.Bounds) Then

        End If
    End Sub
    Function Checkcollision(dist As Integer, p As PictureBox) As Boolean
        Dim previous As Point = p.Location
        p.Location = New Point(p.Location.X, p.Location.Y + dist)
        For Each PictureBox In Me.Controls
            If PictureBox IsNot p AndAlso p.Bounds.IntersectsWith(PictureBox(3).bounds) Then
                Checkcollision = True
                BackColor = Color.Red

                Return True
            End If
        Next
        If p Is Avatar And (Avatar Is guy4 Or
                   Avatar Is guy1) Then
            MessageBox.Show(" You lost the Game!")
        End If
        Return True
    End Function

    Function SoccerBallCollision()
        Dim collision As Boolean = False
        For Each guy In pictures
            If guy IsNot Avatar AndAlso Avatar.Bounds.IntersectsWith(guy.Bounds) Then
                collision = True
                Exit For
            End If
        Next
        If collision Then
            Me.BackColor = Color.Red
            Avatar.Top = 233
            Avatar.Left = 351
        Else
            Me.BackColor = Color.White
        End If
    End Function
    Private Sub Avatar_Click(sender As Object, e As EventArgs) Handles Avatar.Click

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Static counter As Integer
        If counter < 8 Then
            Avatar.Location = New Point(Avatar.Location.X, Avatar.Location.Y - 5)
        Else
            Avatar.Location = New Point(Avatar.Location.X, Avatar.Location.Y + 5)
        End If
        counter = counter + 1
        If counter = 16 Then
            counter = 0
            Timer3.Enabled = False
        End If
    End Sub
    Function SoccerBallgoal()
        Dim collision As Boolean = False
        For Each goal In goals
            If goal IsNot Avatar AndAlso Avatar.Bounds.IntersectsWith(goal.Bounds) Then
                collision = True
                Exit For
            End If
        Next
        If collision Then
            MessageBox.Show(" You Won the Game!")
        End If
    End Function
End Class
