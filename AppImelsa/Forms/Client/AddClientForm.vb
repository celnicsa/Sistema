Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class AddClientForm
    Private InputV As New ValidateInput
    Private DataClient As New Client
    Private DataPhone As New PhoneClient
    Private DataEmail As New EmailClient
    Private Sub AddClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PSliderClient.SelectedPageIndex = 0
        ProgressState(True)
        EnableButtons()
        EnableRemove()
        LoadNextCode()
    End Sub
    Public Sub LoadNextCode()
        TxtBCode.Text = CmdNextCode("SPNextCodeClient")
    End Sub
    Private Sub ProgressState(ByVal Sentido As Boolean)
        If Sentido Then
            If ProgressOne.Value = 50 And ProgressTwo.Value = 0 Then
                ProgressOne.Value = 100
                ProgressTwo.Value = 50
            ElseIf ProgressTwo.Value = 50
                ProgressTwo.Value = 100
            ElseIf ProgressOne.Value = 0
                ProgressOne.Value = 50
            ElseIf ProgressTwo.Value = 100
                ''
            Else
                DesktopAlert.Show("Error de Proceso, No se Puede mostrar Grafica de Proceso")
            End If
        Else
            If ProgressTwo.Value >= 50 And ProgressOne.Value = 100 Then
                ProgressTwo.Value = 0
                ProgressOne.Value = 50
            Else
                DesktopAlert.Show("Error de Proceso, No se Puede mostrar Grafica de Proceso")
            End If
        End If
    End Sub
    Private Sub EnableButtons()
        Dim Page As Int16 = PSliderClient.SelectedPageIndex
        If Page = 0 Then
            BtnBack.Enabled = False
        Else
            BtnBack.Enabled = True
        End If
        If Page = PSliderClient.PageCount - 1 Then
            BtnNext.Enabled = False
            BtnAccept.Enabled = True
        Else
            BtnNext.Enabled = True
            BtnAccept.Enabled = False
        End If
    End Sub
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        If TraslatePage() Then
            Dim PageNum As Int16 = PSliderClient.PageCount
            Dim Page As Int16 = PSliderClient.SelectedPageIndex + 1
            If Page < PageNum Then
                PSliderClient.SelectedPageIndex = PSliderClient.SelectedPageIndex + 1
                EnableButtons()
                ProgressState(True)
            End If
        End If
    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Dim PageNum As Int16 = PSliderClient.PageCount
        Dim Page As Int16 = PSliderClient.SelectedPageIndex + 1
        If Page > 1 Then
            PSliderClient.SelectedPageIndex = PSliderClient.SelectedPageIndex - 1
            EnableButtons()
            ProgressState(False)
        End If
    End Sub
    Private Sub BtnAccept_Click(sender As Object, e As EventArgs) Handles BtnAccept.Click
        CProgress.IsRunning = True
        labelItem1.Text = "Guardando"
        ProgressState(True)
        GetData()
        CProgress.IsRunning = False
        labelItem1.Text = "Guardar"
    End Sub
    Public Function ValidateBox() As Boolean
        If TxtBCode.Text.Length = 0 Then
            Return False
        ElseIf TxtBName.Text.Length = 0
            Return False
        ElseIf TxtBName.Text.Length = 0
            Return False
        ElseIf RbtnCedula.Checked = False And RbtnRuc.Checked = False
            Return False
        ElseIf TxtIden.Text.Length = 0
            Return False
        ElseIf TxtBPerfil.Text.Length = 0
            Return False
        ElseIf TxtBAddres.Text.Length = 0
            Return False
        End If
        Return True
    End Function
    Public Function TraslatePage() As Boolean
        Dim Page As Int16 = PSliderClient.SelectedPageIndex
        Select Case Page
            Case 0
                If ValidateBox() Then
                    If LegalData() = False Then
                        Return False
                    End If
                Else
                    MsgBox("Para Continuar Debe Rellenar los Campos Vacios!", MsgBoxStyle.Exclamation)
                    Return False
                End If
        End Select
        Return True
    End Function
    Public Function LegalData() As Boolean
        If RbtnCedula.Checked Then
            If InputV.IsCedula(TxtIden.Text) = False Then
                MsgBox("La Cedula se ha detectado como invalida, debe Cumplir con el Patron 000-000000-0000A", MsgBoxStyle.Exclamation)
                Return False
            End If
        ElseIf RbtnRuc.Checked
            If InputV.IsRuc(TxtIden.Text) = False Then
                MsgBox("El N° Ruc se ha detectado como invalido, debe Cumplir con el Patron J0000000000000", MsgBoxStyle.Exclamation)
                Return False
            End If
        End If
        Return True
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
    Private Sub GetData()
        If NoContact() Then
            DataClient = New Client
            DataClient.Code = TxtBCode.Text
            DataClient.Name = TxtBName.Text
            DataClient.Ruc = TxtIden.Text
            DataClient.Addres = TxtBAddres.Text
            DataClient.Perfil = TxtBPerfil.Text
            If CmdInsertClient(DataClient) Then
                GetDataPhone(DataClient.Code)
                GetDataEmail(DataClient.Code)
                MsgBox("Datos de Cliente Guardados Satisfactoriamente", MsgBoxStyle.Information)
                Me.Close()
            Else
                MeErrorMessageDialog.ErrorMessage("Error-CL02")
            End If
        End If
    End Sub
    Private Sub GetDataPhone(ByVal Cliente As String)
        Dim NItem As Int16
        NItem = ListBoxTel.Items.Count - 1
        If NItem >= 0 Then
            For i = 0 To NItem
                DataPhone = New PhoneClient
                DataPhone.Code = "Code"
                DataPhone.CodeClient = Cliente
                DataPhone.Phone = ListBoxTel.Items(i).ToString()
                CmdInsertPhoneClient(DataPhone)
            Next
        End If
    End Sub
    Private Sub GetDataEmail(ByVal Cliente As String)
        Dim NItem As Int16
        NItem = ListBoxEmail.Items.Count - 1
        If NItem >= 0 Then
            For i = 0 To NItem
                DataEmail = New EmailClient
                DataEmail.Code = "Code"
                DataEmail.CodeClient = Cliente
                DataEmail.Email = ListBoxEmail.Items(i).ToString()
                CmdInsertEmailClient(DataEmail)
            Next
        End If
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
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class