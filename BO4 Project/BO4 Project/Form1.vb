Public Class Form1
    Dim specialists(100) As specialist
    Dim numspecialists As Integer
    Dim current As Integer
    Structure specialist
        Public id As String
        Public firstname As String
        Public lastname As String
        Public pay As Double
        Public picture As String
    End Structure
    Sub showspecialist(e As specialist)
        idTextBox.Text = e.id
        firstTextBox.Text = e.firstname
        EquiptmentTextBox.Text = e.lastname
        BO3TextBox.Text = e.pay
        PictureBox1.Load(e.picture)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Dim emp As specialist
        emp.id = idTextBox.Text
        emp.firstname = firstTextBox.Text
        emp.lastname = EquiptmentTextBox.Text
        Double.TryParse(BO3TextBox.Text, emp.pay)
        emp.picture = PictureBox1.ImageLocation
        Savespecialist(emp)
    End Sub
    Sub Savespecialist(e As specialist)
        Dim outfile As IO.StreamWriter
        outfile = IO.File.AppendText("Bo4Specialist.txt")
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
        showspecialist(specialists(0))
    End Sub

    Sub Readspecialists()
        Dim infile As IO.StreamReader
        infile = IO.File.OpenText("Bo4Specialist.txt")
        Dim fields() As String

        Do While infile.Peek <> -1

            fields = infile.ReadLine.Split(",")
            Dim e As specialist
            e.id = fields(0)
            e.firstname = fields(1)
            e.lastname = fields(2)
            Double.TryParse(fields(3), e.pay)
            e.picture = fields(4)
            specialists(numspecialists) = e
            numspecialists = numspecialists + 1
        Loop
        infile.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Readspecialists()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If current < numspecialists - 1 Then
            current = current + 1
            showspecialist(specialists(current))
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        If current < numspecialists - 1 Then
            current = current - 1
            showspecialist(specialists(current))
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        showspecialist(specialists(numspecialists - 1))
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub
End Class
