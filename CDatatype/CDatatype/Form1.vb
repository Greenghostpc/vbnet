Public Class Form1
    Dim emp As Employee
    Structure Employee
        Public id As String
        Public firstName As String
        Public lastName As String
        Public pay As Double
    End Structure

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        emp.id = "123"
        emp.firstName = "Bob"
        emp.lastName = "Smith"
        emp.pay = 80000
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = emp.id
        TextBox2.Text = emp.firstName
        TextBox4.Text = emp.lastName
        TextBox3.Text = emp.pay
    End Sub
End Class