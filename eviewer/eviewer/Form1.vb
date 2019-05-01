Public Class Form1
    Dim employees(100) As employee
    Dim numemployees As Integer
    Dim current As Integer
    Structure employee
        Public id As String
        Public firstname As String
        Public lastname As String
        Public pay As Double
        Public picture As String
    End Structure
    Sub showemployee(e As employee)
        idTextBox.Text = e.id
        firstTextBox.Text = e.firstname
        lastTextBox.Text = e.lastname
        payTextBox.Text = e.pay
        PictureBox1.Load(e.picture)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Dim emp As employee
        emp.id = idTextBox.Text
        emp.firstname = firstTextBox.Text
        emp.lastname = lastTextBox.Text
        Double.TryParse(payTextBox.Text, emp.pay)
        emp.picture = PictureBox1.ImageLocation
        Saveemployee(emp)
    End Sub
    Sub Saveemployee(e As employee)
        Dim outfile As IO.StreamWriter
        outfile = IO.File.AppendText("Employees.txt")
        outfile.Write(e.id)
        outfile.Write(", ")
        outfile.Write(e.firstname)
        outfile.Write(", ")
        outfile.Write(e.lastname)
        outfile.Write(", ")
        outfile.Write(e.pay)
        outfile.Write(", ")
        outfile.Write(e.picture)
        outfile.WriteLine()
        outfile.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles firstButton.Click
        showemployee(employees(0))
    End Sub

    Sub Reademployees()
        Dim infile As IO.StreamReader
        infile = IO.File.OpenText("Employees.txt")
        Dim fields() As String

        Do While infile.Peek <> -1

            fields = infile.ReadLine.Split(", ")
            infile.Close()
            Dim e As employee
            e.id = fields(0)
            e.firstname = fields(1)
            e.lastname = fields(2)
            Double.TryParse(fields(3), e.pay)
            e.picture = fields(4)
            employees(numemployees) = e
            numemployees = numemployees + 1
        Loop
        infile.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reademployees()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If current < numemployees - 1 Then
            current = current + 1
            showemployee(employees(current))
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If current < numemployees - 1 Then
            current = current - 1
            showemployee(employees(current))
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If current < numemployees - 0 Then
            current = current - 1
            showemployee(employees(current))
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub
End Class
