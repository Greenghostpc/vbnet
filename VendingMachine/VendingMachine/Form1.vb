Public Class Form1
    Dim balance As Decimal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        balance += 0.25
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        balance += 0.1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        balance += 0.05
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        balance += 1.0
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        balance += 5.0
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        balance += 20.0
    End Sub
End Class