Public Class Form1
    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UsersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database2DataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database2DataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.Database2DataSet.Users)
        UsersBindingNavigator.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UsersTableAdapter.Insert(TextBox2.Text, TextBox3.Text, ComboBox1.SelectedText)
        If ComboBox1.SelectedText = "Admin" Then
            UsersBindingNavigator.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim users = From user In Database2DataSet.Users
                    Where user._UserName_ = TextBox2.Text
                    Select user
        If users.Count = 1 Then
            If users(0)._Password_ Then
                MessageBox.Show("Login Succeeded")
            Else
                MessageBox.Show("The Password is Incorrect")
            End If
        Else
            MessageBox.Show("Invalid username!")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        currentuser = "Bob"
        Form2.ShowDialog()
    End Sub
End Class
