<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnStartTimer = New System.Windows.Forms.Button()
        Me.txtHistory = New System.Windows.Forms.TextBox()
        Me.btnEndTimer = New System.Windows.Forms.Button()
        Me.lblRunning = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'btnStartTimer
        '
        Me.btnStartTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnStartTimer.Location = New System.Drawing.Point(45, 41)
        Me.btnStartTimer.Name = "btnStartTimer"
        Me.btnStartTimer.Size = New System.Drawing.Size(208, 41)
        Me.btnStartTimer.TabIndex = 0
        Me.btnStartTimer.Text = "Start Timer"
        Me.btnStartTimer.UseVisualStyleBackColor = true
        '
        'txtHistory
        '
        Me.txtHistory.Location = New System.Drawing.Point(45, 126)
        Me.txtHistory.Multiline = true
        Me.txtHistory.Name = "txtHistory"
        Me.txtHistory.ReadOnly = true
        Me.txtHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtHistory.Size = New System.Drawing.Size(517, 480)
        Me.txtHistory.TabIndex = 1
        '
        'btnEndTimer
        '
        Me.btnEndTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnEndTimer.Location = New System.Drawing.Point(366, 41)
        Me.btnEndTimer.Name = "btnEndTimer"
        Me.btnEndTimer.Size = New System.Drawing.Size(196, 41)
        Me.btnEndTimer.TabIndex = 2
        Me.btnEndTimer.Text = "End Timer"
        Me.btnEndTimer.UseVisualStyleBackColor = true
        '
        'lblRunning
        '
        Me.lblRunning.AutoSize = true
        Me.lblRunning.Location = New System.Drawing.Point(45, 103)
        Me.lblRunning.Name = "lblRunning"
        Me.lblRunning.Size = New System.Drawing.Size(0, 17)
        Me.lblRunning.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 16!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 650)
        Me.Controls.Add(Me.lblRunning)
        Me.Controls.Add(Me.btnEndTimer)
        Me.Controls.Add(Me.txtHistory)
        Me.Controls.Add(Me.btnStartTimer)
        Me.MaximizeBox = false
        Me.Name = "Form1"
        Me.Text = "Fetch PRD Data To Mobility"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents btnStartTimer As Button
    Friend WithEvents txtHistory As TextBox
    Friend WithEvents btnEndTimer As Button
    Friend WithEvents lblRunning As Label
End Class
