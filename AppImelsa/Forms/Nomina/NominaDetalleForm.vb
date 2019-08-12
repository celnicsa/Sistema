Public Class NominaDetalleForm

    Public Tipo_Operacion As String
    Public ID_Nomina As String
    Private Sub NominaDetalleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Tabla = CmdGetEmployersID()
        For Each Row As DataRow In Tabla.Rows
            ComboBox1.Items.Add(Row("ID").ToString())
        Next
        ComboBox1.SelectedIndex = 0
        If (Tipo_Operacion = "Leer") Then
            BtnUpdateCargo.Visible = False
        End If
    End Sub

    Private Sub BtnUpdateCargo_Click(sender As Object, e As EventArgs) Handles BtnUpdateCargo.Click
        CmdInsertNomina("NO-" + DateInput.Value.Year.ToString() + "-" + DateInput.Value.Month.ToString("d2"), DateInput.Value.Year.ToString(), DateInput.Value.Month, ComboBox1.Text.Split(":")(1), DateInput.Value)
    End Sub
End Class
