<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDrivingDirections
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDrivingDirections))
        Me.lblDrivDir = New System.Windows.Forms.Label()
        Me.picDirections = New System.Windows.Forms.PictureBox()
        Me.lblDirections = New System.Windows.Forms.Label()
        Me.btnShowDirections = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.picDirections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDrivDir
        '
        Me.lblDrivDir.AutoSize = True
        Me.lblDrivDir.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrivDir.Location = New System.Drawing.Point(86, 31)
        Me.lblDrivDir.Name = "lblDrivDir"
        Me.lblDrivDir.Size = New System.Drawing.Size(316, 47)
        Me.lblDrivDir.TabIndex = 0
        Me.lblDrivDir.Text = "Driving Directions"
        Me.lblDrivDir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picDirections
        '
        Me.picDirections.Image = Global.Directions2.My.Resources.Resources.map
        Me.picDirections.Location = New System.Drawing.Point(80, 81)
        Me.picDirections.Name = "picDirections"
        Me.picDirections.Size = New System.Drawing.Size(328, 261)
        Me.picDirections.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDirections.TabIndex = 1
        Me.picDirections.TabStop = False
        '
        'lblDirections
        '
        Me.lblDirections.AutoSize = True
        Me.lblDirections.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblDirections.Location = New System.Drawing.Point(29, 363)
        Me.lblDirections.Name = "lblDirections"
        Me.lblDirections.Size = New System.Drawing.Size(431, 68)
        Me.lblDirections.TabIndex = 0
        Me.lblDirections.Text = resources.GetString("lblDirections.Text")
        '
        'btnShowDirections
        '
        Me.btnShowDirections.Location = New System.Drawing.Point(48, 445)
        Me.btnShowDirections.Name = "btnShowDirections"
        Me.btnShowDirections.Size = New System.Drawing.Size(147, 50)
        Me.btnShowDirections.TabIndex = 1
        Me.btnShowDirections.Text = "Hide Directions"
        Me.btnShowDirections.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(293, 445)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(147, 50)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmDrivingDirections
        '
        Me.AcceptButton = Me.btnShowDirections
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(488, 519)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnShowDirections)
        Me.Controls.Add(Me.lblDirections)
        Me.Controls.Add(Me.picDirections)
        Me.Controls.Add(Me.lblDrivDir)
        Me.Name = "frmDrivingDirections"
        Me.ShowIcon = False
        Me.Text = "Driving Directions"
        CType(Me.picDirections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDrivDir As Label
    Friend WithEvents picDirections As PictureBox
    Friend WithEvents lblDirections As Label
    Friend WithEvents btnShowDirections As Button
    Friend WithEvents btnClose As Button
End Class
