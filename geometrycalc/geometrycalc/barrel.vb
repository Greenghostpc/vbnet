Public Class barrel
    Dim m_contents
    Dim m_capacity
    Public ReadOnly Property radius As Decimal
    Public ReadOnly Property height As Decimal
    Public ReadOnly Property contents As Decimal
        Get
            Return m_contents
        End Get
    End Property
    Public Sub New(r As Decimal, h As Decimal)
        radius = r
        height = h
        m_capacity = Math.PI * radius ^ 2 * height
    End Sub
    Public Sub fill(amt As Decimal)
        m_contents += amt
        If m_contents > m_capacity Then
            m_contents = m_capacity
        End If
    End Sub
    Public Sub drain(amt As Decimal)
        m_contents -= amt
        If m_contents < 0 Then
            m_contents = 0
        End If
    End Sub
End Class
