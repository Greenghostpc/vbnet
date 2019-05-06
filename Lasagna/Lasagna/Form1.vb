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
        TblCdsBindingSource.MoveNext()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TblCdsBindingSource.MovePrevious()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TblCdsBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    End Sub

    Private Sub ToolStripTextBox1_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBox1.TextChanged
        Dim findname As String
        ' findname = InputBox("Enter artist name").ToUpper
        findname = ToolStripTextBox1.Text
        Dim records = From cd In CDDataSet.tblCds
                      Where cd.Artist.ToUpper Like findname & "*"
                      Select cd
        TblCdsBindingSource.DataSource = records.AsDataView

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim maxrate As Double = Aggregate cd In CDDataSet.tblCds
                                    Select cd.Price Into Max()
        Label1.Text = maxrate
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim minrate As Double = Aggregate cd In CDDataSet.tblCds
                                   Select cd.Price Into Min()
        Label2.Text = minrate
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim avgrate As Double = Aggregate cd In CDDataSet.tblCds
                                   Select cd.Price Into Average()
        Label3.Text = avgrate
    End Sub
End Class
