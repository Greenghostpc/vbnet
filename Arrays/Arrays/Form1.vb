Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Labels(19) As Label
        Dim n As Integer

        For Each c In Me.Controls
            If c.name <> "Button1" Then
                Labels(n) = c
                n = n + 1
            End If
        Next

        For Each l In Labels
            l.Text = "Bob"
        Next
    End Sub
End Class
