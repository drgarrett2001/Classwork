<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMathGame
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
        Me.grpDifficulty = New System.Windows.Forms.GroupBox()
        Me.radHard = New System.Windows.Forms.RadioButton()
        Me.radMed = New System.Windows.Forms.RadioButton()
        Me.radEasy = New System.Windows.Forms.RadioButton()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpDifficulty.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpDifficulty
        '
        Me.grpDifficulty.Controls.Add(Me.radHard)
        Me.grpDifficulty.Controls.Add(Me.radMed)
        Me.grpDifficulty.Controls.Add(Me.radEasy)
        Me.grpDifficulty.Location = New System.Drawing.Point(10, 12)
        Me.grpDifficulty.Name = "grpDifficulty"
        Me.grpDifficulty.Size = New System.Drawing.Size(106, 156)
        Me.grpDifficulty.TabIndex = 0
        Me.grpDifficulty.TabStop = False
        Me.grpDifficulty.Text = "Difficulty"
        '
        'radHard
        '
        Me.radHard.AutoSize = True
        Me.radHard.Location = New System.Drawing.Point(16, 109)
        Me.radHard.Name = "radHard"
        Me.radHard.Size = New System.Drawing.Size(48, 17)
        Me.radHard.TabIndex = 2
        Me.radHard.Text = "Hard"
        Me.radHard.UseVisualStyleBackColor = True
        '
        'radMed
        '
        Me.radMed.AutoSize = True
        Me.radMed.Location = New System.Drawing.Point(16, 70)
        Me.radMed.Name = "radMed"
        Me.radMed.Size = New System.Drawing.Size(62, 17)
        Me.radMed.TabIndex = 1
        Me.radMed.Text = "Medium"
        Me.radMed.UseVisualStyleBackColor = True
        '
        'radEasy
        '
        Me.radEasy.AutoSize = True
        Me.radEasy.Checked = True
        Me.radEasy.Location = New System.Drawing.Point(16, 31)
        Me.radEasy.Name = "radEasy"
        Me.radEasy.Size = New System.Drawing.Size(48, 17)
        Me.radEasy.TabIndex = 0
        Me.radEasy.TabStop = True
        Me.radEasy.Text = "Easy"
        Me.radEasy.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(124, 21)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(75, 61)
        Me.btnPlay.TabIndex = 1
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(124, 99)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 61)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmMathGame
        '
        Me.AcceptButton = Me.btnPlay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(210, 181)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.grpDifficulty)
        Me.Name = "frmMathGame"
        Me.ShowIcon = False
        Me.Text = "Math Game"
        Me.grpDifficulty.ResumeLayout(False)
        Me.grpDifficulty.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpDifficulty As GroupBox
    Friend WithEvents radHard As RadioButton
    Friend WithEvents radMed As RadioButton
    Friend WithEvents radEasy As RadioButton
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnClose As Button
End Class
