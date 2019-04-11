Public Class Form1
    Dim fname As String = "Myfile.txt"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim outfile As IO.StreamWriter
        outfile = IO.File.AppendText(fname)
        outfile.WriteLine(TextBox1.Text)
        outfile.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim infile As IO.StreamReader
        TextBox2.Clear()
        If IO.File.Exists(fname) Then
            infile = IO.File.OpenText(fname)
            Do Until infile.Peek = -1
                TextBox2.Text += infile.ReadLine
                TextBox2.Text += vbCrLf

            Loop
            infile.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk
        Dim outfile As IO.StringWriter
        fname = SaveFileDialog1.FileName
        outfile = IO.File.CreateText(fname)
    End Sub
End Class
