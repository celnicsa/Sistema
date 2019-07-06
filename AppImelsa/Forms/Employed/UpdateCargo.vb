Public Class UpdateCargo
    Public DataUpdateCargo As New Cargo
    Private Sub UpdateCargo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtBName.Text = DataUpdateCargo.Name
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
            DataUpdateCargo.Name = TxtBName.Text
            If CmdUpdateCarg(DataUpdateCargo) Then
                MsgBox("Datos de Cargo Actualizados Satisfactoriamente", MsgBoxStyle.Information)
            Else
                MeErrorMessageDialog.ErrorMessage("Error-C04")
            End If
        Else
            MeErrorMessageDialog.ErrorMessage("Error-C01")
        End If
    End Sub

    Private Sub BtnUpdateCargo_Click(sender As Object, e As EventArgs) Handles BtnUpdateCargo.Click
        GetData()
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub


End Class