Public Class BenefitsForm
    Private Sub btnNext1_Click(sender As Object, e As EventArgs) Handles btnNext1.Click

        If rbtDefault.Checked Then
            fPlanRt = 0
        ElseIf rbtStandard.Checked Then
            fPlanRt = 0.05
        ElseIf rbtPlan.Checked Then
            fPlanRt = 0.08
        End If

        fAccIns = 0
        If chkMed.Checked Then
            fAccIns += 37.75
        End If
        If chkLife.Checked Then
            'fAccIns += 18.75
            fAccIns += 18.35
        End If
        If chkDent.Checked Then
            fAccIns += 4.0
        End If

        ComputePayRoll()
        switchPage(OutputForm.PageContainer, currentPage)

    End Sub
End Class