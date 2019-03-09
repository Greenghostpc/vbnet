Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Len As Integer
        Dim width As Integer
        Integer.TryParse(lengthTextBox.Text, Len)
        Integer.TryParse(widthTextBox.Text, width)
        Dim Area As Integer
        areaLabel.Text = CalculateRectangleArea(Len, width)
        Dim Perimeter As Integer
        perimeterLabel.Text = CalculateRectanglePerimeter(Len, width)

    End Sub

    Function CalculateRectangleArea(Len As Integer, width As Integer)
        CalculateRectangleArea = Len * width
    End Function
    Function CalculateRectanglePerimeter(Len As Integer, width As Integer)
        CalculateRectanglePerimeter = Len + Len + width + width


    End Function
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        clearform()
    End Sub
    ''' <summary>
    ''' Clear all values
    ''' </summary>
    Sub clearform()

        lengthTextBox.Clear()
        widthTextBox.Clear()
        areaLabel.Text = ""
        perimeterLabel.Text = ""
    End Sub

    Private Sub CircleCaclulateButton_Click(sender As Object, e As EventArgs) Handles CircleCaclulateButton.Click
        Dim R As Integer
        Integer.TryParse(radiusTextBox.Text, R)
        CircleAreaLabel.Text = CircleArea(R).ToString("F2")
        CurcumfrenceLabel.Text = CirclePerimeter(R).ToString("F2")
    End Sub
    Function CircleArea(R As Integer) As Double
        CircleArea = Math.PI * R ^ 2
    End Function
    Function CirclePerimeter(R As Integer) As Double
        CirclePerimeter = Math.PI * 2 * R
    End Function
End Class
