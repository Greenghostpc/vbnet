Public Class Form1
    Structure Employeet
        Public id As String
        Public firstname As String
        Public lastName As String
        Public pay As Double
    End Structure
    Dim EMP As Employeet
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EMP.id = "123"
        EMP.lastName = "Ross"
        EMP.firstname = "Bob"
        EMP.pay = 80000
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        idTextBox.Text = EMP.id
        fnTextBox.Text = EMP.firstname
        lnTextBox.Text = EMP.lastName
        payTextBox.Text = EMP.pay
    End Sub
End Class