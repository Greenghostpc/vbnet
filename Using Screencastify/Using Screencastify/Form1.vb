Public Class Form1
    Private Sub teslamodelsButton_Click(sender As Object, e As EventArgs) Handles teslamodelsButton.Click
        displayPictureBox.Image = teslamodelsPictureBox.Image
        nameLabel.Text = "Tesla Model S"
        ToolTip1.SetToolTip(displayPictureBox, "This is a Tesla model S")
    End Sub

    Private Sub teslamodelxButton_Click(sender As Object, e As EventArgs) Handles teslamodelxButton.Click
        displayPictureBox.Image = teslamodelxPictureBox.Image
        nameLabel.Text = "Tesla Model X"
        companyLabel.Text = "$79,500"
        mileageLabel.Text = "514 at 45mph a single charge"
    End Sub
End Class
