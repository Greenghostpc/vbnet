Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As New Square
        Integer.TryParse(SideTextBox.Text, s.Side)
        AreaTextBox.Text = s.Area
        PerimeterTextBox.Text = s.Perimeter
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r As New Rectangle
        Integer.TryParse(lengthTextBox.Text, r.length)
        Integer.TryParse(widthTextBox.Text, r.width)
        area2TextBox.Text = r.Area
        perimeter2TextBox.Text = r.Perimeter
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim t As New Right_Triangle
        Integer.TryParse(TextBox4.Text, t.Base)
        Integer.TryParse(TextBox3.Text, t.Height)
        TextBox2.Text = t.Area
        TextBox1.Text = t.Perimeter
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim length, width, height As Integer
        Integer.TryParse(lTextBox.Text, length)
        Integer.TryParse(hTextBox.Text, height)
        Integer.TryParse(wTextBox.Text, width)

        Dim rp As New RectangularPrism(length, width, height)
        saTextBox.Text = rp.surfacearea
        vTextBox.Text = rp.volume
    End Sub
    Dim b As Barrel
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim r, h As Decimal
        Decimal.TryParse(radiusTextBox.Text, r)
        Decimal.TryParse(heightTextBox.Text, h)
        b = New Barrel(r, h)
        contentsTextBox.Text = b.contents
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim fillamt As Decimal
        Decimal.TryParse(fillTextBox.Text, fillamt)
        b.fill(fillamt)
        contentsTextBox.Text = b.contents
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim drainamt As Decimal
        Decimal.TryParse(drainTextBox.Text, drainamt)
        b.drain(drainamt)
        contentsTextBox.Text = b.contents
    End Sub
End Class
