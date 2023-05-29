<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Game
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
        Me.pbEnemy = New System.Windows.Forms.PictureBox()
        Me.pbPlayer = New System.Windows.Forms.PictureBox()
        Me.btAtk = New System.Windows.Forms.Button()
        Me.btFlee = New System.Windows.Forms.Button()
        Me.btBack = New System.Windows.Forms.Button()
        Me.lbOutput = New System.Windows.Forms.Label()
        Me.lbTitle = New System.Windows.Forms.Label()
        CType(Me.pbEnemy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbEnemy
        '
        Me.pbEnemy.BackColor = System.Drawing.Color.Transparent
        Me.pbEnemy.Image = Global.Lab_Task_3.My.Resources.Resources.monster1
        Me.pbEnemy.Location = New System.Drawing.Point(579, 135)
        Me.pbEnemy.Name = "pbEnemy"
        Me.pbEnemy.Size = New System.Drawing.Size(150, 175)
        Me.pbEnemy.TabIndex = 0
        Me.pbEnemy.TabStop = False
        '
        'pbPlayer
        '
        Me.pbPlayer.BackColor = System.Drawing.Color.Transparent
        Me.pbPlayer.Image = Global.Lab_Task_3.My.Resources.Resources.character
        Me.pbPlayer.Location = New System.Drawing.Point(73, 135)
        Me.pbPlayer.Name = "pbPlayer"
        Me.pbPlayer.Size = New System.Drawing.Size(150, 175)
        Me.pbPlayer.TabIndex = 1
        Me.pbPlayer.TabStop = False
        '
        'btAtk
        '
        Me.btAtk.BackColor = System.Drawing.Color.Black
        Me.btAtk.Font = New System.Drawing.Font("Showcard Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btAtk.ForeColor = System.Drawing.Color.Red
        Me.btAtk.Location = New System.Drawing.Point(247, 326)
        Me.btAtk.Name = "btAtk"
        Me.btAtk.Size = New System.Drawing.Size(128, 53)
        Me.btAtk.TabIndex = 2
        Me.btAtk.Text = "Attack"
        Me.btAtk.UseVisualStyleBackColor = False
        '
        'btFlee
        '
        Me.btFlee.BackColor = System.Drawing.Color.Black
        Me.btFlee.Font = New System.Drawing.Font("Showcard Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btFlee.ForeColor = System.Drawing.Color.Yellow
        Me.btFlee.Location = New System.Drawing.Point(418, 326)
        Me.btFlee.Name = "btFlee"
        Me.btFlee.Size = New System.Drawing.Size(128, 53)
        Me.btFlee.TabIndex = 3
        Me.btFlee.Text = "Flee"
        Me.btFlee.UseVisualStyleBackColor = False
        '
        'btBack
        '
        Me.btBack.BackColor = System.Drawing.Color.Black
        Me.btBack.Font = New System.Drawing.Font("Showcard Gothic", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btBack.ForeColor = System.Drawing.Color.White
        Me.btBack.Location = New System.Drawing.Point(638, 12)
        Me.btBack.Name = "btBack"
        Me.btBack.Size = New System.Drawing.Size(128, 53)
        Me.btBack.TabIndex = 4
        Me.btBack.Text = "Back"
        Me.btBack.UseVisualStyleBackColor = False
        '
        'lbOutput
        '
        Me.lbOutput.AutoSize = True
        Me.lbOutput.BackColor = System.Drawing.Color.Transparent
        Me.lbOutput.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbOutput.ForeColor = System.Drawing.Color.White
        Me.lbOutput.Location = New System.Drawing.Point(262, 201)
        Me.lbOutput.Name = "lbOutput"
        Me.lbOutput.Size = New System.Drawing.Size(271, 23)
        Me.lbOutput.TabIndex = 5
        Me.lbOutput.Text = "You've envounter an enemy"
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.BackColor = System.Drawing.Color.Transparent
        Me.lbTitle.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.lbTitle.ForeColor = System.Drawing.Color.Red
        Me.lbTitle.Location = New System.Drawing.Point(201, 30)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(405, 60)
        Me.lbTitle.TabIndex = 6
        Me.lbTitle.Text = "Dungeon's TaLE"
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Lab_Task_3.My.Resources.Resources.Dungeon_bg
        Me.ClientSize = New System.Drawing.Size(778, 444)
        Me.Controls.Add(Me.lbTitle)
        Me.Controls.Add(Me.lbOutput)
        Me.Controls.Add(Me.btBack)
        Me.Controls.Add(Me.btFlee)
        Me.Controls.Add(Me.btAtk)
        Me.Controls.Add(Me.pbPlayer)
        Me.Controls.Add(Me.pbEnemy)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game"
        CType(Me.pbEnemy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbEnemy As PictureBox
    Friend WithEvents pbPlayer As PictureBox
    Friend WithEvents btAtk As Button
    Friend WithEvents btFlee As Button
    Friend WithEvents btBack As Button
    Friend WithEvents lbOutput As Label
    Friend WithEvents lbTitle As Label
End Class
