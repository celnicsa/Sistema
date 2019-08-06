Public Class InventarioForm
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim CategoriaForm As New CategoriaForm
        CategoriaForm.ShowDialog()
    End Sub
End Class