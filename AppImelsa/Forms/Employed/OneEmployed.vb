Imports DevComponents.DotNetBar.SuperGrid

Public Class OneEmployed
    Dim Imagen As String
    Public Code As String
    Dim DataEmployed As New Employed
    Dim DataTelEmployed As New CelEmployed
    Dim DataEmailEmployed As New EmailEmployed
    Dim Input As New ValidateInput
    Public Sub Cargar_Imagen()
        Try
            Me.OpenFileDialog1.ShowDialog()
            If Me.OpenFileDialog1.FileName <> "" Then
                Imagen = OpenFileDialog1.FileName
                Dim Longi As Integer = Imagen.Length
                Dim Imagen2 As String
                Imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(Imagen), Longi - 2, Longi))
                If Imagen2 <> "gif" And Imagen2 <> "bmp" And Imagen2 <> "jpg" And Imagen2 <> "jpeg" And Imagen2 <> "png" Then
                    Imagen2 = CStr(Microsoft.VisualBasic.Mid(RTrim(Imagen), Longi - 3, Longi))
                    If Imagen2 <> "jpeg" And Imagen2 <> "JPEG" And Imagen2 <> "" And Imagen2 <> "long1" Then
                        MsgBox("Formato no Valido") : Exit Sub
                        If Imagen2 <> "long1" Then Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
        PicBPhoto.Load(Imagen)
    End Sub

    Private Sub ButtonX2_Click(sender As Object, e As EventArgs)
        If Not PictureBox1.Image Is Nothing Then
            Dim Nombre As String = InputBox("Digite el Nombre de la Imagen que Desea Almacenar: ")
            Dim Imagen As Image
            Imagen = PictureBox1.Image
            If CmdInsertPhoto(Nombre, BytesToString(ImageToBytes(Imagen))) Then
                MsgBox("imagen Gurdada Satisfactoriamente")
                PictureBox1.Image = Nothing
                CmdLoadNamePhoto(cmBB)
            End If
        Else
            MsgBox("No hay imagen que guardar")
        End If
    End Sub
    Private Sub OneEmployed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmdViewEscolaridadCombo(ComboBox1)
        CmdLoadNamePhoto(cmBB)
        DataEmployed.Code = Code
        CmdDetaillsEmp(DataEmployed)
        LoadData()
        InitElements()
    End Sub
    Public Sub LoadTelTable()
        Dim panel As GridPanel = GridTelContacts.PrimaryGrid
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1
        CmdViewContactsEmp(panel, DataEmployed.Code)
        panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
    End Sub
    Public Sub LoadEmailTable()
        Dim panel As GridPanel = GridEmailContacts.PrimaryGrid
        panel.RowHeaderWidth = 50
        panel.RowHeaderIndexOffset = 1
        CmdViewContactsEmp2(panel, DataEmployed.Code)
        panel.NestedListScanTypes = (NestedListScanTypes.Properties Or NestedListScanTypes.Fields)
    End Sub
    Public Sub LoadData()
        TxtBCode.Text = DataEmployed.Code
        TxtBName.Text = DataEmployed.Name
        TxtBLastName.Text = DataEmployed.Apellido
        TxtBIden.Text = DataEmployed.Identi
        TxtBInss.Text = DataEmployed.Inss
        TxtBAdress.Text = DataEmployed.Direc
        TxtBCargo.Text = DataEmployed.CodeCargo
        TxtBTurno.Text = DataEmployed.CodeTurno
        TxtBSal.Text = DataEmployed.CodeSalario
        TxtBProyect.Text = DataEmployed.CodeProyect
        ComboBox1.SelectedItem = DataEmployed.Escolaridad
        DInput.Value = DataEmployed.DateNaci
        CheckedSexo(DataEmployed.Sexo)
        PicBPhoto.Image = DataEmployed.Photo
        LoadTelTable()
        LoadEmailTable()
    End Sub

    Public Sub InitElements()
        CmdLoadCargP(ListBCargo)
        CmdLoadTurnoP(ListBTurn)
        CmdLoadSalarioP(ListBSalario)
        CmdLoadProyectP(ListBProyect)
    End Sub
    Public Sub CheckedSexo(ByVal Sexo As String)
        If Sexo.Equals("Femenino") Then
            RbtnFemine.Checked = True
        Else
            RbtnMasculine.Checked = True
        End If
    End Sub
    Private Sub cmBB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmBB.SelectedIndexChanged
        Dim MyImageConsult As Image
        MyImageConsult = BytesToImage(CmdLoadPhoto(cmBB.SelectedItem.ToString))
        Try
            PictureBox1.Image = MyImageConsult
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtnChangeTurno_Click(sender As Object, e As EventArgs) Handles BtnChangeTurno.Click
        If ListBTurn.SelectedIndices.Count = 0 Then
            MsgBox("No se ha Seleccionado ningun Turno de la Lista...", MsgBoxStyle.Exclamation)
        Else
            TxtBTurno.Text = ListBTurn.SelectedItem.ToString
        End If
    End Sub
    Private Sub BtnChangeSalario_Click(sender As Object, e As EventArgs) Handles BtnChangeSalario.Click
        If ListBSalario.SelectedIndices.Count = 0 Then
            MsgBox("No se ha Seleccionado ningun Salario de la Lista...", MsgBoxStyle.Exclamation)
        Else
            TxtBSal.Text = ListBSalario.SelectedItem.ToString
        End If
    End Sub
    Private Sub BtnChangeCargo_Click(sender As Object, e As EventArgs) Handles BtnChangeCargo.Click
        If ListBCargo.SelectedItems.Count = 0 Then
            MsgBox("No se ha Seleccionado ningun Cargo de la Lista...", MsgBoxStyle.Exclamation)
        Else
            TxtBCargo.Text = ListBCargo.SelectedItem.ToString
        End If
    End Sub

    Private Sub BtnCahngeProyect_Click(sender As Object, e As EventArgs) Handles BtnCahngeProyect.Click
        If ListBProyect.SelectedIndices.Count = 0 Then
            MsgBox("No se ha Seleccionado ningun Proyecto de la Lista...", MsgBoxStyle.Exclamation)
        Else
            TxtBProyect.Text = ListBProyect.SelectedItem.ToString
        End If
    End Sub

    Private Sub BtnAddTel_Click(sender As Object, e As EventArgs) Handles BtnAddTel.Click
        Dim Numero As String = InputBox("Digite El Nuevo Numero Telefonico que desea almacenar:")
        If Input.IsPhone(Numero) = False Then
            MsgBox("Numero Telefonico detectado como no valido", MsgBoxStyle.Exclamation)
        Else
            DataTelEmployed = New CelEmployed
            DataTelEmployed.Code = "Code_Tel"
            DataTelEmployed.Tel = Numero
            DataTelEmployed.CodeEmployed = Code
            If (CmdInsertPhoneEmp(DataTelEmployed)) Then
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
            DataEmailEmployed = New EmailEmployed
            DataEmailEmployed.Code = "Code_Tel"
            DataEmailEmployed.Email = Email
            DataEmailEmployed.CodeEmployed = Code
            If (CmdInsertEmailEmp(DataEmailEmployed)) Then
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
                DataEmailEmployed = New EmailEmployed
                DataEmailEmployed.Code = Grida.Cells(0).Value.ToString
                DataEmailEmployed.Email = Email
                If (CmdUpdateEmailEmp(DataEmailEmployed)) Then
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
                DataTelEmployed = New CelEmployed
                DataTelEmployed.Code = Grida.Cells(0).Value.ToString
                DataTelEmployed.Tel = Numero
                If (CmdUpdatePhoneEmp(DataTelEmployed)) Then
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
            DataTelEmployed = New CelEmployed
            DataTelEmployed.Code = Grida.Cells(0).Value.ToString
            If QuestionDelete(Grida.Cells(1).Value.ToString) Then
                If (CmdDeleteTelEmployed(DataTelEmployed)) Then
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
                DataEmailEmployed = New EmailEmployed
                DataEmailEmployed.Code = Grida.Cells(0).Value.ToString
                If (CmdDeleteEmailEmployed(DataEmailEmployed)) Then
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

    Private Sub BtnPhoto_Click(sender As Object, e As EventArgs) Handles BtnPhoto.Click
        Cargar_Imagen()
    End Sub
    Private Function ValidateBox() As Boolean
        If TxtBCode.Text.Length = 0 Then
            Return False
        ElseIf TxtBName.Text.Length = 0 Then
            Return False
        ElseIf TxtBLastName.Text.Length = 0 Then
            Return False
        ElseIf TxtBIden.Text.Length = 0 Then
            Return False
        ElseIf TxtBInss.Text.Length = 0 Then
            Return False
        ElseIf TxtBAdress.Text.Length = 0 Then
            Return False
        ElseIf RbtnFemenine.Checked <> True And RbtnMale.Checked <> True
            Return False
        ElseIf TxtBProyect.Text.Length = 0 Then
            Return False
        ElseIf TxtBTurno.Text.Length = 0 Then
            Return False
        ElseIf TxtBCargo.Text.Length = 0 Then
            Return False
        ElseIf TxtBSal.Text.Length = 0 Then
            Return False
        End If
        Return True
    End Function

    Public Function LegalData() As Boolean
        If Input.IsCedula(TxtBIden.Text) = False Then
            MsgBox("La Cedula se ha detectado como invalida, debe Cumplir con el Patron 000-000000-0000A", MsgBoxStyle.Exclamation)
            Return False
        End If
        Return True
    End Function
    Public Function GetSexo() As String
        If RbtnFemine.Checked Then
            Return "Femenino"
        Else
            Return "Masculino"
        End If
    End Function
    Private Sub GetData()
        If ValidateBox() Then
            If LegalData() Then
                DataEmployed = New Employed
                DataEmployed.Code = TxtBCode.Text
                DataEmployed.Name = TxtBName.Text
                DataEmployed.Apellido = TxtBLastName.Text
                DataEmployed.Sexo = GetSexo()
                DataEmployed.DateNaci = DInput.Value.ToString("yyyyMMMdd")
                DataEmployed.Identi = TxtBIden.Text
                DataEmployed.Inss = TxtBInss.Text
                DataEmployed.Inss = TxtBInss.Text
                DataEmployed.Direc = TxtBAdress.Text
                DataEmployed.CodeProyect = TxtBProyect.Text 'ListBProyect.SelectedItem.ToString '
                DataEmployed.CodeTurno = TxtBTurno.Text 'ListBTurn.SelectedItem.ToString
                DataEmployed.CodeCargo = TxtBCargo.Text 'ListBCargo.SelectedItem.ToString
                DataEmployed.CodeSalario = TxtBSal.Text 'ListBSalario.SelectedItem.ToString
                DataEmployed.Photo = PicBPhoto.Image
                DataEmployed.Escolaridad = ComboBox1.Text.Split(" ")(0)
                If CmdUpdateEmployed(DataEmployed) Then
                    MsgBox("Datos de Empleado Guardados Satisfactoriamente", MsgBoxStyle.Information)
                    Me.Close()
                Else
                    MeErrorMessageDialog.ErrorMessage("Error-E02")
                End If
            End If
        Else
            MsgBox("Para Guardar Datos debe Rellenar Campos Vacios!", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        'ProgressItem.IsRunning = True
        LabelProcess.Text = "Guardando"
        GetData()
        LabelProcess.Text = "Guardado"
    End Sub

    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click
        Me.Close()
    End Sub
End Class