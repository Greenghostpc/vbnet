Public Class TeacherLogin
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.UsersTableAdapter.Fill(Me.EbooksDataSet.Users)
        Dim logins = From user In EbooksDataSet.Users
                     Where user.UserName = usernameTextBox.Text
        If logins.Count = 1 AndAlso logins(0).Password = passwordTextBox.Text Then
            currentuser = logins(0).UserName

            If logins(0).Role = "T" Then
                Dim f2 As New teacherview
                f2.ShowDialog()
            End If

        Else
            MessageBox.Show("Login Failed", "User Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EbooksDataSet)

    End Sub

    Private Sub TeacherLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EbooksDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.EbooksDataSet.Users)

    End Sub
End Class