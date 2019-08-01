Imports CrystalDecisions.Shared

Public Class NominaForm
    Dim Info As New CrystalReportNomina
    Dim Param As New ParameterValues
    Dim MyDiscretValues As New ParameterDiscreteValue
    Public Code_Prestamo As String
    Private DataAbono As New Abono
    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click
        If TxtBCode.Text.Length = 0 Then
            MsgBox("Horas Extras no validad", MsgBoxStyle.Exclamation)
        Else
            GenerarReport()
        End If
    End Sub
    Public Sub GenerarReport()
        Param.Clear()
        MyDiscretValues.Value = TxtBCode.Text
        Param.Add(MyDiscretValues)
        Info.DataDefinition.ParameterFields("@HorasExtras").ApplyCurrentValues(Param)

        CrystalReportViewer1.ReportSource = Info
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class