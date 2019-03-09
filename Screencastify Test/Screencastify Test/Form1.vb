Public Class Form1
    Private Sub DarkKnightButton_Click(sender As Object, e As EventArgs) Handles DarkKnightButton.Click
        DisplayPictureBox.Image = DarkKnightPictureBox.Image
        NameLabel.Text = "DarkKnight"
        RarityLabel.Text = "Legendary"
        SeasonLabel.Text = "Season 2"
    End Sub

    Private Sub ReaperButton_Click(sender As Object, e As EventArgs) Handles ReaperButton.Click
        DisplayPictureBox.Image = ReaperPictureBox.Image
        NameLabel.Text = "Reaper"
        RarityLabel.Text = "Legendary"
        SeasonLabel.Text = "Season 3"

    End Sub

    Private Sub GhoulTrooperButton_Click(sender As Object, e As EventArgs) Handles GhoulTrooperButton.Click
        DisplayPictureBox.Image = GhoulTrooperPictureBox.Image
        NameLabel.Text = "Ghoul Trooper"
        RarityLabel.Text = "Epic"
        SeasonLabel.Text = "Season 1"
    End Sub

    Private Sub CrackshotButton_Click(sender As Object, e As EventArgs) Handles CrackshotButton.Click
        DisplayPictureBox.Image = CrackshotPictureBox.Image
        NameLabel.Text = "Crackshot"
        RarityLabel.Text = "Legendary"
        SeasonLabel.Text = "Season 2"
    End Sub
End Class
