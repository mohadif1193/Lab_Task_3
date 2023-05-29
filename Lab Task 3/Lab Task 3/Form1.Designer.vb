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
        Me.btPlay = New System.Windows.Forms.Button()
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btPlay
        '
        Me.btPlay.BackColor = System.Drawing.Color.Black
        Me.btPlay.Font = New System.Drawing.Font("Showcard Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btPlay.Location = New System.Drawing.Point(346, 316)
        Me.btPlay.Name = "btPlay"
        Me.btPlay.Size = New System.Drawing.Size(310, 102)
        Me.btPlay.TabIndex = 0
        Me.btPlay.Text = "Play"
        Me.btPlay.UseVisualStyleBackColor = False
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lbTitle.Location = New System.Drawing.Point(191, 207)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(604, 89)
        Me.lbTitle.TabIndex = 2
        Me.lbTitle.Text = "Dungeon's TaLE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(168, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Welcome to"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Lab_Task_3.My.Resources.Resources.Dungeons_Tale_150x150
        Me.PictureBox1.Location = New System.Drawing.Point(422, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btExit
        '
        Me.btExit.BackColor = System.Drawing.Color.Black
        Me.btExit.Font = New System.Drawing.Font("Showcard Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btExit.ForeColor = System.Drawing.Color.Red
        Me.btExit.Location = New System.Drawing.Point(346, 463)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(310, 102)
        Me.btExit.TabIndex = 6
        Me.btExit.Text = "EXIT"
        Me.btExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1011, 649)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbTitle)
        Me.Controls.Add(Me.btPlay)
        Me.ForeColor = System.Drawing.Color.Lime
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btPlay As Button
    Friend WithEvents lbTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btExit As Button
End Class
