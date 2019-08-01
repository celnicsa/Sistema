Public Class UpdateSalario
    Public DataUpdateSalario As New Salario
    Private Sub UpdateSalario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtBMonthly.Text = DataUpdateSalario.SMensual
    End Sub

    Private Function ValidateBoxs() As Boolean
        If TxtBMonthly.Text.Length = 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub GetData()
        If Me.ValidateBoxs() Then
            DataUpdateSalario.SMensual = TxtBMonthly.Text
            If CmdUpdateSalario(DataUpdateSalario) Then
                MsgBox("Datos de Salario Actualizados Satisfactoriamente", MsgBoxStyle.Information)
            Else
                MeErrorMessageDialog.ErrorMessage("Error-S04")
            End If
        Else
            MeErrorMessageDialog.ErrorMessage("Error-S01")
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        GetData()
        Me.Close()
    End Sub
End Class