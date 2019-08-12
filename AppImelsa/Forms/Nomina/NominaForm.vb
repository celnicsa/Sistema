Imports CrystalDecisions.Shared
Imports DevComponents.DotNetBar.SuperGrid
Public Class NominaForm
    'Dim Info As New CrystalReportNomina'
    Dim Param As New ParameterValues
    Dim MyDiscretValues As New ParameterDiscreteValue
    Public Code_Prestamo As String
    Private DataAbono As New Abono
    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click
        If TxtBCode.Text.Length = 0 Then
            MsgBox("Horas Extras no validad", MsgBoxStyle.Exclamation)
        Else
            ' GenerarReport()
        End If
    End Sub
    '   Public Sub GenerarReport()
    '     Param.Clear()
    '     MyDiscretValues.Value = TxtBCode.Text
    '    Param.Add(MyDiscretValues)
    '    Info.DataDefinition.ParameterFields("@HorasExtras").ApplyCurrentValues(Param)

    '   CrystalReportViewer1.ReportSource = Info
    '   End Sub'
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub NominaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
        CmBCargo.Text = "Enero"
        TextBoxX2.Text = DateTime.Now.Year.ToString()
    End Sub

    Private Sub LoadTable()
        Dim panel As GridPanel = GridEmployed.PrimaryGrid
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1
        CmdViewNomina(panel)
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        If (TxtBSearch.Text <> "") Then
            Dim panel As GridPanel = GridEmployed.PrimaryGrid
            panel.RowHeaderWidth = 50
            panel.RowHeaderIndexOffset = 1
            CmdViewNominaFiltroID(panel, TxtBSearch.Text)
        Else
            MessageBox.Show("Debe escribir un texto para filtrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        If (TextBoxX2.Text <> "") Then
            Dim panel As GridPanel = GridEmployed.PrimaryGrid
            panel.RowHeaderWidth = 50
            panel.RowHeaderIndexOffset = 1
            CmdViewNominaFiltroMesAño(panel, TextBoxX2.Text, CmBCargo.Text)
        Else
            MessageBox.Show("Debe escribir un a�o para realizar el filtro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        LoadTable()
    End Sub

    Private Sub BtnDeleteEmployed_Click(sender As Object, e As EventArgs) Handles BtnDeleteEmployed.Click
        Dim A = GridEmployed.GetSelectedRows()
        If (GridEmployed.GetSelectedRows().Count > 0) Then
            Dim Resultado As Integer = MessageBox.Show("�Seguro que desea borrar esta nomina?", "Cuidado", MessageBoxButtons.YesNoCancel)
            If Resultado = DialogResult.Yes Then
                CmdDeleteNomina(GridEmployed.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(0).Value())
                LoadTable()
                MessageBox.Show("La nomina fue borrada con exito")
            End If
        Else
            MessageBox.Show("Debe seleccionar una fila de la tabla para eliminar dicha nomina.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub CmBCargo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmBCargo.KeyPress
        e.Handled = True
    End Sub


End Class