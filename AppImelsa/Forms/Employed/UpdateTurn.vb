Public Class UpdateTurn
    Public DataUpdateTurno As New Turno
    Private Sub UpdateTurn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TxtBName.Text = DataUpdateTurno.Name
        Me.TxtBHStart.Text = DataUpdateTurno.HsStart
        Me.TxtBHEnd.Text = DataUpdateTurno.HsEnd
        Me.TxtBName.Focus()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Private Function ValidateBoxs() As Boolean
        If TxtBName.Text.Length = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub GetData()
        If Me.ValidateBoxs() Then
            DataUpdateTurno.Name = TxtBName.Text
            DataUpdateTurno.HsStart = TxtBHStart.Text
            DataUpdateTurno.HsEnd = TxtBHEnd.Text
            If CmdUpdateTurno(DataUpdateTurno) Then
                MsgBox("Datos de Turno Actualizados Satisfactoriamente", MsgBoxStyle.Information)
            Else
                MeErrorMessageDialog.ErrorMessage("Error-T04")
            End If
        Else
            MeErrorMessageDialog.ErrorMessage("Error-T01")
        End If
    End Sub

    Private Sub BtnUpdateTurno_Click(sender As Object, e As EventArgs) Handles BtnUpdateTurno.Click
        GetData()
        Me.Close()
    End Sub

    Private Sub BtnCaptureEntrace_Click(sender As Object, e As EventArgs) Handles BtnCaptureEntrace.Click
        TxtBHStart.Text = TimeSelectHour.SelectedTime.ToString
    End Sub

    Private Sub BtnCaptureEnd_Click(sender As Object, e As EventArgs) Handles BtnCaptureEnd.Click
        TxtBHEnd.Text = TimeSelectHour.SelectedTime.ToString
    End Sub
End Class