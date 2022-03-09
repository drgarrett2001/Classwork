Option Strict On
'David Garrett
Public Class frmKRFK
    Dim gdecGames, gdecCost, gdecCertified, gdecGrade, gdecTotal As Decimal

    Private Sub radSeven_CheckedChanged(sender As Object, e As EventArgs) Handles radSeven.CheckedChanged
        If radSeven.Checked Then
            gdecGrade = 2
        End If
        subCalc()
    End Sub

    Private Sub radSix_CheckedChanged(sender As Object, e As EventArgs) Handles radSix.CheckedChanged
        If radSix.Checked Then
            gdecGrade = 3
        End If
        subCalc()
    End Sub

    Private Sub chkCertified_CheckedChanged(sender As Object, e As EventArgs) Handles chkCertified.CheckedChanged
        If chkCertified.Checked Then
            gdecCertified = 10
        Else
            gdecCertified = 0
        End If
        subCalc()
    End Sub

    Private Sub txtGames_TextChanged(sender As Object, e As EventArgs) Handles txtGames.TextChanged
        gdecGames = Math.Round(CDec("0" & Format(txtGames.Text, "Standard")), 0, MidpointRounding.AwayFromZero)
        subCalc()
    End Sub


    Private Sub txtCost_TextChanged(sender As Object, e As EventArgs) Handles txtCost.TextChanged
        If txtCost.Focused Then
            gdecCost = CDec("0" & Format(txtCost.Text, "Standard"))
            subCalc()
        End If
    End Sub


    Private Sub radEight_CheckedChanged(sender As Object, e As EventArgs) Handles radEight.CheckedChanged
        If radEight.Checked Then
            gdecGrade = 1
        End If
        subCalc()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        subReset()
    End Sub

    Private Sub frmKRFK_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        subReset()
    End Sub
    Private Sub subReset()
        gdecGames = 0
        txtGames.Text = "0"
        gdecCost = 0
        txtCost.Text = "0.00"
        txtCost.Text = Format(txtCost.Text, "Currency")
        gdecCertified = 0
        chkCertified.Checked = False
        gdecGrade = 1
        radEight.Checked = True
        subCalc()
        txtGames.Focus()
    End Sub
    Private Sub subCalc()
        gdecTotal = Math.Round(gdecGames * (gdecCost + gdecGrade) + gdecCertified, 2, MidpointRounding.AwayFromZero)
        txtTotal.Text = Format(gdecTotal, "Currency")


    End Sub

    Private Sub txtCost_LostFocus(sender As Object, e As EventArgs) Handles txtCost.LostFocus
        txtCost.Text = Format(txtCost.Text, "Currency")
    End Sub

    Private Sub txtGames_LostFocus(sender As Object, e As EventArgs) Handles txtGames.LostFocus
        txtGames.Text = CStr(gdecGames)
    End Sub
End Class
