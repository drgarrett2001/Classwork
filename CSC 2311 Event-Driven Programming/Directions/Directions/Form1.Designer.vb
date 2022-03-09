<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Me.btnShowDirections = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblDrivDir = New System.Windows.Forms.Label()
        Me.picDirections = New System.Windows.Forms.PictureBox()
        Me.lblDirections = New System.Windows.Forms.Label()
        CType(Me.picDirections, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnShowDirections
        '
        Me.btnShowDirections.Location = New System.Drawing.Point(51, 446)
        Me.btnShowDirections.Name = "btnShowDirections"
        Me.btnShowDirections.Size = New System.Drawing.Size(133, 46)
        Me.btnShowDirections.TabIndex = 0
        Me.btnShowDirections.Text = "Hide Directions"
        Me.btnShowDirections.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(391, 446)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(142, 46)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblDrivDir
        '
        Me.lblDrivDir.AutoSize = True
        Me.lblDrivDir.Font = New System.Drawing.Font("Modern No. 20", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrivDir.Location = New System.Drawing.Point(184, 32)
        Me.lblDrivDir.Name = "lblDrivDir"
        Me.lblDrivDir.Size = New System.Drawing.Size(242, 29)
        Me.lblDrivDir.TabIndex = 2
        Me.lblDrivDir.Text = "Driving Directions"
        '
        'picDirections
        '
        Me.picDirections.Image = Global.Directions.My.Resources.Resources.map
        Me.picDirections.Location = New System.Drawing.Point(127, 101)
        Me.picDirections.Name = "picDirections"
        Me.picDirections.Size = New System.Drawing.Size(385, 256)
        Me.picDirections.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDirections.TabIndex = 3
        Me.picDirections.TabStop = False
        '
        'lblDirections
        '
        Me.lblDirections.AutoSize = True
        Me.lblDirections.Location = New System.Drawing.Point(127, 383)
        Me.lblDirections.Name = "lblDirections"
        Me.lblDirections.Size = New System.Drawing.Size(320, 52)
        Me.lblDirections.TabIndex = 4
        Me.lblDirections.Text = resources.GetString("lblDirections.Text")
        '
        'form1
        '
        Me.AcceptButton = Me.btnShowDirections
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(637, 563)
        Me.Controls.Add(Me.lblDirections)
        Me.Controls.Add(Me.lblDrivDir)
        Me.Controls.Add(Me.picDirections)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnShowDirections)
        Me.Name = "form1"
        Me.ShowIcon = False
        Me.Text = "Driving Directions"
        CType(Me.picDirections, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShowDirections As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblDrivDir As Label
    Friend WithEvents picDirections As PictureBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblDrivDir_Click(sender As Object, e As EventArgs) Handles lblDrivDir.Click

    End Sub

    Friend WithEvents lblDirections As Label

    Private Sub lblDirections_Click(sender As Object, e As EventArgs) Handles lblDirections.Click

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnShowDirections_Click(sender As Object, e As EventArgs) Handles btnShowDirections.Click
        If lblDirections.Visible = True Then
            lblDirections.Visible = False
            btnShowDirections.Text = "Show Directions"
        Else
            lblDirections.Visible = True
            btnShowDirections.Text = "Hide Directions"
        End If

    End Sub

    Private Sub picDirections_Click(sender As Object, e As EventArgs) Handles picDirections.Click

    End Sub
End Class
