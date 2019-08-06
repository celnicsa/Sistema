Imports CrystalDecisions.Shared
Public Class ReporteProyectoForm
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

    End Sub

End Class