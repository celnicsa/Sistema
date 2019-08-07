Imports CrystalDecisions.Shared

Public Class AddAbono
    'Dim Info As New CrystalReport1
    Dim Param As New ParameterValues
    Dim MyDiscretValues As New ParameterDiscreteValue
    Public Code_Prestamo As String
    Private DataAbono As New Abono

    Private Sub AddAbono_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadNextCode()
    End Sub

    Public Function ValidateBoxs() As Boolean
        If TxtBCode.Text.Length = 0 Then
            Return False
        ElseIf TxtBAbono.Text.Length = 0 Then
            Return False
        End If
        Return True
    End Function

    Public Function LegalData() As Boolean
        If TxtBAbono.Value <= 0 Then
            MsgBox("Se ha detectado la cantidad a abonar como invalida...", MsgBoxStyle.Exclamation)
            Return False
        ElseIf DateTime.Compare(DateInput.Value.ToShortDateString, DateTime.Now().ToShortDateString()) > 0
            MsgBox("La Fecha de Abono se ha detectado como no valida...", MsgBoxStyle.Exclamation)
            Return False
        End If
        Return True
    End Function

    Private Sub GetData()
        If ValidateBoxs() Then
            If LegalData() = True Then
                DataAbono.Code = TxtBCode.Text
                DataAbono.Date_Abono = DateInput.Value.ToString("yyyyMMMdd")
                DataAbono.Abono = TxtBAbono.Text
                DataAbono.Prestamo = Code_Prestamo
                If CmdInsertAbono(DataAbono) Then
                    MsgBox("Abono Insertado Satisfactoriament", MsgBoxStyle.Information)
                    'GenerarReport()
                Else
                    MsgBox("Error, no se ingreso Abono", MsgBoxStyle.Exclamation)
                End If
            End If
        Else
            MsgBox("Para Continuar debe rellenar campos vacios", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Public Sub LoadNextCode()
        TxtBCode.Text = CmdNextCode("SPNextCodeAbono")
    End Sub
    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click
        GetData()

        'Me.Close()
    End Sub
    ' Public Sub GenerarReport()
    '    Param.Clear()
    '    MyDiscretValues.Value = TxtBCode.Text
    '   Param.Add(MyDiscretValues)
    '    Info.DataDefinition.ParameterFields("@Code").ApplyCurrentValues(Param)

    '    CrystalReportViewer1.ReportSource = Info
    ' End Sub

    Private Sub PanelEx2_Click(sender As Object, e As EventArgs) Handles PanelEx2.Click

    End Sub

    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class