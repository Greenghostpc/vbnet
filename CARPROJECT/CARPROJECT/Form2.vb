Public Class Form2
    Private Sub CarsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CarsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CarsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClassProgramCarDataSet)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClassProgramCarDataSet.Cars' table. You can move, or remove it, as needed.
        Me.CarsTableAdapter.Fill(Me.ClassProgramCarDataSet.Cars)
        Dim models = From m In ClassProgramCarDataSet.Cars
        For Each model In models
            ComboBox1.Items.Add(model.Model)
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class