Public Class Form1
    Private Sub CountButton_Click(sender As Object, e As EventArgs) Handles countButton.Click
        countLabel.Text = ListBox1.Items.Count
    End Sub

    Private Sub RemoveButton_Click(sender As Object, e As EventArgs) Handles RemoveButton.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
    End Sub

    Private Sub addButton_Click(sender As Object, e As EventArgs) Handles addButton.Click
        For n As Integer = 1 To 10 Step 2

            ListBox1.Items.Add(TextBox1.Text & n)
        Next
    End Sub

    Private Sub MoveButton_Click(sender As Object, e As EventArgs) Handles MoveButton.Click
        If Not ListBox1.SelectedItem Is Nothing Then
            ListBox2.Items.Add(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub addNamesButton_Click(sender As Object, e As EventArgs) Handles addNamesButton.Click
        For Each n In Me.Controls
            ListBox2.Items.Add(n.name)
        Next
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Close()
    End Sub
End Class
