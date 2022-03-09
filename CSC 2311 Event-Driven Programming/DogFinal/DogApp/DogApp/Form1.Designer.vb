<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDogApp
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
        Me.cmbBreed = New System.Windows.Forms.ComboBox()
        Me.lblBreed = New System.Windows.Forms.Label()
        Me.grpAge = New System.Windows.Forms.GroupBox()
        Me.radLessThanTwo = New System.Windows.Forms.RadioButton()
        Me.radTwoToEight = New System.Windows.Forms.RadioButton()
        Me.radMoreThanEight = New System.Windows.Forms.RadioButton()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.grpAge.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbBreed
        '
        Me.cmbBreed.FormattingEnabled = True
        Me.cmbBreed.Location = New System.Drawing.Point(124, 28)
        Me.cmbBreed.Name = "cmbBreed"
        Me.cmbBreed.Size = New System.Drawing.Size(121, 21)
        Me.cmbBreed.TabIndex = 0
        '
        'lblBreed
        '
        Me.lblBreed.AutoSize = True
        Me.lblBreed.Location = New System.Drawing.Point(35, 35)
        Me.lblBreed.Name = "lblBreed"
        Me.lblBreed.Size = New System.Drawing.Size(38, 13)
        Me.lblBreed.TabIndex = 1
        Me.lblBreed.Text = "Breed:"
        '
        'grpAge
        '
        Me.grpAge.Controls.Add(Me.radMoreThanEight)
        Me.grpAge.Controls.Add(Me.radTwoToEight)
        Me.grpAge.Controls.Add(Me.radLessThanTwo)
        Me.grpAge.Location = New System.Drawing.Point(38, 69)
        Me.grpAge.Name = "grpAge"
        Me.grpAge.Size = New System.Drawing.Size(200, 43)
        Me.grpAge.TabIndex = 2
        Me.grpAge.TabStop = False
        Me.grpAge.Text = "Age"
        '
        'radLessThanTwo
        '
        Me.radLessThanTwo.AutoSize = True
        Me.radLessThanTwo.Location = New System.Drawing.Point(15, 19)
        Me.radLessThanTwo.Name = "radLessThanTwo"
        Me.radLessThanTwo.Size = New System.Drawing.Size(37, 17)
        Me.radLessThanTwo.TabIndex = 0
        Me.radLessThanTwo.TabStop = True
        Me.radLessThanTwo.Text = "<2"
        Me.radLessThanTwo.UseVisualStyleBackColor = True
        '
        'radTwoToEight
        '
        Me.radTwoToEight.AutoSize = True
        Me.radTwoToEight.Location = New System.Drawing.Point(70, 19)
        Me.radTwoToEight.Name = "radTwoToEight"
        Me.radTwoToEight.Size = New System.Drawing.Size(40, 17)
        Me.radTwoToEight.TabIndex = 1
        Me.radTwoToEight.TabStop = True
        Me.radTwoToEight.Text = "2-8"
        Me.radTwoToEight.UseVisualStyleBackColor = True
        '
        'radMoreThanEight
        '
        Me.radMoreThanEight.AutoSize = True
        Me.radMoreThanEight.Location = New System.Drawing.Point(134, 19)
        Me.radMoreThanEight.Name = "radMoreThanEight"
        Me.radMoreThanEight.Size = New System.Drawing.Size(37, 17)
        Me.radMoreThanEight.TabIndex = 2
        Me.radMoreThanEight.TabStop = True
        Me.radMoreThanEight.Text = ">8"
        Me.radMoreThanEight.UseVisualStyleBackColor = True
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(108, 130)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 3
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'frmDogApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 226)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.grpAge)
        Me.Controls.Add(Me.lblBreed)
        Me.Controls.Add(Me.cmbBreed)
        Me.Name = "frmDogApp"
        Me.ShowIcon = False
        Me.Text = "Dog Application"
        Me.grpAge.ResumeLayout(False)
        Me.grpAge.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbBreed As ComboBox
    Friend WithEvents lblBreed As Label
    Friend WithEvents grpAge As GroupBox
    Friend WithEvents radMoreThanEight As RadioButton
    Friend WithEvents radTwoToEight As RadioButton
    Friend WithEvents radLessThanTwo As RadioButton
    Friend WithEvents btnGo As Button
End Class
