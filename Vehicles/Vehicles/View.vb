Public Class View
    Private Sub VehiclesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VehiclesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.VehiclesDataSet)

    End Sub

    Private Sub View_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VehiclesDataSet.Vehicles' table. You can move, or remove it, as needed.
        Me.VehiclesTableAdapter.Fill(Me.VehiclesDataSet.Vehicles)
        Label2.Hide()
    End Sub
End Class