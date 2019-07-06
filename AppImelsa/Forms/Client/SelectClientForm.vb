Imports DevComponents.DotNetBar.SuperGrid

Public Class SelectClientForm
    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click
        If GridEmployed.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Cliente", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridEmployed.GetSelectedRows(0)
            Dim WindowsPerfilClient As New OneClientForm
            WindowsPerfilClient.Code = Grida.Cells(0).Value.ToString
            WindowsPerfilClient.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Public Sub LoadClient()
        Dim panel As GridPanel = GridEmployed.PrimaryGrid
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1
        CmdLoadClientSelect(panel)
        panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
    End Sub

    Private Sub SelectClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClient()
    End Sub
End Class