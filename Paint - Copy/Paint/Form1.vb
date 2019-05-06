Public Class Form1
    Dim c As Color
    Dim shapes As New Collection
    Dim currentshape As String

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        Me.Refresh()
    End Sub
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Me.Refresh()
    End Sub
    Sub createrectangle(e As MouseEventArgs)
        Dim r As New MyRectangle
        r.x = e.X
        r.y = e.Y
        r.length = TrackBar1.Value
        r.width = TrackBar2.Value
        r.color = c
        r.fill = CheckBox1.Checked
        shapes.Add(r)

    End Sub
    Sub creategradient(e As MouseEventArgs)
        Dim r As New Mygradient
        r.x = e.X
        r.y = e.Y
        r.length = TrackBar1.Value
        r.width = TrackBar2.Value
        r.color1 = Button57.BackColor
        r.color2 = Button58.BackColor
        r.fill = CheckBox1.Checked
        shapes.Add(r)

    End Sub
    Sub createellipse(e As MouseEventArgs)
        Dim r As New myElipse
        r.x = e.X
        r.y = e.Y
        r.length = TrackBar1.Value
        r.width = TrackBar2.Value
        r.color = c
        r.fill = CheckBox1.Checked
        r.gravity = CheckBox2.Checked
        r.gravityx = TrackBar3.Value
        r.gravityy = TrackBar4.Value
        shapes.Add(r)

    End Sub
    Sub createMyshape(e As MouseEventArgs)
        Dim r As New Myshape
        r.x = e.X
        r.y = e.Y
        r.length = TrackBar1.Value
        r.width = TrackBar2.Value
        r.color = c
        r.fill = CheckBox1.Checked
        r.gravity = CheckBox2.Checked
        r.gravityx = TrackBar3.Value
        r.gravityy = TrackBar4.Value
        shapes.Add(r)

    End Sub
    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        For Each s In shapes
            s.draw(e)
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Refresh()
    End Sub


    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left Then
            Select Case currentshape
                Case "Rectangle"
                    createrectangle(e)
                Case "Ellipse"
                    createellipse(e)
                Case "Picture"
                    createpicture(e)
                Case "Gradient"
                    creategradient(e)
                Case "Myshape"
                    createMyshape(e)
            End Select
            Me.Refresh()
        End If
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button48.Click, Button47.Click, Button46.Click, Button45.Click, Button44.Click, Button43.Click, Button42.Click, Button41.Click, Button40.Click, Button4.Click, Button39.Click, Button38.Click, Button37.Click, Button36.Click, Button35.Click, Button34.Click, Button33.Click, Button32.Click, Button31.Click, Button30.Click, Button3.Click, Button29.Click, Button28.Click, Button27.Click, Button26.Click, Button25.Click, Button24.Click, Button23.Click, Button22.Click, Button21.Click, Button20.Click, Button2.Click, Button19.Click, Button18.Click, Button17.Click, Button16.Click, Button15.Click, Button14.Click, Button13.Click, Button12.Click, Button11.Click, Button10.Click, Button1.Click
        c = sender.backcolor
        Me.Refresh()

    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        shapes.Clear()
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        currentshape = "Rectangle"
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        currentshape = "Ellipse"
    End Sub

    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles TrackBar3.Scroll
        Me.Refresh()
    End Sub

    Private Sub TrackBar4_Scroll(sender As Object, e As EventArgs) Handles TrackBar4.Scroll
        Me.Refresh()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))
        bmp.Save(SaveFileDialog1.FileName)

    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        SaveFileDialog1.ShowDialog()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs)
        GroupBox1.Visible = False
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        If shapes.Count > 0 Then
            shapes.Remove(shapes.Count)
        End If
    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        c = Me.BackColor
        Me.Refresh()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        currentshape = "Picture"
    End Sub
    Sub createpicture(e As MouseEventArgs)
        Dim r As New Mypicture
        r.x = e.X
        r.y = e.Y
        r.length = TrackBar1.Value
        r.height = TrackBar2.Value
        r.picture = PictureBox1.Image
        shapes.Add(r)

    End Sub

    Private Sub Button57_Click(sender As Object, e As EventArgs) Handles Button57.Click
        ColorDialog1.ShowDialog()
        sender.BackColor = ColorDialog1.Color
    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        currentshape = "Gradient"
    End Sub

    Private Sub ColorsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorsToolStripMenuItem.Click
        If GroupBox1.Visible = True Then
            GroupBox1.Visible = False
        Else
            GroupBox1.Visible = True
        End If
    End Sub

    Private Sub GravityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GravityToolStripMenuItem.Click
        If GroupBox2.Visible = True Then
            GroupBox2.Visible = False
        Else
            GroupBox2.Visible = True
        End If
    End Sub

    Private Sub ToolsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolsToolStripMenuItem1.Click
        If GroupBox3.Visible = True Then
            GroupBox3.Visible = False
        Else
            GroupBox3.Visible = True
        End If
    End Sub

    Private Sub Button53_Click_1(sender As Object, e As EventArgs) Handles Button53.Click
        currentshape = "Myshape"
    End Sub
End Class
