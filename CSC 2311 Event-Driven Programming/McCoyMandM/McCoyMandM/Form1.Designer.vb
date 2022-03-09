<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMcCoy
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
        Me.txtPints = New System.Windows.Forms.TextBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.gbMolasses = New System.Windows.Forms.GroupBox()
        Me.radDark = New System.Windows.Forms.RadioButton()
        Me.radMedium = New System.Windows.Forms.RadioButton()
        Me.radLight = New System.Windows.Forms.RadioButton()
        Me.chkHatfield = New System.Windows.Forms.CheckBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblUntaxable = New System.Windows.Forms.Label()
        Me.txtUntaxable = New System.Windows.Forms.TextBox()
        Me.lblPints = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.gbMolasses.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPints
        '
        Me.txtPints.Location = New System.Drawing.Point(111, 11)
        Me.txtPints.Name = "txtPints"
        Me.txtPints.Size = New System.Drawing.Size(100, 20)
        Me.txtPints.TabIndex = 1
        Me.txtPints.Text = "0"
        Me.txtPints.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(111, 45)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(100, 20)
        Me.txtCost.TabIndex = 2
        Me.txtCost.Text = "0.00"
        Me.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gbMolasses
        '
        Me.gbMolasses.Controls.Add(Me.radDark)
        Me.gbMolasses.Controls.Add(Me.radMedium)
        Me.gbMolasses.Controls.Add(Me.radLight)
        Me.gbMolasses.Location = New System.Drawing.Point(111, 79)
        Me.gbMolasses.Name = "gbMolasses"
        Me.gbMolasses.Size = New System.Drawing.Size(100, 100)
        Me.gbMolasses.TabIndex = 4
        Me.gbMolasses.TabStop = False
        Me.gbMolasses.Text = "Molasses"
        '
        'radDark
        '
        Me.radDark.AutoSize = True
        Me.radDark.Location = New System.Drawing.Point(7, 68)
        Me.radDark.Name = "radDark"
        Me.radDark.Size = New System.Drawing.Size(48, 17)
        Me.radDark.TabIndex = 2
        Me.radDark.Text = "Dark"
        Me.radDark.UseVisualStyleBackColor = True
        '
        'radMedium
        '
        Me.radMedium.AutoSize = True
        Me.radMedium.Location = New System.Drawing.Point(7, 44)
        Me.radMedium.Name = "radMedium"
        Me.radMedium.Size = New System.Drawing.Size(62, 17)
        Me.radMedium.TabIndex = 1
        Me.radMedium.Text = "Medium"
        Me.radMedium.UseVisualStyleBackColor = True
        '
        'radLight
        '
        Me.radLight.AutoSize = True
        Me.radLight.Location = New System.Drawing.Point(7, 20)
        Me.radLight.Name = "radLight"
        Me.radLight.Size = New System.Drawing.Size(48, 17)
        Me.radLight.TabIndex = 0
        Me.radLight.TabStop = True
        Me.radLight.Text = "Light"
        Me.radLight.UseVisualStyleBackColor = True
        '
        'chkHatfield
        '
        Me.chkHatfield.AutoSize = True
        Me.chkHatfield.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkHatfield.Location = New System.Drawing.Point(19, 121)
        Me.chkHatfield.Name = "chkHatfield"
        Me.chkHatfield.Size = New System.Drawing.Size(65, 17)
        Me.chkHatfield.TabIndex = 3
        Me.chkHatfield.Text = "Hatfield:"
        Me.chkHatfield.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(75, 217)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 0
        Me.btnReset.TabStop = False
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblUntaxable
        '
        Me.lblUntaxable.AutoSize = True
        Me.lblUntaxable.Location = New System.Drawing.Point(9, 195)
        Me.lblUntaxable.Name = "lblUntaxable"
        Me.lblUntaxable.Size = New System.Drawing.Size(96, 13)
        Me.lblUntaxable.TabIndex = 0
        Me.lblUntaxable.Text = "Untaxable Income:"
        Me.lblUntaxable.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtUntaxable
        '
        Me.txtUntaxable.Location = New System.Drawing.Point(111, 191)
        Me.txtUntaxable.Name = "txtUntaxable"
        Me.txtUntaxable.ReadOnly = True
        Me.txtUntaxable.Size = New System.Drawing.Size(100, 20)
        Me.txtUntaxable.TabIndex = 0
        Me.txtUntaxable.TabStop = False
        Me.txtUntaxable.Text = "$0.00"
        Me.txtUntaxable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPints
        '
        Me.lblPints.AutoSize = True
        Me.lblPints.Location = New System.Drawing.Point(72, 15)
        Me.lblPints.Name = "lblPints"
        Me.lblPints.Size = New System.Drawing.Size(33, 13)
        Me.lblPints.TabIndex = 0
        Me.lblPints.Text = "Pints:"
        Me.lblPints.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Location = New System.Drawing.Point(16, 49)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(89, 13)
        Me.lblCost.TabIndex = 0
        Me.lblCost.Text = "Moonshine Pint $"
        Me.lblCost.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'frmMcCoy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(240, 263)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblPints)
        Me.Controls.Add(Me.txtUntaxable)
        Me.Controls.Add(Me.lblUntaxable)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.chkHatfield)
        Me.Controls.Add(Me.gbMolasses)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.txtPints)
        Me.Name = "frmMcCoy"
        Me.ShowIcon = False
        Me.Text = "McCoy's MoonShine & Molasses"
        Me.gbMolasses.ResumeLayout(False)
        Me.gbMolasses.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPints As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents gbMolasses As GroupBox
    Friend WithEvents radDark As RadioButton
    Friend WithEvents radMedium As RadioButton
    Friend WithEvents radLight As RadioButton
    Friend WithEvents chkHatfield As CheckBox
    Friend WithEvents btnReset As Button
    Friend WithEvents lblUntaxable As Label
    Friend WithEvents lblPints As Label
    Friend WithEvents lblCost As Label
    Public WithEvents txtUntaxable As TextBox
End Class
