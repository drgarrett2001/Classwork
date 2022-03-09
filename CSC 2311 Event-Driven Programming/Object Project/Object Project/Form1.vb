Option Strict On
'David Garrett
Imports PokemonClass
Imports System.IO

Public Class frmMain
    Dim pokeArray(19) As Pokemon
    Dim sortedPokeArray(19) As Pokemon
    Dim teamArray(5) As Pokemon
    Dim txtboxTeam() As TextBox = {txtPkmn1, txtPkmn2, txtPkmn3, txtPkmn4, txtPkmn5, txtPkmn6}
    Dim selected As Pokemon
    'button array to adjsut values
    Dim emptySlot As Integer
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub pkmnSelect(Poke As Pokemon)
        selected = Poke
        lblName.Text = Poke.prpName()
        lblStatValues.Text = String.Format(CStr(Poke.prpHP()) & Environment.NewLine & CStr(Poke.prpAtk()) & Environment.NewLine & CStr(Poke.prpDef()) & Environment.NewLine & CStr(Poke.prpSpA()) & Environment.NewLine & CStr(Poke.prpSpD()) & Environment.NewLine & CStr(Poke.prpSpe()) & Environment.NewLine & CStr(Poke.prpStatTotal()))

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearch.SelectedIndexChanged
        pkmnSelect(sortedPokeArray(cmbSearch.SelectedIndex()))

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strnewName As String
        Dim boolSuccess As Boolean
        If selected Is Nothing Then
            MsgBox("Please select a Pokemon.")
        ElseIf emptySlot < 6 Then
            teamArray(emptySlot) = selected
            strnewName = selected.prpName
            boolSuccess = True
            If emptySlot = 0 Then
                    txtPkmn1.Text = strnewName
                ElseIf emptySlot = 1 Then
                    txtPkmn2.Text = strnewName
                ElseIf emptySlot = 2 Then
                    txtPkmn3.Text = strnewName
                ElseIf emptySlot = 3 Then
                    txtPkmn4.Text = strnewName
                ElseIf emptySlot = 4 Then
                    txtPkmn5.Text = strnewName
                ElseIf emptySlot = 5 Then
                    txtPkmn6.Text = strnewName
                End If
                emptySlot += 1


            End If

    End Sub

    Private Sub btnRemoveLast_Click(sender As Object, e As EventArgs) Handles btnRemoveLast.Click
        If emptySlot = 0 Then
            MsgBox("Your team is empty.")
        ElseIf emptySlot = 1 Then
            txtPkmn1.Text = ""
            emptySlot -= 1
        ElseIf emptySlot = 2 Then
            txtPkmn2.Text = ""
            emptySlot -= 1
        ElseIf emptySlot = 3 Then
            txtPkmn3.Text = ""
            emptySlot -= 1
        ElseIf emptySlot = 4 Then
            txtPkmn4.Text = ""
            emptySlot -= 1
        ElseIf emptySlot = 5 Then
            txtPkmn5.Text = ""
            emptySlot -= 1
        ElseIf emptySlot = 6 Then
            txtPkmn6.Text = ""
            emptySlot -= 1
        End If

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbType.Items.Add("HP")
        cmbType.Items.Add("Atk")
        cmbType.Items.Add("Def")
        cmbType.Items.Add("SpA")
        cmbType.Items.Add("SpD")
        cmbType.Items.Add("Spe")

        Dim fsrFile As New StreamReader("myData.csv")
        Dim strLine, strSplitLine(7) As String
        Dim intIndex As Integer = 0

        Do
            strLine = fsrFile.ReadLine()
            strSplitLine = Split(strLine, ",")

            pokeArray(intIndex) = New Pokemon(strSplitLine(0), Integer.Parse(strSplitLine(1)), Integer.Parse(strSplitLine(2)), Integer.Parse(strSplitLine(3)), Integer.Parse(strSplitLine(4)), Integer.Parse(strSplitLine(5)), Integer.Parse(strSplitLine(6)))
            sortedPokeArray(intIndex) = pokeArray(intIndex)
            intIndex += 1
        Loop Until fsrFile.EndOfStream
        emptySlot = 0

        reset()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        reset()
    End Sub

    Private Sub reset()
        Dim arrayCleaner(5) As Pokemon
        teamArray = arrayCleaner
        lblName.Text = ""

        lblStatValues.Text = "0" & Environment.NewLine & "0" & Environment.NewLine & "0" & Environment.NewLine & "0" & Environment.NewLine & "0" & Environment.NewLine & "0" & Environment.NewLine & "0"
        txtPkmn1.Text = ""
        txtPkmn2.Text = ""
        txtPkmn3.Text = ""
        txtPkmn4.Text = ""
        txtPkmn5.Text = ""
        txtPkmn6.Text = ""
        emptySlot = 0
        cmbSearch.Items.Clear()
        cmbType.Text = ""
        cmbSearch.Text = ""
        radAlphabetical.Focus()
        selected = Nothing

    End Sub

    Private Sub radAlphabetical_CheckedChanged(sender As Object, e As EventArgs) Handles radAlphabetical.CheckedChanged
        If radAlphabetical.Checked Then
            arraySort("ABC")
        Else
            cmbSearch.Items.Clear()
        End If
    End Sub

    Private Sub radSpecStat_CheckedChanged(sender As Object, e As EventArgs) Handles radSpecStat.CheckedChanged
        If radSpecStat.Checked Then
            cmbType.Visible = True
            cmbSearch.Enabled = False

        Else
            cmbType.Visible = False
            cmbSearch.Items.Clear()
        End If
    End Sub

    Private Sub radStatTotal_CheckedChanged(sender As Object, e As EventArgs) Handles radStatTotal.CheckedChanged
        If radStatTotal.Checked Then
            arraySort("StatTotal")
        Else
            cmbSearch.Items.Clear()
        End If
    End Sub
    Private Sub arraySort(method As String)
        Dim presortedPokeArray(19) As Pokemon
        Dim SortByArray(19) As Integer
        If method = "StatTotal" Then
            For intIndex = 0 To 19
                SortByArray(intIndex) = pokeArray(intIndex).prpStatTotal
                presortedPokeArray(intIndex) = pokeArray(intIndex)
            Next
        ElseIf method = "HP" Then
            For intIndex = 0 To 19
                SortByArray(intIndex) = pokeArray(intIndex).prpHP
                presortedPokeArray(intIndex) = pokeArray(intIndex)
            Next
        ElseIf method = "Atk" Then
            For intIndex = 0 To 19
                SortByArray(intIndex) = pokeArray(intIndex).prpAtk
                presortedPokeArray(intIndex) = pokeArray(intIndex)
            Next
        ElseIf method = "Def" Then
            For intIndex = 0 To 19
                SortByArray(intIndex) = pokeArray(intIndex).prpDef
                presortedPokeArray(intIndex) = pokeArray(intIndex)
            Next
        ElseIf method = "SpA" Then
            For intIndex = 0 To 19
                SortByArray(intIndex) = pokeArray(intIndex).prpSpA
                presortedPokeArray(intIndex) = pokeArray(intIndex)
            Next
        ElseIf method = "SpD" Then
            For intIndex = 0 To 19
                SortByArray(intIndex) = pokeArray(intIndex).prpSpD
                presortedPokeArray(intIndex) = pokeArray(intIndex)
            Next
        ElseIf method = "Spe" Then
            For intIndex = 0 To 19
                SortByArray(intIndex) = pokeArray(intIndex).prpSpe
                presortedPokeArray(intIndex) = pokeArray(intIndex)
            Next
        End If
        Array.Sort(SortByArray, presortedPokeArray)
        If method = "ABC" Then
            For intIndex = 0 To 19
                sortedPokeArray(intIndex) = pokeArray(intIndex)
                cmbSearch.Items.Add(sortedPokeArray(intIndex).prpName)
            Next
        Else
            For intIndex = 0 To 19
                sortedPokeArray(intIndex) = presortedPokeArray(19 - intIndex)
                cmbSearch.Items.Add(sortedPokeArray(intIndex).prpName)
            Next
        End If
    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        cmbSearch.Enabled = True
        cmbSearch.Items.Clear()

        If cmbType.SelectedIndex = 0 Then
            arraySort("HP")
        ElseIf cmbType.SelectedIndex = 1 Then
            arraySort("Atk")
        ElseIf cmbType.SelectedIndex = 2 Then
            arraySort("Def")
        ElseIf cmbType.SelectedIndex = 3 Then
            arraySort("SpA")
        ElseIf cmbType.SelectedIndex = 4 Then
            arraySort("SpD")
        ElseIf cmbType.SelectedIndex = 5 Then
            arraySort("Spe")
        End If
    End Sub
End Class