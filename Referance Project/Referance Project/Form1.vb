Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Declare Variable
        Dim num As Integer
        'Get Value From Form
        Integer.TryParse(inputTextBox.Text, num)
        'Put Value On Form
        outputLabel.Text = num

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Declare Variables
        Dim answer As Integer
        Dim num1 As Integer
        Dim num2 As Integer
        'Get Values
        Integer.TryParse(num1TextBox.Text, num1)
        'Do Calculation
        answer = num1 + num2
        'Show Results
        answerLabel.Text = answer

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'clear listbox
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        'add items to listbox
        ListBox1.Items.Add("A")
        For n = 1 To 5
            ListBox1.Items.Add(n)
            'for loop

        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'other for loop
        For Each s In ListBox1.Items
            ListBox2.Items.Add(s)

        Next
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        'if then example
        If TrackBar1.Value < 5 Then
            Me.BackColor = Color.Red
        Else
            Me.BackColor = Color.Green

        End If
    End Sub
End Class
