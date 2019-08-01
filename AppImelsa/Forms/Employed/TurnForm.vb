Imports DevComponents.DotNetBar.SuperGrid

Public Class TurnForm
    Private DataTurno As New Turno
    Private Sub TurnForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
        LoadNextCode()
    End Sub
    Private Sub LoadNextCode()
        TxtBCode.Text = CmdNextCode("SpNextCodeTurn")
    End Sub
    Private Function ValidateBoxs() As Boolean
        If TxtBCode.Text.Length = 0 Then
            Return False
        ElseIf TxtBName.Text.Length = 0 Then
            Return False
        ElseIf TxtBHStar.Text.Length = 0 Then
            Return False
        ElseIf TxtBHEnd.Text.Length = 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub GetData()
        If Me.ValidateBoxs() Then
            DataTurno = New Turno
            DataTurno.Code = TxtBCode.Text
            DataTurno.Name = TxtBName.Text
            DataTurno.HsStart = TxtBHStar.Text
            DataTurno.HsEnd = TxtBHEnd.Text
            If CmdInsertTurno(DataTurno) Then
                MsgBox("Datos de Turno Guardados Satisfactoriamente", MsgBoxStyle.Information)
                LoadNextCode()
            Else
                MeErrorMessageDialog.ErrorMessage("Error-T02")
            End If
        Else
            MeErrorMessageDialog.ErrorMessage("Error-T01")
        End If
    End Sub
    Private Sub LoadTable()
        Dim panel As GridPanel = GridCargos.PrimaryGrid
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1
        CmdViewTurnos(panel)
        panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
    End Sub
    Private Sub BtnInsertTurno_Click(sender As Object, e As EventArgs) Handles BtnInsertTurno.Click
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
        If GridCargos.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Turno", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridCargos.GetSelectedRows(0)
            DataTurno = New Turno
            DataTurno.Code = Grida.Cells(0).Value.ToString
            DataTurno.Name = Grida.Cells(1).Value.ToString
            If QuestionDelete(DataTurno.Name) Then
                If CmdDeleteTurno(DataTurno) Then
                    MsgBox("Datos de Turno Eliminado Satisfactoriamente", MsgBoxStyle.Information)
                Else
                    MeErrorMessageDialog.ErrorMessage("Error-T03")
                End If
            End If
        End If
    End Sub

    Private Sub BtnDeleteTurno_Click(sender As Object, e As EventArgs) Handles BtnDeleteTurno.Click
        GetSelectTurno()
        LoadTable()
    End Sub

    Private Sub CallUpdateTurno()
        If GridCargos.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Turno", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridCargos.GetSelectedRows(0)
            Dim WindowsUpdateTurn As New UpdateTurn
            DataTurno = New Turno
            DataTurno.Code = Grida.Cells(0).Value.ToString
            DataTurno.Name = Grida.Cells(1).Value.ToString
            DataTurno.HsStart = Grida.Cells(2).Value.ToString
            DataTurno.HsEnd = Grida.Cells(3).Value.ToString
            WindowsUpdateTurn.DataUpdateTurno.Code = DataTurno.Code
            WindowsUpdateTurn.DataUpdateTurno.Name = DataTurno.Name
            WindowsUpdateTurn.DataUpdateTurno.HsStart = DataTurno.HsStart
            WindowsUpdateTurn.DataUpdateTurno.HsEnd = DataTurno.HsEnd
            WindowsUpdateTurn.ShowDialog()
        End If
    End Sub

    Private Sub BtnUpdateTurno_Click(sender As Object, e As EventArgs) Handles BtnUpdateTurno.Click
        CallUpdateTurno()
        LoadTable()
    End Sub

    Private Sub BtnCaptureEntrace_Click(sender As Object, e As EventArgs) Handles BtnCaptureEntrace.Click
        TxtBHStar.Text = TimeSelectHour.SelectedTime.ToString
    End Sub

    Private Sub BtnCaptureEnd_Click(sender As Object, e As EventArgs) Handles BtnCaptureEnd.Click
        TxtBHEnd.Text = TimeSelectHour.SelectedTime.ToString
    End Sub

End Class