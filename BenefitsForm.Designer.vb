<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BenefitsForm
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
        Me.PageContainer = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panelnext = New System.Windows.Forms.Panel()
        Me.btnNext1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.chkDent = New System.Windows.Forms.CheckBox()
        Me.chkLife = New System.Windows.Forms.CheckBox()
        Me.chkMed = New System.Windows.Forms.CheckBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.rbtPlan = New System.Windows.Forms.RadioButton()
        Me.rbtStandard = New System.Windows.Forms.RadioButton()
        Me.rbtDefault = New System.Windows.Forms.RadioButton()
        Me.PageContainer.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.panelnext.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'PageContainer
        '
        Me.PageContainer.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PageContainer.Controls.Add(Me.Panel1)
        Me.PageContainer.Controls.Add(Me.GroupBox1)
        Me.PageContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PageContainer.Location = New System.Drawing.Point(0, 0)
        Me.PageContainer.Margin = New System.Windows.Forms.Padding(10)
        Me.PageContainer.Name = "PageContainer"
        Me.PageContainer.Padding = New System.Windows.Forms.Padding(200, 5, 200, 5)
        Me.PageContainer.Size = New System.Drawing.Size(772, 305)
        Me.PageContainer.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.panelnext)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(200, 217)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(372, 47)
        Me.Panel1.TabIndex = 10
        '
        'panelnext
        '
        Me.panelnext.Controls.Add(Me.btnNext1)
        Me.panelnext.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelnext.Location = New System.Drawing.Point(252, 0)
        Me.panelnext.Margin = New System.Windows.Forms.Padding(10)
        Me.panelnext.Name = "panelnext"
        Me.panelnext.Padding = New System.Windows.Forms.Padding(5)
        Me.panelnext.Size = New System.Drawing.Size(120, 47)
        Me.panelnext.TabIndex = 8
        '
        'btnNext1
        '
        Me.btnNext1.BackColor = System.Drawing.Color.PaleGreen
        Me.btnNext1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnNext1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnNext1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext1.Location = New System.Drawing.Point(5, 5)
        Me.btnNext1.Name = "btnNext1"
        Me.btnNext1.Size = New System.Drawing.Size(110, 37)
        Me.btnNext1.TabIndex = 0
        Me.btnNext1.Text = "Next"
        Me.btnNext1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Panel10)
        Me.GroupBox1.Controls.Add(Me.Panel9)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(200, 5)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(372, 212)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Benefits"
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.chkDent)
        Me.Panel10.Controls.Add(Me.chkLife)
        Me.Panel10.Controls.Add(Me.chkMed)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(226, 21)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel10.Size = New System.Drawing.Size(136, 186)
        Me.Panel10.TabIndex = 2
        '
        'chkDent
        '
        Me.chkDent.AutoSize = True
        Me.chkDent.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkDent.Location = New System.Drawing.Point(3, 108)
        Me.chkDent.Name = "chkDent"
        Me.chkDent.Padding = New System.Windows.Forms.Padding(0, 17, 0, 15)
        Me.chkDent.Size = New System.Drawing.Size(130, 51)
        Me.chkDent.TabIndex = 2
        Me.chkDent.Text = "Dental Insurance"
        Me.chkDent.UseVisualStyleBackColor = True
        '
        'chkLife
        '
        Me.chkLife.AutoSize = True
        Me.chkLife.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkLife.Location = New System.Drawing.Point(3, 57)
        Me.chkLife.Name = "chkLife"
        Me.chkLife.Padding = New System.Windows.Forms.Padding(0, 17, 0, 15)
        Me.chkLife.Size = New System.Drawing.Size(130, 51)
        Me.chkLife.TabIndex = 1
        Me.chkLife.Text = "Life Insurance"
        Me.chkLife.UseVisualStyleBackColor = True
        '
        'chkMed
        '
        Me.chkMed.AutoSize = True
        Me.chkMed.Dock = System.Windows.Forms.DockStyle.Top
        Me.chkMed.Location = New System.Drawing.Point(3, 3)
        Me.chkMed.Name = "chkMed"
        Me.chkMed.Padding = New System.Windows.Forms.Padding(0, 17, 0, 15)
        Me.chkMed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkMed.Size = New System.Drawing.Size(130, 54)
        Me.chkMed.TabIndex = 0
        Me.chkMed.Text = "Medical Insurance"
        Me.chkMed.UseCompatibleTextRendering = True
        Me.chkMed.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.rbtPlan)
        Me.Panel9.Controls.Add(Me.rbtStandard)
        Me.Panel9.Controls.Add(Me.rbtDefault)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(10, 21)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel9.Size = New System.Drawing.Size(163, 186)
        Me.Panel9.TabIndex = 1
        '
        'rbtPlan
        '
        Me.rbtPlan.AutoSize = True
        Me.rbtPlan.Dock = System.Windows.Forms.DockStyle.Top
        Me.rbtPlan.Location = New System.Drawing.Point(3, 108)
        Me.rbtPlan.Name = "rbtPlan"
        Me.rbtPlan.Padding = New System.Windows.Forms.Padding(0, 17, 0, 15)
        Me.rbtPlan.Size = New System.Drawing.Size(157, 51)
        Me.rbtPlan.TabIndex = 2
        Me.rbtPlan.Text = "Retirement 401 Plan"
        Me.rbtPlan.UseVisualStyleBackColor = True
        '
        'rbtStandard
        '
        Me.rbtStandard.AutoSize = True
        Me.rbtStandard.Dock = System.Windows.Forms.DockStyle.Top
        Me.rbtStandard.Location = New System.Drawing.Point(3, 54)
        Me.rbtStandard.Name = "rbtStandard"
        Me.rbtStandard.Padding = New System.Windows.Forms.Padding(0, 17, 0, 15)
        Me.rbtStandard.Size = New System.Drawing.Size(157, 54)
        Me.rbtStandard.TabIndex = 1
        Me.rbtStandard.Text = "Retirement Standard"
        Me.rbtStandard.UseCompatibleTextRendering = True
        Me.rbtStandard.UseVisualStyleBackColor = True
        '
        'rbtDefault
        '
        Me.rbtDefault.AutoSize = True
        Me.rbtDefault.Checked = True
        Me.rbtDefault.Dock = System.Windows.Forms.DockStyle.Top
        Me.rbtDefault.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.rbtDefault.FlatAppearance.BorderSize = 0
        Me.rbtDefault.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.rbtDefault.Location = New System.Drawing.Point(3, 3)
        Me.rbtDefault.Name = "rbtDefault"
        Me.rbtDefault.Padding = New System.Windows.Forms.Padding(0, 17, 0, 15)
        Me.rbtDefault.Size = New System.Drawing.Size(157, 51)
        Me.rbtDefault.TabIndex = 0
        Me.rbtDefault.TabStop = True
        Me.rbtDefault.Text = "No Retirement"
        Me.rbtDefault.UseVisualStyleBackColor = True
        '
        'BenefitsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 305)
        Me.Controls.Add(Me.PageContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "BenefitsForm"
        Me.Text = "BenefitsForm"
        Me.PageContainer.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.panelnext.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PageContainer As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents chkDent As CheckBox
    Friend WithEvents chkLife As CheckBox
    Friend WithEvents chkMed As CheckBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents rbtPlan As RadioButton
    Friend WithEvents rbtStandard As RadioButton
    Friend WithEvents rbtDefault As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelnext As Panel
    Friend WithEvents btnNext1 As Button
End Class
