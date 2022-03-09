<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHCMFC
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
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.radSenior = New System.Windows.Forms.RadioButton()
        Me.radStudent = New System.Windows.Forms.RadioButton()
        Me.radChild = New System.Windows.Forms.RadioButton()
        Me.radAdult = New System.Windows.Forms.RadioButton()
        Me.grpOptions = New System.Windows.Forms.GroupBox()
        Me.chkTrainer = New System.Windows.Forms.CheckBox()
        Me.chkKarate = New System.Windows.Forms.CheckBox()
        Me.chkYoga = New System.Windows.Forms.CheckBox()
        Me.grpLength = New System.Windows.Forms.GroupBox()
        Me.txtMonths = New System.Windows.Forms.TextBox()
        Me.lblMonths = New System.Windows.Forms.Label()
        Me.grpFees = New System.Windows.Forms.GroupBox()
        Me.txtTotalFee = New System.Windows.Forms.TextBox()
        Me.txtMonthlyFee = New System.Windows.Forms.TextBox()
        Me.lblTotalFee = New System.Windows.Forms.Label()
        Me.lblMonthlyFee = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.grpType.SuspendLayout()
        Me.grpOptions.SuspendLayout()
        Me.grpLength.SuspendLayout()
        Me.grpFees.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpType
        '
        Me.grpType.Controls.Add(Me.radSenior)
        Me.grpType.Controls.Add(Me.radStudent)
        Me.grpType.Controls.Add(Me.radChild)
        Me.grpType.Controls.Add(Me.radAdult)
        Me.grpType.Location = New System.Drawing.Point(64, 59)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(200, 113)
        Me.grpType.TabIndex = 4
        Me.grpType.TabStop = False
        Me.grpType.Text = "Type of Membership"
        '
        'radSenior
        '
        Me.radSenior.AutoSize = True
        Me.radSenior.Location = New System.Drawing.Point(7, 89)
        Me.radSenior.Name = "radSenior"
        Me.radSenior.Size = New System.Drawing.Size(89, 17)
        Me.radSenior.TabIndex = 3
        Me.radSenior.Text = "S&enior Citizen"
        Me.radSenior.UseVisualStyleBackColor = True
        '
        'radStudent
        '
        Me.radStudent.AutoSize = True
        Me.radStudent.Location = New System.Drawing.Point(7, 66)
        Me.radStudent.Name = "radStudent"
        Me.radStudent.Size = New System.Drawing.Size(62, 17)
        Me.radStudent.TabIndex = 2
        Me.radStudent.Text = "&Student"
        Me.radStudent.UseVisualStyleBackColor = True
        '
        'radChild
        '
        Me.radChild.AutoSize = True
        Me.radChild.Location = New System.Drawing.Point(7, 43)
        Me.radChild.Name = "radChild"
        Me.radChild.Size = New System.Drawing.Size(108, 17)
        Me.radChild.TabIndex = 1
        Me.radChild.Text = "Chil&d (12 && under)"
        Me.radChild.UseVisualStyleBackColor = True
        '
        'radAdult
        '
        Me.radAdult.AutoSize = True
        Me.radAdult.Checked = True
        Me.radAdult.Location = New System.Drawing.Point(7, 20)
        Me.radAdult.Name = "radAdult"
        Me.radAdult.Size = New System.Drawing.Size(95, 17)
        Me.radAdult.TabIndex = 0
        Me.radAdult.TabStop = True
        Me.radAdult.Text = "Standard &Adult"
        Me.radAdult.UseVisualStyleBackColor = True
        '
        'grpOptions
        '
        Me.grpOptions.Controls.Add(Me.chkTrainer)
        Me.grpOptions.Controls.Add(Me.chkKarate)
        Me.grpOptions.Controls.Add(Me.chkYoga)
        Me.grpOptions.Location = New System.Drawing.Point(323, 59)
        Me.grpOptions.Name = "grpOptions"
        Me.grpOptions.Size = New System.Drawing.Size(200, 113)
        Me.grpOptions.TabIndex = 5
        Me.grpOptions.TabStop = False
        Me.grpOptions.Text = "Options"
        '
        'chkTrainer
        '
        Me.chkTrainer.AutoSize = True
        Me.chkTrainer.Location = New System.Drawing.Point(7, 80)
        Me.chkTrainer.Name = "chkTrainer"
        Me.chkTrainer.Size = New System.Drawing.Size(103, 17)
        Me.chkTrainer.TabIndex = 2
        Me.chkTrainer.Text = "&Personal Trainer"
        Me.chkTrainer.UseVisualStyleBackColor = True
        '
        'chkKarate
        '
        Me.chkKarate.AutoSize = True
        Me.chkKarate.Location = New System.Drawing.Point(6, 52)
        Me.chkKarate.Name = "chkKarate"
        Me.chkKarate.Size = New System.Drawing.Size(57, 17)
        Me.chkKarate.TabIndex = 1
        Me.chkKarate.Text = "&Karate"
        Me.chkKarate.UseVisualStyleBackColor = True
        '
        'chkYoga
        '
        Me.chkYoga.AutoSize = True
        Me.chkYoga.Location = New System.Drawing.Point(7, 24)
        Me.chkYoga.Name = "chkYoga"
        Me.chkYoga.Size = New System.Drawing.Size(51, 17)
        Me.chkYoga.TabIndex = 0
        Me.chkYoga.Text = "&Yoga"
        Me.chkYoga.UseVisualStyleBackColor = True
        '
        'grpLength
        '
        Me.grpLength.Controls.Add(Me.txtMonths)
        Me.grpLength.Controls.Add(Me.lblMonths)
        Me.grpLength.Location = New System.Drawing.Point(64, 191)
        Me.grpLength.Name = "grpLength"
        Me.grpLength.Size = New System.Drawing.Size(200, 95)
        Me.grpLength.TabIndex = 0
        Me.grpLength.TabStop = False
        Me.grpLength.Text = "Membership Length"
        '
        'txtMonths
        '
        Me.txtMonths.Location = New System.Drawing.Point(23, 54)
        Me.txtMonths.Name = "txtMonths"
        Me.txtMonths.Size = New System.Drawing.Size(100, 20)
        Me.txtMonths.TabIndex = 1
        '
        'lblMonths
        '
        Me.lblMonths.AutoSize = True
        Me.lblMonths.Location = New System.Drawing.Point(20, 31)
        Me.lblMonths.Name = "lblMonths"
        Me.lblMonths.Size = New System.Drawing.Size(143, 13)
        Me.lblMonths.TabIndex = 0
        Me.lblMonths.Text = "Enter the Number of Months:"
        '
        'grpFees
        '
        Me.grpFees.Controls.Add(Me.txtTotalFee)
        Me.grpFees.Controls.Add(Me.txtMonthlyFee)
        Me.grpFees.Controls.Add(Me.lblTotalFee)
        Me.grpFees.Controls.Add(Me.lblMonthlyFee)
        Me.grpFees.Location = New System.Drawing.Point(323, 191)
        Me.grpFees.Name = "grpFees"
        Me.grpFees.Size = New System.Drawing.Size(200, 95)
        Me.grpFees.TabIndex = 1
        Me.grpFees.TabStop = False
        Me.grpFees.Text = "Membership Fees"
        '
        'txtTotalFee
        '
        Me.txtTotalFee.Location = New System.Drawing.Point(103, 57)
        Me.txtTotalFee.Name = "txtTotalFee"
        Me.txtTotalFee.ReadOnly = True
        Me.txtTotalFee.Size = New System.Drawing.Size(70, 20)
        Me.txtTotalFee.TabIndex = 2
        Me.txtTotalFee.TabStop = False
        Me.txtTotalFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMonthlyFee
        '
        Me.txtMonthlyFee.Location = New System.Drawing.Point(103, 31)
        Me.txtMonthlyFee.Name = "txtMonthlyFee"
        Me.txtMonthlyFee.ReadOnly = True
        Me.txtMonthlyFee.Size = New System.Drawing.Size(70, 20)
        Me.txtMonthlyFee.TabIndex = 1
        Me.txtMonthlyFee.TabStop = False
        Me.txtMonthlyFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalFee
        '
        Me.lblTotalFee.AutoSize = True
        Me.lblTotalFee.Location = New System.Drawing.Point(51, 57)
        Me.lblTotalFee.Name = "lblTotalFee"
        Me.lblTotalFee.Size = New System.Drawing.Size(34, 13)
        Me.lblTotalFee.TabIndex = 0
        Me.lblTotalFee.Text = "Total:"
        Me.lblTotalFee.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblMonthlyFee
        '
        Me.lblMonthlyFee.AutoSize = True
        Me.lblMonthlyFee.Location = New System.Drawing.Point(17, 31)
        Me.lblMonthlyFee.Name = "lblMonthlyFee"
        Me.lblMonthlyFee.Size = New System.Drawing.Size(68, 13)
        Me.lblMonthlyFee.TabIndex = 0
        Me.lblMonthlyFee.Text = "Monthly Fee:"
        Me.lblMonthlyFee.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(106, 369)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(261, 369)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clea&r"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(416, 369)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(597, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(196, 17)
        Me.lblStatus.Text = "Enter an integer in the range of 1-24"
        '
        'frmHCMFC
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(597, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpFees)
        Me.Controls.Add(Me.grpLength)
        Me.Controls.Add(Me.grpOptions)
        Me.Controls.Add(Me.grpType)
        Me.Name = "frmHCMFC"
        Me.ShowIcon = False
        Me.Text = "Membership Fee Calculator"
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.grpOptions.ResumeLayout(False)
        Me.grpOptions.PerformLayout()
        Me.grpLength.ResumeLayout(False)
        Me.grpLength.PerformLayout()
        Me.grpFees.ResumeLayout(False)
        Me.grpFees.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpType As GroupBox
    Friend WithEvents radSenior As RadioButton
    Friend WithEvents radStudent As RadioButton
    Friend WithEvents radChild As RadioButton
    Friend WithEvents radAdult As RadioButton
    Friend WithEvents grpOptions As GroupBox
    Friend WithEvents chkTrainer As CheckBox
    Friend WithEvents chkKarate As CheckBox
    Friend WithEvents chkYoga As CheckBox
    Friend WithEvents grpLength As GroupBox
    Friend WithEvents txtMonths As TextBox
    Friend WithEvents lblMonths As Label
    Friend WithEvents grpFees As GroupBox
    Friend WithEvents txtTotalFee As TextBox
    Friend WithEvents txtMonthlyFee As TextBox
    Friend WithEvents lblTotalFee As Label
    Friend WithEvents lblMonthlyFee As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblStatus As ToolStripStatusLabel
End Class
