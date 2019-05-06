Public Class StudentLogin
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.UsersTableAdapter.Fill(Me.EbooksDataSet.Users)
        Dim logins = From user In EbooksDataSet.Users
                     Where user.UserName = usernameTextBox.Text
        If logins.Count = 1 AndAlso logins(0).Password = passwordTextBox.Text Then
            currentUser = logins(0).UserName

            If logins(0).Role = "S" Then
                Dim f3 As New studentpage
                f3.ShowDialog()
            End If

        Else
            MessageBox.Show("Login Failed", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub StuserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StuserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentloginDataSet)

    End Sub

    Private Sub StudentLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EbooksDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.EbooksDataSet.Users)
        'TODO: This line of code loads data into the 'StudentloginDataSet.Stuser' table. You can move, or remove it, as needed.
        Me.StuserTableAdapter.Fill(Me.StudentloginDataSet.Stuser)

    End Sub
End Class