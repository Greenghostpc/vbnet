' Prodject name:         Tri-County Electricity Prodject
' Prodject purpose:      Displays the monthly electric bill gates
' Copied by:   <Leomonaid> on <11/11/11>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub CalcResidentalTotal(ByVal units As Integer,
                                    ByRef Charge As Double)

        'calculates the total charge for a
        'residental customer

        Const UnitCharge As Double = 0.09
        Const MinFee As Double = 17.65

        Charge = units * UnitCharge
        If Charge < MinFee Then
            Charge = MinFee
        End If
    End Sub
    Private Function GetCommercialTotal(ByVal Units As Integer) As Double
        'calculates the total charge for a
        'commercial customer

        Const UnitCharge As Double = 0.12
        Const MinFee As Double = 21.75
        Dim charge As Double

        charge = Units * UnitCharge
        If charge < MinFee Then
            charge = MinFee
        End If

        Return charge

    End Function
    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub SelectText(sender As Object, e As EventArgs) Handles currentTextBox.Enter, previousTextBox.Enter
        ' select existing text

        Dim thisTextBox As TextBox
        thisTextBox = TryCast(sender, TextBox)
        thisTextBox.SelectAll()

    End Sub

    Private Sub CancelKeys(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles currentTextBox.KeyPress, previousTextBox.KeyPress
        'allow only number and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
            e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub ClearLabels(sender As Object, e As EventArgs) Handles currentTextBox.TextChanged, previousTextBox.TextChanged, residentialRadioButton.Click, commercialRadioButton.Click
        'Clear calculated value

        usageLabel.Text = String.Empty
        totalLabel.Text = String.Empty

    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'displays the monthly usage and total charge

        Dim Previous As Integer
        Dim Current As Integer
        Dim Usage As Integer
        Dim Total As Double

        Integer.TryParse(previousTextBox.Text, Previous)
        Integer.TryParse(currentTextBox.Text, Current)

        If Current >= Previous Then
            Usage = Current - Previous
            If residentialRadioButton.Checked = True Then
                Call CalcResidentalTotal(Usage, Total)
            Else
                Total = GetCommercialTotal(Usage)
            End If

            usageLabel.Text = Usage.ToString("N0")
            totalLabel.Text = Total.ToString("C2")
        Else
            MessageBox.Show("The current reading must " &
                            "be greater than or equal to the " &
                            "previous reading.",
                            "Tri-Country Electricity",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
        End If
    End Sub
End Class
