Option Strict On
'David Garrett

Public Class frmCalendar
    Dim intCalendar(5, 6) As Integer
    Dim strWeek() As String = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"}
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        Dim intCounter As Integer = 0
        Dim intFirstDay As Integer = 0
        Dim intInc As Integer = 0
        Dim intLastDay As Integer = 0
        Dim boolTryParse As Boolean = False
        Dim boolWorking As Boolean = False

        For intInc = 0 To strWeek.GetUpperBound(0)      'Get the first day of the week
            If txtFirstDay.Text = strWeek(intInc) Then
                intFirstDay = intInc
            End If
        Next

        boolTryParse = Integer.TryParse(txtNumofDays.Text, intLastDay)                   'Get last day of the month

        boolWorking = False
        For intRow = 0 To intCalendar.GetUpperBound(0)                                   'Read the numbers into the calendar
            For intCol = 0 To intCalendar.GetUpperBound(1)

                If (intRow = 0 And intCol = intFirstDay) Then                            'First day = begin
                    boolWorking = True
                ElseIf ((7 * intRow) + (intCol + 1) - intFirstDay) > intLastDay Then               'Last Day = stop
                    boolWorking = False
                End If

                If boolWorking = True Then
                    intCounter += 1
                Else
                    intCounter = 0
                End If

                intCalendar(intRow, intCol) = intCounter

            Next
        Next

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        For intInc = 0 To strWeek.GetUpperBound(0)      'Print the Day of the Week
            Console.Write(" " & strWeek(intInc))
        Next

        Console.WriteLine()                                 'New line

        For intRow = 0 To intCalendar.GetUpperBound(0)
            For intCol = 0 To intCalendar.GetUpperBound(1)
                If intCalendar(intRow, intCol) > 0 Then
                    Console.Write("{0,4}", intCalendar(intRow, intCol))
                Else
                    Console.Write("    ")
                End If
            Next
            Console.WriteLine()
        Next

        txtSearchFor.Focus()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        For intRow = 0 To intCalendar.GetUpperBound(0)
            For intCol = 0 To intCalendar.GetUpperBound(1)
                If intCalendar(intRow, intCol) = CInt(txtSearchFor.Text) Then
                    txtFound.Text = strWeek(intCol)
                End If
            Next
        Next
    End Sub
End Class
