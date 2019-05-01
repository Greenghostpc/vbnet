Public Class Form1
    Private Sub TblBO4BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblBO4BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bo4yesDataSet)

    End Sub

    Private Sub TblBO4BindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles TblBO4BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblBO4BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bo4yesDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bo4yesDataSet.tblBO4' table. You can move, or remove it, as needed.
        Me.TblBO4TableAdapter.Fill(Me.Bo4yesDataSet.tblBO4)

    End Sub
End Class
