Imports DevComponents.DotNetBar.SuperGrid

Public Class SelectProyectForm
    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click
        If GridEmployed.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Proyecto", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridEmployed.GetSelectedRows(0)
            Dim WindowsPerfilProyect As New UpdateProyectForm
            WindowsPerfilProyect.Code = Grida.Cells(0).Value.ToString
            WindowsPerfilProyect.ShowDialog()
            Me.Close()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Public Sub LoadProyect()
        Dim panel As GridPanel = GridEmployed.PrimaryGrid
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1
        CmdLoadProyectSelect(panel)
        panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
    End Sub

    Private Sub SelectProyectForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProyect()
    End Sub

End Class