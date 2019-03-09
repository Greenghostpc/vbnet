Public Class Form1
    Dim currentimage As Integer
    Private Sub showPictureButton_Click(sender As Object, e As EventArgs) Handles showPictureButton.Click
        For Each p In ImageList1.Images
            animalPictureBox.Image = p
            System.Threading.Thread.Sleep(600)
            Me.Refresh()
        Next


    End Sub

    Private Sub prevButton_Click(sender As Object, e As EventArgs) Handles prevButton.Click
        If currentimage > 0 Then
            currentimage = currentimage - 1
        End If
        ShowIndex()
    End Sub

    Private Sub nextButton_Click(sender As Object, e As EventArgs) Handles nextButton.Click
        If currentimage < ImageList1.Images.Count - 1 Then

        End If
        currentimage = currentimage + 1
        ShowIndex()
    End Sub

    Sub ShowIndex()
        indexLabel.Text = currentimage
        animalPictureBox.Image = ImageList1.Images(currentimage)
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        OpenFileDialog1.ShowDialog()
        PictureBox1.Load(OpenFileDialog1.FileName)
        ImageList1.Images.Add(PictureBox1.Image)

        PictureBox1.Image = ImageList1.Images(0) ' Show the first picture 
    End Sub
End Class
