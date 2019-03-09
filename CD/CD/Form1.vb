Public Class Form1
    Private Sub TblCdsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblCdsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblCdsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CDDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CDDataSet.tblCds' table. You can move, or remove it, as needed.
        Me.TblCdsTableAdapter.Fill(Me.CDDataSet.tblCds)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TblCdsBindingSource.MoveFirst()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TblCdsBindingSource.MoveLast()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TblCdsBindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TblCdsBindingSource.MovePrevious()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim findName As String
        findName = InputBox("Enter Artist Nmae").ToUpper

        Dim records = From CD In CDDataSet.tblCds
                      Where CD.Artist.ToUpper Like findName & "*"
                      Select CD
        TblCdsBindingSource.DataSource = records.AsDataView
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim maxrate As Double = Aggregate cd In CDDataSet.tblCds
                                    Select cd.Price Into Max
        maxLabel.Text = maxrate
    End Sub
End Class
