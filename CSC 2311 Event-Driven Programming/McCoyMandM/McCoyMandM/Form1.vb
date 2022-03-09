Option Strict On
'David Garrett
Public Class frmMcCoy
    Dim gdecPints, gdecCost, gdecHatfeild, gdecMolasses, gdecUntaxable As Decimal

    Private Sub chkHatfield_CheckedChanged(sender As Object, e As EventArgs) Handles chkHatfield.CheckedChanged
        If chkHatfield.Checked Then
            gdecHatfeild = 100
        Else
            gdecHatfeild = 1
        End If
        subCalcUntaxableIncome()
    End Sub

    Private Sub radMedium_CheckedChanged(sender As Object, e As EventArgs) Handles radMedium.CheckedChanged
        If radMedium.Checked Then
            gdecMolasses = 2
        End If
        subCalcUntaxableIncome()
    End Sub

    Private Sub txtPints_TextChanged(sender As Object, e As EventArgs) Handles txtPints.TextChanged
        gdecPints = CDec("0" & Format(txtPints.Text, "Standard"))
        subCalcUntaxableIncome()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        subReset()
    End Sub
    Private Sub radDark_CheckedChanged(sender As Object, e As EventArgs) Handles radDark.CheckedChanged
        If radDark.Checked Then
            gdecMolasses = 3
        End If
        subCalcUntaxableIncome()
    End Sub
    Private Sub radLight_CheckedChanged(sender As Object, e As EventArgs) Handles radLight.CheckedChanged
        If radLight.Checked Then
            gdecMolasses = 1
        End If
        subCalcUntaxableIncome()
    End Sub
    Private Sub txtCost_TextChanged(sender As Object, e As EventArgs) Handles txtCost.TextChanged
        gdecCost = CDec("0" & Format(txtCost.Text, "Standard"))
        subCalcUntaxableIncome()
    End Sub


    Private Sub subCalcUntaxableIncome()
        gdecUntaxable = (gdecPints * gdecCost + (gdecPints * gdecMolasses)) * gdecHatfeild
        txtUntaxable.Text = Format(gdecUntaxable, "Currency")
    End Sub

    Private Sub txtCost_LostFocus(sender As Object, e As EventArgs) Handles txtCost.LostFocus
        txtCost.Text = Format(txtCost.Text, "Standard")
    End Sub

    Private Sub frmMcCoy_Load(sender As Object, e As EventArgs) Handles Me.Load
        subReset()
    End Sub
    Private Sub subReset()
        gdecPints = 0
        gdecCost = 0
        gdecHatfeild = 1
        gdecMolasses = 0
        gdecUntaxable = 0
        txtPints.Text = "0"
        txtCost.Text = "0.00"
        txtUntaxable.Text = "$0.00"
        chkHatfield.Checked = False
        radLight.Checked = False
        radMedium.Checked = False
        radDark.Checked = False
        txtPints.Focus()
        radLight.TabStop = True
    End Sub
End Class
