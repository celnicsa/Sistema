Imports DevComponents.DotNetBar.SuperGrid
Public Class CategoriaForms
    Private DataCategoria As New Categoria
    Private Sub CategoriaForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
    End Sub
    Private Sub LoadTable()
        Dim panel As GridPanel = GridCategorias.PrimaryGrid
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1
        CmdViewCategoria(panel)
        panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
    End Sub
    Private Function QuestionDelete(ByVal Entidad As String) As Boolean
        Dim Question As Int16
        Question = MsgBox("�Desea Eliminar a la Entidad '" + Entidad + "' ?", MsgBoxStyle.YesNo)
        If Question = MsgBoxResult.Yes Then
            Return True
        End If
        Return False
    End Function
    Private Sub GetSelectedCategoria()
        If GridCategorias.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Categoria", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridCategorias.GetSelectedRows(0)
            DataCategoria = New Categoria
            DataCategoria.Code = Grida.Cells(0).Value.ToString
            DataCategoria.Name = Grida.Cells(1).Value.ToString
            DataCategoria.Descripcion = Grida.Cells(2).Value.ToString
            If QuestionDelete(DataCategoria.Name) Then
                If CmdDeleteCategoria(DataCategoria) Then
                    MsgBox("Datos de Categoria Eliminado Satisfactoriamente", MsgBoxStyle.Information)
                Else
                    MeErrorMessageDialog.ErrorMessage("Error-CL03")
                End If
            End If
        End If
    End Sub
    Private Function QuestionUpdate(ByVal Entidad As String) As Boolean
        Dim Question As Int16
        Question = MsgBox("�Desea Modificarla Entidad a:'" + Entidad + "' ?", MsgBoxStyle.YesNo)
        If Question = MsgBoxResult.Yes Then
            Return True
        End If
        Return False
    End Function
    Private Sub GetSelectedUpdateCategoria()
        If GridCategorias.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Categoria", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridCategorias.GetSelectedRows(0)
            DataCategoria = New Categoria
            DataCategoria.Code = TextCodigo.Text
            DataCategoria.Name = TextNombre.Text
            DataCategoria.Descripcion = TextDesc.Text
            If QuestionUpdate(DataCategoria.Name) Then
                If CmdUpdateCategoria(DataCategoria) Then
                    MsgBox("Datos de Categoria Modificado Satisfactoriamente", MsgBoxStyle.Information)
                Else
                    MeErrorMessageDialog.ErrorMessage("Error-CL03")
                End If
            End If
        End If
    End Sub
    Private Sub ButtonX2_Click(sender As Object, e As EventArgs)
        GetSelectedCategoria()
        LoadTable()
    End Sub
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs)
        GetSelectedUpdateCategoria()
        LoadTable()
    End Sub
    Private Sub GridCategorias_RowClick(sender As Object, e As GridRowClickEventArgs) Handles GridCategorias.RowClick
        Dim Grida As GridRow = GridCategorias.GetSelectedRows(0)
        TextCodigo.Text = Grida.Cells(0).Value
        TextNombre.Text = Grida.Cells(1).Value
        TextDesc.Text = Grida.Cells(2).Value
    End Sub

    Private Sub GetData()
        DataCategoria = New Categoria
        DataCategoria.Code = TextCodigo.Text
        DataCategoria.Name = TextNombre.Text
        DataCategoria.Descripcion = TextDesc.Text
        If CmdInsertCategoria(DataCategoria) Then
            MsgBox("Datos de Categoria Guardados Satisfactoriamente", MsgBoxStyle.Information)
        Else
            MeErrorMessageDialog.ErrorMessage("Error-CL02")
        End If
    End Sub
    Private Sub BtnUpdateClient_Click(sender As Object, e As EventArgs)
        GetData()
        LoadTable()
    End Sub

    Private Sub BtnUpdateClient_Click_1(sender As Object, e As EventArgs) Handles BtnUpdateClient.Click
        GetSelectedUpdateCategoria()
        LoadTable()
    End Sub
End Class