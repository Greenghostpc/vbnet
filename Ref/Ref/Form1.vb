Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Declare Variable
        Dim num As Integer
        'Get value from form
        Integer.TryParse(inputTextBox.Text, num)
        'Put value on form
        outputLabel.Text = num
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Declare variables
        Dim answer As Integer
        Dim num1 As Integer
        Dim num2 As Integer
        'Get values from form
        Integer.TryParse(num1TextBox.Text, num1)
        Integer.TryParse(num2TextBox.Text, num2)
        'Do calculation
        answer = num1 + num2
        'Show results
        answerLabel.Text = answer
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Clear Listbox
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        'Add items to listbox
        ListBox1.Items.Add("A")
        For n = 1 To 30 Step 3
            ListBox1.Items.Add(n)
            ' For Loop

        Next

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Other For Loop
        For Each s In ListBox1.Items
            ListBox2.Items.Add(s)
        Next
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        'If then Example
        If TrackBar1.Value < 5 Then
            Me.BackColor = Color.Red
        Else
            Me.BackColor = Color.Green
        End If
    End Sub
End Class
