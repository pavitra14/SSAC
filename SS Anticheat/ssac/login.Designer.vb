<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.clntag = New System.Windows.Forms.TextBox()
        Me.ign = New System.Windows.Forms.TextBox()
        Me.cmd_login = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Game = New System.Windows.Forms.TextBox()
        Me.Match = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clan Tag ( Example - NITE)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Player's in-game name"
        '
        'clntag
        '
        Me.clntag.Location = New System.Drawing.Point(269, 6)
        Me.clntag.Name = "clntag"
        Me.clntag.Size = New System.Drawing.Size(110, 20)
        Me.clntag.TabIndex = 2
        '
        'ign
        '
        Me.ign.Location = New System.Drawing.Point(269, 32)
        Me.ign.Name = "ign"
        Me.ign.Size = New System.Drawing.Size(110, 20)
        Me.ign.TabIndex = 3
        '
        'cmd_login
        '
        Me.cmd_login.Location = New System.Drawing.Point(12, 125)
        Me.cmd_login.Name = "cmd_login"
        Me.cmd_login.Size = New System.Drawing.Size(364, 72)
        Me.cmd_login.TabIndex = 4
        Me.cmd_login.Text = "Login"
        Me.cmd_login.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Match No. (Numbers only)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Game No.  (Numbers Only)"
        '
        'Game
        '
        Me.Game.Location = New System.Drawing.Point(269, 91)
        Me.Game.Name = "Game"
        Me.Game.Size = New System.Drawing.Size(110, 20)
        Me.Game.TabIndex = 7
        '
        'Match
        '
        Me.Match.Location = New System.Drawing.Point(269, 62)
        Me.Match.Name = "Match"
        Me.Match.Size = New System.Drawing.Size(110, 20)
        Me.Match.TabIndex = 8
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 209)
        Me.Controls.Add(Me.Match)
        Me.Controls.Add(Me.Game)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmd_login)
        Me.Controls.Add(Me.ign)
        Me.Controls.Add(Me.clntag)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents clntag As System.Windows.Forms.TextBox
    Friend WithEvents ign As System.Windows.Forms.TextBox
    Friend WithEvents cmd_login As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Game As System.Windows.Forms.TextBox
    Friend WithEvents Match As System.Windows.Forms.TextBox

End Class
