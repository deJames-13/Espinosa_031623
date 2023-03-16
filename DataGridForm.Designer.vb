<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataGridForm
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
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.panelnext = New System.Windows.Forms.Panel()
        Me.btnAgain = New System.Windows.Forms.Button()
        Me.Panel20 = New System.Windows.Forms.Panel()
        Me.dtGrid1 = New System.Windows.Forms.DataGridView()
        Me.dtName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtDept = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtGross = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtFedTax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtBenefits = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtNet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PageContainer.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panelnext.SuspendLayout()
        Me.Panel20.SuspendLayout()
        CType(Me.dtGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PageContainer
        '
        Me.PageContainer.BackColor = System.Drawing.Color.Azure
        Me.PageContainer.Controls.Add(Me.Panel19)
        Me.PageContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PageContainer.Location = New System.Drawing.Point(0, 0)
        Me.PageContainer.Margin = New System.Windows.Forms.Padding(10)
        Me.PageContainer.Name = "PageContainer"
        Me.PageContainer.Padding = New System.Windows.Forms.Padding(5)
        Me.PageContainer.Size = New System.Drawing.Size(772, 305)
        Me.PageContainer.TabIndex = 3
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel19.Controls.Add(Me.Panel1)
        Me.Panel19.Controls.Add(Me.Panel20)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel19.Location = New System.Drawing.Point(5, 5)
        Me.Panel19.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel19.Size = New System.Drawing.Size(762, 295)
        Me.Panel19.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.panelnext)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(5, 243)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 47)
        Me.Panel1.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(178, 47)
        Me.Panel2.TabIndex = 9
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightCoral
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(5, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(168, 37)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'panelnext
        '
        Me.panelnext.Controls.Add(Me.btnAgain)
        Me.panelnext.Dock = System.Windows.Forms.DockStyle.Right
        Me.panelnext.Location = New System.Drawing.Point(574, 0)
        Me.panelnext.Margin = New System.Windows.Forms.Padding(10)
        Me.panelnext.Name = "panelnext"
        Me.panelnext.Padding = New System.Windows.Forms.Padding(5)
        Me.panelnext.Size = New System.Drawing.Size(178, 47)
        Me.panelnext.TabIndex = 8
        '
        'btnAgain
        '
        Me.btnAgain.BackColor = System.Drawing.Color.PaleGreen
        Me.btnAgain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnAgain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btnAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgain.Location = New System.Drawing.Point(5, 5)
        Me.btnAgain.Name = "btnAgain"
        Me.btnAgain.Size = New System.Drawing.Size(168, 37)
        Me.btnAgain.TabIndex = 0
        Me.btnAgain.Text = "Input Again"
        Me.btnAgain.UseVisualStyleBackColor = False
        '
        'Panel20
        '
        Me.Panel20.Controls.Add(Me.dtGrid1)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel20.Location = New System.Drawing.Point(5, 5)
        Me.Panel20.Margin = New System.Windows.Forms.Padding(5)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(752, 178)
        Me.Panel20.TabIndex = 0
        '
        'dtGrid1
        '
        Me.dtGrid1.AllowUserToAddRows = False
        Me.dtGrid1.AllowUserToResizeColumns = False
        Me.dtGrid1.AllowUserToResizeRows = False
        Me.dtGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGrid1.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dtGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtName, Me.dtDept, Me.dtGross, Me.dtFedTax, Me.dtBenefits, Me.dtNet})
        Me.dtGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGrid1.Location = New System.Drawing.Point(0, 0)
        Me.dtGrid1.Name = "dtGrid1"
        Me.dtGrid1.ReadOnly = True
        Me.dtGrid1.RowTemplate.Height = 25
        Me.dtGrid1.Size = New System.Drawing.Size(752, 178)
        Me.dtGrid1.TabIndex = 0
        '
        'dtName
        '
        Me.dtName.HeaderText = "Name"
        Me.dtName.Name = "dtName"
        Me.dtName.ReadOnly = True
        Me.dtName.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'dtDept
        '
        Me.dtDept.HeaderText = "Department"
        Me.dtDept.Name = "dtDept"
        Me.dtDept.ReadOnly = True
        Me.dtDept.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'dtGross
        '
        Me.dtGross.HeaderText = "Gross"
        Me.dtGross.Name = "dtGross"
        Me.dtGross.ReadOnly = True
        '
        'dtFedTax
        '
        Me.dtFedTax.HeaderText = "Federal Tax"
        Me.dtFedTax.Name = "dtFedTax"
        Me.dtFedTax.ReadOnly = True
        '
        'dtBenefits
        '
        Me.dtBenefits.HeaderText = "Benefits"
        Me.dtBenefits.Name = "dtBenefits"
        Me.dtBenefits.ReadOnly = True
        '
        'dtNet
        '
        Me.dtNet.HeaderText = "Net Pay"
        Me.dtNet.Name = "dtNet"
        Me.dtNet.ReadOnly = True
        '
        'DataGridForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 305)
        Me.Controls.Add(Me.PageContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "DataGridForm"
        Me.Text = "DataGridForm"
        Me.PageContainer.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.panelnext.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        CType(Me.dtGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PageContainer As Panel
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Panel20 As Panel
    Friend WithEvents dtGrid1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents panelnext As Panel
    Friend WithEvents btnAgain As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents dtName As DataGridViewTextBoxColumn
    Friend WithEvents dtDept As DataGridViewTextBoxColumn
    Friend WithEvents dtGross As DataGridViewTextBoxColumn
    Friend WithEvents dtFedTax As DataGridViewTextBoxColumn
    Friend WithEvents dtBenefits As DataGridViewTextBoxColumn
    Friend WithEvents dtNet As DataGridViewTextBoxColumn
End Class
