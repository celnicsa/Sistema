Imports CrystalDecisions.Shared

Public Class ReporteUnicoForm

    Dim Info As New ReporteForm
    Public Code As String
    Public Detalles As String
    Public Codigo As String
    Dim DataProyect As New Proyect
    Dim Param As New ParameterValues
    Dim MyDiscretValues As New ParameterDiscreteValue
    Private Sub OneProyectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataProyect.Code = Code
        CmdDetaillsProyect(DataProyect)
        LoadData()
    End Sub
    Public Sub LoadData()
        Codigo = DataProyect.Code
        Detalles = (" " + Code + " - " + DataProyect.Name + " - " + DataProyect.Cliente + " ")
        lbDatos.Text = Detalles
    End Sub

    Public Sub GenerarReport()
        Param.Clear()
        MyDiscretValues.Value = Codigo
        Param.Add(MyDiscretValues)
        Info.DataDefinition.ParameterFields("@code").ApplyCurrentValues(Param)

        CrystalReportViewer1.ReportSource = Info
    End Sub

End Class