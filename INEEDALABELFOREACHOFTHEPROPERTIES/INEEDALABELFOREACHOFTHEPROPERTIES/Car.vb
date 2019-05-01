Public Class Car
    Public Event Outofgas()
    Public Property carColor As Color
    Public Property make As String
    Public Property model As String
    Public Property fuel As Decimal
    Public Property MPG As Integer

    Public Sub drive(d As Integer)
        fuel = fuel - (d * MPG)
        If fuel < 0 Then
            RaiseEvent Outofgas()
        End If
    End Sub
End Class
