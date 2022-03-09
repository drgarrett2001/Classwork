Option Strict On
Imports System.IO
'David Garrett
Public Class frmSalesByMonth
    Dim strFirstMonth, strSumFreq As String
    Dim monthArray(11, 1) As String 'frequency, total value
    Dim month() As String = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
        For intIndex = 0 To month.GetUpperBound(0)
            Console.WriteLine(month(intIndex).Substring(0, 3) & ":  " & monthArray(intIndex, 1))
        Next
        Console.WriteLine("-----------")
        Console.WriteLine()
        cmbMonth.SelectedIndex = -1
        cmbPrintChoice.SelectedIndex = -1

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim fsrFile As New StreamReader("SalesByMonth.csv")
        Dim strRecord As String
        Dim intArrayValue, intReadValue As Integer
        Dim strSplit(1) As String
        Dim boolDone As Boolean
        Dim decArrayValue, decReadValue As Decimal
        ReDim monthArray(11, 1)
        Reset()
        If cmbMonth.SelectedIndex = -1 Then
            cmbMonth.SelectedIndex = 0
        End If
        If cmbPrintChoice.SelectedIndex = -1 Then
            cmbPrintChoice.SelectedIndex = 0
        End If
        Do
            ReDim strSplit(1)
            strRecord = fsrFile.ReadLine
            strSplit = Split(strRecord, ",")
            For intIndex = 0 To 11
                If strSplit(0) = month(intIndex).Substring(0, 3) Then
                    'Counting Frequency
                    boolDone = Integer.TryParse(monthArray(intIndex, 1), intArrayValue)
                    intArrayValue = intArrayValue + 1
                    monthArray(intIndex, 1) = intArrayValue.ToString
                    'Adding sum
                    boolDone = Decimal.TryParse(strSplit(1), decReadValue)
                    boolDone = Decimal.TryParse(monthArray(intIndex, 0), decArrayValue)
                    decArrayValue = decArrayValue + decReadValue
                    monthArray(intIndex, 0) = decArrayValue.ToString
                End If
            Next
        Loop Until fsrFile.EndOfStream

        For intIndex = cmbMonth.SelectedIndex To month.GetUpperBound(0)
            If cmbPrintChoice.SelectedIndex = 0 Then 'sum
                Console.WriteLine("{0,-9} : ${1,5}", month(intIndex).Substring(0, 3), monthArray(intIndex, 0))
            ElseIf cmbPrintChoice.SelectedIndex = 1 Then 'Count
                Console.WriteLine("{0,-9} : {1,2}", month(intIndex).Substring(0, 3), monthArray(intIndex, 1))
            End If
        Next
        For intIndex = 0 To cmbMonth.SelectedIndex - 1
            If cmbPrintChoice.SelectedIndex = 0 Then 'sum
                Console.WriteLine("{0,-9} : ${1,5}", month(intIndex).Substring(0, 3), monthArray(intIndex, 0))
            ElseIf cmbPrintChoice.SelectedIndex = 1 Then 'Count
                Console.WriteLine("{0,-9} : {1,2}", month(intIndex).Substring(0, 3), monthArray(intIndex, 1))
            End If
        Next
        Console.WriteLine("-----------")
        Console.WriteLine()

    End Sub
    Private Sub Reset()
        ReDim monthArray(11, 1)
        For intIndexA = 0 To 11
            For intIndexB = 0 To 1
                monthArray(intIndexA, intIndexB) = "0"
            Next
        Next
    End Sub

End Class
