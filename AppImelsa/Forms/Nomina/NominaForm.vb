
Imports Excel = Microsoft.Office.Interop.Excel
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

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        If (GridEmployed.GetSelectedRows().Count > 0) Then
            Try
                Me.Cursor = Cursors.WaitCursor
                Dim appXL As Excel.Application
                Dim wbXl As Excel.Workbook
                Dim shXL As Excel.Worksheet
                Dim indice As Integer = 2
                appXL = CreateObject("Excel.Application")
                appXL.Visible = False
                wbXl = appXL.Workbooks.Add
                shXL = wbXl.ActiveSheet
                Dim formatRange As Excel.Range
                formatRange = shXL.Range("a1")
                formatRange.EntireRow.Font.Bold = True
                shXL.Cells(2, 2).Value = "ID de nomina:"
                shXL.Cells(2, 2).Font.Bold = True
                shXL.Cells(4, 2).Value = "Fecha de generacion:"
                shXL.Cells(4, 2).Font.Bold = True
                shXL.Cells(5, 2).Value = "Año:"
                shXL.Cells(5, 2).Font.Bold = True
                shXL.Cells(6, 2).Value = "Mes:"
                shXL.Cells(6, 2).Font.Bold = True
                shXL.Cells(4, 5).Value = "Gastos en bruto:"
                shXL.Cells(4, 5).Font.Bold = True
                shXL.Cells(5, 5).Value = "Gastos en deducciones:"
                shXL.Cells(5, 5).Font.Bold = True
                shXL.Cells(6, 5).Value = "Generado por:"
                shXL.Cells(6, 5).Font.Bold = True

                shXL.Cells(2, 3).Value = GridEmployed.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(0).Value()
                shXL.Cells(4, 3).Value = GridEmployed.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(3).Value()
                shXL.Cells(5, 3).Value = GridEmployed.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(1).Value()
                shXL.Cells(6, 3).Value = GridEmployed.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(2).Value()
                shXL.Cells(4, 6).Value = GridEmployed.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(4).Value()
                shXL.Cells(5, 6).Value = GridEmployed.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(5).Value()
                shXL.Cells(6, 6).Value = GridEmployed.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(6).Value()

                shXL.Columns("B:B").ColumnWidth = 30
                shXL.Columns("C:C").ColumnWidth = 30
                shXL.Columns("E:E").ColumnWidth = 30
                shXL.Columns("F:F").ColumnWidth = 35
                shXL.Columns("D:D").ColumnWidth = 20
                shXL.Columns("B").Cells.HorizontalAlignment = -4108
                shXL.Columns("D").Cells.HorizontalAlignment = -4108
                shXL.Columns("C").Cells.HorizontalAlignment = -4108
                shXL.Columns("E").Cells.HorizontalAlignment = -4108
                shXL.Columns("F").Cells.HorizontalAlignment = -4108
                shXL.Columns("G").Cells.HorizontalAlignment = -4108

                shXL.Cells(8, 2).Value = "ID empleado:"
                shXL.Cells(8, 2).Font.Bold = True
                shXL.Cells(8, 3).Value = "Nombre Completo:"
                shXL.Cells(8, 3).Font.Bold = True
                shXL.Cells(8, 4).Value = "Salario Bruto:"
                shXL.Cells(8, 4).Font.Bold = True
                shXL.Cells(8, 5).Value = "Deducciones INSS:"
                shXL.Cells(8, 5).Font.Bold = True
                shXL.Cells(8, 6).Value = "Deducciones IR:"
                shXL.Cells(8, 6).Font.Bold = True
                shXL.Cells(8, 7).Value = "Salario Neto:"
                shXL.Cells(8, 7).Font.Bold = True

                Dim Detalle = CMDVIEWNOMINDETALLEEXCEL(GridEmployed.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(0).Value())

                Dim FilaID As Integer = 9
                For Each Row As DataRow In Detalle.Rows
                    shXL.Cells(FilaID, 2).Value = Row("ID Empleado").ToString()
                    shXL.Cells(FilaID, 3).Value = Row("Nombre Completo").ToString()
                    shXL.Cells(FilaID, 4).Value = Row("Salario Bruto").ToString()
                    shXL.Cells(FilaID, 5).Value = Row("Deducciones de INSS").ToString()
                    shXL.Cells(FilaID, 6).Value = Row("IR").ToString()
                    shXL.Cells(FilaID, 7).Value = Row("Total_Neto").ToString()
                    FilaID = FilaID + 1
                Next


                Dim saveFileDialog1 As New SaveFileDialog()
                saveFileDialog1.Title = "Guardar documento Excel"
                saveFileDialog1.Filter = "Excel File|*.xlsx"
                saveFileDialog1.FileName = GridEmployed.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(0).Value()
                saveFileDialog1.ShowDialog()

                wbXl.SaveAs(saveFileDialog1.FileName)
                appXL.Workbooks.Close()
                appXL.Quit()
                MsgBox("Se genero con exito el reporte.")
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        Else
            MessageBox.Show("Debe seleccionar una fila de la tabla para ver dicho reporte.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
