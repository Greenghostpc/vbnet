Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub colorButton_Click(sender As Object, e As EventArgs) Handles colorButton.Click
        Me.BackColor = Color.Moccasin
    End Sub

    Private Sub visualButton_Click(sender As Object, e As EventArgs) Handles visualButton.Click
        mainPictureBox.Visible = Not mainPictureBox.Visible
    End Sub
End Class