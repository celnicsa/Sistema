Imports DevComponents.DotNetBar.SuperGrid

Public Class NominaDetalleForm

    Public Tipo_Operacion As String
    Public ID_Nomina As String
    Public Bruto_Total As String
    Public Deducciones_Total As String
    Public Fecha As DateTime
    Public Usuario As String
    Public Mes As String
    Public Año As String

    Private Sub NominaDetalleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Tabla = CmdGetEmployersID()
        Dim panel As GridPanel = GridCargos.PrimaryGrid
        panel.RowHeaderWidth = 50
        Panel.RowHeaderIndexOffset = 1
        For Each Row As DataRow In Tabla.Rows
            ComboBox1.Items.Add(Row("ID").ToString())
        Next
        ComboBox1.SelectedIndex = 0
        If (Tipo_Operacion = "Leer") Then
            BtnUpdateCargo.Visible = False
            CmdViewNominaDetalle(panel, ID_Nomina)
            TextBoxX1.Text = Bruto_Total
            TextBoxX4.Text = Deducciones_Total
            TextBoxX2.Text = ID_Nomina
            TextBoxX3.Text = Mes
            TxtBName.Text = Año
            DateInput.Value = Fecha
            ComboBox1.SelectedValue = Usuario
        End If
    End Sub

    Private Sub BtnUpdateCargo_Click(sender As Object, e As EventArgs) Handles BtnUpdateCargo.Click
        Dim panel As GridPanel = GridCargos.PrimaryGrid
        Dim Resultado = CmdInsertNomina("NO-" + DateInput.Value.Year.ToString() + "-" + DateInput.Value.Month.ToString("d2"), DateInput.Value.Year.ToString(), MonthName(DateInput.Value.Month, False), ComboBox1.Text.Split(":")(1), DateInput.Value)
        CmdViewNominaDetalle(panel, "NO-" + DateInput.Value.Year.ToString() + "-" + DateInput.Value.Month.ToString("d2"))
        TextBoxX1.Text = Resultado(0).ToString()
        TextBoxX4.Text = Resultado(1).ToString()
        TextBoxX2.Text = "NO-" + DateInput.Value.Year.ToString() + "-" + DateInput.Value.Month.ToString("d2")
        TextBoxX3.Text = MonthName(DateInput.Value.Month.ToString())
        TxtBName.Text = DateInput.Value.Year.ToString()
        BtnUpdateCargo.Visible = False

    End Sub
End Class
