<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKRFK
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
        Me.lblGames = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.txtGames = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.chkCertified = New System.Windows.Forms.CheckBox()
        Me.grpGrade = New System.Windows.Forms.GroupBox()
        Me.radSix = New System.Windows.Forms.RadioButton()
        Me.radSeven = New System.Windows.Forms.RadioButton()
        Me.radEight = New System.Windows.Forms.RadioButton()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.grpGrade.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblGames
        '
        Me.lblGames.AutoSize = True
        Me.lblGames.Location = New System.Drawing.Point(24, 31)
        Me.lblGames.Name = "lblGames"
        Me.lblGames.Size = New System.Drawing.Size(62, 13)
        Me.lblGames.TabIndex = 0
        Me.lblGames.Text = "# of Games"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(191, 31)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(81, 13)
        Me.lblCost.TabIndex = 0
        Me.lblCost.Text = "Cost Per Game:"
        '
        'txtGames
        '
        Me.txtGames.Location = New System.Drawing.Point(85, 28)
        Me.txtGames.Name = "txtGames"
        Me.txtGames.Size = New System.Drawing.Size(65, 20)
        Me.txtGames.TabIndex = 1
        Me.txtGames.Text = "0"
        Me.txtGames.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(278, 28)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(65, 20)
        Me.txtCost.TabIndex = 2
        Me.txtCost.Text = "$0.00"
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'chkCertified
        '
        Me.chkCertified.AutoSize = True
        Me.chkCertified.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCertified.Location = New System.Drawing.Point(145, 75)
        Me.chkCertified.Name = "chkCertified"
        Me.chkCertified.Size = New System.Drawing.Size(64, 17)
        Me.chkCertified.TabIndex = 3
        Me.chkCertified.Text = "Certified"
        Me.chkCertified.UseVisualStyleBackColor = True
        '
        'grpGrade
        '
        Me.grpGrade.Controls.Add(Me.radSix)
        Me.grpGrade.Controls.Add(Me.radSeven)
        Me.grpGrade.Controls.Add(Me.radEight)
        Me.grpGrade.Location = New System.Drawing.Point(96, 118)
        Me.grpGrade.Name = "grpGrade"
        Me.grpGrade.Size = New System.Drawing.Size(156, 100)
        Me.grpGrade.TabIndex = 4
        Me.grpGrade.TabStop = False
        Me.grpGrade.Text = "Grade"
        '
        'radSix
        '
        Me.radSix.AutoSize = True
        Me.radSix.Location = New System.Drawing.Point(39, 68)
        Me.radSix.Name = "radSix"
        Me.radSix.Size = New System.Drawing.Size(98, 17)
        Me.radSix.TabIndex = 0
        Me.radSix.TabStop = True
        Me.radSix.Text = "6 (International)"
        Me.radSix.UseVisualStyleBackColor = True
        '
        'radSeven
        '
        Me.radSeven.AutoSize = True
        Me.radSeven.Location = New System.Drawing.Point(39, 44)
        Me.radSeven.Name = "radSeven"
        Me.radSeven.Size = New System.Drawing.Size(95, 17)
        Me.radSeven.TabIndex = 0
        Me.radSeven.TabStop = True
        Me.radSeven.Text = "7 (Competitive)"
        Me.radSeven.UseVisualStyleBackColor = True
        '
        'radEight
        '
        Me.radEight.AutoSize = True
        Me.radEight.Location = New System.Drawing.Point(39, 20)
        Me.radEight.Name = "radEight"
        Me.radEight.Size = New System.Drawing.Size(100, 17)
        Me.radEight.TabIndex = 0
        Me.radEight.TabStop = True
        Me.radEight.Text = "8 (Recreational)"
        Me.radEight.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(91, 231)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(57, 13)
        Me.lblTotal.TabIndex = 4
        Me.lblTotal.Text = "Total Due:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(164, 231)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 0
        Me.txtTotal.TabStop = False
        Me.txtTotal.Text = "$0.00"
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(140, 275)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'frmKRFK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(355, 330)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.grpGrade)
        Me.Controls.Add(Me.chkCertified)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtGames)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblGames)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKRFK"
        Me.ShowIcon = False
        Me.Text = "David Garrett"
        Me.grpGrade.ResumeLayout(False)
        Me.grpGrade.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGames As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents txtGames As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents chkCertified As CheckBox
    Friend WithEvents grpGrade As GroupBox
    Friend WithEvents radSix As RadioButton
    Friend WithEvents radSeven As RadioButton
    Friend WithEvents radEight As RadioButton
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnReset As Button
End Class
