Public Class teacherview
    Private Sub StuserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StuserBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StuserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentloginDataSet)

    End Sub

    Private Sub teacherview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EbooksDataSet.Users' table. You can move, or remove it, as needed.
        Me.UsersTableAdapter.Fill(Me.EbooksDataSet.Users)
        'TODO: This line of code loads data into the 'EbooksDataSet.Vouchers' table. You can move, or remove it, as needed.
        Me.VouchersTableAdapter.Fill(Me.EbooksDataSet.Vouchers)
        'TODO: This line of code loads data into the 'EbooksDataSet.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.EbooksDataSet.Books)
        'TODO: This line of code loads data into the 'StudentloginDataSet.Stuser' table. You can move, or remove it, as needed.
        Me.StuserTableAdapter.Fill(Me.StudentloginDataSet.Stuser)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim books = From b In ebooksDataSet.Books
                    Where b.Title = booksListBox.SelectedItem
        Dim bookID As Integer
        bookID = books(0).ID

        'Find the selected user
        Dim users = From u In ebooksDataSet.Users
                    Where u.UserName = usersListBox.SelectedItem
        Dim userName As String
        userName = users(0).UserName

        'Add this voucher to the vouchers table
        Dim newVoucher As ebooksDataSet.VouchersRow
        newVoucher = ebooksDataSet.Vouchers.NewVouchersRow
        newVoucher.BookID = bookID
        newVoucher.UserName = userName
        newVoucher.Voucher = voucherTextBox.Text
        ebooksDataSet.Vouchers.AddVouchersRow(newVoucher)

        Me.Validate()
        Me.VouchersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EbooksDataSet)

    End Sub
End Class