Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Hide()
        PictureBox2.Hide()
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Tile" Then
            PictureBox1.Hide()
            PictureBox2.Show()
            CostLabel.Text = "$5.99/sq ft"
        End If
        If ComboBox1.SelectedItem = "Carpet" Then
            PictureBox2.Hide()
            PictureBox1.Show()
            CostLabel.Text = "$2.99/sq ft"
        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AreaLabel.Text = (LengthBox.Text * WidthBox.Text)
        If ComboBox1.SelectedItem = "Tile" Then
            TotalCostLabel.Text = (AreaLabel.Text * 5.99)
        End If
        If ComboBox1.SelectedItem = "Carpet" Then
            TotalCostLabel.Text = (AreaLabel.Text * 2.99)
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Button2.Enabled = True
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        Button3.Enabled = True
    End Sub
End Class
