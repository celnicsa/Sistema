Public Class AddArticuloForm
    Private DataArticulo As New Articulo
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
                Me.Close()
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
    Private Sub LabelX4_Click(sender As Object, e As EventArgs) Handles LabelX4.Click

    End Sub

    Private Sub BtnInsertEscolaridad_Click(sender As Object, e As EventArgs) Handles BtnInsertEscolaridad.Click
        GetData()
    End Sub

    Private Sub AddArticuloForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmdViewProyectosCombo(ComboBox1)
        ComboBox1.SelectedIndex = 0
    End Sub
End Class