Public Class Form1
    Private Sub TblCdsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblCdsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblCdsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CDDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CDDataSet.tblCds' table. You can move, or remove it, as needed.
        Me.TblCdsTableAdapter.Fill(Me.CDDataSet.tblCds)
        Dim records = From cd In CDDataSet.tblCds
                      Select cd
        For Each r In records
            ComboBox1.Items.Add(r.Artist)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim records = From cd In CDDataSet.tblCds
                      Select cd
        For Each r In records
            TextBox1.Text += r.Artist.PadRight(30) & r.CdName.PadRight(30) & vbCrLf

        Next
    End Sub
End Class
