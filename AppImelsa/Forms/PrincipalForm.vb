Imports DevComponents.DotNetBar
Public Class PrincipalForm
    Private Time As Int32 = 0
    Private Sub PrincipalForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MTimer.Start()
    End Sub
    Private Sub NewWindows(ByVal Titulo As String, ByRef Windows As DevComponents.DotNetBar.Metro.MetroForm)
        Dim newpage As New SuperTabItem()
        Dim Panel As New SuperTabControlPanel()
        TabCWindows.SelectedTab = TabCWindows.Tabs.Item(0)
        TabCWindows.Tabs.Add(newpage)
        TabCWindows.Controls.Add(Panel)
        TabCWindows.SelectedTab = newpage
        Windows.TopLevel = False
        Windows.Parent = Panel
        newpage.AttachedControl = Panel
        newpage.Text = Titulo
        newpage.PredefinedColor = eTabItemColor.OfficeMobile2014Blue
        Windows.Show()
    End Sub
    Private Sub BtnEmployeds_Click(sender As Object, e As EventArgs) Handles BtnEmployed.Click
        Dim WindowsEmployed As New EmployedForm
        NewWindows("Empleados", WindowsEmployed)
    End Sub
    Private Sub BtnClients_Click(sender As Object, e As EventArgs) Handles BtnClient.Click
        Dim WindowsClient As New ClientForm
        NewWindows("Clientes", WindowsClient)
    End Sub
    Private Sub BtnProyects_Click(sender As Object, e As EventArgs) Handles BtnProyect.Click
        Dim WindowsProyect As New ProyectForm
        NewWindows("Proyectos", WindowsProyect)
    End Sub
    Private Sub ButtonItem4_Click(sender As Object, e As EventArgs)
        Dim WindowsAsistence As New AsistenceForm
        NewWindows("Asistencias", WindowsAsistence)
    End Sub
    Private Sub ButtonPrestamos_Click(sender As Object, e As EventArgs) Handles ButtonItem33.Click
        Dim WindowsPrestamos As New PrestamoForm
        NewWindows("Prestamos", WindowsPrestamos)
    End Sub
    Private Sub CallTurnForm()
        Dim WindowsTurn As New TurnForm
        WindowsTurn.ShowDialog()
    End Sub
    Private Sub CallCargoForm()
        Dim WindowsCarg As New CargoForm
        WindowsCarg.ShowDialog()
    End Sub
    Private Sub CallSalarioForm()
        Dim WindowsSalario As New SalarioForm
        WindowsSalario.ShowDialog()
    End Sub
    Private Sub ButtonSalario_Click(sender As Object, e As EventArgs) Handles BtnSalario.Click
        CallSalarioForm()
    End Sub
    Private Sub ButtonTurno_Click(sender As Object, e As EventArgs)
        CallTurnForm()
    End Sub
    Private Sub ButtonCargo_Click(sender As Object, e As EventArgs) Handles BtnCargo.Click
        CallCargoForm()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles MTimer.Tick
        Time += 1
        If (Time = 300) Then
            'PVision_Mision.Image = My.Resources.Mision
        ElseIf (Time = 600)Then
            MTimer.Stop()
            ' PVision_Mision.Image = My.Resources.Vision
            Time = 0
            MTimer.Start()
        End If

    End Sub
    Private Sub Btn_ReportProyect_Click(sender As Object, e As EventArgs) Handles BtnReportProyect.Click
        Dim WindowsReportProyect As New ReportProyectForm
        WindowsReportProyect.ShowDialog()
    End Sub

    Private Sub BtnBackup_Click(sender As Object, e As EventArgs) Handles BtnBackup.Click
        If CmdBackup() Then
            MsgBox("Base De Datos Restaurada Con Exito", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub BtnAddEmp_Click(sender As Object, e As EventArgs) Handles BtnAddEmp.Click
        Dim WindowsAddEmployed As New AddEmployedForm
        WindowsAddEmployed.ShowDialog()
    End Sub

    Private Sub BtnAddClient_Click(sender As Object, e As EventArgs) Handles BtnAddClient.Click
        Dim WindowsAddProyect As New AddClientForm
        WindowsAddProyect.ShowDialog()
    End Sub

    Private Sub BtnAddProyect_Click(sender As Object, e As EventArgs) Handles BtnAddProyect.Click
        Dim WindowsAddProyect As New AddProyectForm
        WindowsAddProyect.ShowDialog()
    End Sub

    Private Sub BtnViewOneEmp_Click(sender As Object, e As EventArgs) Handles BtnViewOneEmp.Click
        Dim WindowsOneEmp As New SelectEmployedForm
        WindowsOneEmp.ShowDialog()
    End Sub

    Private Sub BtnViewOneProyect_Click(sender As Object, e As EventArgs) Handles BtnViewOneProyect.Click
        Dim WindowsOneProyect As New SelectProyectForm
        WindowsOneProyect.ShowDialog()
    End Sub

    Private Sub BtnViewOneClient_Click(sender As Object, e As EventArgs) Handles BtnViewOneClient.Click
        Dim WindowsOneClient As New SelectClientForm
        WindowsOneClient.ShowDialog()
    End Sub

    Private Sub BtnAbono_Click(sender As Object, e As EventArgs) Handles BtnAbono.Click
        Dim WindowsAbono As New SelectPrestamoForm
        WindowsAbono.ShowDialog()
    End Sub

    Private Sub ButtonItem1_Click(sender As Object, e As EventArgs) Handles ButtonItem1.Click
        Dim NF As New NominaForm
        NewWindows("Nomina", NominaForm)
    End Sub

    Private Sub ButtonItem44_Click(sender As Object, e As EventArgs) Handles ButtonItem44.Click
        Dim EscolaridadForm As New EscolaridadForm
        EscolaridadForm.ShowDialog()
    End Sub

    Private Sub ButtonItem20_Click(sender As Object, e As EventArgs) Handles ButtonItem20.Click
        Dim CategoriaForm As New CategoriaForm
        CategoriaForm.ShowDialog()
    End Sub

    Private Sub ButtonItem3_Click(sender As Object, e As EventArgs) Handles ButtonItem3.Click
        Dim InventarioForm As New InventarioForm
        InventarioForm.ShowDialog()
    End Sub
End Class
