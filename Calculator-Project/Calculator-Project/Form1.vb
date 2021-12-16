Public Class Form1

    'variable declaration'

    Dim num1, num2, energyUsed, energyCost, monthlyBill As Double
    Dim unitcost As Double = 10
    Dim monthlyTax As Double = 500

    Private Sub btnBill_Click(sender As Object, e As EventArgs) Handles btnBill.Click

        num1 = Val(txtPresentReadings.Text)
        num2 = Val(txtPreviousReadings.Text)
        energyUsed = num1 - num2
        energyCost = unitcost * energyUsed
        monthlyBill = monthlyTax + energyCost


        'Displacing the results on text-boxes'

        txtEnergyUsed.Text = energyUsed
        txtEnergyCost.Text = energyCost
        txtUnitCost.Text = unitcost
        txtMonthlyTax.Text = monthlyTax
        txtMonthlyBill.Text = monthlyBill
    End Sub

    'logic for clearing the values'
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtEnergyUsed.Clear()
        txtEnergyCost.Clear()
        txtMonthlyBill.Clear()
        txtPresentReadings.Clear()
        txtPreviousReadings.Clear()

    End Sub


    'Closing the application'
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub


End Class
