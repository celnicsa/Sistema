Imports DevComponents.DotNetBar.SuperGrid

Public Class PrestamoForm
    Dim DataPrestamo As Prestamo
    Private Sub PrestamoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
    End Sub
    Private Sub LoadTable()
        Dim panel As GridPanel = GridPrestamo.PrimaryGrid
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1
        CmdViewPrestamos(panel)
        'panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
    End Sub
    Private Function QuestionDelete(ByVal Entidad As String) As Boolean
        Dim Question As Int16
        Question = MsgBox("¿Desea Eliminar a el prestamo'" + Entidad + "' ?", MsgBoxStyle.YesNo)
        If Question = MsgBoxResult.Yes Then
            Return True
        End If
        Return False
    End Function
    Private Sub GetSelectedPrestamo()
        If GridPrestamo.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Prestamo", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridPrestamo.GetSelectedRows(0)
            DataPrestamo = New Prestamo
            DataPrestamo.Code = Grida.Cells(0).Value.ToString
            DataPrestamo.Employed = Grida.Cells(1).Value.ToString
            DataPrestamo.Monto = Grida.Cells(3).Value.ToString
            If QuestionDelete(DataPrestamo.Code + "del Empleado " + DataPrestamo.Employed) Then
                If CmdDeletePrestamo(DataPrestamo) Then
                    MsgBox("Datos de Prestamo Eliminado Satisfactoriamente", MsgBoxStyle.Information)
                Else
                    MeErrorMessageDialog.ErrorMessage("Error-E03")
                End If
            End If
        End If
    End Sub
    Private Sub BtnDeletePrestamo_Click(sender As Object, e As EventArgs) Handles BtnDeletePrestamo.Click
        GetSelectedPrestamo()
        LoadTable()
    End Sub
    Private Sub BtnLoadTable_Click(sender As Object, e As EventArgs) Handles BtnLoadTable.Click
        LoadTable()
    End Sub
    Private Sub CallInsertPrestamo()
        Dim WindowsInsertPrestamo As New AddPrestamoForm
        WindowsInsertPrestamo.ShowDialog()
    End Sub
    Private Sub CallInsertAbono()
        If GridPrestamo.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Prestamo", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridPrestamo.GetSelectedRows(0)
            Dim WindowsAbono As New AbonoForm
            WindowsAbono.Code_Prestamo = Grida.Cells(0).Value.ToString
            WindowsAbono.ShowDialog()
        End If

    End Sub
    Private Sub BtnNewPrestamo_Click(sender As Object, e As EventArgs) Handles BtnNewClient.Click
        CallInsertPrestamo()
        LoadTable()
    End Sub

    Private Sub BtnAbono_Click(sender As Object, e As EventArgs) Handles BtnAbono.Click
        CallInsertAbono()
        LoadTable()
    End Sub

    Private Sub TxtBSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtBSearch.TextChanged
        Dim Panel As GridPanel = GridPrestamo.PrimaryGrid
        CmdViewPrestamos(Panel)
        Panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
        If RbtnName.Checked = True Then
            CmdSearchPrestamo(Panel, "Employed", TxtBSearch.Text)
        ElseIf RbtnCode.Checked
            CmdSearchPrestamo(Panel, "Code", TxtBSearch.Text)
        End If
    End Sub

    Private Sub RbtnAll_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnAll.CheckedChanged
        If RbtnAll.Checked Then
            LoadTable()
        End If
    End Sub
End Class