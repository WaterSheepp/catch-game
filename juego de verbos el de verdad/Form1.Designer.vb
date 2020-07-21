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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Missed = New System.Windows.Forms.Label()
        Me.leftMover = New System.Windows.Forms.Timer(Me.components)
        Me.rightMover = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.bomb2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.basket = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bomb1 = New System.Windows.Forms.PictureBox()
        Me.verb1 = New System.Windows.Forms.Timer(Me.components)
        Me.verb3 = New System.Windows.Forms.Timer(Me.components)
        Me.verb4 = New System.Windows.Forms.Timer(Me.components)
        Me.boom1 = New System.Windows.Forms.Timer(Me.components)
        Me.boom2 = New System.Windows.Forms.Timer(Me.components)
        Me.verb2 = New System.Windows.Forms.Timer(Me.components)
        Me.endGame = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bomb2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.basket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bomb1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.Location = New System.Drawing.Point(24, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Tag = "txtScore"
        Me.Label1.Text = "Score 0"
        '
        'Missed
        '
        Me.Missed.AutoSize = True
        Me.Missed.BackColor = System.Drawing.Color.Transparent
        Me.Missed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Missed.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Missed.Location = New System.Drawing.Point(490, 38)
        Me.Missed.Name = "Missed"
        Me.Missed.Size = New System.Drawing.Size(107, 25)
        Me.Missed.TabIndex = 2
        Me.Missed.Tag = "txtMiss"
        Me.Missed.Text = "Missed 0"
        '
        'leftMover
        '
        Me.leftMover.Interval = 10
        '
        'rightMover
        '
        Me.rightMover.Interval = 10
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.juego_de_verbos_el_de_verdad.My.Resources.Resources.dance
        Me.PictureBox4.Location = New System.Drawing.Point(428, 102)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(73, 63)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Tag = "bomb"
        '
        'bomb2
        '
        Me.bomb2.BackColor = System.Drawing.Color.Transparent
        Me.bomb2.Image = Global.juego_de_verbos_el_de_verdad.My.Resources.Resources.boom
        Me.bomb2.Location = New System.Drawing.Point(333, 102)
        Me.bomb2.Name = "bomb2"
        Me.bomb2.Size = New System.Drawing.Size(73, 63)
        Me.bomb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bomb2.TabIndex = 0
        Me.bomb2.TabStop = False
        Me.bomb2.Tag = "bomb"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.juego_de_verbos_el_de_verdad.My.Resources.Resources.eat
        Me.PictureBox3.Location = New System.Drawing.Point(237, 102)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(76, 63)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Tag = "verb"
        '
        'basket
        '
        Me.basket.BackColor = System.Drawing.Color.Transparent
        Me.basket.Image = Global.juego_de_verbos_el_de_verdad.My.Resources.Resources.basket
        Me.basket.Location = New System.Drawing.Point(262, 486)
        Me.basket.Name = "basket"
        Me.basket.Size = New System.Drawing.Size(107, 93)
        Me.basket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.basket.TabIndex = 0
        Me.basket.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.juego_de_verbos_el_de_verdad.My.Resources.Resources.run
        Me.PictureBox2.Location = New System.Drawing.Point(132, 102)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 63)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Tag = "verb"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.juego_de_verbos_el_de_verdad.My.Resources.Resources.swim
        Me.PictureBox1.Location = New System.Drawing.Point(29, 102)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "verb"
        '
        'bomb1
        '
        Me.bomb1.BackColor = System.Drawing.Color.Transparent
        Me.bomb1.Image = Global.juego_de_verbos_el_de_verdad.My.Resources.Resources.boom2
        Me.bomb1.Location = New System.Drawing.Point(524, 102)
        Me.bomb1.Name = "bomb1"
        Me.bomb1.Size = New System.Drawing.Size(73, 63)
        Me.bomb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bomb1.TabIndex = 0
        Me.bomb1.TabStop = False
        Me.bomb1.Tag = "bomb"
        '
        'verb1
        '
        Me.verb1.Enabled = True
        Me.verb1.Interval = 10
        '
        'verb3
        '
        Me.verb3.Enabled = True
        Me.verb3.Interval = 10
        '
        'verb4
        '
        Me.verb4.Enabled = True
        Me.verb4.Interval = 10
        '
        'boom1
        '
        Me.boom1.Enabled = True
        Me.boom1.Interval = 10
        '
        'boom2
        '
        Me.boom2.Enabled = True
        Me.boom2.Interval = 10
        '
        'verb2
        '
        Me.verb2.Enabled = True
        Me.verb2.Interval = 10
        '
        'endGame
        '
        Me.endGame.AutoSize = True
        Me.endGame.BackColor = System.Drawing.Color.Transparent
        Me.endGame.Font = New System.Drawing.Font("Microsoft YaHei UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endGame.ForeColor = System.Drawing.Color.Crimson
        Me.endGame.Location = New System.Drawing.Point(92, 292)
        Me.endGame.Name = "endGame"
        Me.endGame.Size = New System.Drawing.Size(445, 96)
        Me.endGame.TabIndex = 3
        Me.endGame.Text = "Game Over"
        Me.endGame.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(622, 696)
        Me.Controls.Add(Me.endGame)
        Me.Controls.Add(Me.Missed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bomb1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.bomb2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.basket)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Juego de Verbos MO"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bomb2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.basket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bomb1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Missed As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents basket As PictureBox
    Friend WithEvents bomb2 As PictureBox
    Friend WithEvents leftMover As Timer
    Friend WithEvents rightMover As Timer
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents bomb1 As PictureBox
    Friend WithEvents verb1 As Timer
    Friend WithEvents verb3 As Timer
    Friend WithEvents verb4 As Timer
    Friend WithEvents boom1 As Timer
    Friend WithEvents boom2 As Timer
    Friend WithEvents verb2 As Timer
    Friend WithEvents endGame As Label
End Class
