Public Class Right_Triangle
    Public Property Base As Integer
    Public Property Height As Integer

    Public ReadOnly Property Perimeter As Integer
        Get
            Perimeter = (Height + Math.Sqrt((Base * Base) + (Height * Height)))
        End Get
    End Property
    Public ReadOnly Property Area As Integer
        Get
            Area = (Base * Height) / 2
        End Get
    End Property
End Class
