Imports DevComponents.DotNetBar.Controls

Public Class AddEmployedForm
    Private InputV As New ValidateInput
    Private DataEmployed As New Employed
    Private DataPhone As New CelEmployed
    Private DataEmail As New EmailEmployed
    Private Sub AddEmployedForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PSliderEmployed.SelectedPageIndex = 0
        ProgressState(True)
        EnableButtons()
        InitElements()
        LoadDefaultPhoto()
        LoadNextCode()
    End Sub
    Public Sub LoadNextCode()
        TxtBCode.Text = CmdNextCode("SPNextCodeEmp")
    End Sub
    Public Sub LoadDefaultPhoto()
        Dim MyImageConsult As Image
        Try
            MyImageConsult = BytesToImage(CmdLoadPhoto("DefaultPic"))
            PictureBox1.Image = MyImageConsult
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub InitElements()
        If CmdLoadTurno(CmBTurno) = False Then
            MeErrorMessageDialog.ErrorMessage("Error-L01")
        End If
        If CmdLoadCarg(ListBoxCargo) = False Then
            MeErrorMessageDialog.ErrorMessage("Error-L02")
        End If
        If CmdLoadSalario(ListBoxSalario) = False Then
            MeErrorMessageDialog.ErrorMessage("Error-L03")
        End If
        If CmdLoadProyect(ListBoxProyect) = False Then
            MeErrorMessageDialog.ErrorMessage("Error-L04")
        End If

        EnableRemove()
    End Sub
    Private Function AddPhone() As Boolean
        If TxtBPhone.Text.Length = 0 Or InputV.IsPhone(TxtBPhone.Text) = False Then
            Return False
        Else
            ListBoxTel.Items.Add(TxtBPhone.Text)
            TxtBPhone.Clear()
            TxtBPhone.Focus()
            Return True
        End If
    End Function
    Private Function AddEmail() As Boolean
        If TxtBEmail.Text.Length = 0 Or InputV.IsEmail(TxtBEmail.Text) = False Then
            Return False
        Else
            ListBoxEmail.Items.Add(TxtBEmail.Text)
            TxtBEmail.Clear()
            TxtBEmail.Focus()
            Return True
        End If
    End Function
    Private Sub ValidatePhone()
        If AddPhone() = False Then
            MeErrorMessageDialog.ErrorMessage("Error-Ph01")
        End If
    End Sub
    Private Sub ValidateEmail()
        If AddEmail() = False Then
            MeErrorMessageDialog.ErrorMessage("Error-Em01")
        End If
    End Sub
    Private Function RemovePhone() As Boolean
        Dim Index As Int16
        Index = ListBoxTel.SelectedIndex
        If Index > -1 Then
            ListBoxTel.Items.RemoveAt(Index)
            Return True
        Else
            Return False
        End If
    End Function
    Private Function RemoveEmail() As Boolean
        Dim Index As Int16
        Index = ListBoxEmail.SelectedIndex
        If Index > -1 Then
            ListBoxEmail.Items.RemoveAt(Index)
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub EnableRemove()
        If ListBoxTel.Items.Count > 0 Then
            BtnRemovePhone.Enabled = True
        Else
            BtnRemovePhone.Enabled = False
        End If

        If ListBoxEmail.Items.Count > 0 Then
            BtnRemoveEmail.Enabled = True
        Else
            BtnRemoveEmail.Enabled = False
        End If
    End Sub
    Public Function GetSexo() As String
        If RbtnFemenine.Checked Then
            Return "Femenino"
        Else
            Return "Masculino"
        End If
    End Function
    Private Sub ProgressState(ByVal Sentido As Boolean)
        If Sentido Then
            If ProgressOne.Value = 50 Then
                ProgressOne.Value = 100
                ProgressTwo.Value = 50
            ElseIf ProgressTwo.Value = 50
                ProgressTwo.Value = 100
                ProgressTree.Value = 50
            ElseIf ProgressTree.Value = 50
                ProgressTree.Value = 100
            ElseIf ProgressOne.Value = 0
                ProgressOne.Value = 50.0
            Else
                DesktopAlert.Show("Error de Proceso, No se Puede mostrar Grafica de Proceso")
            End If
        Else
            If ProgressTwo.Value = 50 And ProgressOne.Value = 100 Then
                ProgressTwo.Value = 0
                ProgressOne.Value = 50
            ElseIf ProgressTree.Value = 50 And ProgressTwo.Value = 100
                ProgressTree.Value = 0
                ProgressTwo.Value = 50
            Else
                DesktopAlert.Show("Error de Proceso, No se Puede mostrar Grafica de Proceso")
            End If
        End If
    End Sub
    Private Sub EnableButtons()
        Dim Page As Int16 = PSliderEmployed.SelectedPageIndex
        If Page = 0 Then
            BtnBack.Enabled = False
        Else
            BtnBack.Enabled = True
        End If
        If Page = PSliderEmployed.PageCount - 1 Then
            BtnNext.Enabled = False
            BtnAccept.Enabled = True
        Else
            BtnNext.Enabled = True
            BtnAccept.Enabled = False
        End If

    End Sub
    Public Sub Cargar_Imagen()
        Dim Imagen As String = ""
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
        PictureBox1.Load(Imagen)
    End Sub
    Private Function NoContact()
        If ListBoxEmail.Items.Count = 0 And ListBoxTel.Items.Count = 0 Then
            Dim Question As Int16
            Question = MsgBox("No se ha Añadido ningun Contacto, ¿Desea Continuar?", MsgBoxStyle.YesNo)
            If Question = MsgBoxResult.No Then
                Return False
            End If
        End If
        Return True
    End Function
    Private Sub GetData()
        If NoContact() Then
            DataEmployed = New Employed
            DataEmployed.Code = TxtBCode.Text
            DataEmployed.Name = TxtBName.Text
            DataEmployed.Apellido = TxtBLastName.Text
            DataEmployed.Sexo = GetSexo()
            DataEmployed.DateNaci = DateInputBirth.Value.ToString("yyyyMMMdd")
            DataEmployed.Identi = TxtBIden.Text
            DataEmployed.Inss = TxtBInss.Text
            DataEmployed.Inss = TxtBInss.Text
            DataEmployed.Direc = TxtBAddres.Text
            DataEmployed.CodeProyect = ListBoxProyect.SelectedItem.ToString
            DataEmployed.CodeTurno = CmBTurno.SelectedItem.ToString
            DataEmployed.CodeCargo = ListBoxCargo.SelectedItem.ToString
            DataEmployed.CodeSalario = ListBoxSalario.SelectedItem.ToString
            DataEmployed.Photo = PictureBox1.Image
            If CmdInsertEmployed(DataEmployed) Then
                GetDataPhone(DataEmployed.Code)
                GetDataEmail(DataEmployed.Code)
                ProgressState(True)
                MsgBox("Datos de Empleado Guardados Satisfactoriamente", MsgBoxStyle.Information)
                Me.Close()
            Else
                MeErrorMessageDialog.ErrorMessage("Error-E02")
            End If
        End If
    End Sub
    Private Sub GetDataPhone(ByVal Employed As String)
        Dim NItem As Int16
        NItem = ListBoxTel.Items.Count - 1
        If NItem >= 0 Then
            For i = 0 To NItem
                DataPhone = New CelEmployed
                DataPhone.Code = "Code"
                DataPhone.CodeEmployed = Employed
                DataPhone.Tel = ListBoxTel.Items(i).ToString()
                CmdInsertPhoneEmp(DataPhone)
            Next
        End If
    End Sub
    Private Sub GetDataEmail(ByVal Employed As String)
        Dim NItem As Int16
        NItem = ListBoxEmail.Items.Count - 1
        If NItem >= 0 Then
            For i = 0 To NItem
                DataEmail = New EmailEmployed
                DataEmail.Code = "Code"
                DataEmail.CodeEmployed = Employed
                DataEmail.Email = ListBoxEmail.Items(i).ToString()
                CmdInsertEmailEmp(DataEmail)
            Next
        End If
    End Sub
    Private Function ValidateBoxPageOne() As Boolean
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
        ElseIf TxtBAddres.Text.Length = 0 Then
            Return False
        ElseIf RbtnFemenine.Checked <> True And RbtnMale.Checked <> True
            Return False
        End If
        Return True
    End Function
    Private Function ValidateBoxPageTwo() As Boolean
        If CmBTurno.SelectedIndex = -1 Then
            Return False
        ElseIf ListBoxCargo.SelectedIndex = -1 Then
            Return False
        ElseIf ListBoxSalario.SelectedIndex = -1 Then
            Return False
        ElseIf ListBoxProyect.SelectedIndex = -1 Then
            Return False
        End If
        Return True
    End Function
    Public Function TraslatePage() As Boolean
        Dim Page As Int16 = PSliderEmployed.SelectedPageIndex
        Select Case Page
            Case 0
                If ValidateBoxPageOne() Then
                    If LegalData() = False Then
                        Return False
                    End If
                Else
                    MsgBox("Para Continuar Debe Rellenar los Campos Vacios!", MsgBoxStyle.Exclamation)
                    Return False
                End If
            Case 1
                If ValidateBoxPageTwo() Then
                    Return True
                Else
                    MsgBox("Para Continuar Debe Rellenar los Campos Vacios!", MsgBoxStyle.Exclamation)
                    Return False
                End If
        End Select
        Return True
    End Function
    Public Function LegalData() As Boolean
        If InputV.IsCedula(TxtBIden.Text) = False Then
            MsgBox("La Cedula se ha detectado como invalida, debe Cumplir con el Patron 000-000000-0000A", MsgBoxStyle.Exclamation)
            Return False
        End If
        Return True
    End Function
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If TraslatePage() Then
            Dim PageNum As Int16 = PSliderEmployed.PageCount
            Dim Page As Int16 = PSliderEmployed.SelectedPageIndex + 1
            If Page < PageNum Then
                PSliderEmployed.SelectedPageIndex = PSliderEmployed.SelectedPageIndex + 1
                EnableButtons()
                ProgressState(True)
            End If
        End If
    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim PageNum As Int16 = PSliderEmployed.PageCount
        Dim Page As Int16 = PSliderEmployed.SelectedPageIndex + 1
        If Page > 1 Then
            PSliderEmployed.SelectedPageIndex = PSliderEmployed.SelectedPageIndex - 1
            EnableButtons()
            ProgressState(False)
        End If
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
    Private Sub BtnAddPhone_Click(sender As Object, e As EventArgs) Handles BtnAddPhone.Click
        ValidatePhone()
        EnableRemove()
    End Sub
    Private Sub BtnAddEmail_Click(sender As Object, e As EventArgs) Handles BtnAddEmail.Click
        ValidateEmail()
        EnableRemove()
    End Sub
    Private Sub BtnRemovePhone_Click(sender As Object, e As EventArgs) Handles BtnRemovePhone.Click
        RemovePhone()
        EnableRemove()
    End Sub
    Private Sub BtnRemoveEmail_Click(sender As Object, e As EventArgs) Handles BtnRemoveEmail.Click
        RemoveEmail()
        EnableRemove()
    End Sub
    Private Sub BtnAddTurn_Click(sender As Object, e As EventArgs) Handles BtnAddTurn.Click
        Dim WindowsAddTurn As New TurnForm
        WindowsAddTurn.ShowDialog()
        InitElements()
    End Sub
    Private Sub BtnAddCargo_Click(sender As Object, e As EventArgs) Handles BtnAddCargo.Click
        Dim WindowsAddCargo As New CargoForm
        WindowsAddCargo.ShowDialog()
        InitElements()
    End Sub
    Private Sub BtnAddSalario_Click(sender As Object, e As EventArgs) Handles BtnAddSalario.Click
        Dim WindowsAddSalario As New SalarioForm
        WindowsAddSalario.ShowDialog()
        InitElements()
    End Sub
    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click
        CProgress.IsRunning = True
        labelItem1.Text = "Guardando"
        GetData()
        CProgress.IsRunning = False
        labelItem1.Text = "Guardar"
    End Sub

    Private Sub BtnLoadPhoto_Click(sender As Object, e As EventArgs) Handles BtnLoadPhoto.Click
        Cargar_Imagen()
    End Sub
End Class