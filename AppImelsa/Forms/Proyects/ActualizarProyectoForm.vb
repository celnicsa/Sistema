Public Class ActualizarProyectoForm
    Public Code As String
    Dim DataProyect As New Proyect
    Dim Input As New ValidateInput
    Private Sub OneProyectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataProyect.Code = Code
        CmdDetaillsProyect(DataProyect)
        LoadData()
    End Sub
    Public Sub LoadData()
        TxtBCode.Text = DataProyect.Code
        TxtBName.Text = DataProyect.Name
        TxtBPresupuesto.Value = DataProyect.Presupuesto
        TxtBDesc.Text = DataProyect.Descripcion
        TxtBAddres.Text = DataProyect.Ubicacion
        TxtBClient.Text = DataProyect.Cliente
        DateInputInit.Value = DataProyect.DateStar
        DateInputEnd.Value = DataProyect.DateEnd
        CheckedState()
    End Sub
    Public Sub CheckedState()
        If DataProyect.Estado = 0 Then
            ChBState.Checked = True
        Else
            ChBState.Checked = False
        End If
    End Sub
    Private Function ValidateBoxs() As Boolean
        If TxtBCode.Text.Length = 0 Then
            Return False
        ElseIf TxtBName.Text.Length = 0 Then
            Return False
        ElseIf TxtBAddres.Text.Length = 0 Then
            Return False
        ElseIf TxtBPresupuesto.Text.Length = 0 Then
            Return False
        End If
        Return True
    End Function

    Private Function LegalData() As Boolean
        If DateTime.Compare(DateInputEnd.Value, DateInputInit.Value) <= 0 Then
            MsgBox("Se han Detectado la Fecha de Culminacion de proyecto como invalida, la fecha de culminacion no puede ser antes de la fecha de inicio", MsgBoxStyle.Exclamation)
        End If
        Return True
    End Function
    Private Function GetState() As Int16
        If ChBState.Checked Then
            Return 0
        Else
            Return 1
        End If
    End Function
    Private Sub GetData()
        If ValidateBoxs() Then
            If LegalData() = True Then
                DataProyect.Code = TxtBCode.Text
                DataProyect.Name = TxtBName.Text
                DataProyect.Presupuesto = TxtBPresupuesto.Text
                DataProyect.Ubicacion = TxtBAddres.Text
                DataProyect.Descripcion = TxtBDesc.Text
                DataProyect.DateStar = DateInputInit.Value.ToString("yyyyMMMdd")
                DataProyect.DateEnd = DateInputEnd.Value.ToString("yyyyMMMdd")
                DataProyect.Estado = GetState()
                If CmdUpdateProyect(DataProyect) Then
                    MsgBox("Proyecto Insertado Satisfactoriament")
                Else
                    MsgBox("Error, no se ingreso proyecto")
                End If
            End If
        Else
            MsgBox("Para Continuar debe rellenar campos vacios", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        GetData()
        Me.Close()
    End Sub

    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click
        Me.Close()
    End Sub

    Private Sub TxtBCode_Click(sender As Object, e As EventArgs) Handles TxtBCode.Click

    End Sub
End Class