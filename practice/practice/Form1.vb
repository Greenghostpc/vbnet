Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Integer
        ListBox1.Items.Clear()
        For n As Integer = 1 To 100
            sum = sum + n
            ListBox1.Items.Add(n)

        Next
        Label1.Text = "sum of 1 to 100"
        TextBox1.Text = sum
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim add As Integer
        For b As Integer = 2 To 200
            add = add + b
            ListBox1.Items.Add(b)
        Next
        Label1.Text = "sum of 2 to 200"
        TextBox1.Text = add
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim odd As Integer
        For c As Integer = -99 To 99 Step 2
            odd = odd + c
            ListBox1.Items.Add(c)

        Next
        Label1.Text = "sum of -99 to 99"
        TextBox1.Text = odd
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim cod As Integer
        For d As Integer = 0 To 100 Step 4
            cod = cod + d
            ListBox1.Items.Add(d)

        Next
        Label1.Text = "sum of 0 to 100"
        TextBox1.Text = cod
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim s As String = ""
        For n = 1 To 5
            For k = 1 To n
                s = s & "X"
                ListBox1.Items.Add(s)
            Next
        Next
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim s As Integer
        For n = 4 To 1 Step -1
            For k = 1 To 4
                If k <> n Then
                    s = s & "X"
                Else
                    s = s & "0"
                End If


            Next
            ListBox1.Items.Add(s)
            s = ""
        Next
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For Each p In ImageList1.Images
            PictureBox1.Image = p
            System.Threading.Thread.Sleep(600)
            Me.Refresh()

        Next
    End Sub
End Class
