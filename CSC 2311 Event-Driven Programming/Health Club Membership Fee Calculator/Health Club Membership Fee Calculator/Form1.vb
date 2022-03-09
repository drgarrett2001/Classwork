'David Garrett
Option Strict On

Public Class frmHCMFC
    Dim gintMonths, gintAdded, gintMonthlyFee As Integer

    Private Sub frmHCMFC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        subReset()
    End Sub

    Private Sub txtMonths_TextChanged(sender As Object, e As EventArgs) Handles txtMonths.TextChanged
        If Integer.TryParse(txtMonths.Text, gintMonths) = False Then
            lblStatus.Text = "Months must be an integer."
            btnCalculate.Enabled = False
        ElseIf (gintMonths > 24) Or (gintMonths < 0) Then
            lblStatus.Text = "Integer must be in the range 1-24"
            btnCalculate.Enabled = False
        Else
            btnCalculate.Enabled = True
        End If
    End Sub

    Private Sub subReset()
        radAdult.Checked = True
        chkYoga.Checked = False
        chkKarate.Checked = False
        chkTrainer.Checked = False
        txtMonths.Text = String.Empty
        txtMonthlyFee.Text = String.Empty
        txtTotalFee.Text = String.Empty
        lblStatus.Text = "Enter an integer in the range of 1-24"
        gintMonthlyFee = 40
        gintMonths = 0
        txtMonths.Focus()
    End Sub

    Private Sub radAdult_CheckedChanged(sender As Object, e As EventArgs) Handles radAdult.CheckedChanged
        If radAdult.Checked Then
            gintMonthlyFee = 40
        End If
    End Sub

    Private Sub radChild_CheckedChanged(sender As Object, e As EventArgs) Handles radChild.CheckedChanged
        If radChild.Checked Then
            gintMonthlyFee = 20
        End If
    End Sub

    Private Sub chkYoga_CheckedChanged(sender As Object, e As EventArgs) Handles chkYoga.CheckedChanged
        If chkYoga.Checked Then
            gintAdded = gintAdded + 10
        Else
            gintAdded = gintAdded - 10
        End If
    End Sub

    Private Sub radStudent_CheckedChanged(sender As Object, e As EventArgs) Handles radStudent.CheckedChanged
        If radStudent.Checked Then
            gintMonthlyFee = 25
        End If
    End Sub

    Private Sub chkKarate_CheckedChanged(sender As Object, e As EventArgs) Handles chkKarate.CheckedChanged
        If chkKarate.Checked Then
            gintAdded = gintAdded + 30
        Else
            gintAdded = gintAdded - 30
        End If
    End Sub

    Private Sub chkTrainer_CheckedChanged(sender As Object, e As EventArgs) Handles chkTrainer.CheckedChanged
        If chkTrainer.Checked Then
            gintAdded = gintAdded + 50
        Else
            gintAdded = gintAdded - 50
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        subReset()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        subCalc()
    End Sub

    Private Sub grpFees_Enter(sender As Object, e As EventArgs) Handles grpFees.Enter

    End Sub

    Private Sub grpOptions_Enter(sender As Object, e As EventArgs) Handles grpOptions.Enter

    End Sub

    Private Sub grpType_Enter(sender As Object, e As EventArgs) Handles grpType.Enter

    End Sub

    Private Sub grpLength_Enter(sender As Object, e As EventArgs) Handles grpLength.Enter

    End Sub

    Private Sub radSenior_CheckedChanged(sender As Object, e As EventArgs) Handles radSenior.CheckedChanged
        If radSenior.Checked Then
            gintMonthlyFee = 30
        End If
    End Sub

    Private Sub subCalc()
        txtMonthlyFee.Text = Format(gintMonthlyFee + gintAdded, "Currency")
        txtTotalFee.Text = Format(gintMonths * (gintMonthlyFee + gintAdded), "Currency")
    End Sub
End Class
