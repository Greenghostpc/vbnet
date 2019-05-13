Public Class Crane
    Dim m_height As Integer = 4
    Public ReadOnly Property height As Integer
        Get
            Return m_height
        End Get
    End Property
    Public Sub raise(amt As Integer)
        If height < 12 Then
            m_height += amt
        End If
    End Sub
    Public Sub lower(amt As Integer)
        If height > 4 Then
            m_height -= amt
        End If
    End Sub
End Class
