Public Class AddProyectForm
    Private DataProyect As New Proyect
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
        ElseIf CmBClient.SelectedIndex = -1
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
                If CmdInsertProyect(DataProyect) Then
                    ProgressOne.Value = 100
                    MsgBox("Proyecto Insertado Satisfactoriament")
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

    Private Sub PageSliderPage1_Paint(sender As Object, e As PaintEventArgs) Handles PageSliderPage1.Paint

    End Sub
End Class