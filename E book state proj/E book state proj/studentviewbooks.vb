Public Class studentviewbooks
    Private Sub StudentviewBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.StudentviewBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StudentviewtableDataSet)

    End Sub

    Private Sub studentviewbooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'EbooksDataSet.Books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.EbooksDataSet.Books)
        'TODO: This line of code loads data into the 'StudentviewtableDataSet.Studentview' table. You can move, or remove it, as needed.
        Me.StudentviewTableAdapter.Fill(Me.StudentviewtableDataSet.Studentview)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        studentpage.Show()
        Me.Close()
    End Sub
End Class