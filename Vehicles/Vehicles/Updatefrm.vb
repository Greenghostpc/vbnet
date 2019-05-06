Public Class Updatefrm
    Private Sub VehiclesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VehiclesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VehiclesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VehiclesDataSet)

    End Sub

    Private Sub Updatefrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VehiclesDataSet.Vehicles' table. You can move, or remove it, as needed.
        Me.VehiclesTableAdapter.Fill(Me.VehiclesDataSet.Vehicles)

    End Sub
End Class