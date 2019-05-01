Public Class Form1
    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database7DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database7DataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.Database7DataSet.Users)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim users = From user In Database7DataSet.Users
                    Where user.Username = TextBox1.Text
                    Select user
        If users.Count = 1 Then
            If users(0).Password = TextBox2.Text Then
                MessageBox.Show("Login succeded")
            Else
                MessageBox.Show("Invalid password")

            End If
        Else
            MessageBox.Show("Invalid username")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r As Database7DataSet.UsersRow
        r = Database7DataSet.Users.NewUsersRow
        r.Username = "Justin"
        r.Password = "Roiland"
        r.Role = "Student"
        Database7DataSet.Users.AddUsersRow(r)
        Database7DataSet.Users.AcceptChanges()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        currentuser = "Monica"
        Dim f As New Form2
        f.ShowDialog()
    End Sub
End Class
