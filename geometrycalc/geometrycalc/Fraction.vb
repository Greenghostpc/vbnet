Public Class Fraction
    Dim m_numer As Integer
    Dim m_denom As Integer

    Public Sub New(n As Integer, d As Integer)
        m_numer = n / GCD(n, d)
        m_denom = d / GCD(n, d)
    End Sub

    Public ReadOnly Property numer As Integer
        Get
            Return m_numer
        End Get
    End Property

    Public ReadOnly Property denom As Integer
        Get
            Return m_denom
        End Get
    End Property

    Public Function multiply(other As Fraction) As Fraction
        Dim n, d As Integer
        n = m_numer * other.m_numer
        d = m_denom * other.m_denom
        Return New Fraction(n, d)
    End Function

    Public Function reciprocal() As Fraction
        Return New Fraction(m_denom, m_numer)
    End Function

    Public Function divide(other As Fraction) As Fraction
        Return multiply(other.reciprocal)
    End Function

    Public Function GCD(a As Integer, b As Integer) As Integer

        If (a = 0) Then Return b
        If (b = 0) Then Return a

        If (a > b) Then
            Return GCD(a Mod b, b)
        Else
            Return GCD(a, b Mod a)
        End If
    End Function
End Class
