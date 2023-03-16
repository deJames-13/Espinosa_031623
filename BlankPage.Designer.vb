<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BlankPage
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
        Me.SuspendLayout()
        '
        'PageContainer
        '
        Me.PageContainer.BackColor = System.Drawing.Color.Azure
        Me.PageContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PageContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PageContainer.Location = New System.Drawing.Point(0, 0)
        Me.PageContainer.Margin = New System.Windows.Forms.Padding(10)
        Me.PageContainer.Name = "PageContainer"
        Me.PageContainer.Padding = New System.Windows.Forms.Padding(5)
        Me.PageContainer.Size = New System.Drawing.Size(525, 284)
        Me.PageContainer.TabIndex = 2
        '
        'BlankPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 284)
        Me.Controls.Add(Me.PageContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "BlankPage"
        Me.Text = "BlankPage"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PageContainer As Panel
End Class
