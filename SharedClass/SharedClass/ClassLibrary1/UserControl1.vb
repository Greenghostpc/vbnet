Public Class UserControl1
    Public Property caption As String
    Public Property buttontext As String
    Public Property bkcolor As System.Drawing.Color
    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.text = caption
        Button1.Text = buttontext
        Me.BackColor = bkcolor
    End Sub
End Class
