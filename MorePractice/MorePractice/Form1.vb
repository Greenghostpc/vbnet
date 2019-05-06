Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Integer
        For n As Integer = 1 To 100
            sum = sum + n
            ListBox1.Items.Add(n)
        Next
        Label1.Text = "sum of 1 to 100"
        TextBox1.Text = sum
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        Label1.Text = ""
        TextBox1.Text = ""

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sum As Integer
        For n As Integer = 2 To 200 Step 2
            sum = sum + n
            ListBox1.Items.Add(n)
        Next
        Label1.Text = "sum of 2 to 200 by 2's"
        TextBox1.Text = sum
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sum As Integer
        For n As Integer = -99 To 99 Step 2
            sum = sum + n
            ListBox1.Items.Add(n)
        Next
        Label1.Text = "sum of -99 to 99 by 2's"
        TextBox1.Text = sum
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sum As Integer
        For n As Integer = 0 To 100 Step 4
            sum = sum + n
            ListBox1.Items.Add(n)
        Next
        Label1.Text = "sum of 0 to 100 by 4's"
        TextBox1.Text = sum
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim sum As Integer
        For n As Integer = 50 To 0 Step -1
            sum = sum + n
            ListBox1.Items.Add(n)
        Next
        Label1.Text = "sum of 50 to 0"
        TextBox1.Text = sum
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim sum As Integer
        For n As Integer = 1000 To 2000 Step 100
            sum = sum + n
            ListBox1.Items.Add(n)
        Next
        Label1.Text = "sum of 1000 to 2000 by 100's"
        TextBox1.Text = sum
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim s As String = ""
        For n = 1 To 5
            s = s & "X"
            ListBox1.Items.Add(s)
        Next
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim s As String
        For n = 4 To 1 Step -1
            For k = 1 To 4
                If k <> n Then
                    s = s & "X"
                Else
                    s = s & "O"
                End If
            Next
            ListBox1.Items.Add(s)
        Next
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        For Each p In ImageList1.Images
            PictureBox1.Image = p
            System.Threading.Thread.Sleep(1000)
            Me.Refresh()

        Next
    End Sub
End Class
