Imports DevComponents.DotNetBar.SuperGrid

Public Class AbonoForm
    Public Code_Prestamo As String
    Private DataAbono As New Abono
    Private DataPrestamo As New Prestamo
    Private Sub AbonoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitInterface()
        LoadTable()
    End Sub
    Private Sub InitInterface()
        If Code_Prestamo.Length > 0 Then
            DataPrestamo.Code = Code_Prestamo
            If CmdDetailsPrestamo(DataPrestamo) Then
                LabelCode.Text = DataPrestamo.Code
                LabelEmployed.Text = DataPrestamo.Employed
                LabelMonto.Text = DataPrestamo.Monto
                LabelSaldo.Text = DataPrestamo.Saldo
            End If
        Else
            LabelCode.Text = "-1"
            LabelEmployed.Text = "-1"
            LabelMonto.Text = "-1"
            LabelSaldo.Text = "-1"
        End If
    End Sub
    Private Sub LoadTable()
        Dim panel As GridPanel = GridAbono.PrimaryGrid
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1
        CmdViewAbono(panel, Code_Prestamo)
        panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
    End Sub

    Private Sub BtnAddAbono_Click(sender As Object, e As EventArgs) Handles BtnAddAbono.Click
        Dim WindowsAddAbono As New AddAbono
        WindowsAddAbono.Code_Prestamo = LabelCode.Text
        WindowsAddAbono.ShowDialog()
        LoadTable()
        InitInterface()
    End Sub
    Private Function QuestionDelete(ByVal Entidad As String) As Boolean
        Dim Question As Int16
        Question = MsgBox("¿Desea Eliminar a la Entidad '" + Entidad + "' ?", MsgBoxStyle.YesNo)
        If Question = MsgBoxResult.Yes Then
            Return True
        End If
        Return False
    End Function
    Private Sub GetSelectedAbono()
        If GridAbono.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Abono", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridAbono.GetSelectedRows(0)
            DataAbono = New Abono
            DataAbono.Code = Grida.Cells(0).Value.ToString
            If QuestionDelete(DataAbono.Code) Then
                If CmdDeleteAbono(DataAbono) Then
                    MsgBox("Abono Revertido Satisfactoriamente", MsgBoxStyle.Information)
                Else
                    MeErrorMessageDialog.ErrorMessage("Error-E03")
                End If
            End If
        End If
    End Sub
    Private Sub BtnDeleteAbono_Click(sender As Object, e As EventArgs) Handles BtnDeleteAbono.Click
        GetSelectedAbono()
        LoadTable()
        InitInterface()
    End Sub
    Private Sub BtnUpdateAbono_Click(sender As Object, e As EventArgs) Handles BtnUpdateAbono.Click
        If GridAbono.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Abono", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridAbono.GetSelectedRows(0)
            Dim WindowsUpdateAbono As New UpdateAbonoForm
            WindowsUpdateAbono.Code_Abono = Grida.Cells(0).Value.ToString
            WindowsUpdateAbono.ShowDialog()
        End If
        LoadTable()
    End Sub
End Class