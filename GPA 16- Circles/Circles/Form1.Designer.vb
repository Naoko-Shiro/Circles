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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CircleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuArea = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPerimeter = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.lblRadius = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CircleToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CircleToolStripMenuItem
        '
        Me.CircleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuArea, Me.mnuPerimeter})
        Me.CircleToolStripMenuItem.Name = "CircleToolStripMenuItem"
        Me.CircleToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.CircleToolStripMenuItem.Text = "Circle"
        '
        'mnuArea
        '
        Me.mnuArea.Name = "mnuArea"
        Me.mnuArea.Size = New System.Drawing.Size(152, 22)
        Me.mnuArea.Text = "Area"
        '
        'mnuPerimeter
        '
        Me.mnuPerimeter.Name = "mnuPerimeter"
        Me.mnuPerimeter.Size = New System.Drawing.Size(152, 22)
        Me.mnuPerimeter.Text = "Perimeter"
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(156, 77)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(100, 20)
        Me.txtRadius.TabIndex = 1
        '
        'lblRadius
        '
        Me.lblRadius.AutoSize = True
        Me.lblRadius.Location = New System.Drawing.Point(101, 77)
        Me.lblRadius.Name = "lblRadius"
        Me.lblRadius.Size = New System.Drawing.Size(40, 13)
        Me.lblRadius.TabIndex = 2
        Me.lblRadius.Text = "Radius"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblRadius)
        Me.Controls.Add(Me.txtRadius)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CircleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuArea As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPerimeter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtRadius As System.Windows.Forms.TextBox
    Friend WithEvents lblRadius As System.Windows.Forms.Label

End Class
