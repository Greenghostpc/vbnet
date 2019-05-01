Public Class Form1
    Private Sub YAGA_1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles YAGA_1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.YAGA_1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CDcollectionDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CDcollectionDataSet.YAGA_1' table. You can move, or remove it, as needed.
        Me.YAGA_1TableAdapter.Fill(Me.CDcollectionDataSet.YAGA_1)

    End Sub
End Class
