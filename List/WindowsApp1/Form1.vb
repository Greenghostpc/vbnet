Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        For n As Integer = 1 To 10
            ListBox1.Items.Add(TextBox1.Text & n)
        Next
    End Sub

    Private Sub CountButton_Click(sender As Object, e As EventArgs) Handles CountButton.Click
        CountLabel.Text = ListBox1.Items.Count
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ListBox1.Items.Clear()
        CountLabel.Text = " "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles MoveButton.Click
        If Not ListBox1.SelectedItem Is Nothing Then
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub NameButton_Click(sender As Object, e As EventArgs) Handles NameButton.Click
        For Each X In Me.Controls
            ListBox1.Items.Add(X.name)
        Next
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
