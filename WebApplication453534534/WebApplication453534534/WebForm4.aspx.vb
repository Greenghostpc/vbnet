Public Class WebForm4
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cupcount As Decimal
        Dim sweatpantscount As Decimal
        Dim ballcount As Decimal
        Dim carcount As Decimal
        Dim shirtcount As Decimal
        Dim backpackcount As Decimal
        Dim walletcount As Decimal

        Dim cup As Decimal
        Dim sweatpants As Decimal
        Dim ball As Decimal
        Dim car As Decimal
        Dim shirt As Decimal
        Dim backpack As Decimal
        Dim wallet As Decimal

        cup = 10.99
        sweatpants = 25.5
        ball = 0.99
        car = 99999.99
        shirt = 15.99
        backpack = 45.98
        wallet = 25.5

        Decimal.TryParse(TextBox1.Text, cupcount)
        Decimal.TryParse(TextBox2.Text, sweatpantscount)
        Decimal.TryParse(TextBox3.Text, ballcount)
        Decimal.TryParse(TextBox4.Text, carcount)
        Decimal.TryParse(TextBox5.Text, shirtcount)
        Decimal.TryParse(TextBox6.Text, backpackcount)
        Decimal.TryParse(TextBox7.Text, walletcount)

        Dim total As Decimal
        total = (cup * cupcount) + (sweatpants * sweatpantscount) + (ball * ballcount) + (car * carcount) + (shirt * shirtcount) + (backpack * backpackcount) + (wallet * walletcount)
        totalLabel.Text = total.ToString("C2")
    End Sub
End Class