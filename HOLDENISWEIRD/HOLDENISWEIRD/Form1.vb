Public Class Form1
    Dim str As String
    Private Sub MaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        str = TextBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lengthLabel.Text = str.Length
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        trimLabel.Text = str.Trim
        TextBox1.Text = str.Trim
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim s As Integer
        Dim c As Integer

        Integer.TryParse(TextBox2.Text, s)
        Integer.TryParse(TextBox3.Text, c)

        removeLabel.Text = str.Remove(s, c)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim s As Integer
        Integer.TryParse(sTextBox.Text, s)
        insertlabel.Text = str.Insert(s, valueTextBox.Text)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Containlabel.Text = str.Contains(cTextBox.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim c, s As Integer
        Integer.TryParse(s, scTextBox.Text)
        Integer.TryParse(c, ccTextBox.Text)
        substringLabel.Text = str.Substring(s, c)
    End Sub


    Private Sub TextBox5_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox5.TextChanged, TextBox4.TextChanged
        If TextBox4.Text.ToUpper Like TextBox5.Text Then
            Me.BackColor = Color.GreenYellow
        Else
            Me.BackColor = Color.Tomato
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim s As String
        s = InputBox("Enter a word")
        Dim d As String
        For n As Integer = 0 To s.Length - 1
            d += "-"
        Next
        TextBox6.Text = d
    End Sub
End Class
