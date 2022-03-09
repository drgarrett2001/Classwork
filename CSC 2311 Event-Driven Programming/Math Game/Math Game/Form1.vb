'David Garrett
Option Strict On
Public Class frmMathGame
    Dim gintmax As Integer
    Private Sub frmMathGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim intWins, intRandomOne, intRandomTwo, intResponse As Integer
        Dim strResponse As String
        Dim rVal1, rVal2 As New Random
        Dim boolGuessedAnInteger, boolDone As Boolean
        intWins = 0
        boolDone = False
        Do
            intRandomOne = rVal1.Next(1, gintmax + 1)
            intRandomTwo = rVal1.Next(1, gintmax + 1)
            strResponse = InputBox(intRandomOne & " + " & intRandomTwo & "?")
            boolGuessedAnInteger = Integer.TryParse(strResponse, intResponse)
            If strResponse = "" Then
                MsgBox("You have quit the game.")
                boolDone = True
            ElseIf boolGuessedAnInteger = False Then
                MsgBox("Please enter an integer.")
                intWins = 0
            ElseIf intResponse = intRandomOne + intRandomTwo Then
                intWins = intWins + 1
                MsgBox("Correct.")
            Else
                MsgBox("Incorrect.")
                intWins = 0
            End If
            If intWins = 3 Then
                MsgBox("You have won the game.")
                boolDone = True
            End If
        Loop While boolDone = False

    End Sub

    Private Sub radEasy_CheckedChanged(sender As Object, e As EventArgs) Handles radEasy.CheckedChanged
        If radEasy.Checked = True Then
            gintmax = 10
        End If
    End Sub

    Private Sub radMed_CheckedChanged(sender As Object, e As EventArgs) Handles radMed.CheckedChanged
        If radMed.Checked = True Then
            gintmax = 100
        End If
    End Sub

    Private Sub radHard_CheckedChanged(sender As Object, e As EventArgs) Handles radHard.CheckedChanged
        If radHard.Checked = True Then
            gintmax = 1000
        End If
    End Sub
End Class
