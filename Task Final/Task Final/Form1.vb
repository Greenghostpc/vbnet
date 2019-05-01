Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False
        GroupBox2.Visible = False
    End Sub


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            GroupBox1.Visible = True
            GroupBox2.Visible = False
        End If


    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        If RadioButton2.Checked = True Then
            GroupBox2.Visible = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Tile" Then
            PictureBox1.Image = My.Resources.tile
            Label8.Text = "5.99"
        End If
        If ComboBox1.Text = "Carpet" Then
            PictureBox1.Image = My.Resources.carpet
            Label8.Text = "2.99"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim length As Decimal
        Dim width As Decimal
        Dim area As Decimal
        Dim total As Decimal
        Dim matPrice As Decimal

        Decimal.TryParse(TextBox1.Text, length)
        Decimal.TryParse(TextBox2.Text, width)
        Decimal.TryParse(TextBox1.Text, area)
        Decimal.TryParse(Label8.Text, matPrice)

        total = (length * width) * matPrice
        Label3.Text = total.ToString("C2")
    End Sub
End Class
