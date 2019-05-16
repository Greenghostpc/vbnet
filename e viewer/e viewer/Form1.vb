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


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reademployee()
        Me.BackColor = Color.IndianRed
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim emp As employee
        emp.id = "1"
        emp.firstname = "johnny"
        emp.lastname = "ross"
        emp.pay = "44"
        showemployee(emp)

    End Sub
    Sub showemployee(e As employee)
        TextBox1.Text = e.id
        TextBox2.Text = e.firstname
        TextBox3.Text = e.lastname
        TextBox4.Text = e.pay
       PictureBox1.Load(e.picture)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim emp As employee
        emp.id = TextBox1.Text
        emp.firstname = TextBox2.Text
        emp.lastname = TextBox3.Text
        Double.TryParse(TextBox4.Text, emp.pay)
        saveemployee(emp)
    End Sub
    Sub saveemployee(e As employee)
        Dim outfile As IO.StreamWriter
        outfile = IO.File.AppendText("employee.txt")
        outfile.Write(e.id)
        outfile.Write(",")
        outfile.Write(e.firstname)
        outfile.Write(",")
        outfile.Write(e.lastname)
        outfile.Write(",")
        outfile.Write(e.pay)
        outfile.WriteLine()
        outfile.Close()

    End Sub
    Sub reademployee()
        Dim infile As IO.StreamReader
        infile = IO.File.OpenText("employees.txt")
        Dim fields() As String
        Do While infile.Peek <> -1

            fields = infile.ReadLine.Split(",")
            Dim e As employee
            e.id = fields(0)
            e.firstname = fields(0)
            e.lastname = fields(0)
            e.pay = fields(0)
        Loop



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        showemployee(employees(0))




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim current As Integer
        If current < numemployees - 1 Then

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub
End Class

