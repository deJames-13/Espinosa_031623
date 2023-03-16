Module ComputationModule

    Public currentPage = BlankPage.PageContainer

    Public strName, strEmployee, strDept As String
    Public fhrs, fPayrate, fOt, fGr, fBnft, fNet, fFedTax As Double
    Public arrInfos As New ArrayList()
    Public fPlanRt, fTxRt, fAccIns As Double

    Public Sub reset()
        fhrs = fPayrate = fOt = fGr = fBnft = fNet = fFedTax = 0
        strName = ""
        strEmployee = ""
        strDept = ""
        fPlanRt = fTxRt = fAccIns = 0
        arrInfos = New ArrayList()

        ClearAll({OutputForm.txtGross, OutputForm.txtTax, OutputForm.txtBenefits, OutputForm.txtNet})
        ClearAll({InputForm.txtName, InputForm.txtDept, InputForm.txtHrs, InputForm.txtPayr})
        InputForm.mtxtEmpId.Clear()
        BenefitsForm.rbtDefault.Checked = True
        BenefitsForm.chkDent.Checked = False
        BenefitsForm.chkLife.Checked = False
        BenefitsForm.chkMed.Checked = False

        switchPage(InputForm.PageContainer, currentPage)

    End Sub

    Public Function inputsValidate(str As String()) As Boolean
        For Each s In str
            If Not IsNumeric(s) Then
                Return False
            End If
        Next
        Return True
    End Function

    Public Sub getInputs(str As String)
        Dim arrInfo As Array = Split(str, "/")
        strName = arrInfo(0)
        strDept = arrInfo(1)
        fhrs = CDbl(arrInfo(3))
        fPayrate = CDbl(arrInfo(4))
    End Sub

    Public Sub ComputePayRoll()

        fOt = 0
        If fhrs > 40 Then
            fOt = (fhrs - 40) * (0.5 * fPayrate)
        End If

        fGr = fPayrate * fhrs + fOt
        If fGr > 0 AndAlso fGr <= 985 Then
            fTxRt = 0.08
        ElseIf fGr > 985.01 AndAlso fGr <= 2450 Then
            fTxRt = 0.18
        ElseIf fGr > 2450.01 Then
            fTxRt = 0.28

        End If
        fFedTax = fGr * fTxRt
        fBnft = (fGr * fPlanRt) + fAccIns
        fNet = fGr - (fBnft + fFedTax)

        setOutput()
    End Sub

    Public Sub SaveInputs()
        Dim strInputs As String = fGr & "/" & fFedTax & "/" & fBnft & "/" & fNet
        arrInfos.Add(strInputs)
    End Sub


    Public Sub setOutput()
        OutputForm.txtGross.Text = fGr.ToString("C2")
        OutputForm.txtBenefits.Text = fBnft.ToString("C2")
        OutputForm.txtTax.Text = fFedTax.ToString("C2")
        OutputForm.txtNet.Text = fNet.ToString("C2")
    End Sub


    Public Sub addToGrid()
        For idx As Integer = 0 To arrInfos.Count - 1
            Dim arr As Array = Split(arrInfos(idx), "/")
            Dim nR As Integer = DataGridForm.dtGrid1.Rows.Add
            DataGridForm.dtGrid1.Item("dtName", nR).Value = strName
            DataGridForm.dtGrid1.Item("dtDept", nR).Value = strDept
            For cols As Integer = 0 To DataGridForm.dtGrid1.ColumnCount - 3
                DataGridForm.dtGrid1.Item(cols + 2, nR).Value = CDbl(arr(cols)).ToString("C2")
            Next
        Next
    End Sub



    Public Sub ClearAll(ts As TextBox())
        For Each t In ts
            t.Clear()
        Next
    End Sub

    Public Sub switchPage(ByRef newPage As Panel, ByRef currentPage As Panel)
        If newPage.Visible Then
            Return
        End If
        currentPage.Hide()
        newPage.Parent = MainWindow.PageContainer
        newPage.Dock = DockStyle.Fill
        newPage.Show()
        currentPage = newPage
    End Sub
End Module
