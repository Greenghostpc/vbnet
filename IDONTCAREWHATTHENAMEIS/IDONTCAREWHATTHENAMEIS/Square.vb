Public Class Square
    Public Property Side As Integer
    Public ReadOnly Property Perimeter As Integer
        Get
            Perimeter = 4 * Side
        End Get
    End Property
    Public ReadOnly Property Area As Integer
        Get
            Area = Side * Side
        End Get
    End Property
End Class
