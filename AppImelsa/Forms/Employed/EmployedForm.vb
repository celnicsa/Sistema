Imports DevComponents.DotNetBar.SuperGrid
Public Class EmployedForm
    Private DataEmployed As New Employed
    Private Sub EmployedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
        UpdateRangeSlider()
        CmBSexo.SelectedIndex = 0
        CmdLoadCarg(CmBCargo)
        CmBCargo.SelectedIndex = 0
        CmdLoadTurnoF(CmBTurno)
        CmBTurno.SelectedIndex = 0
    End Sub
    Private Sub LoadTable()
        Dim panel As GridPanel = GridEmployed.PrimaryGrid
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1
        CmdViewEmployeds(panel)
        panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
    End Sub
    Private Function QuestionDelete(ByVal Entidad As String) As Boolean
        Dim Question As Int16
        Question = MsgBox("¿Desea Eliminar a la Entidad '" + Entidad + "' ?", MsgBoxStyle.YesNo)
        If Question = MsgBoxResult.Yes Then
            Return True
        End If
        Return False
    End Function
    Private Sub GetSelectedEmployed()
        If GridEmployed.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Empleado", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridEmployed.GetSelectedRows(0)
            DataEmployed = New Employed
            DataEmployed.Code = Grida.Cells(0).Value.ToString
            DataEmployed.Name = Grida.Cells(1).Value.ToString
            DataEmployed.Apellido = Grida.Cells(2).Value.ToString
            If QuestionDelete(DataEmployed.Name + " " + DataEmployed.Apellido) Then
                If CmdDeleteEmployed(DataEmployed) Then
                    MsgBox("Datos de Empleado Eliminado Satisfactoriamente", MsgBoxStyle.Information)
                Else
                    MeErrorMessageDialog.ErrorMessage("Error-E03")
                End If
            End If
        End If
    End Sub
    Private Sub CallInsertEmployed()
        Dim WindowsInsertEmployed As New AddEmployedForm
        WindowsInsertEmployed.ShowDialog()
    End Sub
    Private Sub BtnInsertClient_Click(sender As Object, e As EventArgs) Handles BtnNewEmployed.Click
        CallInsertEmployed()
        LoadTable()
    End Sub
    Private Sub BtnDeleteEmployed_Click(sender As Object, e As EventArgs) Handles BtnDeleteEmployed.Click
        GetSelectedEmployed()
        LoadTable()
    End Sub
    Private Sub BtnLoadTable_Click(sender As Object, e As EventArgs)
        LoadTable()
    End Sub
    Private Sub RbtnAll_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnAll.CheckedChanged
        If RbtnAll.Checked Then
            LoadTable()
        End If
    End Sub
    Private Sub Search()
        Dim Panel As GridPanel = GridEmployed.PrimaryGrid
        Panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
        If RbtnName.Checked = True Then
            CmdSearchEmployed(Panel, "Name", TxtBSearch.Text, RangeSlider1.Value.Min, RangeSlider1.Value.Max,
                              GetSelectSexo, GetSelectCargo, GetSelectTurno)
        ElseIf RbtnIden.Checked
            CmdSearchEmployed(Panel, "Iden", TxtBSearch.Text, RangeSlider1.Value.Min, RangeSlider1.Value.Max,
                              GetSelectSexo, GetSelectCargo, GetSelectTurno)
        ElseIf RbtnCode.Checked
            CmdSearchEmployed(Panel, "Code", TxtBSearch.Text, RangeSlider1.Value.Min, RangeSlider1.Value.Max,
                              GetSelectSexo, GetSelectCargo, GetSelectTurno)
        End If
    End Sub
    Private Sub TxtBSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtBSearch.TextChanged
        Search()
    End Sub
    Private Sub UpdateRangeSlider()
        LabelX3.Text = "Min: " + RangeSlider1.Value.Min.ToString + " - " + "Max: " + RangeSlider1.Value.Max.ToString
        Search()
    End Sub
    Private Sub RangeSlider1_ValueChanged(sender As Object, e As EventArgs) Handles RangeSlider1.ValueChanged
        UpdateRangeSlider()
    End Sub
    Private Sub SuperGridControl1_SelectionChanged(sender As Object, e As GridEventArgs) Handles GridEmployed.SelectionChanged
        'If GridEmployed.GetSelectedRows.Count = 0 Then

        'Else
        '    Dim Grida As GridRow = GridEmployed.GetSelectedRows(0)
        '    LabelName.Text = Grida.Cells(1).Value.ToString() + " " + Grida.Cells(2).Value.ToString()
        '    LabelCarg.Text = Grida.Cells(7).Value.ToString()
        '    LabelAge.Text = Grida.Cells(3).Value.ToString()
        'End If
    End Sub
    Public Function GetSelectSexo() As String
        Dim ItemSelect As Int16 = CmBSexo.SelectedIndex
        Select Case ItemSelect
            Case 0
                Return ""
            Case 1
                Return "M"
            Case 2
                Return "F"
            Case Else
                MsgBox("Error en filtro Sexo", MsgBoxStyle.Exclamation)
                Return "Error"
        End Select
    End Function
    Public Function GetSelectCargo() As String
        Dim ItemSelect As Int16 = CmBCargo.SelectedIndex
        If ItemSelect = 0 Then
            Return ""
        Else
            Return CmBCargo.Items(ItemSelect).ToString
        End If
    End Function
    Public Function GetSelectTurno() As String
        Dim ItemSelect As Int16 = CmBTurno.SelectedIndex
        If ItemSelect = 0 Then
            Return ""
        Else
            Return CmBTurno.Items(ItemSelect).ToString
        End If
    End Function
    Private Sub CmBSexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmBSexo.SelectedIndexChanged
        Search()
    End Sub
    Private Sub CmBCargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmBCargo.SelectedIndexChanged
        Search()
    End Sub
    Private Sub CmBTurno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmBTurno.SelectedIndexChanged
        Search()
    End Sub
    Private Sub BtnUpdateCargo_Click(sender As Object, e As EventArgs) Handles BtnUpdateCargo.Click
        CmdLoadCarg(CmBCargo)
        CmBCargo.SelectedIndex = 0
    End Sub
    Private Sub BtnUpdateTurno_Click(sender As Object, e As EventArgs) Handles BtnUpdateTurno.Click
        CmdLoadTurnoF(CmBTurno)
        CmBTurno.SelectedIndex = 0
    End Sub
    Private Sub BtnUpdateEmployed_Click(sender As Object, e As EventArgs) Handles BtnUpdateEmployed.Click
        If GridEmployed.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Empleado", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridEmployed.GetSelectedRows(0)
            Dim WindowsPerfilEmployed As New OneEmployed
            WindowsPerfilEmployed.Code = Grida.Cells(0).Value.ToString
            WindowsPerfilEmployed.ShowDialog()
        End If
    End Sub


End Class