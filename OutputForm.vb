Public Class OutputForm
    Private Sub btnNext1_Click(sender As Object, e As EventArgs) Handles btnNext1.Click
        SaveInputs()
        addToGrid()
        switchPage(DataGridForm.PageContainer, currentPage)
    End Sub

    Private Sub btnAgain_Click(sender As Object, e As EventArgs) Handles btnAgain.Click
        Dim m As Integer = MessageBox.Show("Are you sure you don't want to save the data to grid?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If m = vbYes Then
            reset()
            Return
        End If
    End Sub
End Class