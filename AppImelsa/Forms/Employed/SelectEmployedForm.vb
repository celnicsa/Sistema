Imports DevComponents.DotNetBar.SuperGrid

Public Class SelectEmployedForm
    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click
        If GridEmployed.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Empleado", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridEmployed.GetSelectedRows(0)
            Dim WindowsPerfilEmployed As New OneEmployed
            WindowsPerfilEmployed.Code = Grida.Cells(0).Value.ToString
            WindowsPerfilEmployed.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Public Sub LoadEmployed()
        Dim panel As GridPanel = GridEmployed.PrimaryGrid
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1
        CmdLoadEmployed(panel)
        panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
    End Sub

    Private Sub SelectEmployedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployed()
    End Sub
End Class