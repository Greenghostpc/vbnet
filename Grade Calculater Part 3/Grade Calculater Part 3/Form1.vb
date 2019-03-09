Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim TG As Integer
        Dim TW As Decimal
        Dim FG As Integer
        Dim FW As Decimal
        Dim HG As Integer
        Dim HW As Decimal
        Dim TT As Integer

        Integer.TryParse(A1G.Text, TG)
        Decimal.TryParse(A1W.Text, TW)
        Integer.TryParse(A2G.Text, FG)
        Decimal.TryParse(A2W.Text, FW)
        Integer.TryParse(A3G.Text, HG)
        Decimal.TryParse(A3W.Text, HW)

        TT = TG * TW + FG * FW + HG * HW

        FinalGrade.Text = TT
    End Sub
End Class
