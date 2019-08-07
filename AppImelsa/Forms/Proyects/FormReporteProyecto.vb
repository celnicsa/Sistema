Imports CrystalDecisions.Shared

Public Class FormReporteProyecto

    Dim Info As New ReporteForm
    Dim Param As New ParameterValues
    Dim MyDiscretValues As New ParameterDiscreteValue
    Private Sub BTN1_Click(sender As Object, e As EventArgs) Handles BTN1.Click

        If DateTime.Compare(DataEnd.Value, DataInt.Value) < 0 Then

            MsgBox("Fecha Invalida, no cumple con el rango", MsgBoxStyle.Exclamation)
        Else
            GenerarReport()

        End If

    End Sub

    Public Sub GenerarReport()
        Param.Clear()
        MyDiscretValues.Value = DataInt.Value.ToString("yyyy-MM-dd")
        Param.Add(MyDiscretValues)
        Info.DataDefinition.ParameterFields("@DateInit").ApplyCurrentValues(Param)

        Param.Clear()
        MyDiscretValues.Value = DataEnd.Value.ToString("yyyy-MM-dd")
        Param.Add(MyDiscretValues)
        Info.DataDefinition.ParameterFields("@DateEnd").ApplyCurrentValues(Param)

        CrystalReportViewer1.ReportSource = Info
    End Sub

End Class