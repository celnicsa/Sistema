Imports DevComponents.DotNetBar.SuperGrid

Public Class OneClientForm
    Public Code As String
    Dim DataClient As New Client
    Dim DataTelClient As New PhoneClient
    Dim DataEmailClient As New EmailClient
    Dim Input As New ValidateInput
    Private Sub OneClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataClient.Code = Code
        CmdDetaillsClient(DataClient)
        LoadData()
    End Sub
    Public Sub LoadTelTable()
        Dim panel As GridPanel = GridTelContacts.PrimaryGrid
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1
        CmdViewContactsEmp3(panel, DataClient.Code)
        panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
    End Sub
    Public Sub LoadEmailTable()
        Dim panel As GridPanel = GridEmailContacts.PrimaryGrid
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1
        CmdViewContactsEmp4(panel, DataClient.Code)
        panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
    End Sub
    Public Sub LoadProyectTable()
        Dim panel As GridPanel = GridProyect.PrimaryGrid
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1
        CmdViewProyectOfClients(panel, DataClient.Code)
        panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
    End Sub
    Public Sub LoadData()
        TxtBCode.Text = DataClient.Code
        TxtBName.Text = DataClient.Name
        TxtBIden.Text = DataClient.Ruc
        TxtBPerfil.Text = DataClient.Perfil
        TxtBAddres.Text = DataClient.Addres
        CheckedIden()
        LoadTelTable()
        LoadEmailTable()
        LoadProyectTable()
    End Sub
    Public Sub CheckedIden()
        If Input.IsCedula(DataClient.Ruc) Then
            RbtnCedula.Checked = True
        ElseIf Input.IsRuc(DataClient.Ruc)
            RbtnRuc.Checked = True
        End If
    End Sub
    Private Sub BtnAddTel_Click(sender As Object, e As EventArgs) Handles BtnAddTel.Click
        Dim Numero As String = InputBox("Digite El Nuevo Numero Telefonico que desea almacenar:")
        If Input.IsPhone(Numero) = False Then
            MsgBox("Numero Telefonico detectado como no valido", MsgBoxStyle.Exclamation)
        Else
            DataTelClient = New PhoneClient
            DataTelClient.Code = "Code_Tel"
            DataTelClient.Phone = Numero
            DataTelClient.CodeClient = Code
            If (CmdInsertPhoneClient(DataTelClient)) Then
                MsgBox("Numero Telefonico Almacenado Correctamente", MsgBoxStyle.Information)
                LoadTelTable()
            Else
                MsgBox("Error, Almacenamiento de Numero telefonico concluyo en error")
            End If
        End If
    End Sub
    Private Sub BtnAddEmail_Click(sender As Object, e As EventArgs) Handles BtnAddEmail.Click
        Dim Email As String = InputBox("Digite El Nuevo Correo Electronico que desea almacenar:")
        If Input.IsEmail(Email) = False Then
            MsgBox("Correo Electronico detectado como no valido", MsgBoxStyle.Exclamation)
        Else
            DataEmailClient = New EmailClient
            DataEmailClient.Code = "Code_Tel"
            DataEmailClient.Email = Email
            DataEmailClient.CodeClient = Code
            If (CmdInsertEmailClient(DataEmailClient)) Then
                MsgBox("Correo Electronico Almacenado Correctamente", MsgBoxStyle.Information)
                LoadEmailTable()
            Else
                MsgBox("Error, Almacenamiento de Correo Electronico concluyo en error")
            End If
        End If
    End Sub
    Private Sub BtnModEmail_Click(sender As Object, e As EventArgs) Handles BtnModEmail.Click
        If GridEmailContacts.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Correo Electronico", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridEmailContacts.GetSelectedRows(0)
            Dim Email As String = InputBox("Digite El Nuevo Correo Electronico Para Modifcar:")
            If Input.IsEmail(Email) = False Then
                MsgBox("Correo Electronico detectado como no valido", MsgBoxStyle.Exclamation)
            Else
                DataEmailClient = New EmailClient
                DataEmailClient.Code = Grida.Cells(0).Value.ToString
                DataEmailClient.Email = Email
                If (CmdUpdateEmailClient(DataEmailClient)) Then
                    MsgBox("Correo Electronico Modificado Correctamente", MsgBoxStyle.Information)
                    LoadEmailTable()
                Else
                    MsgBox("Error, Modificacion de Correo Electronico concluyo en error")
                End If
            End If
        End If
    End Sub
    Private Sub BtnModTel_Click(sender As Object, e As EventArgs) Handles BtnModTel.Click
        If GridTelContacts.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Numero Telefonico", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridTelContacts.GetSelectedRows(0)
            Dim Numero As String = InputBox("Digite El Nuevo Numero Telefonico Para Modifcar:")
            If Input.IsPhone(Numero) = False Then
                MsgBox("Numero Telefonico detectado como no valido", MsgBoxStyle.Exclamation)
            Else
                DataTelClient = New PhoneClient
                DataTelClient.Code = Grida.Cells(0).Value.ToString
                DataTelClient.Phone = Numero
                If (CmdUpdatePhoneClient(DataTelClient)) Then
                    MsgBox("Numero Telefonico Modificado Correctamente", MsgBoxStyle.Information)
                    LoadTelTable()
                Else
                    MsgBox("Error, Modificacion de Numero Telefonico concluyo en error")
                End If
            End If
        End If
    End Sub

    Private Sub BtnRemoveTel_Click(sender As Object, e As EventArgs) Handles BtnRemoveTel.Click
        If GridTelContacts.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Numero Telefonico", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridTelContacts.GetSelectedRows(0)
            DataTelClient = New PhoneClient
            DataTelClient.Code = Grida.Cells(0).Value.ToString
            If QuestionDelete(Grida.Cells(1).Value.ToString) Then
                If (CmdDeleteTelClient(DataTelClient)) Then
                    MsgBox("Numero Telefonico Elimacion Correctamente", MsgBoxStyle.Information)
                    LoadTelTable()
                Else
                    MsgBox("Error, Elimanacion de Numero Telefonico concluyo en error")
                End If
            End If
        End If
    End Sub
    Private Sub BtnRemoveEmail_Click(sender As Object, e As EventArgs) Handles BtnRemoveEmail.Click
        If GridEmailContacts.GetSelectedRows.Count = 0 Then
            MsgBox("No se ha Seleccionado Correo Electronico", MsgBoxStyle.Information)
        Else
            Dim Grida As GridRow = GridEmailContacts.GetSelectedRows(0)
            If QuestionDelete(Grida.Cells(1).Value.ToString) Then
                DataEmailClient = New EmailClient
                DataEmailClient.Code = Grida.Cells(0).Value.ToString
                If (CmdDeleteEmailClient(DataEmailClient)) Then
                    MsgBox("Correo Electronico Eliminado Correctamente", MsgBoxStyle.Information)
                    LoadEmailTable()
                Else
                    MsgBox("Error, Eliminacion de Correo Electronico concluyo en error")
                End If
            End If
        End If
    End Sub
    Private Function QuestionDelete(ByVal Entidad As String) As Boolean
        Dim Question As Int16
        Question = MsgBox("¿Desea Eliminar el Contacto: '" + Entidad + "' ?", MsgBoxStyle.YesNo)
        If Question = MsgBoxResult.Yes Then
            Return True
        End If
        Return False
    End Function
    Public Function ValidateBox() As Boolean
        If TxtBCode.Text.Length = 0 Then
            Return False
        ElseIf TxtBName.Text.Length = 0
            Return False
        ElseIf TxtBName.Text.Length = 0
            Return False
        ElseIf RbtnCedula.Checked = False And RbtnRuc.Checked = False
            Return False
        ElseIf TxtBIden.Text.Length = 0
            Return False
        ElseIf TxtBPerfil.Text.Length = 0
            Return False
        ElseIf TxtBAddres.Text.Length = 0
            Return False
        End If
        Return True
    End Function
    Public Function LegalData() As Boolean
        If RbtnCedula.Checked Then
            If Input.IsCedula(TxtBIden.Text) = False Then
                MsgBox("La Cedula se ha detectado como invalida, debe Cumplir con el Patron 000-000000-0000A", MsgBoxStyle.Exclamation)
                Return False
            End If
        ElseIf RbtnRuc.Checked
            If Input.IsRuc(TxtBIden.Text) = False Then
                MsgBox("El N° Ruc se ha detectado como invalido, debe Cumplir con el Patron J0000000000000", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If
        Return True
    End Function
    Private Sub GetData()
        If ValidateBox() Then
            If LegalData() Then
                DataClient = New Client
                DataClient.Code = TxtBCode.Text
                DataClient.Name = TxtBName.Text
                DataClient.Ruc = TxtBIden.Text
                DataClient.Addres = TxtBAddres.Text
                DataClient.Perfil = TxtBPerfil.Text
                If CmdUpdateClient(DataClient) Then
                    MsgBox("Datos de Cliente Guardados Satisfactoriamente", MsgBoxStyle.Information)
                    Me.Close()
                Else
                    MeErrorMessageDialog.ErrorMessage("Error-CL02")
                End If
            End If
        Else
            MsgBox("Para Guardar Datos debe Rellenar Campos Vacios!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        GetData()
    End Sub

    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click
        Me.Close()
    End Sub
End Class