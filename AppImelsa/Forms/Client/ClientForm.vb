Imports DevComponents.DotNetBar.SuperGrid

Public Class ClientForm
    Private DataClient As New Client
    Private Sub ClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
    End Sub

    Private Sub LoadTable()
        Dim panel As GridPanel = GridClient.PrimaryGrid
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1
        CmdViewClients(panel)
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

    Private Sub GetSelectedClient()
        If GridClient.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Cliente", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridClient.GetSelectedRows(0)
            DataClient = New Client
            DataClient.Code = Grida.Cells(0).Value.ToString
            DataClient.Name = Grida.Cells(1).Value.ToString
            DataClient.Ruc = Grida.Cells(2).Value.ToString
            If QuestionDelete(DataClient.Name) Then
                If CmdDeleteClient(DataClient) Then
                    MsgBox("Datos de Cliente Eliminado Satisfactoriamente", MsgBoxStyle.Information)
                Else
                    MeErrorMessageDialog.ErrorMessage("Error-CL03")
                End If
            End If
        End If
    End Sub

    Private Sub BtnLoadTable_Click(sender As Object, e As EventArgs) Handles BtnLoadTable.Click
        LoadTable()
    End Sub

    Private Sub BtnDeleteClient_Click(sender As Object, e As EventArgs) Handles BtnDeleteClient.Click
        GetSelectedClient()
        LoadTable()
    End Sub

    Private Sub CallNewClient()
        Dim WindowsInsertClient As New AddClientForm
        WindowsInsertClient.ShowDialog()
    End Sub

    Private Sub CallOneClient()
        If GridClient.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Empleado", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridClient.GetSelectedRows(0)
            Dim WindowsOneClient As New OneClientForm
            WindowsOneClient.Code = Grida.Cells(0).Value.ToString
            WindowsOneClient.ShowDialog()
        End If

    End Sub

    Private Sub BtnNewClient_Click(sender As Object, e As EventArgs) Handles BtnNewClient.Click
        CallNewClient()
        LoadTable()
    End Sub

    Private Sub BtnUpdateClient_Click(sender As Object, e As EventArgs) Handles BtnUpdateClient.Click
        CallOneClient()
    End Sub

    Private Sub TxtBSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtBSearch.TextChanged
        Dim Panel As GridPanel = GridClient.PrimaryGrid
        CmdViewClients(Panel)
        Panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
        If RbtnName.Checked = True Then
            CmdSearchClient(Panel, "Name", TxtBSearch.Text)
        ElseIf RbtnIden.Checked
            CmdSearchClient(Panel, "Iden", TxtBSearch.Text)
        ElseIf RbtnCode.Checked
            CmdSearchClient(Panel, "Code", TxtBSearch.Text)
        End If
    End Sub

    Private Sub RbtnAll_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnAll.CheckedChanged
        If RbtnAll.Checked Then
            LoadTable()
        End If
    End Sub
End Class