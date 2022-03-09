<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSSTC
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
        Me.txtSales = New System.Windows.Forms.TextBox()
        Me.txtTaxDue = New System.Windows.Forms.TextBox()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.lblTaxDue = New System.Windows.Forms.Label()
        Me.lblTaxRate = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.nudTaxRate = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudTaxRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSales
        '
        Me.txtSales.Location = New System.Drawing.Point(115, 27)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Size = New System.Drawing.Size(100, 20)
        Me.txtSales.TabIndex = 0
        Me.txtSales.Text = "0.00"
        Me.txtSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTaxDue
        '
        Me.txtTaxDue.Location = New System.Drawing.Point(115, 109)
        Me.txtTaxDue.Name = "txtTaxDue"
        Me.txtTaxDue.ReadOnly = True
        Me.txtTaxDue.Size = New System.Drawing.Size(100, 20)
        Me.txtTaxDue.TabIndex = 2
        Me.txtTaxDue.Text = "$0.00"
        Me.txtTaxDue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Location = New System.Drawing.Point(58, 34)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(36, 13)
        Me.lblSales.TabIndex = 0
        Me.lblSales.Text = "Sales:"
        '
        'lblTaxDue
        '
        Me.lblTaxDue.AutoSize = True
        Me.lblTaxDue.Location = New System.Drawing.Point(46, 116)
        Me.lblTaxDue.Name = "lblTaxDue"
        Me.lblTaxDue.Size = New System.Drawing.Size(51, 13)
        Me.lblTaxDue.TabIndex = 0
        Me.lblTaxDue.Text = "Tax Due:"
        '
        'lblTaxRate
        '
        Me.lblTaxRate.AutoSize = True
        Me.lblTaxRate.Location = New System.Drawing.Point(43, 75)
        Me.lblTaxRate.Name = "lblTaxRate"
        Me.lblTaxRate.Size = New System.Drawing.Size(54, 13)
        Me.lblTaxRate.TabIndex = 0
        Me.lblTaxRate.Text = "Tax Rate:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(24, 176)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(105, 43)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'BtnReset
        '
        Me.BtnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnReset.Location = New System.Drawing.Point(144, 176)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(100, 43)
        Me.BtnReset.TabIndex = 4
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'nudTaxRate
        '
        Me.nudTaxRate.DecimalPlaces = 2
        Me.nudTaxRate.Increment = New Decimal(New Integer() {25, 0, 0, 131072})
        Me.nudTaxRate.Location = New System.Drawing.Point(115, 68)
        Me.nudTaxRate.Name = "nudTaxRate"
        Me.nudTaxRate.Size = New System.Drawing.Size(115, 20)
        Me.nudTaxRate.TabIndex = 1
        Me.nudTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudTaxRate.UseWaitCursor = True
        Me.nudTaxRate.Value = New Decimal(New Integer() {825, 0, 0, 131072})
        '
        'frmSSTC
        '
        Me.AcceptButton = Me.btnCalc
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnReset
        Me.ClientSize = New System.Drawing.Size(269, 247)
        Me.Controls.Add(Me.nudTaxRate)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblTaxRate)
        Me.Controls.Add(Me.lblTaxDue)
        Me.Controls.Add(Me.lblSales)
        Me.Controls.Add(Me.txtTaxDue)
        Me.Controls.Add(Me.txtSales)
        Me.Name = "frmSSTC"
        Me.ShowIcon = False
        Me.Text = "State Sales Tax Calculator"
        CType(Me.nudTaxRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSales As TextBox
    Friend WithEvents txtTaxDue As TextBox
    Friend WithEvents lblSales As Label
    Friend WithEvents lblTaxDue As Label
    Friend WithEvents lblTaxRate As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents nudTaxRate As NumericUpDown
End Class
