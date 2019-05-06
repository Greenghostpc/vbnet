Public Class Rectangle
    Public Property width As Integer
    Public Property length As Integer
    Public ReadOnly Property Perimeter As Integer
        Get
            Perimeter = (2 * width) + (2 * length)
        End Get
    End Property
    Public ReadOnly Property Area As Integer
        Get
            Area = length * width
        End Get
    End Property
End Class
