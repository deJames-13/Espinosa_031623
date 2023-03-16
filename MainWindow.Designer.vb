<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
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
        Me.WindowPanel = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PageContainer = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.toolMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolEmpInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolBenefits = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolPayroll = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolDataGrid = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowPanel.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WindowPanel
        '
        Me.WindowPanel.Controls.Add(Me.Panel6)
        Me.WindowPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WindowPanel.Location = New System.Drawing.Point(0, 0)
        Me.WindowPanel.Name = "WindowPanel"
        Me.WindowPanel.Size = New System.Drawing.Size(784, 361)
        Me.WindowPanel.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.PageContainer)
        Me.Panel6.Controls.Add(Me.Panel17)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel6.Size = New System.Drawing.Size(784, 361)
        Me.Panel6.TabIndex = 3
        '
        'PageContainer
        '
        Me.PageContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PageContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PageContainer.Dock = System.Windows.Forms.DockStyle.Top
        Me.PageContainer.Location = New System.Drawing.Point(5, 45)
        Me.PageContainer.Margin = New System.Windows.Forms.Padding(10)
        Me.PageContainer.Name = "PageContainer"
        Me.PageContainer.Padding = New System.Windows.Forms.Padding(5)
        Me.PageContainer.Size = New System.Drawing.Size(772, 305)
        Me.PageContainer.TabIndex = 7
        '
        'Panel17
        '
        Me.Panel17.BackColor = System.Drawing.Color.Transparent
        Me.Panel17.Controls.Add(Me.MenuStrip1)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Panel17.Location = New System.Drawing.Point(5, 5)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel17.Size = New System.Drawing.Size(772, 40)
        Me.Panel17.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolMenu, Me.toolEmpInfo, Me.toolBenefits, Me.toolPayroll, Me.toolDataGrid})
        Me.MenuStrip1.Location = New System.Drawing.Point(5, 5)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(762, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'toolMenu
        '
        Me.toolMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.toolMenu.Name = "toolMenu"
        Me.toolMenu.Size = New System.Drawing.Size(50, 26)
        Me.toolMenu.Text = "Menu"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'toolEmpInfo
        '
        Me.toolEmpInfo.CheckOnClick = True
        Me.toolEmpInfo.Name = "toolEmpInfo"
        Me.toolEmpInfo.Size = New System.Drawing.Size(137, 26)
        Me.toolEmpInfo.Text = "Employee Information"
        '
        'toolBenefits
        '
        Me.toolBenefits.CheckOnClick = True
        Me.toolBenefits.Name = "toolBenefits"
        Me.toolBenefits.Size = New System.Drawing.Size(61, 26)
        Me.toolBenefits.Text = "Benefits"
        '
        'toolPayroll
        '
        Me.toolPayroll.CheckOnClick = True
        Me.toolPayroll.Name = "toolPayroll"
        Me.toolPayroll.Size = New System.Drawing.Size(127, 26)
        Me.toolPayroll.Text = "Pay Roll Information"
        '
        'toolDataGrid
        '
        Me.toolDataGrid.CheckOnClick = True
        Me.toolDataGrid.Name = "toolDataGrid"
        Me.toolDataGrid.Size = New System.Drawing.Size(68, 26)
        Me.toolDataGrid.Text = "Data Grid"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.Controls.Add(Me.WindowPanel)
        Me.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainWindow"
        Me.ShowIcon = False
        Me.Text = "Welcome to my Form!"
        Me.WindowPanel.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WindowPanel As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel17 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents toolMenu As ToolStripMenuItem
    Friend WithEvents PageContainer As Panel
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolEmpInfo As ToolStripMenuItem
    Friend WithEvents toolBenefits As ToolStripMenuItem
    Friend WithEvents toolPayroll As ToolStripMenuItem
    Friend WithEvents toolDataGrid As ToolStripMenuItem
End Class
