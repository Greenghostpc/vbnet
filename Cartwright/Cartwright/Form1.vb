'
'
'
'

Option Explicit On
Option Strict On
Option Infer On

Public Class Form1

    Private Sub TblItemsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblItemsBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.TblItemsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.ItemtouyosDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message,
"Cartwright Industries",
MessageBoxButtons.OK,
MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ItemtouyosDataSet.tblItems' table. You can move, or remove it, as needed.
        Me.TblItemsTableAdapter.Fill(Me.ItemtouyosDataSet.tblItems)

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        '

        Dim itemnum As String
        Const prompt As String = "One or more characters" &
            "(leave empty to retrieve all records):"

        '
        itemnum = InputBox(prompt, "Item Number")
        itemnum = itemnum.ToUpper.Trim

        '
        Dim records = From item In ItemtouyosDataSet.tblItems
                      Where item.ItemNum.ToUpper Like itemnum & "*"
                      Select item

        TblItemsBindingSource.DataSource = records.AsDataView
    End Sub
End Class
