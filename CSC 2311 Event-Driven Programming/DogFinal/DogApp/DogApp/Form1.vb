Option Strict On
'David Garrett
Imports DogClass
Imports System.IO

Public Class frmDogApp
    Dim DogAry(49) As Dog
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        For intIndex = 0 To 49
            If String.Equals(cmbBreed.SelectedItem, DogAry(intIndex).prpBreed) Then
                If (DogAry(intIndex).prpAge < 2 And radLessThanTwo.Checked) Then
                    Console.WriteLine(DogAry(intIndex).funReturnClassAttributes())
                ElseIf DogAry(intIndex).prpAge > 2 And DogAry(intIndex).prpAge < 8 And radTwoToEight.Checked Then
                    Console.WriteLine(DogAry(intIndex).funReturnClassAttributes())
                ElseIf (DogAry(intIndex).prpAge > 8 And radMoreThanEight.Checked) Then
                    Console.WriteLine(DogAry(intIndex).funReturnClassAttributes())
                End If
            End If
        Next
    End Sub

    Private Sub frmDogApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbBreed.Items.Add("Lab")
        cmbBreed.Items.Add("Pug")
        cmbBreed.Items.Add("Husky")
        cmbBreed.Items.Add("Aussie")
        cmbBreed.Items.Add("GSD")
        cmbBreed.Items.Add("Poodle")

        Dim fsrFile As New StreamReader("dogData.csv")
        Dim strLine, strSplitLine(2) As String
        Dim IntIndex As Integer = 0

        Do
            strLine = fsrFile.ReadLine()
            strSplitLine = Split(strLine, ",")

            DogAry(IntIndex) = New Dog(strSplitLine(0), strSplitLine(1), CInt(strSplitLine(2)))
            IntIndex += 1
        Loop Until fsrFile.EndOfStream


    End Sub
End Class
