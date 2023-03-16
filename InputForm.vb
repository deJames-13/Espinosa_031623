Public Class InputForm

    Private Sub btnNext1_Click(sender As Object, e As EventArgs) Handles btnNext1.Click

        If Not inputsValidate({txtHrs.Text, txtPayr.Text}) Then
            MsgBox("Invalid Numeric Input!")
            reset()
            Return
        End If


        getInputs(txtName.Text & "/" & txtDept.Text & "/" & mtxtEmpId.Text & "/" & txtHrs.Text & "/" & txtPayr.Text)
        switchPage(BenefitsForm.PageContainer, currentPage)
    End Sub
End Class