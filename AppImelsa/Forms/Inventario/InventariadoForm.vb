Imports DevComponents.DotNetBar.SuperGrid
Public Class InventariadoForm
    Private DataArticulo As New Articulo
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim CategoriaForm As New CategoriaForms
        CategoriaForm.ShowDialog()
    End Sub

    Private Sub InventarioForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
    End Sub
    Private Sub LoadTable()
        Dim panel As GridPanel = GridArticulo.PrimaryGrid
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1
        CmdViewArticulo(panel)
        panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
    End Sub

    Private Sub BtnNewClient_Click(sender As Object, e As EventArgs) Handles BtnNewClient.Click
        Dim ArticuloForm As New AddArticuloForm
        ArticuloForm.ShowDialog()
    End Sub

    Private Sub BtnLoadTable_Click(sender As Object, e As EventArgs) Handles BtnLoadTable.Click
        GetSelectedArticulo()
    End Sub
    Private Function QuestionDelete(ByVal Entidad As String) As Boolean
        Dim Question As Int16
        Question = MsgBox("¿Desea Eliminar a la Entidad '" + Entidad + "' ?", MsgBoxStyle.YesNo)
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

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs) Handles ButtonX2.Click
        LoadTable()
    End Sub
End Class