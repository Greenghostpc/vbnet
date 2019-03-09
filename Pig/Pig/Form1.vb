Public Class Form1
    Dim vowels As New List(Of String)
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        vowels.AddRange({"a", "e", "i", "o", "u"})
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = Pe(TextBox1.Text)
    End Sub
    Function Pe(s As String) As String
        ' returns unchanged if no matches found
        Dim endword As String = s
        Dim ss() As Char = s.ToLower.Substring(0, 2).ToCharArray
        If Not vowels.Contains(ss(0)) Then
            If Not vowels.Contains(ss(1)) Then
                endword = s.Substring(2, s.Length - 2) & s.Substring(0, 2) & "ay"
            Else
                If vowels.Contains(ss(1)) Then
                    endword = s.Substring(1, s.Length - 1) & s.Substring(0, 1) & "ay"
                End If

            End If
        End If
        Return endword
    End Function
End Class