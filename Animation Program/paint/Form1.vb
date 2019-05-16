Public Class Form1
    Dim c As Color
    Dim shapes As New Collection
    Dim currentshape As String


    Sub createrectangular(e As MouseEventArgs)

        Dim r As New myrectangle
        r.x = e.X
        r.y = e.Y
        r.color = c
        r.length = TrackBar1.Value
        r.width = TrackBar2.Value
        r.fill = checkbox1.checked
        shapes.Add(r)
    End Sub

    Sub createellipse(e As MouseEventArgs)

        Dim r As New MyEllipse
        r.x = e.X
        r.y = e.Y
        r.color = c
        r.length = TrackBar1.Value
        r.width = TrackBar2.Value
        r.fill = CheckBox1.Checked
        r.gravity = CheckBox2.Checked
        r.gravityx = TrackBar3.Value
        r.gravityy = TrackBar4.Value
        shapes.Add(r)
    End Sub
    Sub createMyShape(e As MouseEventArgs)

        Dim r As New MyShape
        r.x = e.X
        r.y = e.Y
        r.color = c
        r.length = TrackBar1.Value
        r.width = TrackBar2.Value
        r.fill = CheckBox1.Checked
        r.gravity = CheckBox2.Checked
        r.gravityx = TrackBar3.Value
        r.gravityy = TrackBar4.Value
        shapes.Add(r)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Refresh()
    End Sub


    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        For Each s In shapes
            s.draw(e)
        Next
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Select Case currentshape
                Case "Rectangle"
                    createrectangular(e)
                Case "Ellipse"
                    createellipse(e)
                Case "MyShape"
                    createMyShape(e)
            End Select
            Me.Refresh()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        shapes.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        currentshape = "Rectangle"
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs)
        currentshape = "Ellipse"
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))
        bmp.Save("screenshot.png")

    End Sub

    Private Sub save_Click(sender As Object, e As EventArgs)
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        shapes.Clear()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)
        currentshape = "MyShape"
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        If shapes.Count > 0 Then
            shapes.Remove(shapes.Count)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Rectangle" Then
            currentshape = "Rectangle"
        End If
        If ComboBox1.Text = "Ellipse" Then
            currentshape = "Ellipse"
        End If
        If ComboBox1.Text = "Gradient" Then
            currentshape = "Gradient"
        End If
        If ComboBox1.Text = "Shape" Then
            currentshape = "MyShape"
        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        ColorDialog1.ShowDialog()
        c = ColorDialog1.Color
        Me.Refresh()
    End Sub

    Private Sub ClearToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem1.Click
        shapes.Clear()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim tempfile As String = My.Computer.FileSystem.GetTempFileName()
        Dim bmp As New Bitmap(Me.Width, Me.Height)
        Me.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))
        bmp.Save(tempfile)
        sender.Load(tempfile)

    End Sub
End Class