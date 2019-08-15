Imports CrystalDecisions.Shared
Public Class ReportProyectForm
    Dim Info As New CrystalReportReporteLista
    Dim Param As New ParameterValues
    Dim MyDiscretValues As New ParameterDiscreteValue
    Private Sub BtnGenerarReport_Click(sender As Object, e As EventArgs) Handles BtnGenerarReport.Click
        If DateTime.Compare(DateInputEnd.Value, DateInputInit.Value) < 0 Then
            MsgBox("Fecha Invalida, no cumple con el rango", MsgBoxStyle.Exclamation)
        Else
            GenerarReport()
        End If
    End Sub

    Public Sub GenerarReport()
        Param.Clear()
        MyDiscretValues.Value = DateInputInit.Value.ToString("yyyy-MM-dd")
        Param.Add(MyDiscretValues)
        Info.DataDefinition.ParameterFields("@DateInit").ApplyCurrentValues(Param)

        Param.Clear()
        MyDiscretValues.Value = DateInputEnd.Value.ToString("yyyy-MM-dd")
        Param.Add(MyDiscretValues)
        Info.DataDefinition.ParameterFields("@DateEnd").ApplyCurrentValues(Param)

        CrystalReportViewer1.ReportSource = Info
    End Sub

End Class