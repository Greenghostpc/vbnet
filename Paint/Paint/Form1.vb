Public Class Form1
    Dim c As Color
    Dim Shapes As New Collection
    Dim currentshape As String
    Sub CreateEllipse(e As MouseEventArgs)
        Dim r As New MyEllipse
        r.x = e.X
        r.y = e.Y
        r.Length = TrackBar1.Value
        r.Width = TrackBar2.Value
        r.Color = c
        r.fill = fillCheckBox.Checked
        r.gravity = gravityCheckBox.Checked
        r.gravityx = TrackBar3.Value
        r.gravityy = TrackBar4.Value
        Shapes.Add(r)
        Me.Refresh()
    End Sub
    Sub CreateRectangle(e As MouseEventArgs)
        Dim r As New MyRectangle
        r.x = e.X
        r.y = e.Y
        r.Length = TrackBar1.Value
        r.Width = TrackBar2.Value
        r.Color = c
        r.fill = fillCheckBox.Checked
        r.gravity = gravityCheckBox.Checked
        r.gravityx = TrackBar3.Value
        r.gravityy = TrackBar4.Value
        Shapes.Add(r)
        Me.Refresh()
    End Sub
    Sub CreatePicture(e As MouseEventArgs)
        Dim r As New MyPicture
        r.x = e.X
        r.y = e.Y
        r.Length = TrackBar1.Value
        r.height = TrackBar2.Value
        r.picture = PictureBox1.Image
        Shapes.Add(r)
        Me.Refresh()
    End Sub
    Sub CreateGradient(e As MouseEventArgs)
        Dim r As New MyGradient
        r.x = e.X
        r.y = e.Y
        r.Length = TrackBar1.Value
        r.Width = TrackBar2.Value
        r.Color1 = Button17.BackColor
        r.Color2 = Color.Blue
        r.fill = fillCheckBox.Checked
        Shapes.Add(r)
        Me.Refresh()
    End Sub
    Sub CreateShape(e As MouseEventArgs)
        Dim r As New MyShape
        r.x = e.X
        r.y = e.Y
        r.Length = TrackBar1.Value
        r.Width = TrackBar2.Value
        r.Color = c
        r.fill = fillCheckBox.Checked
        r.gravity = gravityCheckBox.Checked
        r.gravityx = TrackBar3.Value
        r.gravityy = TrackBar4.Value
        Shapes.Add(r)
        Me.Refresh()
    End Sub
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        For Each s In Shapes
            s.draw(e)
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click
        c = sender.backcolor
        Me.Refresh()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Refresh()
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left Then
            Select Case currentshape
                Case "Rectangle"
                    CreateRectangle(e)
                Case "Ellipse"
                    CreateEllipse(e)
                Case "Picture"
                    CreatePicture(e)
                Case "Gradient"
                    CreateGradient(e)
                Case "Shape"
                    CreateShape(e)
            End Select
            Me.Refresh()
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button10.Click
        c = sender.backcolor
        Me.Refresh()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        ColorDialog1.ShowDialog()
        c = ColorDialog1.Color
        Me.Refresh()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Shapes.Clear()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Rectangle" Then
            currentshape = "Rectangle"
        Else
            If ComboBox1.Text = "Ellipse" Then
                currentshape = "Ellipse"
            Else
                If ComboBox1.Text = "Picture" Then
                    currentshape = "Picture"
                Else
                    If ComboBox1.Text = "Gradient" Then
                        currentshape = "Gradient"
                    Else
                        If ComboBox1.Text = "Shape" Then
                            currentshape = "Shape"
                        End If
                    End If
                End If
            End If
            End If
    End Sub
    'Picture
    'Gradient
    'Shape

    Private Sub gravityCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles gravityCheckBox.CheckedChanged

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))
        bmp.Save("screenshot.png")

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        currentshape = "Picture"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        currentshape = "Gradient"
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        If Shapes.Count > 0 Then
            Shapes.Remove(Shapes.Count)
        End If
    End Sub
End Class
