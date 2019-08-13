Public Class AddProyectForm
    Private DataProyect As New Proyect
    Public nota As String
    Private Sub AddProyectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmdLoadClient(CmBClient)
        ProgressOne.Value = 50
        LoadNextCode()
    End Sub

    Private Sub LoadNextCode()
        TxtBCode.Text = CmdNextCode("SPNextCodeProyect")
    End Sub

    Private Function ValidateBoxs() As Boolean
        If TxtBCode.Text.Length = 0 Then
            Return False
        ElseIf TxtBName.Text.Length = 0 Then
            Return False
        ElseIf TxtBUbicacion.Text.Length = 0 Then
            Return False
        ElseIf TxtBPresupuesto.Text.Length = 0 Then
            Return False
        ElseIf CmBClient.SelectedIndex = -1 Then
            Return False
        End If
        Return True
    End Function

    Private Function LegalData() As Boolean
        If DateTime.Compare(DateInputEnd.Value, DateInputInit.Value) < 0 Then
            MsgBox("Se han Detectado la Fecha de Culminacion de proyecto como invalida, la fecha de culminacion no puede ser antes de la fecha de inicio", MsgBoxStyle.Exclamation)
        End If
        Return True
    End Function
    Private Function Getlista1() As Int16
        nota = LisCob.Text
        If nota = "Sin Definir" Then
            Return 6
        ElseIf nota = "Electricidad" Then
            Return 1
        ElseIf nota = "Construccion" Then
            Return 2
        ElseIf nota = "Instalacion" Then
            Return 3
        ElseIf nota = "Transformadores" Then
            Return 4
        ElseIf nota = "Capacitacion" Then
            Return 5
        Else
            Return 6
        End If
    End Function
    Private Sub GetData()
        If ValidateBoxs() Then
            If LegalData() = True Then
                DataProyect.Code = TxtBCode.Text
                DataProyect.Name = TxtBName.Text
                DataProyect.Presupuesto = TxtBPresupuesto.Text
                DataProyect.Ubicacion = TxtBUbicacion.Text
                DataProyect.Descripcion = TxtBDesc.Text
                DataProyect.DateStar = DateInputInit.Value.ToString("yyyyMMMdd")
                DataProyect.DateEnd = DateInputEnd.Value.ToString("yyyyMMMdd")
                DataProyect.Cliente = CmBClient.SelectedItem.ToString
                DataProyect.Estado = 0
                DataProyect.Observacion = TxtObservacion.Text
                DataProyect.Tipo = Getlista1()

                If CmdInsertProyect(DataProyect) Then
                    ProgressOne.Value = 100
                    MsgBox("Proyecto Insertado Satisfactoriamente " + nota)

                Else
                    MsgBox("Error, no se ingreso proyecto")
                End If
            End If
        Else
            MsgBox("Para Continuar debe rellenar campos vacios", MsgBoxStyle.Information)
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