Public Class Form1
    Dim current As Integer


    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click, Button1.Click

        Dim f As New Form2
        If f.ShowDialog() = DialogResult.OK Then


            songComboBox1.Items.Add(f.TextBox1.Text)
            songComboBox2.Items.Add(f.TextBox2.Text)
            songComboBox3.Items.Add(f.TextBox3.Text)
            songComboBox4.Items.Add(f.TextBox4.Text)
            songComboBox5.Items.Add(f.TextBox5.Text)
            songComboBox6.Items.Add(f.TextBox6.Text)

            songImageList.Images.Add(f.PictureBox1.Image)


        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub songComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles songComboBox1.SelectedIndexChanged
        songComboBox2.SelectedIndex = songComboBox1.SelectedIndex
        songComboBox3.SelectedIndex = songComboBox1.SelectedIndex
        songComboBox4.SelectedIndex = songComboBox1.SelectedIndex
        songComboBox5.SelectedIndex = songComboBox1.SelectedIndex
        songComboBox6.SelectedIndex = songComboBox1.SelectedIndex
        PictureBox1.Image = songImageList.Images(songComboBox1.SelectedIndex)

    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If current < songComboBox1.Items.Count - 1 Then
            current = current + 1
            SetItem(current)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SetItem(0)
        current = 0
    End Sub
    Sub SetItem(i As Integer)
        songComboBox1.SelectedIndex = i
        songComboBox2.SelectedIndex = i
        songComboBox3.SelectedIndex = i
        songComboBox4.SelectedIndex = i
        songComboBox5.SelectedIndex = i
        songComboBox6.SelectedIndex = i
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If current < songComboBox1.Items.Count - 1 Then
            current = current + 1
            SetItem(current)
        End If
    End Sub
End Class
