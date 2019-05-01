Public Class Form1
    Dim current As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f As New Form2
        If f.ShowDialog = DialogResult.OK Then
            additem(f.firstTextBox.Text, f.lastTextBox.Text, f.emailTextBox.Text, f.brandTextBox.Text, f.lengthTextBox.Text, f.heightTextBox.Text, photoPictureBox.Image)
        End If
    End Sub

    Sub additem(first As String, last As String, email As String, brand As String, length As String, height As String, photo As Image)
        firstComboBox.Items.Add(first)
        lastComboBox.Items.Add(last)
        emailComboBox.Items.Add(email)
        brandComboBox.Items.Add(brand)
        lengthComboBox.Items.Add(length)
        heightComboBox.Items.Add(height)
        ImageList1.Images.Add(photo)
    End Sub
    Private Sub firstComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles firstComboBox.SelectedIndexChanged
        SetItem(firstComboBox.SelectedIndex)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SetItem(0)
        current = 0
    End Sub
    Sub SetItem(i As Integer)
        firstComboBox.SelectedIndex = i
        lastComboBox.SelectedIndex = i
        emailComboBox.SelectedIndex = i
        brandComboBox.SelectedIndex = i
        lengthComboBox.SelectedIndex = i
        heightComboBox.SelectedIndex = i
        photoPictureBox.Image = ImageList1.Images(i)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If current < firstComboBox.Items.Count - 1 Then
            SetItem(current)
            current = current + 1
        Else
            SetItem(0)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If current > 0 Then
            current = current - 1
            SetItem(current)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim s As Integer
        s = firstComboBox.Items.Count - 1
        SetItem(s)
        s = current
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
