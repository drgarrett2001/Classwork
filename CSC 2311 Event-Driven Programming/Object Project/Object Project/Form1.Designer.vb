<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpTeam = New System.Windows.Forms.GroupBox()
        Me.txtPkmn4 = New System.Windows.Forms.TextBox()
        Me.btnRemoveLast = New System.Windows.Forms.Button()
        Me.lblPkmn6 = New System.Windows.Forms.Label()
        Me.lblPkmn5 = New System.Windows.Forms.Label()
        Me.lblPkmn4 = New System.Windows.Forms.Label()
        Me.lblPkmn3 = New System.Windows.Forms.Label()
        Me.lblPkmn2 = New System.Windows.Forms.Label()
        Me.lblPkmn1 = New System.Windows.Forms.Label()
        Me.txtPkmn6 = New System.Windows.Forms.TextBox()
        Me.txtPkmn3 = New System.Windows.Forms.TextBox()
        Me.txtPkmn5 = New System.Windows.Forms.TextBox()
        Me.txtPkmn2 = New System.Windows.Forms.TextBox()
        Me.txtPkmn1 = New System.Windows.Forms.TextBox()
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.grpSelected = New System.Windows.Forms.GroupBox()
        Me.lblStatValues = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblStatNames = New System.Windows.Forms.Label()
        Me.lblStats = New System.Windows.Forms.Label()
        Me.grpSearchBy = New System.Windows.Forms.GroupBox()
        Me.radAlphabetical = New System.Windows.Forms.RadioButton()
        Me.radStatTotal = New System.Windows.Forms.RadioButton()
        Me.radSpecStat = New System.Windows.Forms.RadioButton()
        Me.cmbSearch = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.grpTeam.SuspendLayout()
        Me.grpSearch.SuspendLayout()
        Me.grpSelected.SuspendLayout()
        Me.grpSearchBy.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpTeam
        '
        Me.grpTeam.Controls.Add(Me.txtPkmn4)
        Me.grpTeam.Controls.Add(Me.btnRemoveLast)
        Me.grpTeam.Controls.Add(Me.lblPkmn6)
        Me.grpTeam.Controls.Add(Me.lblPkmn5)
        Me.grpTeam.Controls.Add(Me.lblPkmn4)
        Me.grpTeam.Controls.Add(Me.lblPkmn3)
        Me.grpTeam.Controls.Add(Me.lblPkmn2)
        Me.grpTeam.Controls.Add(Me.lblPkmn1)
        Me.grpTeam.Controls.Add(Me.txtPkmn6)
        Me.grpTeam.Controls.Add(Me.txtPkmn3)
        Me.grpTeam.Controls.Add(Me.txtPkmn5)
        Me.grpTeam.Controls.Add(Me.txtPkmn2)
        Me.grpTeam.Controls.Add(Me.txtPkmn1)
        Me.grpTeam.Location = New System.Drawing.Point(21, 249)
        Me.grpTeam.Name = "grpTeam"
        Me.grpTeam.Size = New System.Drawing.Size(381, 213)
        Me.grpTeam.TabIndex = 2
        Me.grpTeam.TabStop = False
        Me.grpTeam.Text = "Your Team"
        '
        'txtPkmn4
        '
        Me.txtPkmn4.Location = New System.Drawing.Point(214, 92)
        Me.txtPkmn4.Name = "txtPkmn4"
        Me.txtPkmn4.ReadOnly = True
        Me.txtPkmn4.Size = New System.Drawing.Size(100, 20)
        Me.txtPkmn4.TabIndex = 13
        Me.txtPkmn4.TabStop = False
        Me.txtPkmn4.Text = " "
        Me.txtPkmn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnRemoveLast
        '
        Me.btnRemoveLast.Location = New System.Drawing.Point(147, 179)
        Me.btnRemoveLast.Name = "btnRemoveLast"
        Me.btnRemoveLast.Size = New System.Drawing.Size(87, 23)
        Me.btnRemoveLast.TabIndex = 12
        Me.btnRemoveLast.Text = "Remove Last"
        Me.btnRemoveLast.UseVisualStyleBackColor = True
        '
        'lblPkmn6
        '
        Me.lblPkmn6.AutoSize = True
        Me.lblPkmn6.Location = New System.Drawing.Point(214, 128)
        Me.lblPkmn6.Name = "lblPkmn6"
        Me.lblPkmn6.Size = New System.Drawing.Size(34, 13)
        Me.lblPkmn6.TabIndex = 11
        Me.lblPkmn6.Text = "Slot 6"
        '
        'lblPkmn5
        '
        Me.lblPkmn5.AutoSize = True
        Me.lblPkmn5.Location = New System.Drawing.Point(67, 129)
        Me.lblPkmn5.Name = "lblPkmn5"
        Me.lblPkmn5.Size = New System.Drawing.Size(37, 13)
        Me.lblPkmn5.TabIndex = 10
        Me.lblPkmn5.Text = "Slot 5:"
        '
        'lblPkmn4
        '
        Me.lblPkmn4.AutoSize = True
        Me.lblPkmn4.Location = New System.Drawing.Point(214, 77)
        Me.lblPkmn4.Name = "lblPkmn4"
        Me.lblPkmn4.Size = New System.Drawing.Size(37, 13)
        Me.lblPkmn4.TabIndex = 9
        Me.lblPkmn4.Text = "Slot 4:"
        '
        'lblPkmn3
        '
        Me.lblPkmn3.AutoSize = True
        Me.lblPkmn3.Location = New System.Drawing.Point(67, 78)
        Me.lblPkmn3.Name = "lblPkmn3"
        Me.lblPkmn3.Size = New System.Drawing.Size(37, 13)
        Me.lblPkmn3.TabIndex = 8
        Me.lblPkmn3.Text = "Slot 3:"
        '
        'lblPkmn2
        '
        Me.lblPkmn2.AutoSize = True
        Me.lblPkmn2.Location = New System.Drawing.Point(214, 26)
        Me.lblPkmn2.Name = "lblPkmn2"
        Me.lblPkmn2.Size = New System.Drawing.Size(37, 13)
        Me.lblPkmn2.TabIndex = 7
        Me.lblPkmn2.Text = "Slot 2:"
        '
        'lblPkmn1
        '
        Me.lblPkmn1.AutoSize = True
        Me.lblPkmn1.Location = New System.Drawing.Point(67, 27)
        Me.lblPkmn1.Name = "lblPkmn1"
        Me.lblPkmn1.Size = New System.Drawing.Size(37, 13)
        Me.lblPkmn1.TabIndex = 6
        Me.lblPkmn1.Text = "Slot 1:"
        '
        'txtPkmn6
        '
        Me.txtPkmn6.Location = New System.Drawing.Point(214, 142)
        Me.txtPkmn6.Name = "txtPkmn6"
        Me.txtPkmn6.ReadOnly = True
        Me.txtPkmn6.Size = New System.Drawing.Size(100, 20)
        Me.txtPkmn6.TabIndex = 5
        Me.txtPkmn6.TabStop = False
        Me.txtPkmn6.Text = " "
        Me.txtPkmn6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPkmn3
        '
        Me.txtPkmn3.Location = New System.Drawing.Point(66, 92)
        Me.txtPkmn3.Name = "txtPkmn3"
        Me.txtPkmn3.ReadOnly = True
        Me.txtPkmn3.Size = New System.Drawing.Size(100, 20)
        Me.txtPkmn3.TabIndex = 3
        Me.txtPkmn3.TabStop = False
        Me.txtPkmn3.Text = " "
        Me.txtPkmn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPkmn5
        '
        Me.txtPkmn5.Location = New System.Drawing.Point(66, 142)
        Me.txtPkmn5.Name = "txtPkmn5"
        Me.txtPkmn5.ReadOnly = True
        Me.txtPkmn5.Size = New System.Drawing.Size(100, 20)
        Me.txtPkmn5.TabIndex = 2
        Me.txtPkmn5.TabStop = False
        Me.txtPkmn5.Text = " "
        Me.txtPkmn5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPkmn2
        '
        Me.txtPkmn2.Location = New System.Drawing.Point(214, 42)
        Me.txtPkmn2.Name = "txtPkmn2"
        Me.txtPkmn2.ReadOnly = True
        Me.txtPkmn2.Size = New System.Drawing.Size(100, 20)
        Me.txtPkmn2.TabIndex = 1
        Me.txtPkmn2.TabStop = False
        Me.txtPkmn2.Text = " "
        Me.txtPkmn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPkmn1
        '
        Me.txtPkmn1.Location = New System.Drawing.Point(66, 42)
        Me.txtPkmn1.Name = "txtPkmn1"
        Me.txtPkmn1.ReadOnly = True
        Me.txtPkmn1.Size = New System.Drawing.Size(100, 20)
        Me.txtPkmn1.TabIndex = 0
        Me.txtPkmn1.TabStop = False
        Me.txtPkmn1.Text = " "
        Me.txtPkmn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'grpSearch
        '
        Me.grpSearch.Controls.Add(Me.cmbType)
        Me.grpSearch.Controls.Add(Me.grpSelected)
        Me.grpSearch.Controls.Add(Me.grpSearchBy)
        Me.grpSearch.Controls.Add(Me.cmbSearch)
        Me.grpSearch.Controls.Add(Me.btnAdd)
        Me.grpSearch.Location = New System.Drawing.Point(21, 12)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(381, 231)
        Me.grpSearch.TabIndex = 1
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search Box"
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(47, 135)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(121, 21)
        Me.cmbType.TabIndex = 7
        Me.cmbType.Visible = False
        '
        'grpSelected
        '
        Me.grpSelected.Controls.Add(Me.lblStatValues)
        Me.grpSelected.Controls.Add(Me.lblName)
        Me.grpSelected.Controls.Add(Me.lblStatNames)
        Me.grpSelected.Controls.Add(Me.lblStats)
        Me.grpSelected.Location = New System.Drawing.Point(198, 35)
        Me.grpSelected.Name = "grpSelected"
        Me.grpSelected.Size = New System.Drawing.Size(162, 167)
        Me.grpSelected.TabIndex = 6
        Me.grpSelected.TabStop = False
        Me.grpSelected.Text = "Selected Pokemon"
        '
        'lblStatValues
        '
        Me.lblStatValues.AutoSize = True
        Me.lblStatValues.Location = New System.Drawing.Point(89, 61)
        Me.lblStatValues.Name = "lblStatValues"
        Me.lblStatValues.Size = New System.Drawing.Size(13, 91)
        Me.lblStatValues.TabIndex = 4
        Me.lblStatValues.Text = "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(54, 23)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(54, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Bulbasaur"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblStatNames
        '
        Me.lblStatNames.AutoSize = True
        Me.lblStatNames.Location = New System.Drawing.Point(32, 61)
        Me.lblStatNames.Name = "lblStatNames"
        Me.lblStatNames.Size = New System.Drawing.Size(56, 91)
        Me.lblStatNames.TabIndex = 1
        Me.lblStatNames.Text = "HP:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Atk:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Def: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SpA:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SpD:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Spe:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Stat Total:"
        Me.lblStatNames.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblStats
        '
        Me.lblStats.AutoSize = True
        Me.lblStats.Location = New System.Drawing.Point(64, 46)
        Me.lblStats.Name = "lblStats"
        Me.lblStats.Size = New System.Drawing.Size(34, 13)
        Me.lblStats.TabIndex = 0
        Me.lblStats.Text = "Stats:"
        Me.lblStats.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'grpSearchBy
        '
        Me.grpSearchBy.Controls.Add(Me.radAlphabetical)
        Me.grpSearchBy.Controls.Add(Me.radStatTotal)
        Me.grpSearchBy.Controls.Add(Me.radSpecStat)
        Me.grpSearchBy.Location = New System.Drawing.Point(47, 35)
        Me.grpSearchBy.Name = "grpSearchBy"
        Me.grpSearchBy.Size = New System.Drawing.Size(123, 93)
        Me.grpSearchBy.TabIndex = 1
        Me.grpSearchBy.TabStop = False
        Me.grpSearchBy.Text = "Sort by:"
        '
        'radAlphabetical
        '
        Me.radAlphabetical.AutoSize = True
        Me.radAlphabetical.Location = New System.Drawing.Point(19, 19)
        Me.radAlphabetical.Name = "radAlphabetical"
        Me.radAlphabetical.Size = New System.Drawing.Size(90, 17)
        Me.radAlphabetical.TabIndex = 1
        Me.radAlphabetical.TabStop = True
        Me.radAlphabetical.Text = "Alphabetically"
        Me.radAlphabetical.UseVisualStyleBackColor = True
        '
        'radStatTotal
        '
        Me.radStatTotal.AutoSize = True
        Me.radStatTotal.Location = New System.Drawing.Point(19, 40)
        Me.radStatTotal.Name = "radStatTotal"
        Me.radStatTotal.Size = New System.Drawing.Size(71, 17)
        Me.radStatTotal.TabIndex = 2
        Me.radStatTotal.TabStop = True
        Me.radStatTotal.Text = "Stat Total"
        Me.radStatTotal.UseVisualStyleBackColor = True
        '
        'radSpecStat
        '
        Me.radSpecStat.AutoSize = True
        Me.radSpecStat.Location = New System.Drawing.Point(19, 61)
        Me.radSpecStat.Name = "radSpecStat"
        Me.radSpecStat.Size = New System.Drawing.Size(85, 17)
        Me.radSpecStat.TabIndex = 3
        Me.radSpecStat.TabStop = True
        Me.radSpecStat.Text = "Specific Stat"
        Me.radSpecStat.UseVisualStyleBackColor = True
        '
        'cmbSearch
        '
        Me.cmbSearch.FormattingEnabled = True
        Me.cmbSearch.Location = New System.Drawing.Point(47, 164)
        Me.cmbSearch.Name = "cmbSearch"
        Me.cmbSearch.Size = New System.Drawing.Size(123, 21)
        Me.cmbSearch.TabIndex = 4
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(66, 196)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(85, 23)
        Me.btnAdd.TabIndex = 5
        Me.btnAdd.Text = "Add to Team"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(237, 478)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(111, 478)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 8
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(422, 521)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpSearch)
        Me.Controls.Add(Me.grpTeam)
        Me.Name = "frmMain"
        Me.ShowIcon = False
        Me.Text = "Pokemon Team Build"
        Me.grpTeam.ResumeLayout(False)
        Me.grpTeam.PerformLayout()
        Me.grpSearch.ResumeLayout(False)
        Me.grpSelected.ResumeLayout(False)
        Me.grpSelected.PerformLayout()
        Me.grpSearchBy.ResumeLayout(False)
        Me.grpSearchBy.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpTeam As GroupBox
    Friend WithEvents btnRemoveLast As Button
    Friend WithEvents lblPkmn6 As Label
    Friend WithEvents lblPkmn5 As Label
    Friend WithEvents lblPkmn4 As Label
    Friend WithEvents lblPkmn3 As Label
    Friend WithEvents lblPkmn2 As Label
    Friend WithEvents lblPkmn1 As Label
    Friend WithEvents txtPkmn6 As TextBox
    Friend WithEvents txtPkmn3 As TextBox
    Friend WithEvents txtPkmn5 As TextBox
    Friend WithEvents txtPkmn2 As TextBox
    Friend WithEvents txtPkmn1 As TextBox
    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents grpSearchBy As GroupBox
    Friend WithEvents radStatTotal As RadioButton
    Friend WithEvents radSpecStat As RadioButton
    Friend WithEvents cmbSearch As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents radAlphabetical As RadioButton
    Friend WithEvents grpSelected As GroupBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblStatNames As Label
    Friend WithEvents lblStats As Label
    Friend WithEvents lblStatValues As Label
    Friend WithEvents txtPkmn4 As TextBox
    Friend WithEvents cmbType As ComboBox
End Class
