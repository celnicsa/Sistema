
Imports CrystalDecisions.Shared
Imports DevComponents.DotNetBar.SuperGrid
Public Class NominaForm
    Private Sub BtnNewEmployed_Click(sender As Object, e As EventArgs) Handles BtnNewEmployed.Click
        Dim ND As New NominaDetalleForm
        ND.Tipo_Operacion = "Nueva"
        ND.ShowDialog()
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
            MessageBox.Show("Debe escribir un año para realizar el filtro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        LoadTable()
    End Sub

    Private Sub BtnDeleteEmployed_Click(sender As Object, e As EventArgs) Handles BtnDeleteEmployed.Click
        If (GridEmployed.GetSelectedRows().Count > 0) Then
            Dim Resultado As Integer = MessageBox.Show("¿Seguro que desea borrar esta nomina?", "Cuidado", MessageBoxButtons.YesNoCancel)
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

    Private Sub BtnUpdateEmployed_Click(sender As Object, e As EventArgs) Handles BtnUpdateEmployed.Click
        If (GridEmployed.GetSelectedRows().Count > 0) Then
            Dim ND As New NominaDetalleForm
            ND.Tipo_Operacion = "Leer"
            ND.ID_Nomina = GridEmployed.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(0).Value()
            ND.Bruto_Total = GridEmployed.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(4).Value()
            ND.Deducciones_Total = GridEmployed.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(5).Value()
            ND.Fecha = GridEmployed.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(3).Value()
            ND.Usuario = GridEmployed.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(6).Value()
            ND.Año = GridEmployed.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(1).Value()
            ND.Mes = GridEmployed.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(2).Value()
            ND.ShowDialog()
        Else
            MessageBox.Show("Debe seleccionar una fila de la tabla para ver dicha nomina.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class