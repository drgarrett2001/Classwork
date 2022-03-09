<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalendar
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
        Me.txtFirstDay = New System.Windows.Forms.TextBox()
        Me.txtNumofDays = New System.Windows.Forms.TextBox()
        Me.txtSearchFor = New System.Windows.Forms.TextBox()
        Me.txtFound = New System.Windows.Forms.TextBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblFirstDay = New System.Windows.Forms.Label()
        Me.lblNumOfDays = New System.Windows.Forms.Label()
        Me.lblSearchFor = New System.Windows.Forms.Label()
        Me.lblFound = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFirstDay
        '
        Me.txtFirstDay.Location = New System.Drawing.Point(137, 27)
        Me.txtFirstDay.Name = "txtFirstDay"
        Me.txtFirstDay.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstDay.TabIndex = 1
        '
        'txtNumofDays
        '
        Me.txtNumofDays.Location = New System.Drawing.Point(137, 65)
        Me.txtNumofDays.Name = "txtNumofDays"
        Me.txtNumofDays.Size = New System.Drawing.Size(100, 20)
        Me.txtNumofDays.TabIndex = 2
        '
        'txtSearchFor
        '
        Me.txtSearchFor.Location = New System.Drawing.Point(137, 144)
        Me.txtSearchFor.Name = "txtSearchFor"
        Me.txtSearchFor.Size = New System.Drawing.Size(100, 20)
        Me.txtSearchFor.TabIndex = 5
        '
        'txtFound
        '
        Me.txtFound.Location = New System.Drawing.Point(137, 182)
        Me.txtFound.Name = "txtFound"
        Me.txtFound.ReadOnly = True
        Me.txtFound.Size = New System.Drawing.Size(100, 20)
        Me.txtFound.TabIndex = 0
        Me.txtFound.TabStop = False
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(150, 103)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 4
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(38, 103)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnLoad.TabIndex = 3
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(99, 209)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.TabStop = False
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblFirstDay
        '
        Me.lblFirstDay.AutoSize = True
        Me.lblFirstDay.Location = New System.Drawing.Point(51, 27)
        Me.lblFirstDay.Name = "lblFirstDay"
        Me.lblFirstDay.Size = New System.Drawing.Size(48, 13)
        Me.lblFirstDay.TabIndex = 0
        Me.lblFirstDay.Text = "First Day"
        '
        'lblNumOfDays
        '
        Me.lblNumOfDays.AutoSize = True
        Me.lblNumOfDays.Location = New System.Drawing.Point(49, 65)
        Me.lblNumOfDays.Name = "lblNumOfDays"
        Me.lblNumOfDays.Size = New System.Drawing.Size(53, 13)
        Me.lblNumOfDays.TabIndex = 0
        Me.lblNumOfDays.Text = "# of Days"
        '
        'lblSearchFor
        '
        Me.lblSearchFor.AutoSize = True
        Me.lblSearchFor.Location = New System.Drawing.Point(47, 144)
        Me.lblSearchFor.Name = "lblSearchFor"
        Me.lblSearchFor.Size = New System.Drawing.Size(56, 13)
        Me.lblSearchFor.TabIndex = 0
        Me.lblSearchFor.Text = "Search for"
        '
        'lblFound
        '
        Me.lblFound.AutoSize = True
        Me.lblFound.Location = New System.Drawing.Point(57, 182)
        Me.lblFound.Name = "lblFound"
        Me.lblFound.Size = New System.Drawing.Size(37, 13)
        Me.lblFound.TabIndex = 0
        Me.lblFound.Text = "Found"
        '
        'frmCalendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 258)
        Me.Controls.Add(Me.lblFound)
        Me.Controls.Add(Me.lblSearchFor)
        Me.Controls.Add(Me.lblNumOfDays)
        Me.Controls.Add(Me.lblFirstDay)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtFound)
        Me.Controls.Add(Me.txtSearchFor)
        Me.Controls.Add(Me.txtNumofDays)
        Me.Controls.Add(Me.txtFirstDay)
        Me.Name = "frmCalendar"
        Me.ShowIcon = False
        Me.Text = "Calendar2D1MonthForSearch"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstDay As TextBox
    Friend WithEvents txtNumofDays As TextBox
    Friend WithEvents txtSearchFor As TextBox
    Friend WithEvents txtFound As TextBox
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblFirstDay As Label
    Friend WithEvents lblNumOfDays As Label
    Friend WithEvents lblSearchFor As Label
    Friend WithEvents lblFound As Label
End Class
