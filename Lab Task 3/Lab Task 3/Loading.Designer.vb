<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Loading
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
        Me.components = New System.ComponentModel.Container()
        Me.pbLoading = New System.Windows.Forms.ProgressBar()
        Me.lbLoading = New System.Windows.Forms.Label()
        Me.timerLoad = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'pbLoading
        '
        Me.pbLoading.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pbLoading.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pbLoading.Location = New System.Drawing.Point(52, 124)
        Me.pbLoading.Name = "pbLoading"
        Me.pbLoading.Size = New System.Drawing.Size(358, 34)
        Me.pbLoading.TabIndex = 11
        '
        'lbLoading
        '
        Me.lbLoading.AutoSize = True
        Me.lbLoading.BackColor = System.Drawing.Color.Transparent
        Me.lbLoading.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lbLoading.ForeColor = System.Drawing.Color.White
        Me.lbLoading.Location = New System.Drawing.Point(37, 60)
        Me.lbLoading.Name = "lbLoading"
        Me.lbLoading.Size = New System.Drawing.Size(385, 30)
        Me.lbLoading.TabIndex = 10
        Me.lbLoading.Text = " You are exiting the dungeon"
        '
        'timerLoad
        '
        Me.timerLoad.Enabled = True
        Me.timerLoad.Interval = 50
        '
        'Loading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(480, 206)
        Me.Controls.Add(Me.pbLoading)
        Me.Controls.Add(Me.lbLoading)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Loading"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbLoading As ProgressBar
    Friend WithEvents lbLoading As Label
    Friend WithEvents timerLoad As Timer
End Class
