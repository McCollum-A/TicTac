﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormGame
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
        Me.LblSpot7 = New System.Windows.Forms.Label()
        Me.LblSpot8 = New System.Windows.Forms.Label()
        Me.LblSpot9 = New System.Windows.Forms.Label()
        Me.LblSpot6 = New System.Windows.Forms.Label()
        Me.LblSpot5 = New System.Windows.Forms.Label()
        Me.LblSpot4 = New System.Windows.Forms.Label()
        Me.LblSpot3 = New System.Windows.Forms.Label()
        Me.LblSpot2 = New System.Windows.Forms.Label()
        Me.LblSpot1 = New System.Windows.Forms.Label()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.LblPlayer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LblSpot7
        '
        Me.LblSpot7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSpot7.Font = New System.Drawing.Font("Verdana", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSpot7.Location = New System.Drawing.Point(16, 331)
        Me.LblSpot7.Name = "LblSpot7"
        Me.LblSpot7.Size = New System.Drawing.Size(96, 96)
        Me.LblSpot7.TabIndex = 0
        Me.LblSpot7.Text = "-"
        '
        'LblSpot8
        '
        Me.LblSpot8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSpot8.Font = New System.Drawing.Font("Verdana", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSpot8.Location = New System.Drawing.Point(128, 331)
        Me.LblSpot8.Name = "LblSpot8"
        Me.LblSpot8.Size = New System.Drawing.Size(96, 96)
        Me.LblSpot8.TabIndex = 1
        Me.LblSpot8.Text = "-"
        '
        'LblSpot9
        '
        Me.LblSpot9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSpot9.Font = New System.Drawing.Font("Verdana", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSpot9.Location = New System.Drawing.Point(240, 331)
        Me.LblSpot9.Name = "LblSpot9"
        Me.LblSpot9.Size = New System.Drawing.Size(96, 96)
        Me.LblSpot9.TabIndex = 2
        Me.LblSpot9.Text = "-"
        '
        'LblSpot6
        '
        Me.LblSpot6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSpot6.Font = New System.Drawing.Font("Verdana", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSpot6.Location = New System.Drawing.Point(240, 209)
        Me.LblSpot6.Name = "LblSpot6"
        Me.LblSpot6.Size = New System.Drawing.Size(96, 96)
        Me.LblSpot6.TabIndex = 5
        Me.LblSpot6.Text = "-"
        '
        'LblSpot5
        '
        Me.LblSpot5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSpot5.Font = New System.Drawing.Font("Verdana", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSpot5.Location = New System.Drawing.Point(128, 209)
        Me.LblSpot5.Name = "LblSpot5"
        Me.LblSpot5.Size = New System.Drawing.Size(96, 96)
        Me.LblSpot5.TabIndex = 4
        Me.LblSpot5.Text = "-"
        '
        'LblSpot4
        '
        Me.LblSpot4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSpot4.Font = New System.Drawing.Font("Verdana", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSpot4.Location = New System.Drawing.Point(16, 209)
        Me.LblSpot4.Name = "LblSpot4"
        Me.LblSpot4.Size = New System.Drawing.Size(96, 96)
        Me.LblSpot4.TabIndex = 3
        Me.LblSpot4.Text = "-"
        '
        'LblSpot3
        '
        Me.LblSpot3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSpot3.Font = New System.Drawing.Font("Verdana", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSpot3.Location = New System.Drawing.Point(240, 83)
        Me.LblSpot3.Name = "LblSpot3"
        Me.LblSpot3.Size = New System.Drawing.Size(96, 96)
        Me.LblSpot3.TabIndex = 8
        Me.LblSpot3.Text = "-"
        '
        'LblSpot2
        '
        Me.LblSpot2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSpot2.Font = New System.Drawing.Font("Verdana", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSpot2.Location = New System.Drawing.Point(128, 83)
        Me.LblSpot2.Name = "LblSpot2"
        Me.LblSpot2.Size = New System.Drawing.Size(96, 96)
        Me.LblSpot2.TabIndex = 7
        Me.LblSpot2.Text = "-"
        '
        'LblSpot1
        '
        Me.LblSpot1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblSpot1.Font = New System.Drawing.Font("Verdana", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSpot1.Location = New System.Drawing.Point(16, 83)
        Me.LblSpot1.Name = "LblSpot1"
        Me.LblSpot1.Size = New System.Drawing.Size(96, 96)
        Me.LblSpot1.TabIndex = 6
        Me.LblSpot1.Tag = "0,0"
        Me.LblSpot1.Text = "-"
        '
        'BtnStart
        '
        Me.BtnStart.Location = New System.Drawing.Point(43, 19)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(150, 24)
        Me.BtnStart.TabIndex = 9
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'LblPlayer
        '
        Me.LblPlayer.AutoSize = True
        Me.LblPlayer.Location = New System.Drawing.Point(282, 19)
        Me.LblPlayer.Name = "LblPlayer"
        Me.LblPlayer.Size = New System.Drawing.Size(48, 13)
        Me.LblPlayer.TabIndex = 10
        Me.LblPlayer.Text = "Player: _"
        '
        'FormGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 442)
        Me.Controls.Add(Me.LblPlayer)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.LblSpot3)
        Me.Controls.Add(Me.LblSpot2)
        Me.Controls.Add(Me.LblSpot1)
        Me.Controls.Add(Me.LblSpot6)
        Me.Controls.Add(Me.LblSpot5)
        Me.Controls.Add(Me.LblSpot4)
        Me.Controls.Add(Me.LblSpot9)
        Me.Controls.Add(Me.LblSpot8)
        Me.Controls.Add(Me.LblSpot7)
        Me.Name = "FormGame"
        Me.Text = "Tic-Tac"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblSpot7 As Label
    Friend WithEvents LblSpot8 As Label
    Friend WithEvents LblSpot9 As Label
    Friend WithEvents LblSpot6 As Label
    Friend WithEvents LblSpot5 As Label
    Friend WithEvents LblSpot4 As Label
    Friend WithEvents LblSpot3 As Label
    Friend WithEvents LblSpot2 As Label
    Friend WithEvents LblSpot1 As Label
    Friend WithEvents BtnStart As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LblPlayer As Label
End Class
