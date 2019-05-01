Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clearform()
    End Sub

    ''' <summary>
    ''' clears all fields
    ''' </summary>
    Sub clearform()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        aLabel.Text = ""
        pLabel.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim l, w, area, p As Integer
        Integer.TryParse(TextBox1.Text, l)
        Integer.TryParse(TextBox2.Text, w)
        area = calculateArea(l, w)
        p = calculatePerimeter(l, w)
        aLabel.Text = area
        pLabel.Text = p
    End Sub
    Function calculateArea(length As Integer, width As Integer) As Integer
        calculateArea = length * width
    End Function
    Function calculatePerimeter(length As Integer, width As Integer) As Integer
        calculatePerimeter = length * 2 + width * 2
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim r As Integer
        Integer.TryParse(TextBox3.Text, r)
        aLabel.Text = CircleArea(r).ToString("F2")
        pLabel.Text = circlePerimeter(r).ToString("F2")
    End Sub
    Function CircleArea(r As Integer) As Double
        Return Math.PI * r ^ 2
    End Function
    Function circlePerimeter(r As Integer) As Double
        circlePerimeter = 2 * Math.PI * r
    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim l, w, area, p As Integer
        Integer.TryParse(TextBox4.Text, l)
        Integer.TryParse(TextBox5.Text, w)
        area = (l * w) / 2
        p = (2 * l + 2 * w) / 2
        aLabel.Text = area
        pLabel.Text = p
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim a As Integer
        Dim area As Decimal
        Dim p As Integer

        Integer.TryParse(TextBox6.Text, a)
        area = (1 / 4) * (Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5)))) * a ^ 2
        aLabel.Text = area.ToString("F2")

        Integer.TryParse(TextBox6.Text, p)
        p = 5 * a
        pLabel.Text = p.ToString("F2")
    End Sub
    Function pentagonArea(a As Integer, area As Decimal) As Double
    End Function

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim a As Integer
        Dim area As Decimal
        Dim p As Integer

        Integer.TryParse(TextBox6.Text, a)
        area = (1 / 4) * (Math.Sqrt(6 * (6 + 2 * Math.Sqrt(6)))) * a ^ 2
        aLabel.Text = area.ToString("F2")

        Integer.TryParse(TextBox6.Text, p)
        p = 6 * a
        pLabel.Text = p.ToString("F2")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim a As Integer
        Dim area As Decimal
        Dim p As Integer

        Integer.TryParse(TextBox6.Text, a)
        area = (1 / 4) * (Math.Sqrt(8 * (8 + 2 * Math.Sqrt(8)))) * a ^ 2
        aLabel.Text = area.ToString("F2")

        Integer.TryParse(TextBox6.Text, p)
        p = 8 * a
        pLabel.Text = p.ToString("F2")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

