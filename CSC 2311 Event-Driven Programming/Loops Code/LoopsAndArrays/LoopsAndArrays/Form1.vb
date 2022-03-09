Option Strict On
Public Class frmExamples

    Private Sub btnExample1_Click(sender As Object, e As EventArgs) Handles btnExample1.Click
        Dim intIndex As Integer

        Console.WriteLine()
        Console.WriteLine(StrDup(8, "-"))
        Console.WriteLine("example1")
        Console.WriteLine(intIndex)
        Console.WriteLine(StrDup(8, "-"))

        For intIndex = 1 To 5
            Console.WriteLine(intIndex)
        Next

        Console.WriteLine(StrDup(5, "-"))
        Console.WriteLine(intIndex)

    End Sub

    Private Sub btnExample2_Click(sender As Object, e As EventArgs) Handles btnExample2.Click

        Dim intIndex As Integer

        Console.WriteLine()
        Console.WriteLine(StrDup(8, "-"))
        Console.WriteLine("example2")
        Console.WriteLine(intIndex)
        Console.WriteLine(StrDup(8, "-"))

        intIndex = 1
        Do Until intIndex > 5
            Console.WriteLine(intIndex)
            intIndex += 1
        Loop

    End Sub

    Private Sub btnExample3_Click(sender As Object, e As EventArgs) Handles btnExample3.Click
        Dim intInteger0, intInteger1, intInteger2, intInteger3, intInteger4 As Integer

        Console.WriteLine()
        Console.WriteLine(StrDup(8, "-"))
        Console.WriteLine("example3")
        Console.WriteLine(StrDup(8, "-"))

        intInteger0 = 0 * 2
        intInteger1 = 1 * 2
        intInteger2 = 2 * 2
        intInteger3 = 3 * 2
        intInteger4 = 4 * 2

        Console.WriteLine(intInteger0)
        Console.WriteLine(intInteger1)
        Console.WriteLine(intInteger2)
        Console.WriteLine(intInteger3)
        Console.WriteLine(intInteger4)

        Console.WriteLine(intInteger4)
        Console.WriteLine(intInteger3)
        Console.WriteLine(intInteger2)
        Console.WriteLine(intInteger1)
        Console.WriteLine(intInteger0)

    End Sub

    Private Sub btnExample4_Click(sender As Object, e As EventArgs) Handles btnExample4.Click
        Dim intInteger(4), intIndex As Integer

        Console.WriteLine()
        Console.WriteLine(StrDup(10, "-"))
        Console.WriteLine("example4.1")
        Console.WriteLine(StrDup(10, "-"))

        For intIndex = 0 To 4
            intInteger(intIndex) = intIndex * 2
            Console.WriteLine(intInteger(intIndex))
        Next

        Console.WriteLine()
        Console.WriteLine(StrDup(10, "-"))
        Console.WriteLine("example4.2")
        Console.WriteLine(StrDup(10, "-"))

        For intIndex = 4 To 0 Step -1
            Console.WriteLine(intInteger(intIndex))
        Next

    End Sub

    Private Sub btnExample5_Click(sender As Object, e As EventArgs) Handles btnExample5.Click
        Dim shrTable(9, 9) As Short
        Dim intRow, intColumn As Integer

        For intRow = 0 To 9
            For intColumn = 0 To 9
                shrTable(intRow, intColumn) = CShort(intRow + intColumn)
            Next intColumn
        Next intRow

        Console.WriteLine()
        Console.WriteLine(StrDup(10, "-"))
        Console.WriteLine("example5.1")
        Console.WriteLine(StrDup(10, "-"))

        For intRow = 9 To 0 Step -1
            For intColumn = 0 To 9
                Console.WriteLine(intRow & " " & intColumn & " " & shrTable(intRow, intColumn))
            Next intColumn
            Console.WriteLine()
        Next intRow

        Console.WriteLine()
        Console.WriteLine(StrDup(10, "-"))
        Console.WriteLine("example5.2")
        Console.WriteLine(StrDup(10, "-"))

        For intRow = 0 To 9 Step 1
            For intColumn = 0 To 9 Step 1
                Console.Write(shrTable(intRow, intColumn) & " ")
            Next intColumn
            Console.WriteLine()
        Next intRow


    End Sub

    Private Sub btnExample6_Click(sender As Object, e As EventArgs) Handles btnExample6.Click
        Dim strMonth() As String = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
        Dim strWeek() As String = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"}
        Dim intRow As Integer

        Console.WriteLine()
        Console.WriteLine(StrDup(10, "-"))
        Console.WriteLine("example6.1")
        Console.WriteLine(StrDup(10, "-"))


        For intRow = 0 To 11 Step 1
            Console.WriteLine(intRow & " " & strMonth(intRow))
        Next

        Console.WriteLine()
        Console.WriteLine(StrDup(10, "-"))
        Console.WriteLine("example6.2")
        Console.WriteLine(StrDup(10, "-"))

        For intRow = 0 To 11 Step 1
            If strMonth(intRow) = txtExample6.Text Then
                Console.WriteLine(intRow & " " & strMonth(intRow))
                Exit For
            Else
                Console.WriteLine(intRow)
            End If
        Next

        Console.WriteLine()
        Console.WriteLine(StrDup(10, "-"))
        Console.WriteLine("example6.1")
        Console.WriteLine(StrDup(10, "-"))


        For intRow = 0 To 6 Step 1
            Console.WriteLine(intRow & " " & strWeek(intRow))
        Next

    End Sub

    Private Sub btnExample7_Click(sender As Object, e As EventArgs) Handles btnExample7.Click
        Dim int1dArray(,), int2dArray(,), int3dArray(,,) As Integer

        Console.WriteLine()
        Console.WriteLine(StrDup(10, "-"))
        Console.WriteLine("example7.1")
        Console.WriteLine(StrDup(10, "-"))

        ReDim int1dArray(9, 3)

        Console.WriteLine("length:" & int1dArray.Length)


        Console.WriteLine()
        Console.WriteLine(int1dArray.GetUpperBound(0))
        Console.WriteLine(int1dArray.GetLength(0))

        Console.WriteLine()
        Console.WriteLine(StrDup(10, "-"))
        Console.WriteLine("example7.2")
        Console.WriteLine(StrDup(10, "-"))

        ReDim int2dArray(15, 7)

        Console.WriteLine()
        Console.WriteLine(int2dArray.GetUpperBound(0))
        Console.WriteLine(int2dArray.GetLength(0))
        Console.WriteLine(int2dArray.GetUpperBound(1))
        Console.WriteLine(int2dArray.GetLength(1))

        Console.WriteLine()
        Console.WriteLine(StrDup(10, "-"))
        Console.WriteLine("example7.3")
        Console.WriteLine(StrDup(10, "-"))

        ReDim int3dArray(15, 7, 4)

        Console.WriteLine()
        Console.WriteLine(int3dArray.GetUpperBound(0))
        Console.WriteLine(int3dArray.GetLength(0))
        Console.WriteLine(int3dArray.GetUpperBound(1))
        Console.WriteLine(int3dArray.GetLength(1))
        Console.WriteLine(int3dArray.GetUpperBound(2))
        Console.WriteLine(int3dArray.GetLength(2))

    End Sub

    Private Sub btnExample8_Click(sender As Object, e As EventArgs) Handles btnExample8.Click
        Dim intCounts(), intRow As Integer

        Console.WriteLine()
        Console.WriteLine(StrDup(10, "-"))
        Console.WriteLine("example8.1")
        Console.WriteLine(StrDup(10, "-"))

        ReDim intCounts(9)          ' ReDim can occur 1 or more times anywhere after Dim statement
        For intRow = 0 To intCounts.GetUpperBound(0)
            intCounts(intRow) = intRow
        Next

        For intRow = intCounts.GetUpperBound(0) To 0 Step -1
            Console.WriteLine(intCounts(intRow))
        Next

        Console.WriteLine()
        Console.WriteLine(StrDup(10, "-"))
        Console.WriteLine("example8.2")
        Console.WriteLine(StrDup(10, "-"))

        ReDim Preserve intCounts(20) ' Redim Preserve doesn't reinitialize array values to default (0)

        For intRow = 0 To intCounts.GetUpperBound(0)
            Console.WriteLine(intRow & " " & intCounts(intRow))
        Next

        Console.WriteLine()
        Console.WriteLine(StrDup(10, "-"))
        Console.WriteLine("example8.3")
        Console.WriteLine(StrDup(10, "-"))

        ReDim intCounts(20) ' Redim does reinitialize array values to default (0)

        For intRow = 0 To intCounts.GetUpperBound(0)
            Console.WriteLine(intRow & " " & intCounts(intRow))
        Next

        Console.WriteLine()
        Console.WriteLine(StrDup(10, "-"))
        Console.WriteLine("example8.4")
        Console.WriteLine(StrDup(10, "-"))


        For intRow = 0 To intCounts.GetUpperBound(0)
            intCounts(intRow) = intRow
        Next

        For intRow = intCounts.GetUpperBound(0) To 0 Step -1
            Console.WriteLine(intCounts(intRow))
        Next

        Console.WriteLine()
        Console.WriteLine(StrDup(10, "-"))
        Console.WriteLine("example8.5")
        Console.WriteLine(StrDup(10, "-"))

        ReDim intCounts(5)
        For intRow = 0 To intCounts.GetUpperBound(0)
            intCounts(intRow) = intRow
        Next

        For intRow = intCounts.GetUpperBound(0) To 0 Step -1
            Console.WriteLine(intCounts(intRow))
        Next

    End Sub
End Class
