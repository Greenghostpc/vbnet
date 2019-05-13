Public Class Form1
    Dim c As New Crane

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c.raise(1)
        Label2.Text = c.height
        If Label2.Text <> 12 Then
            PictureBox2.Top -= 15
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c.lower(1)
        Label2.Text = c.height
        If Label2.Text <> 4 Then
            PictureBox2.Top += 15
        End If
    End Sub
End Class
