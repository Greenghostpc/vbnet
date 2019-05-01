Public Class WebForm2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim length As Decimal
        Dim width As Decimal
        Dim total As Decimal

        Decimal.TryParse(TextBox1.Text, length)
        Decimal.TryParse(TextBox2.Text, width)
        If RadioButton1.Checked = True Then
            total = width * length * 4.99
        End If
        If RadioButton2.Checked = True Then
            total = width * length * 3.99
        End If
        If RadioButton3.Checked = True Then
            total = width * length * 8.99
        End If
        Label4.Text = total.ToString("C2")
    End Sub
End Class