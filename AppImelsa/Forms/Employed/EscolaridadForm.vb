Imports DevComponents.DotNetBar.SuperGrid

Public Class EscolaridadForm

    Dim FlagOperacion As String

    Private Sub EscolaridadForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()
        LoadNextCode()
    End Sub

    Private Sub BtnInsertEscolaridad_Click(sender As Object, e As EventArgs) Handles BtnInsertEscolaridad.Click
        GetData()
        LoadTable()
    End Sub

    Private Sub BtnDeleteEscolaridad_Click(sender As Object, e As EventArgs) Handles BtnDeleteEscolaridad.Click
        If CmdDeleteEscolaridad(GridEscolaridades.GetCell(GridEscolaridades.ActiveRow.Index, 0).Value) Then
            MsgBox("Datos de la escolaridad Eliminados Satisfactoriamente", MsgBoxStyle.Information)
            LoadTable()
            LoadNextCode()
            TxtBName.Text = ""
            TxtBBeneficio.Text = ""
            BtnInsertEscolaridad.Text = "Agregar"
            FlagOperacion = "Insertar"
        Else
            ErrorMessage("Error-E01")
        End If
    End Sub


    Private Sub GridEscolaridades_RowHeaderClick(sender As Object, e As GridRowHeaderClickEventArgs) Handles GridEscolaridades.RowHeaderClick
        BtnInsertEscolaridad.Text = "Actualizar"
        TxtBCode.Text = GridEscolaridades.GetCell(GridEscolaridades.ActiveRow.Index, 0).Value
        TxtBName.Text = GridEscolaridades.GetCell(GridEscolaridades.ActiveRow.Index, 1).Value
        TxtBBeneficio.Text = GridEscolaridades.GetCell(GridEscolaridades.ActiveRow.Index, 2).Value
        FlagOperacion = "Actualizar"
    End Sub


    Private Sub LoadTable()
        Dim panel As GridPanel = GridEscolaridades.PrimaryGrid
        panel.RowHeaderWidth = 80
        panel.RowHeaderIndexOffset = 2
        CmdViewEscolaridad(panel)
        panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
        TxtBName.Text = ""
        TxtBBeneficio.Text = ""
        BtnInsertEscolaridad.Text = "Agregar"
    End Sub

    Private Sub LoadNextCode()
        TxtBCode.Text = CmdNextCode("[SPNextCodeEscolaridad]")

    End Sub

    Private Function ValidateBoxs() As Boolean
        If TxtBCode.Text.Length = 0 Then
            Return False
        ElseIf TxtBName.Text.Length = 0 Then
            Return False
        ElseIf TxtBBeneficio.Text.Length = 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub GetData()
        If Me.ValidateBoxs() Then
            Dim EscolaridadItem As New Escolaridad()
            EscolaridadItem.P_Codigo_Escolaridad = TxtBCode.Text
            EscolaridadItem.P_Nombre_Grado = TxtBName.Text
            EscolaridadItem.P_Beneficio_Grado = TxtBBeneficio.Text

            If (FlagOperacion <> "Actualizar") Then
                If CmdInsertEscolaridad(EscolaridadItem) Then
                    MsgBox("Datos de la escolaridad Guardados Satisfactoriamente", MsgBoxStyle.Information)
                    LoadNextCode()
                Else
                    MeErrorMessageDialog.ErrorMessage("Error-C02")
                End If
            Else
                If CmdUpdateEscolaridad(EscolaridadItem) Then
                    MsgBox("Datos de la escolaridad Guardados Satisfactoriamente", MsgBoxStyle.Information)
                    LoadNextCode()
                Else
                    MeErrorMessageDialog.ErrorMessage("Error-C02")
                End If
            End If
            TxtBName.Text = ""
            TxtBBeneficio.Text = ""
            BtnInsertEscolaridad.Text = "Agregar"

        Else
            MeErrorMessageDialog.ErrorMessage("Error-CL01")
        End If
    End Sub

    Private Sub TxtBName_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBName.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtBBeneficio.Select()
        End If
    End Sub

    Private Sub TxtBBeneficio_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBBeneficio.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnInsertEscolaridad.PerformClick()
        End If
    End Sub
End Class