<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnClickMe = New System.Windows.Forms.Button()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.lblClick = New System.Windows.Forms.Label()
        Me.txtBox = New System.Windows.Forms.TextBox()
        Me.imgCLick = New System.Windows.Forms.PictureBox()
        Me.lblDog = New System.Windows.Forms.Label()
        Me.prgClick = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.imgCLick, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClickMe
        '
        Me.btnClickMe.Location = New System.Drawing.Point(68, 79)
        Me.btnClickMe.Name = "btnClickMe"
        Me.btnClickMe.Size = New System.Drawing.Size(75, 23)
        Me.btnClickMe.TabIndex = 0
        Me.btnClickMe.Text = "Click Me"
        Me.btnClickMe.UseVisualStyleBackColor = True
        '
        'chk1
        '
        Me.chk1.AutoSize = True
        Me.chk1.Location = New System.Drawing.Point(68, 119)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(70, 17)
        Me.chk1.TabIndex = 1
        Me.chk1.Text = "Click Me!"
        Me.chk1.UseVisualStyleBackColor = True
        '
        'lblClick
        '
        Me.lblClick.AutoSize = True
        Me.lblClick.Location = New System.Drawing.Point(65, 25)
        Me.lblClick.Name = "lblClick"
        Me.lblClick.Size = New System.Drawing.Size(90, 13)
        Me.lblClick.TabIndex = 3
        Me.lblClick.Text = "Type here to print"
        '
        'txtBox
        '
        Me.txtBox.Location = New System.Drawing.Point(68, 41)
        Me.txtBox.Name = "txtBox"
        Me.txtBox.Size = New System.Drawing.Size(100, 20)
        Me.txtBox.TabIndex = 4
        '
        'imgCLick
        '
        Me.imgCLick.Image = Global.Hello_Worlds.My.Resources.Resources.Jerry_s_pug
        Me.imgCLick.Location = New System.Drawing.Point(68, 170)
        Me.imgCLick.Name = "imgCLick"
        Me.imgCLick.Size = New System.Drawing.Size(264, 222)
        Me.imgCLick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgCLick.TabIndex = 5
        Me.imgCLick.TabStop = False
        '
        'lblDog
        '
        Me.lblDog.AutoSize = True
        Me.lblDog.Location = New System.Drawing.Point(68, 154)
        Me.lblDog.Name = "lblDog"
        Me.lblDog.Size = New System.Drawing.Size(89, 13)
        Me.lblDog.TabIndex = 6
        Me.lblDog.Text = "CLICK THE DOG"
        '
        'prgClick
        '
        Me.prgClick.Location = New System.Drawing.Point(68, 432)
        Me.prgClick.Name = "prgClick"
        Me.prgClick.Size = New System.Drawing.Size(262, 47)
        Me.prgClick.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 416)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Click The Progress Bar below"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 566)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.prgClick)
        Me.Controls.Add(Me.lblDog)
        Me.Controls.Add(Me.imgCLick)
        Me.Controls.Add(Me.txtBox)
        Me.Controls.Add(Me.lblClick)
        Me.Controls.Add(Me.chk1)
        Me.Controls.Add(Me.btnClickMe)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.imgCLick, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClickMe As Button
    Friend WithEvents chk1 As CheckBox
    Friend WithEvents lblClick As Label
    Friend WithEvents txtBox As TextBox
    Friend WithEvents imgCLick As PictureBox
    Friend WithEvents lblDog As Label
    Friend WithEvents prgClick As ProgressBar
    Friend WithEvents Label1 As Label
End Class
