Imports DevComponents.DotNetBar.SuperGrid
Imports Excel = Microsoft.Office.Interop.Excel
Public Class InventariadoForm
    Private DataArticulo As New Articulo
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim CategoriaForm As New CategoriaForms
        CategoriaForm.ShowDialog()
    End Sub

    Private Sub InventarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmdViewProyectosCombo(ComboBox1)
        ComboBox1.SelectedIndex = 0
        LoadTable()
    End Sub
    Private Sub LoadTable()
        Dim panel As GridPanel = GridArticulo.PrimaryGrid
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1
        CmdViewArticulo(panel)
        panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
    End Sub

    Private Sub BtnNewClient_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub BtnLoadTable_Click(sender As Object, e As EventArgs) Handles BtnLoadTable.Click
        GetSelectedArticulo()
    End Sub
    Private Function QuestionDelete(ByVal Entidad As String) As Boolean
        Dim Question As Int16
        Question = MsgBox("�Desea Eliminar a la Entidad '" + Entidad + "' ?", MsgBoxStyle.YesNo)
        If Question = MsgBoxResult.Yes Then
            Return True
        End If
        Return False
    End Function
    Private Sub GetSelectedArticulo()
        If GridArticulo.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Categoria", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridArticulo.GetSelectedRows(0)
            DataArticulo = New Articulo
            DataArticulo.Articulo = Grida.Cells(0).Value.ToString
            DataArticulo.Categoria = Grida.Cells(1).Value.ToString
            DataArticulo.Proyecto = Grida.Cells(2).Value.ToString
            If QuestionDelete(DataArticulo.Name) Then
                If CmdDeleteArticulo(DataArticulo) Then
                    MsgBox("Articulo Eliminado Satisfactoriamente", MsgBoxStyle.Information)
                Else
                    MeErrorMessageDialog.ErrorMessage("Error-CL03")
                End If
            End If
        End If
    End Sub

    Private Sub GetData()
        If Me.ValidateBoxs() Then
            DataArticulo = New Articulo
            DataArticulo.Articulo = TextCodeArt.Text
            DataArticulo.Categoria = TextCodeCat.Text
            DataArticulo.Proyecto = ComboBox1.Text.Split(" ")(0)
            DataArticulo.Name = TextName.Text
            DataArticulo.Descripcion = TextDesc.Text
            DataArticulo.Stock = TextStock.Text
            If CmdInsertArticulo(DataArticulo) Then
                MsgBox("Nuevo Articulo Guardado Satisfactoriamente", MsgBoxStyle.Information)
            Else
                MeErrorMessageDialog.ErrorMessage("Error-CL02")
            End If
        End If
    End Sub
    Private Function ValidateBoxs() As Boolean
        If TextCodeArt.Text.Length = 0 Then
            Return False
        ElseIf TextCodeCat.Text.Length = 0 Then
            Return False
        ElseIf TextName.Text.Length = 0 Then
            Return False
        ElseIf TextStock.Text.Length = 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Function QuestionUpdate(ByVal Entidad As String) As Boolean
        Dim Question As Int16
        Question = MsgBox("�Desea Modificarla Entidad a:'" + Entidad + "' ?", MsgBoxStyle.YesNo)
        If Question = MsgBoxResult.Yes Then
            Return True
        End If
        Return False
    End Function
    Private Sub GetSelectedUpdateArticulo()
        If GridArticulo.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Categoria", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridArticulo.GetSelectedRows(0)
            DataArticulo = New Articulo
            DataArticulo.Articulo = TextCodeArt.Text
            DataArticulo.Categoria = TextCodeCat.Text
            DataArticulo.Proyecto = ComboBox1.Text.Split(" ")(0)
            DataArticulo.Name = TextName.Text
            DataArticulo.Descripcion = TextDesc.Text
            DataArticulo.Stock = TextStock.Text
            If QuestionUpdate(DataArticulo.Name) Then
                If CmdUpdateArticulo(DataArticulo) Then
                    MsgBox("Datos de Articulo Modificado Satisfactoriamente", MsgBoxStyle.Information)
                Else
                    MeErrorMessageDialog.ErrorMessage("Error-CL03")
                End If
            End If
        End If
    End Sub


    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        LoadTable()
    End Sub

    Private Sub BtnInsertArticulo_Click(sender As Object, e As EventArgs) Handles BtnInsertArticulo.Click
        GetData()
        LoadTable()
    End Sub

    Private Sub GridArticulo_RowClick(sender As Object, e As GridRowClickEventArgs) Handles GridArticulo.RowClick
        Dim Grida As GridRow = GridArticulo.GetSelectedRows(0)
        TextCodeArt.Text = Grida.Cells(0).Value
        TextName.Text = Grida.Cells(1).Value
        TextDesc.Text = Grida.Cells(5).Value
        TextStock.Text = Grida.Cells(4).Value
    End Sub

    Private Sub ButtonX3_Click(sender As Object, e As EventArgs) Handles ButtonX3.Click
        GetSelectedUpdateArticulo()
        LoadTable()
    End Sub

    Private Sub BtnReportCaller_Click(sender As Object, e As EventArgs) Handles BtnReportCaller.Click
        If (GridArticulo.GetSelectedRows().Count > 0) Then
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
                shXL.Cells(2, 2).Value = "ID de Articulo"
                shXL.Cells(2, 2).Font.Bold = True
                shXL.Cells(4, 2).Value = " Nombre de Articulo"
                shXL.Cells(4, 2).Font.Bold = True
                shXL.Cells(5, 2).Value = "Nombre de Categoria"
                shXL.Cells(5, 2).Font.Bold = True
                shXL.Cells(6, 2).Value = "Descripcion"
                shXL.Cells(6, 2).Font.Bold = True
                shXL.Cells(4, 5).Value = "Nombre Proyecto"
                shXL.Cells(4, 5).Font.Bold = True
                shXL.Cells(5, 5).Value = "Stock"
                shXL.Cells(5, 5).Font.Bold = True
                shXL.Cells(6, 5).Value = "Codigo Proyecto"
                shXL.Cells(6, 5).Font.Bold = True

                shXL.Cells(2, 3).Value = GridArticulo.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(0).Value()
                shXL.Cells(5, 3).Value = GridArticulo.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(1).Value()
                shXL.Cells(6, 3).Value = GridArticulo.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(2).Value()
                shXL.Cells(4, 3).Value = GridArticulo.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(3).Value()
                shXL.Cells(4, 6).Value = GridArticulo.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(4).Value()
                shXL.Cells(5, 6).Value = GridArticulo.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(5).Value()
                shXL.Cells(5, 6).Value = GridArticulo.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(6).Value()

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


                Dim Detalle = CmdReportArticulo(GridArticulo.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(6).Value().ToString())

                Dim FilaID As Integer = 9
                For Each Row As DataRow In Detalle.Rows
                    shXL.Cells(FilaID, 2).Value = Row("CodigoArticulo").ToString()
                    shXL.Cells(FilaID, 3).Value = Row("Articulo").ToString()
                    shXL.Cells(FilaID, 4).Value = Row("Categoria").ToString()
                    shXL.Cells(FilaID, 5).Value = Row("Proyecto").ToString()
                    shXL.Cells(FilaID, 6).Value = Row("Cantidad").ToString()
                    shXL.Cells(FilaID, 7).Value = Row("Descripcion").ToString()
                    shXL.Cells(FilaID, 8).Value = Row("CodProyect").ToString()
                    FilaID = FilaID + 1
                Next


                Dim saveFileDialog1 As New SaveFileDialog()
                saveFileDialog1.Title = "Guardar documento Excel"
                saveFileDialog1.Filter = "Excel File|*.xlsx"
                saveFileDialog1.FileName = GridArticulo.GetSelectedRows().Item(0).GridPanel.GetSelectedRows.GetCells(6).Value().ToString()
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