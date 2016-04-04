<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGame
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.lblRock = New System.Windows.Forms.Label()
        Me.lblScissors = New System.Windows.Forms.Label()
        Me.lblPaper = New System.Windows.Forms.Label()
        Me.tmrPaint = New System.Windows.Forms.Timer(Me.components)
        Me.tmrCountdown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrRockMovement = New System.Windows.Forms.Timer(Me.components)
        Me.tmrScissorsMovement = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPaperMovement = New System.Windows.Forms.Timer(Me.components)
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(521, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ControlsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ControlsToolStripMenuItem
        '
        Me.ControlsToolStripMenuItem.Name = "ControlsToolStripMenuItem"
        Me.ControlsToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.ControlsToolStripMenuItem.Text = "Controls"
        '
        'PicBox
        '
        Me.PicBox.Location = New System.Drawing.Point(12, 43)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(500, 300)
        Me.PicBox.TabIndex = 1
        Me.PicBox.TabStop = False
        '
        'lblRock
        '
        Me.lblRock.AutoSize = True
        Me.lblRock.Location = New System.Drawing.Point(12, 27)
        Me.lblRock.Name = "lblRock"
        Me.lblRock.Size = New System.Drawing.Size(48, 13)
        Me.lblRock.TabIndex = 3
        Me.lblRock.Text = "Rock - 0"
        '
        'lblScissors
        '
        Me.lblScissors.AutoSize = True
        Me.lblScissors.Location = New System.Drawing.Point(237, 27)
        Me.lblScissors.Name = "lblScissors"
        Me.lblScissors.Size = New System.Drawing.Size(61, 13)
        Me.lblScissors.TabIndex = 4
        Me.lblScissors.Text = "Scissors - 0"
        '
        'lblPaper
        '
        Me.lblPaper.AutoSize = True
        Me.lblPaper.Location = New System.Drawing.Point(434, 27)
        Me.lblPaper.Name = "lblPaper"
        Me.lblPaper.Size = New System.Drawing.Size(50, 13)
        Me.lblPaper.TabIndex = 5
        Me.lblPaper.Text = "Paper - 0"
        '
        'tmrPaint
        '
        '
        'tmrCountdown
        '
        '
        'tmrRockMovement
        '
        '
        'tmrScissorsMovement
        '
        '
        'tmrPaperMovement
        '
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'frmGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 344)
        Me.Controls.Add(Me.lblPaper)
        Me.Controls.Add(Me.lblScissors)
        Me.Controls.Add(Me.lblRock)
        Me.Controls.Add(Me.PicBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGame"
        Me.Text = "Prototype"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PicBox As System.Windows.Forms.PictureBox
    Friend WithEvents lblRock As System.Windows.Forms.Label
    Friend WithEvents lblScissors As System.Windows.Forms.Label
    Friend WithEvents lblPaper As System.Windows.Forms.Label
    Friend WithEvents tmrPaint As System.Windows.Forms.Timer
    Friend WithEvents tmrCountdown As System.Windows.Forms.Timer
    Friend WithEvents tmrRockMovement As System.Windows.Forms.Timer
    Friend WithEvents tmrScissorsMovement As System.Windows.Forms.Timer
    Friend WithEvents tmrPaperMovement As System.Windows.Forms.Timer
    Friend WithEvents ControlsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
