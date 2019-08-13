Imports DevComponents.DotNetBar.SuperGrid

Public Class ProyectForm
    Private DataProyect As New Proyect
    Private Sub EmployedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
        CmBEstado.SelectedIndex = 0
    End Sub

    Private Sub LoadTable()
        Dim panel As GridPanel = GridProyect.PrimaryGrid
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1
        CmdViewProyect(panel)
        panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
    End Sub
    Private Function QuestionDelete(ByVal Entidad As String) As Boolean
        Dim Question As Int16
        Question = MsgBox("�Desea Eliminar a la Entidad '" + Entidad + "' ?", MsgBoxStyle.YesNo)
        If Question = MsgBoxResult.Yes Then
            Return True
        End If
        Return False
    End Function

    Private Sub GetSelectedEmployed()
        If GridProyect.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Proyecto", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridProyect.GetSelectedRows(0)
            DataProyect = New Proyect
            DataProyect.Code = Grida.Cells(0).Value.ToString
            DataProyect.Name = Grida.Cells(1).Value.ToString
            If QuestionDelete(DataProyect.Name) Then
                If CmdDeleteProyect(DataProyect) Then
                    MsgBox("Datos de Proyectos Eliminado Satisfactoriamente", MsgBoxStyle.Information)
                Else
                    MeErrorMessageDialog.ErrorMessage("Error-P03")
                End If
            End If
        End If
    End Sub

    Private Sub CallInsertProyect()
        Dim WindowsInsertProyect As New AgregarProyectoForm
        WindowsInsertProyect.ShowDialog()
    End Sub

    Private Sub BtnInsertClient_Click(sender As Object, e As EventArgs) Handles BtnNewEmployed.Click
        CallInsertProyect()
        LoadTable()
    End Sub

    Private Sub BtnDeleteEmployed_Click(sender As Object, e As EventArgs) Handles BtnDeleteEmployed.Click
        GetSelectedEmployed()
        LoadTable()
    End Sub

    Private Sub BtnLoadTable_Click(sender As Object, e As EventArgs) Handles BtnLoadTable.Click
        LoadTable()
    End Sub
    Public Sub Search()
        Dim Panel As GridPanel = GridProyect.PrimaryGrid
        Dim DateInit_1, DateInit_2, DateEnd_1, DateEnd_2 As Date
        Dim Case_1, Case_2 As Int16
        If ChBDateInit.Checked Then
            Case_1 = 1
        Else
            Case_1 = 0
        End If
        If ChBDateEnd.Checked Then
            Case_2 = 1
        Else
            Case_2 = 0
        End If
        CmdViewProyect(Panel)
        GetDateInitRange(DateInit_1, DateInit_2)
        GetDateEndRange(DateEnd_1, DateEnd_2)
        Panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
        If RbtnName.Checked = True Then
            CmdSearchProyect(Panel, "Name", TxtBSearch.Text, GetSelectEstado(), DateInit_1, DateInit_2, Case_1,
                             DateEnd_1, DateEnd_2, Case_2)
        ElseIf RbtnIden.Checked Then
            CmdSearchProyect(Panel, "Client", TxtBSearch.Text, GetSelectEstado(), DateInit_1, DateInit_2, Case_1,
                             DateEnd_1, DateEnd_2, Case_2)
        ElseIf RbtnCode.Checked Then
            CmdSearchProyect(Panel, "Code", TxtBSearch.Text, GetSelectEstado(), DateInit_1, DateInit_2, Case_1,
                             DateEnd_1, DateEnd_2, Case_2)
        End If
    End Sub
    Private Sub TxtBSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtBSearch.TextChanged
        Search()
    End Sub
    Public Function GetSelectEstado() As String
        Dim ItemSelect As Int16 = CmBEstado.SelectedIndex
        Select Case ItemSelect
            Case 0
                Return ""
            Case 1
                Return "0"
            Case 2
                Return "1"
            Case Else
                MsgBox("Error en filtro Sexo", MsgBoxStyle.Exclamation)
                Return "Error"
        End Select
    End Function
    Private Sub RbtnAll_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnAll.CheckedChanged
        If RbtnAll.Checked Then
            LoadTable()
        End If
    End Sub

    Public Sub GetDateInitRange(ByRef DateInit_1 As Date, ByRef DateInit_2 As Date)
        DateInit_1 = DinputInit_1.Value.ToString("yyyyMMMdd")
        DateInit_2 = DinputInit_2.Value.ToString("yyyyMMMdd")
    End Sub
    Public Sub GetDateEndRange(ByRef DateEnd_1 As Date, ByRef DateEnd_2 As Date)
        DateEnd_1 = DinputEnd_1.Value.ToString("yyyyMMMdd")
        DateEnd_2 = DinputEnd_2.Value.ToString("yyyyMMMdd")
    End Sub
    Private Sub CmBEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmBEstado.SelectedIndexChanged
        Search()
    End Sub
    Private Sub DinputInit_2_ValueChanged(sender As Object, e As EventArgs) Handles DinputInit_2.ValueChanged
        If DateTime.Compare(DinputInit_2.Value, DinputInit_1.Value) < 0 Then
            MsgBox("Fecha Invalida, no cumple con el rango", MsgBoxStyle.Exclamation)
            DinputInit_2.Value = DinputInit_1.Value
        End If
        Search()
    End Sub
    Private Sub DinputInit_1_ValueChanged(sender As Object, e As EventArgs) Handles DinputInit_1.ValueChanged
        If DateTime.Compare(DinputInit_2.Value, DinputInit_1.Value) < 0 Then
            MsgBox("Fecha Invalida, no cumple con el rango", MsgBoxStyle.Exclamation)
            DinputInit_1.Value = DinputInit_2.Value
        End If
        Search()
    End Sub
    Private Sub DinputEnd_1_ValueChanged(sender As Object, e As EventArgs) Handles DinputEnd_1.ValueChanged
        If DateTime.Compare(DinputEnd_2.Value, DinputEnd_1.Value) < 0 Then
            MsgBox("Fecha Invalida, no cumple con el rango", MsgBoxStyle.Exclamation)
            DinputEnd_1.Value = DinputEnd_2.Value
        End If
        Search()
    End Sub
    Private Sub DinputEnd_2_ValueChanged(sender As Object, e As EventArgs) Handles DinputEnd_2.ValueChanged
        If DateTime.Compare(DinputEnd_2.Value, DinputEnd_1.Value) < 0 Then
            MsgBox("Fecha Invalida, no cumple con el rango", MsgBoxStyle.Exclamation)
            DinputEnd_2.Value = DinputEnd_1.Value
        End If
        Search()
    End Sub

    Private Sub ChBDateInit_CheckedChanged(sender As Object, e As EventArgs) Handles ChBDateInit.CheckedChanged
        Search()
    End Sub

    Private Sub ChBDateEnd_CheckedChanged(sender As Object, e As EventArgs) Handles ChBDateEnd.CheckedChanged
        Search()
    End Sub

    Private Sub BtnUpdateEmployed_Click(sender As Object, e As EventArgs) Handles BtnUpdateEmployed.Click
        If GridProyect.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Proyecto", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridProyect.GetSelectedRows(0)
            Dim WindowsOneProyect As New ActualizarProyectoForm
            WindowsOneProyect.Code = Grida.Cells(0).Value.ToString
            WindowsOneProyect.ShowDialog()
        End If
    End Sub

    Private Sub BtnGenerarReport_Click(sender As Object, e As EventArgs) Handles BtnGenerarReport.Click
        Dim WindowsReport As New ReporteProyectoForm
        WindowsReport.ShowDialog()
    End Sub

    Private Sub BtnProUnico_Click(sender As Object, e As EventArgs) Handles BtnProUnico.Click
        If GridProyect.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Proyecto", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridProyect.GetSelectedRows(0)
            Dim WindowsReporteProyect As New ReporteUnicoForm
            WindowsReporteProyect.Code = Grida.Cells(0).Value.ToString
            WindowsReporteProyect.ShowDialog()
        End If
    End Sub
End Class