Public Class Form1
    Dim income As Integer
    Dim food As Integer
    Dim entertainment As Integer
    Dim shopping As Integer
    Dim withdraws As Integer
    Dim months As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Integer.TryParse(TextBox1.Text, income)
        Integer.TryParse(TextBox2.Text, entertainment)
        Integer.TryParse(TextBox3.Text, shopping)
        Integer.TryParse(TextBox4.Text, withdraws)
        Integer.TryParse(TextBox5.Text, food)
        Integer.TryParse(TextBox6.Text, months)
    End Sub
End Class