'David Garrett
Option Strict On
Public Class frmSSTC
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        txtTaxDue.Text = Format(CStr(CDec(txtSales.Text) * nudTaxRate.Value * 0.01), "Currency")
        txtSales.Text = Format(txtSales.Text, "Standard")
        txtSales.Focus()
        txtSales.SelectAll()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        txtSales.Text = "0.00"
        nudTaxRate.Value = CDec(8.25)
        txtTaxDue.Text = Format(0, "Currency")
        txtSales.Text = Format(txtSales.Text, "Standard")
        txtSales.Focus()
        txtSales.SelectAll()
    End Sub

    Private Sub txtSales_LostFocus(sender As Object, e As EventArgs) Handles txtSales.LostFocus
        txtSales.Text = Format(txtSales.Text, "Standard")
    End Sub
End Class
