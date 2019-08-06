
Imports DevComponents.DotNetBar.SuperGrid

Public Class InventarioForm
    Private Sub ButtonX1_Click(sender As Object, e As EventArgs) Handles ButtonX1.Click
        Dim WindowsInsertCategoria As New CategoriaForm
        WindowsInsertCategoria.ShowDialog()
    End Sub
End Class