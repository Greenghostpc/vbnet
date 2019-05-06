Public Class Form1
    Dim money As Integer
    Dim name As String
    Private Sub clickHereButton_Click(sender As Object, e As EventArgs) Handles clickHereButton.Click
        Dim rg As New Random
        Dim rg2 As New Random
        Dim rg3 As New Random
        money = money - 5
        leftLabel.Text = rg.Next(1, 10)
        midLabel.Text = rg2.Next(1, 13)
        rightLabel.Text = rg3.Next(1, 21)
        If leftLabel.Text = midLabel.Text And midLabel.Text = rightLabel.Text Then
            Me.BackgroundImage = My.Resources.bling
            Me.BackColor = Color.Green
            money = money + 100
            TextBox1.Visible = True
            Button2.Visible = True
            Label6.Visible = True
        Else
            Me.BackgroundImage = My.Resources.gambling
            Me.BackColor = DefaultBackColor
            TextBox1.Visible = False
            Button2.Visible = False
            Label6.Visible = False
        End If
        Label3.Text = money
        If money > 199 Then
            Label4.Text = "Electric Scooter"
        End If
        If money > 299 Then
            Label4.Text = "$200 Google Play Giftcard"
            If money > 399 Then
                Label4.Text = "GTX1080TI"
            End If
        End If
        If money < 0 Then
            Me.Close()
        End If
    End Sub

    Private Sub leftPictureBox_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        money = 75
        TextBox1.Visible = False
        Button2.Visible = False
        Label6.Visible = False
        Label8.Visible = False
        Label7.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Items.Add(Label4.Text)
    End Sub
    Dim lastwinner As Date
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        name = TextBox1.Text
        lastwinner = Now()
        congLabel.Text = TextBox1.Text + " Just won $" + Label3.Text
        Label8.Visible = True
        Label7.Visible = True
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim ts As TimeSpan
        ts = Now() - lastwinner
        Dim fmtString As String = String.Format("{0}:{1}:{2}",
        ts.Hours.ToString("d2"),
        ts.Minutes.ToString("d2"),
        ts.Seconds.ToString("d2"))
        Label7.Text = fmtString
    End Sub
End Class
