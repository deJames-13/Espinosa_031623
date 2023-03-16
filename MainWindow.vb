Public Class MainWindow


    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPage(InputForm.PageContainer, currentPage)

    End Sub
    Private Sub handleTool_Click(sender As Object, e As EventArgs) Handles toolEmpInfo.Click, toolBenefits.Click, toolPayroll.Click, toolMenu.Click, toolDataGrid.Click, ExitToolStripMenuItem.Click
        Dim tool As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

        Select Case tool.Name
            Case "toolEmpInfo"
                switchPage(InputForm.PageContainer, currentPage)
            Case "toolBenefits"
                switchPage(BenefitsForm.PageContainer, currentPage)
            Case "toolPayroll"
                switchPage(OutputForm.PageContainer, currentPage)
            Case "toolDataGrid"
                switchPage(DataGridForm.PageContainer, currentPage)
            Case "toolMenu"
                switchPage(InputForm.PageContainer, currentPage)
            Case "ExitToolStripMenuItem"
                Me.Close()
        End Select

    End Sub
End Class
