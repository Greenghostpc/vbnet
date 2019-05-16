Public Class Bank_Account
    Dim m_balance As Decimal
    Public ReadOnly Property accountnumber As String
    Public ReadOnly Property balance As Decimal
        Get
            Return m_balance
        End Get
    End Property
    Public Sub New(act As String)
        accountnumber = act
    End Sub
    Public Sub deposit(amt As Decimal)
        m_balance += amt
    End Sub
    Public Sub withdraw(amt As balance)
        m_balance -= amt
    End Sub
End Class
