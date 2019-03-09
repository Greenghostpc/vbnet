Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'declare vairables
        Dim num As Integer

        'get val from form
        Integer.TryParse(inputTextBox.Text, num)

        'Put val onto form
        OutputLabel.Text = num
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'declare vars
        Dim num1 As Integer
        Dim num2 As Integer

        'get values
        Integer.TryParse(tb1.Text, num1)
        Integer.TryParse(tb2.Text, num2)

        'calc
        Dim answer As Integer
        answer = num1 + num2

        'show ans
        ansl.Text = answer

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ListBox2.Items.Clear()

        ListBox2.Items.Add("A")

        For n = 1 To 20 Step 2
            ListBox2.Items.Add(n)
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For Each s In ListBox1.Items

        Next
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value < 5 Then
            Me.BackColor = Color.Firebrick
        Else
            Me.BackColor = Color.AliceBlue
        End If
    End Sub
End Class
