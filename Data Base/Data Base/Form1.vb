Public Class Form1
    Private Sub TBL_AlbumsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TBL_AlbumsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TBL_AlbumsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CD_CollectionDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CD_CollectionDataSet.TBL_Albums' table. You can move, or remove it, as needed.
        Me.TBL_AlbumsTableAdapter.Fill(Me.CD_CollectionDataSet.TBL_Albums)

    End Sub
End Class
