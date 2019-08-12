Imports DevComponents.DotNetBar.SuperGrid
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
End Class