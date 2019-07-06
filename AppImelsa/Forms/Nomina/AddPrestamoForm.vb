Imports DevComponents.DotNetBar.SuperGrid

Public Class AddPrestamoForm
    Dim DataPrestamo As New Prestamo
    Private Sub AddPrestamoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployed()
    End Sub
    Public Sub LoadEmployed()
        Dim panel As GridPanel = GLoadEmployed.PrimaryGrid
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1
        CmdLoadEmployed(panel)
        panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
    End Sub
    Private Function ValidateBoxs() As Boolean
        If TxtBCode.Text.Length = 0 Then
            Return False
        ElseIf TxtBMonto.Text.Length = 0 Then
            Return False
        ElseIf TxtBCuota.Text.Length = 0 Then
            Return False
        End If
        Return True
    End Function
    Private Function LegalData() As Boolean
        If TxtBMonto.Text <= 0 Then
            MsgBox("Se ha detectado el campo Monto como no Valido", MsgBoxStyle.Exclamation)
            Return False
        ElseIf TxtBCuota.Text <= 0 Then
            MsgBox("Se ha detectado el campo Cuota como no Valido", MsgBoxStyle.Exclamation)
            Return False
        End If
        Return True
    End Function
    Private Sub GetData()
        If GLoadEmployed.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Prestamo", MsgBoxStyle.Information)
        Else
            If ValidateBoxs() Then
                If LegalData() = True Then
                    Dim Grida As GridRow = GLoadEmployed.GetSelectedRows(0)
                    DataPrestamo.Code = TxtBCode.Text
                    DataPrestamo.DatePres = DateInput.Value.ToString("yyyyMMMdd")
                    DataPrestamo.Monto = TxtBMonto.Text
                    DataPrestamo.Cuota = TxtBCuota.Text
                    DataPrestamo.Saldo = TxtBMonto.Text
                    DataPrestamo.Employed = Grida.Cells(0).Value.ToString
                    If CmdInsertPrestamo(DataPrestamo) Then
                        ProgressOne.Value = 100
                        MsgBox("Prestamo Insertado Satisfactoriamente", MsgBoxStyle.Information)
                        Me.Close()
                    Else
                        MsgBox("Error, no se ingreso proyecto", MsgBoxStyle.Exclamation)
                    End If
                End If
            Else
                MsgBox("Para Continuar debe rellenar campos vacios", MsgBoxStyle.Information)
            End If
        End If
    End Sub
    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click
        GetData()
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub


End Class