Public Class UpdateAbonoForm
    Public Code_Abono As String
    Private DataAbono As New Abono
    Private Sub UpdateAbonoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataAbono.Code = Code_Abono
        LabelCode.Text = DataAbono.Code
    End Sub

    Public Function ValidateBoxs() As Boolean
        If LabelCode.Text.Length = 0 Then
            Return False
        ElseIf TxtBAbono.Text.Length = 0
            Return False
        End If
        Return True
    End Function

    Public Function LegalData() As Boolean
        If TxtBAbono.Value <= 0 Then
            MsgBox("Se ha detectado el monto del Abono como no Valido", MsgBoxStyle.Exclamation)
            Return False
        End If
        Return True
    End Function

    Public Sub GetData()
        If ValidateBoxs() Then
            If LegalData() Then
                DataAbono.Code = LabelCode.Text
                DataAbono.Abono = TxtBAbono.Value
                If CmdUpdateAbono(DataAbono) Then
                    MsgBox("Datos de Abono Actualizados Satisfactoriamente", MsgBoxStyle.Information)
                Else
                    MeErrorMessageDialog.ErrorMessage("Error-C04")
                End If
            End If
        Else
            MsgBox("Error Rellene los campos Vacios...", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click
        GetData()
        Me.Close()
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class