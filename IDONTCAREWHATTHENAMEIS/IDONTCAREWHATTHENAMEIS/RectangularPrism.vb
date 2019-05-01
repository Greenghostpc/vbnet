Public Class RectangularPrism
    Dim m_length As Integer
    Dim m_width As Integer
    Dim m_height As Integer

    Public Property length As Integer
        Set(value As Integer)
            m_length = Math.Abs(value)
        End Set
        Get
            Return m_length
        End Get
    End Property
    Public Property width As Integer
        Set(value As Integer)
            m_width = Math.Abs(value)
        End Set
        Get
            Return m_width
        End Get
    End Property
    Public Property height As Integer
        Set(value As Integer)
            m_height = Math.Abs(value)

        End Set
        Get
            Return m_height
        End Get
    End Property

    Public Sub New(l As Integer, w As Integer, h As Integer)
        length = l
        width = w
        height = h

    End Sub
    Public ReadOnly Property volume As Integer
        Get
            volume = length * width * height
        End Get
    End Property
    Public ReadOnly Property surfacearea As Integer
        Get
            surfacearea = 2 * ((length * width) + (length * height) + (width * height))
        End Get
    End Property
End Class
