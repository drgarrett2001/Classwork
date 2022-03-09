Option Strict On
'David Garrett
Public Class frmGuessingGame
    Dim gintmax, gintTries, gintDifficulty As Integer
    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click

        Dim strResponse As String = ""
        Dim strTries As String
        Dim intResponse, intRVal, intEndCase As Integer
        Dim boolGuessedAnInteger As Boolean
        intEndCase = 0
        'Input Box

        Dim rVal As New Random
        intRVal = rVal.Next(1, gintmax + 1)

        strResponse = InputBox("Guess a number between 1 and " & gintmax, "Random Number Guessing Game", " ")
        Do
            boolGuessedAnInteger = Integer.TryParse(strResponse, intResponse)
            gintTries = gintTries - 1
            If gintTries < 0 Then
                strTries = "Unlimited"
            ElseIf gintTries >= 0 Then
                If boolGuessedAnInteger = False Then
                    strTries = CStr(gintTries + -1)
                ElseIf intResponse > gintmax And intResponse < 1 Then
                    strTries = CStr(gintTries + -1)
                Else
                    strTries = CStr(gintTries)
                End If
            End If
            Console.WriteLine(strResponse & " " & intResponse)
            If strResponse = "" Then
                intEndCase = 3
            ElseIf strResponse = " " Then
                strResponse = InputBox("Empty Box" & vbCrLf & "Tries Remaining: " & strTries, "Random Number Guessing Game", " ")
            ElseIf boolGuessedAnInteger = False Then
                strResponse = InputBox("Not an integer." & vbCrLf & "Tries Remaining: " & strTries, "Random Number Guessing Game", " ")
                'ElseIf strResponse = "" Then
                '    intEndCase = 3
            ElseIf intResponse > gintmax And intResponse < 1 Then
                strResponse = InputBox("Out of the range. Please choose a number between 1 and " & gintmax & vbCrLf & "Tries Remaining: " & strTries, "Random Number Guessing Game", " ")
            ElseIf intResponse > intRVal AndAlso gintDifficulty < 4 Then
                strResponse = InputBox("Too high." & vbCrLf & "Tries Remaining: " & strTries, "Random Number Guessing Game", " ")
            ElseIf intResponse < intRVal AndAlso gintDifficulty < 4 Then
                strResponse = InputBox("Too low." & vbCrLf & "Tries Remaining: " & strTries, "Random Number Guessing Game", " ")
            ElseIf intResponse <> intRVal Then
                strResponse = InputBox("Wrong." & vbCrLf & " Tries Remaining: " & strTries, "Random Number Guessing Game", " ")
            End If

            If gintTries = 0 Then
                intEndCase = 2
            ElseIf intResponse = intRVal Then
                intEndCase = 1
            End If
        Loop While intEndCase = 0


        'text display for the result
        If intEndCase = 1 Then
            MsgBox("congrats. you did it. yay.")
        ElseIf intEndCase = 2 Then
            MsgBox("You ran out of tries. No one is surprised.")
        ElseIf intEndCase = 3 Then
            MsgBox("quitter")
        End If

    End Sub

    Private Sub radMedium_CheckedChanged(sender As Object, e As EventArgs) Handles radMedium.CheckedChanged
        If radMedium.Checked = True Then
            gintmax = 100
            gintTries = 20
            gintDifficulty = 2
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub RadVeteran_CheckedChanged(sender As Object, e As EventArgs) Handles RadVeteran.CheckedChanged
        If RadVeteran.Checked = True Then
            gintmax = 100
            gintTries = 10
            gintDifficulty = 4
        End If
    End Sub

    Private Sub radHard_CheckedChanged(sender As Object, e As EventArgs) Handles radHard.CheckedChanged
        If radHard.Checked = True Then
            gintmax = 100
            gintTries = 5
            gintDifficulty = 3
        End If
    End Sub

    Private Sub radEasy_CheckedChanged(sender As Object, e As EventArgs) Handles radEasy.CheckedChanged
        If radEasy.Checked = True Then
            gintmax = 10
            gintTries = -1
            gintDifficulty = 1
        End If
    End Sub
End Class
