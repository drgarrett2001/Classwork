<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuessingGame
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
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpDifficulty = New System.Windows.Forms.GroupBox()
        Me.RadVeteran = New System.Windows.Forms.RadioButton()
        Me.radHard = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radEasy = New System.Windows.Forms.RadioButton()
        Me.grpDifficulty.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(31, 142)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 23)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(119, 142)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpDifficulty
        '
        Me.grpDifficulty.Controls.Add(Me.RadVeteran)
        Me.grpDifficulty.Controls.Add(Me.radHard)
        Me.grpDifficulty.Controls.Add(Me.radMedium)
        Me.grpDifficulty.Controls.Add(Me.radEasy)
        Me.grpDifficulty.Location = New System.Drawing.Point(31, 12)
        Me.grpDifficulty.Name = "grpDifficulty"
        Me.grpDifficulty.Size = New System.Drawing.Size(163, 124)
        Me.grpDifficulty.TabIndex = 2
        Me.grpDifficulty.TabStop = False
        Me.grpDifficulty.Text = "Difficulty"
        '
        'RadVeteran
        '
        Me.RadVeteran.AutoSize = True
        Me.RadVeteran.Location = New System.Drawing.Point(7, 92)
        Me.RadVeteran.Name = "RadVeteran"
        Me.RadVeteran.Size = New System.Drawing.Size(62, 17)
        Me.RadVeteran.TabIndex = 3
        Me.RadVeteran.TabStop = True
        Me.RadVeteran.Text = "Veteran"
        Me.RadVeteran.UseVisualStyleBackColor = True
        '
        'radHard
        '
        Me.radHard.AutoSize = True
        Me.radHard.Location = New System.Drawing.Point(7, 68)
        Me.radHard.Name = "radHard"
        Me.radHard.Size = New System.Drawing.Size(48, 17)
        Me.radHard.TabIndex = 2
        Me.radHard.TabStop = True
        Me.radHard.Text = "Hard"
        Me.radHard.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(7, 44)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(62, 17)
        Me.radMedium.TabIndex = 1
        Me.radMedium.TabStop = True
        Me.radMedium.Text = "Medium"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radEasy
        '
        Me.radEasy.AutoSize = True
        Me.radEasy.Location = New System.Drawing.Point(7, 20)
        Me.radEasy.Name = "radEasy"
        Me.radEasy.Size = New System.Drawing.Size(48, 17)
        Me.radEasy.TabIndex = 0
        Me.radEasy.TabStop = True
        Me.radEasy.Text = "Easy"
        Me.radEasy.UseVisualStyleBackColor = True
        '
        'frmGuessingGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(225, 184)
        Me.Controls.Add(Me.grpDifficulty)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPlay)
        Me.Name = "frmGuessingGame"
        Me.ShowIcon = False
        Me.Text = "Form1"
        Me.grpDifficulty.ResumeLayout(False)
        Me.grpDifficulty.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPlay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpDifficulty As GroupBox
    Friend WithEvents RadVeteran As RadioButton
    Friend WithEvents radHard As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radEasy As RadioButton
End Class
