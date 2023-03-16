Public Class DataGridForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        MainWindow.Close()
    End Sub

    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        reset()
        switchPage(InputForm.PageContainer, currentPage)
        Return
    End Sub

    Private Sub dtGrid1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtGrid1.CellEndEdit
        '
    End Sub
End Class