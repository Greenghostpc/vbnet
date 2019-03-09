Public Class Form1
    Private Sub Box1_Click(sender As Object, e As EventArgs) Handles Box1.Click, Box2.Click, Box3.Click, Box4.Click, Box5.Click, Box6.Click, Box7.Click, Box8.Click, Box9.Click
        If sender.Text = " " Then
            sender.Text = "X"
        ElseIf sender.Text = "X" Then
            sender.Text = "O"
        Else
            sender.Text = " "
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Box1.Text = Box2.Text And Box2.Text = Box3.Text And Box1.Text <> " " Or
          Box4.Text = Box6665.Text And Box5.Text = Box6.Text And Box4.Text <> " " Or
          Box7.Text = Box8.Text And Box8.Text = Box9.Text And Box7.Text <> " " Or
          Box1.Text = Box4.Text And Box4.Text = Box7.Text And Box1.Text <> " " Or
          Box2.Text = Box5.Text And Box5.Text = Box8.Text And Box2.Text <> " " Or
          Box3.Text = Box6.Text And Box6.Text = Box9.Text And Box3.Text <> " " Or
          Box1.Text = Box5.Text And Box5.Text = Box9.Text And Box1.Text <> " " Or
          Box3.Text = Box5.Text And Box5.Text = Box7.Text And Box3.Text <> " " Then

            Me.BackColor = Color.Green
        Else
            Me.BackColor = Color.Red
        End If
    End Sub
End Class
