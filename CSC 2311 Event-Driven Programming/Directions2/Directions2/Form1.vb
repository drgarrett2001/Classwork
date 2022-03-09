Public Class frmDrivingDirections
    Private Sub btnShowDirections_Click(sender As Object, e As EventArgs) Handles btnShowDirections.Click
        If lblDirections.Visible = True Then
            lblDirections.Visible = False
            btnShowDirections.Text = "Show Directions"
        Else
            lblDirections.Visible = True
            btnShowDirections.Text = "Hide Directions"
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
