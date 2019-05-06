Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim age As Integer
        If Integer.TryParse(TextBox1.Text, age) Then

            If age > 17 Then
                Label1.Text = "You can vote."
                Me.BackColor = Color.Green
                Form2.ShowDialog()
            Else
                Label1.Text = "You can't vote"
                Me.BackColor = Color.Red
                Form3.ShowDialog()
            End If
        Else
            MessageBox.Show("Invalid Age")
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, AddToolStripMenuItem.Click
        Dim f As New Form4
        If f.ShowDialog() = DialogResult.OK Then
            ListBox1.Items.Add(f.fnameTextBox.Text & " " & f.lnameTextBox.Text)

        End If
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class