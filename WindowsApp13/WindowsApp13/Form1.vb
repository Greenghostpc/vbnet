Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nums(19) As Integer
        Dim labels(19) As Label
        Dim n As Integer
        For Each c In Me.Controls
            If c.name <> "Button1" Then
                labels(n) = c
                n = n + 1
            End If
        Next
        For Each l In labels
            l.Text = "Bob"
        Next
    End Sub
End Class
