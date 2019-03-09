Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        IDTextBox.Text = "1"
        FNameTextBox.Text = "Joseph"
        LNameTextBox.Text = "Robinson"
        payTextBox.Text = "$1.3Mil"
        PictureBox1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        IDTextBox.Text = "2"
        FNameTextBox.Text = "Joe"
        LNameTextBox.Text = "Bob"
        payTextBox.Text = "$1500"
        PictureBox1.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        IDTextBox.Text = "3"
        FNameTextBox.Text = "Caillou"
        LNameTextBox.Text = "Conser"
        payTextBox.Text = "-$2500"
        'AddPicture
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        IDTextBox.Text = "4"
        FNameTextBox.Text = "Lamb"
        LNameTextBox.Text = ""
        payTextBox.Text = "$-100"
        'AddPicture
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        IDTextBox.Text = "5"
        FNameTextBox.Text = "Meme"
        LNameTextBox.Text = "Man"
        payTextBox.Text = "$2080"
        'AddPicture
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        IDTextBox.Text = "6"
        FNameTextBox.Text = "Null"
        LNameTextBox.Text = "Unknown"
        payTextBox.Text = ""
        PictureBox1.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Hide()
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        IDTextBox.Hide()
        FNameTextBox.Hide()
        LNameTextBox.Hide()
        payTextBox.Hide()
        Button1.Hide()
        Button2.Hide()
        Button3.Hide()
        Button4.Hide()
        Button5.Hide()
        Button6.Hide()
        Button8.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        OpenFileDialog1.ShowDialog()
        PictureBox1.Show()
        Label1.Show()
        Label2.Show()
        Label3.Show()
        Label4.Show()
        IDTextBox.Show()
        FNameTextBox.Show()
        LNameTextBox.Show()
        payTextBox.Show()
        Button1.Show()
        Button2.Show()
        Button3.Show()
        Button4.Show()
        Button5.Show()
        Button6.Show()
        Button8.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        OpenFileDialog1.ShowDialog()
    End Sub
End Class