Imports DevComponents.DotNetBar.SuperGrid

Public Class CargoForm
    Private DataCargo As New Cargo

    Private Sub CargoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
        LoadNextCode()
    End Sub
    Private Sub LoadNextCode()
        TxtBCode.Text = CmdNextCode("SPNextCodeCarg")
    End Sub
    Private Function ValidateBoxs() As Boolean
        If TxtBCode.Text.Length = 0 Then
            Return False
        ElseIf TxtBName.Text.Length = 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub LoadTable()
        Dim panel As GridPanel = GridCargos.PrimaryGrid
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1
        CmdViewCargos(panel)
        panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
    End Sub

    Private Sub GetData()
        If Me.ValidateBoxs() Then
            DataCargo = New Cargo
            DataCargo.Code = TxtBCode.Text
            DataCargo.Name = TxtBName.Text
            If CmdInsertCargo(DataCargo) Then
                MsgBox("Datos de Cargo Guardados Satisfactoriamente", MsgBoxStyle.Information)
                LoadNextCode()
            Else
                MeErrorMessageDialog.ErrorMessage("Error-C02")
            End If
        Else
            MeErrorMessageDialog.ErrorMessage("Error-C01")
        End If
    End Sub

    Private Function QuestionDelete(ByVal Entidad As String) As Boolean
        Dim Question As Int16
        Question = MsgBox("¿Desea Eliminar a la Entidad '" + Entidad + "' ?", MsgBoxStyle.YesNo)
        If Question = MsgBoxResult.Yes Then
            Return True
        End If
        Return False
    End Function

    Private Sub GetSelectCargo()
        If GridCargos.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Cargo", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridCargos.GetSelectedRows(0)
            DataCargo = New Cargo
            DataCargo.Code = Grida.Cells(0).Value.ToString
            DataCargo.Name = Grida.Cells(1).Value.ToString
            If QuestionDelete(DataCargo.Name) Then
                If CmdDeleteCargo(DataCargo) Then
                    MsgBox("Datos de Turno Eliminado Satisfactoriamente", MsgBoxStyle.Information)
                Else
                    MeErrorMessageDialog.ErrorMessage("Error-T03")
                End If
            End If
        End If
    End Sub

    Private Sub BtnInsertCargo_Click(sender As Object, e As EventArgs) Handles BtnInsertCargo.Click
        GetData()
        LoadTable()
    End Sub

    Private Sub BtnDeleteCargo_Click(sender As Object, e As EventArgs) Handles BtnDeleteCargo.Click
        GetSelectCargo()
        LoadTable()
    End Sub

    Private Sub BtnUpdateCargo_Click(sender As Object, e As EventArgs) Handles BtnUpdateCargo.Click
        CallUpdateCarg()
        LoadTable()
    End Sub


    Private Sub CallUpdateCarg()
        If GridCargos.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Cargo", MsgBoxStyle.Information)
        Else
            Dim WindowsUpdateCarg As New UpdateCargo
            Dim Grida As GridRow = GridCargos.GetSelectedRows(0)
            DataCargo = New Cargo
            DataCargo.Code = Grida.Cells(0).Value.ToString
            DataCargo.Name = Grida.Cells(1).Value.ToString
            WindowsUpdateCarg.DataUpdateCargo.Code = DataCargo.Code
            WindowsUpdateCarg.DataUpdateCargo.Name = DataCargo.Name
            WindowsUpdateCarg.ShowDialog()
        End If
    End Sub


End Class