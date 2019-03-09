Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Integer
        ListBox1.Items.Clear()
        For n As Integer = 100 To 1 Step -1
            sum = sum + n
            ListBox1.Items.Add(n)
        Next
        TextBox1.Text = sum
        Label1.Text = "sum of 1 to 100"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sum As Integer
        ListBox1.Items.Clear()
        For n As Integer = -99 To 99 Step 2
            sum = sum + n
            ListBox1.Items.Add(n)
        Next
        TextBox1.Text = sum
        Label1.Text = "Odds from -99 to 99"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sum As Integer
        ListBox1.Items.Clear()
        For n As Integer = 0 To 100 Step 4
            sum = sum + n
            ListBox1.Items.Add(n)
        Next
        TextBox1.Text = sum
        Label1.Text = "0 to 100 by 4"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sum As Integer
        ListBox1.Items.Clear()
        For n As Integer = 50 To 0 Step -1
            sum = sum + n
            ListBox1.Items.Add(n)
        Next
        TextBox1.Text = sum
        Label1.Text = "50 to 0"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sum As Integer
        ListBox1.Items.Clear()
        For n As Integer = 1000 To 2000 Step 100
            sum = sum + n
            ListBox1.Items.Add(n)
        Next
        TextBox1.Text = sum
        Label1.Text = "1000 To 2000 By 100"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim sum As String
        ListBox1.Items.Clear()
        For n = 1 To 5 Step 1
            sum = sum + n
            ListBox1.Items.Add(n)
        Next
        TextBox1.Text = sum
        Label1.Text = "Adding X"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim s As String = String.Empty
        For n = 4 To 1 Step 1
            For k = 1 To 4
                If k = n Then
                    s = s & "O"
                Else
                    s = s & "X"
                End If
            Next
            ListBox1.Items.Add(s)
            s = String.Empty
        Next
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        For Each p In ImageList1.Images
            PictureBox1.Image = p
            System.Threading.Thread.Sleep(1000)
            Me.Refresh()
        Next
    End Sub
End Class
