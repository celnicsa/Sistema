Imports DevComponents.DotNetBar.SuperGrid
Public Class NominaForm
    Private Sub BtnNewEmployed_Click(sender As Object, e As EventArgs) Handles BtnNewEmployed.Click
        Dim ND As New NominaDetalleForm
        ND.ShowDialog()
    End Sub
End Class