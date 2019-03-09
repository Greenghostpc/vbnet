Public Class Form1
    Structure employee
        Public id As String
        Public firstname As String
        Public lastname As String
        Public pay As Double
        Public picture As String
    End Structure
    Dim employees(100) As employee
    Dim numemployees As Integer
    Dim current As Integer

    Private Sub Button_Click(sender As Object, e As EventArgs)
        Dim emp As employee
        emp.id = "1"
        emp.firstname = "Bob"
        emp.lastname = "Ross"
        emp.pay = "2"
        showEmployee(emp)
    End Sub

    Sub showEmployee(e As employee)
        IDTextBox.Text = e.id
        FNameTextBox.Text = e.firstname
        LNameTextBox.Text = e.lastname
        payTextBox.Text = e.pay
        PictureBox1.Load(e.picture)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Dim emp As employee
        emp.id = IDTextBox.Text
        emp.firstname = FNameTextBox.Text
        emp.lastname = LNameTextBox.Text
        Double.TryParse(payTextBox.Text, emp.pay)
        emp.picture = PictureBox1.ImageLocation
        saveEmployee(emp)

    End Sub

    Sub saveEmployee(e As employee)
        Dim outfile As IO.StreamWriter
        outfile = IO.File.AppendText("employees.txt")
        outfile.Write(e.id)
        outfile.Write(",")
        outfile.Write(e.firstname)
        outfile.Write(",")
        outfile.Write(e.lastname)
        outfile.Write(",")
        outfile.Write(e.pay)

        outfile.Write(",")
        outfile.Write(e.picture)
        outfile.WriteLine()
        outfile.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        showEmployee(employees(0))
    End Sub

    Function readEmployees() As employee
        Dim infile As IO.StreamReader
        infile = IO.File.OpenText("employees.txt")
        Dim fields() As String
        Do While infile.Peek <> -1

            fields = infile.ReadLine.Split(",")
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

    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        readEmployees()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        If current < numemployees - 1 Then
            current = current + 1
            showEmployee(employees(current))
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub First_Click(sender As Object, e As EventArgs) Handles First.Click
        If current < numemployees - 1 Then
            current = current - 1
            showEmployee(employees(current))
        End If
    End Sub
End Class