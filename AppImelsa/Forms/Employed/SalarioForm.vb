Imports DevComponents.DotNetBar.SuperGrid

Public Class SalarioForm
    Private DataSalario As New Salario
    Private Sub SalarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
        LoadNextCode()
    End Sub
    Private Sub LoadNextCode()
        TxtBCode.Text = CmdNextCode("SPNextCodeSal")
    End Sub
    Private Function ValidateBoxs() As Boolean
        If TxtBCode.Text.Length = 0 Then
            Return False
        ElseIf TxtBMonthly.Text.Length = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub GetData()
        If Me.ValidateBoxs() Then
            DataSalario = New Salario
            DataSalario.Code = TxtBCode.Text
            DataSalario.SMensual = TxtBMonthly.Text
            If CmdInsertSalario(DataSalario) Then
                MsgBox("Datos de Salario Guardados Satisfactoriamente", MsgBoxStyle.Information)
                LoadNextCode()
            Else
                MeErrorMessageDialog.ErrorMessage("Error-S02")
            End If
        Else
            MeErrorMessageDialog.ErrorMessage("Error-S01")
        End If
    End Sub

    Private Sub LoadTable()
        Dim panel As GridPanel = GridSalarios.PrimaryGrid
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1
        CmdViewSalarios(panel)
        panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
    End Sub

    Private Sub BtnInsertTurno_Click(sender As Object, e As EventArgs) Handles BtnInsertSalario.Click
        GetData()
        LoadTable()
    End Sub

    Private Function QuestionDelete(ByVal Entidad As String) As Boolean
        Dim Question As Int16
        Question = MsgBox("¿Desea Eliminar a la Entidad '" + Entidad + "' ?", MsgBoxStyle.YesNo)
        If Question = MsgBoxResult.Yes Then
            Return True
        End If
        Return False
    End Function

    Private Sub GetSelectTurno()
        If GridSalarios.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Salario", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridSalarios.GetSelectedRows(0)
            DataSalario = New Salario
            DataSalario.Code = Grida.Cells(0).Value.ToString
            DataSalario.SMensual = Grida.Cells(1).Value.ToString
            If QuestionDelete(DataSalario.SMensual) Then
                If CmdDeleteSalario(DataSalario) Then
                    MsgBox("Datos de Salario Eliminado Satisfactoriamente", MsgBoxStyle.Information)
                Else
                    MeErrorMessageDialog.ErrorMessage("Error-C03")
                End If
            End If
        End If
    End Sub

    Private Sub BtnDeleteTurno_Click(sender As Object, e As EventArgs) Handles BtnDeleteSalario.Click
        GetSelectTurno()
        LoadTable()
    End Sub

    Private Sub CallUpdateTurno()
        If GridSalarios.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Salario", MsgBoxStyle.Information)
        Else
            Dim WindowsUpdateSalario As New UpdateSalario
            Dim Grida As GridRow = GridSalarios.GetSelectedRows(0)
            DataSalario = New Salario
            DataSalario.Code = Grida.Cells(0).Value.ToString
            DataSalario.SMensual = Grida.Cells(1).Value.ToString
            DataSalario.SQuincenal = Grida.Cells(2).Value.ToString
            DataSalario.SHora = Grida.Cells(3).Value.ToString
            WindowsUpdateSalario.DataUpdateSalario.Code = DataSalario.Code
            WindowsUpdateSalario.DataUpdateSalario.SMensual = DataSalario.SMensual
            WindowsUpdateSalario.DataUpdateSalario.SQuincenal = DataSalario.SQuincenal
            WindowsUpdateSalario.DataUpdateSalario.SHora = DataSalario.SHora
            WindowsUpdateSalario.ShowDialog()
        End If
    End Sub

    Private Sub BtnUpdateSalario_Click(sender As Object, e As EventArgs) Handles BtnUpdateSalario.Click
        CallUpdateTurno()
        LoadTable()
    End Sub


End Class