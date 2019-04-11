Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub modelsButton_Click(sender As Object, e As EventArgs) Handles modelsButton.Click
        displayPictureBox.Image = modelsPictureBox.Image
        nameLabel.Text = "Model S"
        ToolTip1.SetToolTip(displayPictureBox, "This is a Tesla Model S")
    End Sub

    Private Sub modelxButton_Click(sender As Object, e As EventArgs) Handles modelxButton.Click
        displayPictureBox.Image = modelxPictureBox.Image
        nameLabel.Text = " Model x"
        ToolTip1.SetToolTip(displayPictureBox, "This is a Tesla Model X")
    End Sub

    Private Sub modelsButton_MouseMove(sender As Object, e As MouseEventArgs) Handles modelsButton.MouseMove
        displayPictureBox.Image = modelsPictureBox.Image
        nameLabel.Text = "Model S"
        ToolTip1.SetToolTip(displayPictureBox, "This is a Tesla Model S")
    End Sub

    Private Sub modelxButton_MouseMove(sender As Object, e As MouseEventArgs) Handles modelxButton.MouseMove
        displayPictureBox.Image = modelxPictureBox.Image
        nameLabel.Text = "Model X"
        ToolTip1.SetToolTip(displayPictureBox, "This is a Tesla Model X")
    End Sub
End Class
