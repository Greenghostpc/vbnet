Public Class Form3
    Private Sub CarsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.CarsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ClassProgramCarDataSet)

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ClassProgramCarDataSet.Cars' table. You can move, or remove it, as needed.
        Me.CarsTableAdapter.Fill(Me.ClassProgramCarDataSet.Cars)
        Dim averageprice As Decimal
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim cars = From c In ClassProgramCarDataSet.Cars
                   Where c.Make.ToUpper Like TextBox1.Text.ToUpper & "*"
        CarsDataGridView.DataSource = cars.AsDataView
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

        Dim models = From m In ClassProgramCarDataSet.Cars
                     Where m.Model.ToUpper Like TextBox2.Text.ToUpper & "*"
        CarsDataGridView.DataSource = models.AsDataView

    End Sub
End Class