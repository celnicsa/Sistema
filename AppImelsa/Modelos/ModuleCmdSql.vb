Imports System.Data.SqlClient
Imports DevComponents.DotNetBar.Controls
Imports DevComponents.DotNetBar.SuperGrid

Module ModuleCmdSql
    Dim Connect As New SqlConnection(My.Settings.ConexionSQL)
    Dim Cmd As New SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Public Function CmdBackup() As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPBackupImelsa", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdInsertTurno(ByVal Data As Turno) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPInsertTurno", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Name", Data.Name)
            Cmd.Parameters.AddWithValue("@H_Star", Data.HsStart)
            Cmd.Parameters.AddWithValue("@H_End", Data.HsEnd)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdInsertCargo(ByVal Data As Cargo) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPInsertCargo", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Name", Data.Name)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdInsertSalario(ByVal Data As Salario) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPInsertSalarioBase", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@SMensual", Data.SMensual)
            Cmd.Parameters.AddWithValue("@SQuincenal", Data.SQuincenal)
            Cmd.Parameters.AddWithValue("@SHora", Data.SHora)
            Cmd.Parameters.AddWithValue("@SMensual_Neto", Data.SHora)
            Cmd.Parameters.AddWithValue("@Expect_Anual", Data.SHora)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdInsertEmployed(ByVal Data As Employed) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPInsertEmployed", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Name", Data.Name)
            Cmd.Parameters.AddWithValue("@LastName", Data.Apellido)
            Cmd.Parameters.AddWithValue("@Sexo", Data.Sexo)
            Cmd.Parameters.AddWithValue("@DateB", Data.DateNaci)
            Cmd.Parameters.AddWithValue("@Iden", Data.Identi)
            Cmd.Parameters.AddWithValue("@Inss", Data.Inss)
            Cmd.Parameters.AddWithValue("@Addres", Data.Direc)
            Cmd.Parameters.AddWithValue("@Proyect", Data.CodeProyect)
            Cmd.Parameters.AddWithValue("@Turno", Data.CodeTurno)
            Cmd.Parameters.AddWithValue("@Cargo", Data.CodeCargo)
            Cmd.Parameters.AddWithValue("@SalarioBase", Data.CodeSalario)
            Cmd.Parameters.AddWithValue("@Photo", BytesToString(ImageToBytes(Data.Photo)))
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdUpdateEmployed(ByVal Data As Employed) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPUpdateEmployed", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Name", Data.Name)
            Cmd.Parameters.AddWithValue("@LastName", Data.Apellido)
            Cmd.Parameters.AddWithValue("@Sexo", Data.Sexo)
            Cmd.Parameters.AddWithValue("@DateB", Data.DateNaci)
            Cmd.Parameters.AddWithValue("@Iden", Data.Identi)
            Cmd.Parameters.AddWithValue("@Inss", Data.Inss)
            Cmd.Parameters.AddWithValue("@Addres", Data.Direc)
            Cmd.Parameters.AddWithValue("@Proyect", Data.CodeProyect)
            Cmd.Parameters.AddWithValue("@Turno", Data.CodeTurno)
            Cmd.Parameters.AddWithValue("@Cargo", Data.CodeCargo)
            Cmd.Parameters.AddWithValue("@SalarioBase", Data.CodeSalario)
            Cmd.Parameters.AddWithValue("@Photo", BytesToString(ImageToBytes(Data.Photo)))
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdInsertPhoneEmp(ByVal Data As CelEmployed) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPInsertPhoneEmployed", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Phone", Data.Tel)
            Cmd.Parameters.AddWithValue("@Employed", Data.CodeEmployed)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdInsertEmailEmp(ByVal Data As EmailEmployed) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPInsertEmailEmployed", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Email", Data.Email)
            Cmd.Parameters.AddWithValue("@Employed", Data.CodeEmployed)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdInsertProyect(ByVal Data As Proyect) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPInsertProyect", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Name", Data.Name)
            Cmd.Parameters.AddWithValue("@Presupuesto", Data.Presupuesto)
            Cmd.Parameters.AddWithValue("@DateInit", Data.DateStar)
            Cmd.Parameters.AddWithValue("@DateEnd", Data.DateEnd)
            Cmd.Parameters.AddWithValue("@Ubic", Data.Ubicacion)
            Cmd.Parameters.AddWithValue("@Desc", Data.Descripcion)
            Cmd.Parameters.AddWithValue("@Estate", Data.Estado)
            Cmd.Parameters.AddWithValue("@Client", Data.Cliente)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdUpdateProyect(ByVal Data As Proyect) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPUpdateProyect", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Name", Data.Name)
            Cmd.Parameters.AddWithValue("@Presupuesto", Data.Presupuesto)
            Cmd.Parameters.AddWithValue("@DateInit", Data.DateStar)
            Cmd.Parameters.AddWithValue("@DateEnd", Data.DateEnd)
            Cmd.Parameters.AddWithValue("@Ubic", Data.Ubicacion)
            Cmd.Parameters.AddWithValue("@Desc", Data.Descripcion)
            Cmd.Parameters.AddWithValue("@Estate", Data.Estado)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdInsertPrestamo(ByVal Data As Prestamo) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPInsertPrestamo", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Date", Data.DatePres)
            Cmd.Parameters.AddWithValue("@Monto", Data.Monto)
            Cmd.Parameters.AddWithValue("@Cuota", Data.Cuota)
            Cmd.Parameters.AddWithValue("@Saldo", Data.Saldo)
            Cmd.Parameters.AddWithValue("@Employed", Data.Employed)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdInsertAbono(ByVal Data As Abono) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPInsertAbono", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Date", Data.Date_Abono)
            Cmd.Parameters.AddWithValue("@Abono", Data.Abono)
            Cmd.Parameters.AddWithValue("@Prestamo", Data.Prestamo)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Sub CmdViewTurnos(ByRef DataGridViewTurn As GridPanel)
        Try
            Connect.Open()
            Cmd = New SqlCommand("Select * From ViewTurno", Connect)
            da = New SqlDataAdapter(Cmd)
            ds = New DataSet
            da.Fill(ds, "Turnos")
            DataGridViewTurn.DataSource = ds.Tables("Turnos")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
    Public Function CmdInsertClient(ByVal Data As Client) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPInsertClient", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Name", Data.Name)
            Cmd.Parameters.AddWithValue("@Ruc", Data.Ruc)
            Cmd.Parameters.AddWithValue("@Direccion", Data.Addres)
            Cmd.Parameters.AddWithValue("@Perfil", Data.Perfil)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdUpdateClient(ByVal Data As Client) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPUpdateClient", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Name", Data.Name)
            Cmd.Parameters.AddWithValue("@Ruc", Data.Ruc)
            Cmd.Parameters.AddWithValue("@Direccion", Data.Addres)
            Cmd.Parameters.AddWithValue("@Perfil", Data.Perfil)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdInsertPhoneClient(ByVal Data As PhoneClient) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPInsertPhoneClient", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Phone", Data.Phone)
            Cmd.Parameters.AddWithValue("@Client", Data.CodeClient)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdInsertEmailClient(ByVal Data As EmailClient) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPInsertEmailClient", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Email", Data.Email)
            Cmd.Parameters.AddWithValue("@Client", Data.CodeClient)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Sub CmdViewCargos(ByRef DataGridViewCargo As GridPanel)
        Try
            Connect.Open()
            Cmd = New SqlCommand("Select * From ViewCargo", Connect)
            da = New SqlDataAdapter(Cmd)
            ds = New DataSet
            da.Fill(ds, "Cargos")
            DataGridViewCargo.DataSource = ds.Tables("Cargos")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
    Public Sub CmdViewSalarios(ByRef DataGridViewSalario As GridPanel)
        Try
            Connect.Open()
            Cmd = New SqlCommand("Select * From ViewSalario", Connect)
            da = New SqlDataAdapter(Cmd)
            ds = New DataSet
            da.Fill(ds, "Salarios")
            DataGridViewSalario.DataSource = ds.Tables("Salarios")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
    Public Sub CmdViewEmployeds(ByRef DataGridViewEmployed As GridPanel)
        Try
            Connect.Open()
            Cmd = New SqlCommand("Select * From ViewEmployed", Connect)
            da = New SqlDataAdapter(Cmd)
            ds = New DataSet
            da.Fill(ds, "Employeds")
            DataGridViewEmployed.DataSource = ds.Tables("Employeds")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
    Public Sub CmdViewClients(ByRef DataGridViewClient As GridPanel)
        Try
            Connect.Open()
            Cmd = New SqlCommand("Select * From ViewClient", Connect)
            da = New SqlDataAdapter(Cmd)
            ds = New DataSet
            da.Fill(ds, "Clients")
            DataGridViewClient.DataSource = ds.Tables("Clients")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
    Public Sub CmdViewProyectOfClients(ByRef DataGridViewProyectOfClient As GridPanel, ByVal Code_Client As String)
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPProyectOfClient", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Code_Client)
            da = New SqlDataAdapter(Cmd)
            ds = New DataSet
            da.Fill(ds, "Proyectos")
            DataGridViewProyectOfClient.DataSource = ds.Tables("Proyectos")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub

    Public Sub CmdViewPrestamos(ByRef DataGridViewPrestamo As GridPanel)
        Try
            Connect.Open()
            Cmd = New SqlCommand("Select * From ViewPrestamos", Connect)
            da = New SqlDataAdapter(Cmd)
            ds = New DataSet
            da.Fill(ds, "Prestamos")
            DataGridViewPrestamo.DataSource = ds.Tables("Prestamos")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
    Public Sub CmdViewAbono(ByRef DataGridViewProyect As GridPanel, ByVal Code_Prestamo As String)
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPReadAbono", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code_Prestamo", Code_Prestamo)
            da = New SqlDataAdapter(Cmd)
            ds = New DataSet
            da.Fill(ds, "Abono")
            DataGridViewProyect.DataSource = ds.Tables("Abono")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
    Public Sub CmdViewProyect(ByRef DataGridViewProyect As GridPanel)
        Try
            Connect.Open()
            Cmd = New SqlCommand("Select * From ViewProyect", Connect)
            da = New SqlDataAdapter(Cmd)
            ds = New DataSet
            da.Fill(ds, "Proyectos")
            DataGridViewProyect.DataSource = ds.Tables("Proyectos")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
    Public Function CmdDeleteTurno(ByVal Data As Turno) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPDeleteTurno", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdDeleteCargo(ByVal Data As Cargo) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPDeleteCargo", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdDeleteSalario(ByVal Data As Salario) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPDeleteSalarioBase", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdDeleteEmployed(ByVal Data As Employed) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPDeleteEmployed", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdDeleteTelEmployed(ByVal Data As CelEmployed) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPDeleteTelEmployed", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdDeleteEmailEmployed(ByVal Data As EmailEmployed) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPDeleteEmailEmployed", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdDeleteClient(ByVal Data As Client) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPDeleteClient", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdDeleteTelClient(ByVal Data As PhoneClient) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPDeleteTelClient", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdDeleteEmailClient(ByVal Data As EmailClient) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPDeleteEmailClient", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdDeleteProyect(ByVal Data As Proyect) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPDeleteProyect", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdDeletePrestamo(ByVal Data As Prestamo) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPDeletePrestamo", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdDeleteAbono(ByVal Data As Abono) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPDeleteAbono", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdUpdateTurno(ByVal Data As Turno) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPUpdateTurno", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Name", Data.Name)
            Cmd.Parameters.AddWithValue("@H_Star", Data.HsStart)
            Cmd.Parameters.AddWithValue("@H_End", Data.HsEnd)
            If Cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdUpdateCarg(ByVal Data As Cargo) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPUpdateCarg", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Name", Data.Name)
            If Cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdUpdateSalario(ByVal Data As Salario) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPUpdateSalarioBase", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@SMensual", Data.SMensual)
            Cmd.Parameters.AddWithValue("@SQuincenal", Data.SQuincenal)
            Cmd.Parameters.AddWithValue("@SHora", Data.SHora)
            If Cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdUpdatePrestamo(ByVal Data As Prestamo) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPUpdatePrestamo", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Monto", Data.Monto)
            Cmd.Parameters.AddWithValue("@Cuota", Data.Cuota)
            If Cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdUpdateAbono(ByVal Data As Abono) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPUpdateAbono", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Abono", Data.Abono)
            If Cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdUpdatePhoneEmp(ByVal Data As CelEmployed) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPUpdateTelEmployed", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Tel", Data.Tel)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdUpdateEmailEmp(ByVal Data As EmailEmployed) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPUpdateEmailEmployed", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Email", Data.Email)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdUpdatePhoneClient(ByVal Data As PhoneClient) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPUpdateTelClient", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Tel", Data.Phone)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdUpdateEmailClient(ByVal Data As EmailClient) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPUpdateEmailClient", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            Cmd.Parameters.AddWithValue("@Email", Data.Email)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Function CmdLoadTurno(ByRef Caja As ComboBox) As Boolean
        Caja.Items.Clear()
        Try
            Dim Flag As Boolean = True
            Connect.Open()
            Cmd = New SqlCommand("SPLoadTurno", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            dr = Cmd.ExecuteReader
            Do While dr.Read
                Caja.Items.Add(dr.GetString(0))
            Loop
            Return Flag
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdLoadTurnoF(ByRef Caja As ComboBoxEx) As Boolean
        Caja.Items.Clear()
        Caja.Items.Add("Indiferente")
        Try
            Dim Flag As Boolean = True
            Connect.Open()
            Cmd = New SqlCommand("SPLoadTurno", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            dr = Cmd.ExecuteReader
            Do While dr.Read
                Caja.Items.Add(dr.GetString(0))
            Loop
            Return Flag
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdLoadTurnoP(ByRef Caja As ListBox) As Boolean
        Caja.Items.Clear()
        Caja.Items.Add("No Asignar")
        Try
            Dim Flag As Boolean = True
            Connect.Open()
            Cmd = New SqlCommand("SPLoadTurno", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            dr = Cmd.ExecuteReader
            Do While dr.Read
                Caja.Items.Add(dr.GetString(0))
            Loop
            Return Flag
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdLoadCarg(ByRef Caja As ListBox) As Boolean
        Caja.Items.Clear()
        Try
            Dim Flag As Boolean = True
            Connect.Open()
            Cmd = New SqlCommand("SPLoadCarg", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            dr = Cmd.ExecuteReader
            Do While dr.Read
                Caja.Items.Add(dr.GetString(0))
            Loop
            Return Flag
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdLoadCargP(ByRef Caja As ListBox) As Boolean
        Caja.Items.Clear()
        Caja.Items.Add("No Asignar")
        Try
            Dim Flag As Boolean = True
            Connect.Open()
            Cmd = New SqlCommand("SPLoadCarg", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            dr = Cmd.ExecuteReader
            Do While dr.Read
                Caja.Items.Add(dr.GetString(0))
            Loop
            Return Flag
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdLoadCarg(ByRef Caja As ComboBoxEx) As Boolean
        Caja.Items.Clear()
        Caja.Items.Add("Indiferente")
        Try
            Dim Flag As Boolean = True
            Connect.Open()
            Cmd = New SqlCommand("SPLoadCarg", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            dr = Cmd.ExecuteReader
            Do While dr.Read
                Caja.Items.Add(dr.GetString(0))
            Loop
            Return Flag
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdLoadSalario(ByRef Caja As ListBox) As Boolean
        Caja.Items.Clear()
        Try
            Dim Flag As Boolean = True
            Connect.Open()
            Cmd = New SqlCommand("SPLoadSalarioBase", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            dr = Cmd.ExecuteReader
            Do While dr.Read
                Caja.Items.Add(dr.GetValue(0).ToString)
            Loop
            Return Flag
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdLoadSalarioP(ByRef Caja As ListBox) As Boolean
        Caja.Items.Clear()
        Caja.Items.Add("No Asignar")
        Try
            Dim Flag As Boolean = True
            Connect.Open()
            Cmd = New SqlCommand("SPLoadSalarioBase", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            dr = Cmd.ExecuteReader
            Do While dr.Read
                Caja.Items.Add(dr.GetValue(0).ToString)
            Loop
            Return Flag
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdLoadProyect(ByRef Caja As ListBox) As Boolean
        Caja.Items.Clear()
        Try
            Dim Flag As Boolean = True
            Connect.Open()
            Cmd = New SqlCommand("SPLoadProyect", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            dr = Cmd.ExecuteReader
            Do While dr.Read
                Caja.Items.Add(dr.GetValue(0).ToString)
            Loop
            Caja.Items.Add("No Asignar")
            Return Flag
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdLoadProyectP(ByRef Caja As ListBox) As Boolean
        Caja.Items.Clear()
        Caja.Items.Add("No Asignar")
        Try
            Dim Flag As Boolean = True
            Connect.Open()
            Cmd = New SqlCommand("SPLoadProyect", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            dr = Cmd.ExecuteReader
            Do While dr.Read
                Caja.Items.Add(dr.GetValue(0).ToString)
            Loop
            Return Flag
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function

    Public Function CmdLoadClient(ByRef Caja As ComboBox) As Boolean
        Caja.Items.Clear()
        Try
            Dim Flag As Boolean = True
            Connect.Open()
            Cmd = New SqlCommand("SPLoadClient", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            dr = Cmd.ExecuteReader
            Do While dr.Read
                Caja.Items.Add(dr.GetValue(0).ToString)
            Loop
            Return Flag
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdDetailsPrestamo(ByRef Data As Prestamo) As Boolean
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPDetailsPrestamo", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            dr = Cmd.ExecuteReader
            If dr.Read Then
                Data.Employed = dr.GetValue(0).ToString
                Data.Monto = dr.GetValue(1).ToString
                Data.Saldo = dr.GetValue(2).ToString
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Sub CmdDetaillsEmp(ByRef Data As Employed)
        Dim Resultado As String = ""
        Dim Array As Byte() = Nothing
        Dim ArrayText()
        Dim Count As Integer = 0
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPPerfilEmployed", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            dr = Cmd.ExecuteReader
            Do While dr.Read
                Data.Name = dr.Item("Nombre")
                Data.Apellido = dr.Item("Apellido")
                Data.Identi = dr.Item("Cedula")
                Data.Inss = dr.Item("INSS")
                Data.Direc = dr.Item("Direccion")
                Data.DateNaci = dr.Item("Fecha")
                Data.Sexo = dr.Item("Sexo")
                Data.CodeTurno = dr.Item("Turno")
                Data.CodeProyect = dr.Item("Proyecto Asignado")
                Data.CodeCargo = dr.Item("Cargo")
                Data.CodeSalario = dr.Item("Salario Base")
                Resultado = dr.Item("Foto")
            Loop
            ArrayText = Resultado.Split(",")
            ReDim Array(ArrayText.Length - 1)
            For Count = 0 To ArrayText.Length - 1
                If ArrayText(Count).Equals("") = False Then
                    Array(Count) = ArrayText(Count)
                End If
            Next
            Data.Photo = BytesToImage(Array)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
    Public Sub CmdDetaillsClient(ByRef Data As Client)
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPPerfilClient", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            dr = Cmd.ExecuteReader
            Do While dr.Read
                Data.Name = dr.Item("Nombre del Cliente")
                Data.Ruc = dr.Item("N° Ruc")
                Data.Perfil = dr.Item("Mision Social")
                Data.Addres = dr.Item("Dirección")
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
    Public Sub CmdDetaillsProyect(ByRef Data As Proyect)
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPDetaillsProyect", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Data.Code)
            dr = Cmd.ExecuteReader
            Do While dr.Read
                Data.Code = dr.Item("Codigo")
                Data.Name = dr.Item("Nombre")
                Data.Cliente = dr.Item("Cliente")
                Data.Presupuesto = dr.Item("Presupuesto")
                Data.DateStar = dr.Item("Fecha de Inicio")
                Data.DateEnd = dr.Item("Fecha de Culminación")
                Data.Ubicacion = dr.Item("Ubicación")
                Data.Descripcion = dr.Item("Descripcion")
                Data.Estado = dr.Item("Estado")
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
    Public Sub CmdLoadEmployed(ByRef DataGrid As GridPanel)
        Try
            Connect.Open()
            Cmd = New SqlCommand("Exec SPLoadEmployed", Connect)
            da = New SqlDataAdapter(Cmd)
            ds = New DataSet
            da.Fill(ds, "Empleados")
            DataGrid.DataSource = ds.Tables("Empleados")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
    Public Sub CmdLoadClientSelect(ByRef DataGrid As GridPanel)
        Try
            Connect.Open()
            Cmd = New SqlCommand("Exec SPLoadClientSelect", Connect)
            da = New SqlDataAdapter(Cmd)
            ds = New DataSet
            da.Fill(ds, "Clients")
            DataGrid.DataSource = ds.Tables("Clients")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
    Public Sub CmdLoadProyectSelect(ByRef DataGrid As GridPanel)
        Try
            Connect.Open()
            Cmd = New SqlCommand("Exec SPLoadProyectSelect", Connect)
            da = New SqlDataAdapter(Cmd)
            ds = New DataSet
            da.Fill(ds, "Clients")
            DataGrid.DataSource = ds.Tables("Clients")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
    Public Sub CmdLoadPrestamoSelect(ByRef DataGrid As GridPanel)
        Try
            Connect.Open()
            Cmd = New SqlCommand("Exec SPLoadPrestamoSelect", Connect)
            da = New SqlDataAdapter(Cmd)
            ds = New DataSet
            da.Fill(ds, "Prestamo")
            DataGrid.DataSource = ds.Tables("Prestamo")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
    Public Sub CmdSearchEmployed(ByRef DataGrid As GridPanel, ByVal SearchFor As String,
                                 ByVal Clave As String, ByVal EdadMin As String, ByVal EdadMax As String,
                                 ByVal Sexo As String, ByVal Cargo As String, ByVal Turno As String)
        Try
            Connect.Open()
            Select Case SearchFor
                Case "Code"
                    Cmd = New SqlCommand("Select * from dbo.SearchEmployedForCode('" + Clave + "'," + EdadMin + "," +
                                         EdadMax + ",'" + Sexo + "','" + Cargo + "','" + Turno + "')", Connect)
                Case "Name"
                    Cmd = New SqlCommand("Select * from dbo.SearchEmployedForName('" + Clave + "'," + EdadMin + "," +
                                         EdadMax + ",'" + Sexo + "','" + Cargo + "','" + Turno + "')", Connect)
                Case "Iden"
                    Cmd = New SqlCommand("Select * from dbo.SearchEmployedForCedula('" + Clave + "'," + EdadMin + "," +
                                         EdadMax + ",'" + Sexo + "','" + Cargo + "','" + Turno + "')", Connect)
            End Select
            da = New SqlDataAdapter(Cmd)
            ds = New DataSet
            da.Fill(ds, "Employeds")
            DataGrid.DataSource = ds.Tables("Employeds")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
    Public Sub CmdSearchClient(ByRef DataGrid As GridPanel, ByVal SearchFor As String,
                                 ByVal Clave As String)
        Try
            Connect.Open()
            Select Case SearchFor
                Case "Code"
                    Cmd = New SqlCommand("Select * from dbo.SearchClientForCode('" + Clave + "')", Connect)
                Case "Name"
                    Cmd = New SqlCommand("Select * from dbo.SearchClientForName('" + Clave + "')", Connect)
                Case "Iden"
                    Cmd = New SqlCommand("Select * from dbo.SearchClientForIden('" + Clave + "')", Connect)
            End Select
            da = New SqlDataAdapter(Cmd)
            ds = New DataSet
            da.Fill(ds, "Clients")
            DataGrid.DataSource = ds.Tables("Clients")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
    Public Sub CmdSearchProyect(ByRef DataGrid As GridPanel, ByVal SearchFor As String,
                                ByVal Clave As String, ByVal Estado As String, ByVal DateInit_1 As Date,
                                ByVal DateInit_2 As Date, ByVal Case_1 As String, ByVal DateEnd_1 As Date,
                                ByVal DateEnd_2 As Date, ByVal Case_2 As String)
        Try
            Connect.Open()
            Select Case SearchFor
                Case "Code"
                    Cmd = New SqlCommand("Select * from dbo.SearchProyectForCode('" + Clave + "','" + Estado + "','" + DateInit_1 +
                                         "','" + DateInit_2 + "'," + Case_1 + ",'" + DateEnd_1 + "','" + DateEnd_2 + "'," + Case_2 +
                                         ")", Connect)
                Case "Name"
                    Cmd = New SqlCommand("Select * from dbo.SearchProyectForName('" + Clave + "','" + Estado + "','" + DateInit_1 +
                                         "','" + DateInit_2 + "'," + Case_1 + ",'" + DateEnd_1 + "','" + DateEnd_2 + "'," + Case_2 +
                                         ")", Connect)
                Case "Client"
                    Cmd = New SqlCommand("Select * from dbo.SearchProyectForClient('" + Clave + "','" + Estado + "','" + DateInit_1 +
                                         "','" + DateInit_2 + "'," + Case_1 + ",'" + DateEnd_1 + "','" + DateEnd_2 + "'," + Case_2 +
                                         ")", Connect)
            End Select
            da = New SqlDataAdapter(Cmd)
            ds = New DataSet
            da.Fill(ds, "Proyect")
            DataGrid.DataSource = ds.Tables("Proyect")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
    Public Sub CmdSearchPrestamo(ByRef DataGrid As GridPanel, ByVal SearchFor As String,
                                ByVal Clave As String)
        Try
            Connect.Open()
            Select Case SearchFor
                Case "Code"
                    Cmd = New SqlCommand("Select * from dbo.SearchPrestamoForCode('" + Clave + "')", Connect)
                Case "Employed"
                    Cmd = New SqlCommand("Select * from dbo.SearchPrestamoForEmployed('" + Clave + "')", Connect)
            End Select
            da = New SqlDataAdapter(Cmd)
            ds = New DataSet
            da.Fill(ds, "Prestamo")
            DataGrid.DataSource = ds.Tables("Prestamo")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub

    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Public Function CmdInsertPhoto(ByVal Code As String, ByVal Photo As String)
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPLoadPhoto", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Code)
            Cmd.Parameters.AddWithValue("@Photo", Photo)
            If Cmd.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdLoadPhoto(ByVal Code As String) As Byte()
        Dim Resultado As String = ""
        Dim Array As Byte() = Nothing
        Dim ArrayText()
        Dim Count As Integer = 0
        Try
            Connect.Open()
            Cmd = New SqlCommand("LoadPhotoForEmp", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Code)
            dr = Cmd.ExecuteReader
            Do While dr.Read
                Resultado = dr.Item("Foto")
            Loop

            ArrayText = Resultado.Split(",")
            ReDim Array(ArrayText.Length - 1)
            For Count = 0 To ArrayText.Length - 1
                If ArrayText(Count).Equals("") = False Then
                    Array(Count) = ArrayText(Count)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
        Return Array
    End Function
    Public Function CmdLoadNamePhoto(ByRef Caja As ComboBoxEx) As Boolean
        Caja.Items.Clear()
        'Caja.Items.Add("Indiferente")
        Try
            Dim Flag As Boolean = True
            Connect.Open()
            Cmd = New SqlCommand("LoadNamePhoto", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            dr = Cmd.ExecuteReader
            Do While dr.Read
                Caja.Items.Add(dr.GetString(0))
            Loop
            Return Flag
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Connect.Close()
        End Try
    End Function
    Public Function CmdNextCode(ByVal Proc As String) As String
        Dim Code As String = ""
        Try
            Connect.Open()
            Cmd = New SqlCommand(Proc, Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            dr = Cmd.ExecuteReader
            Do While dr.Read
                Code += dr.Item(0)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
        Return Code
    End Function
    Public Sub CmdViewContactsEmp(ByRef DataGridViewProyect As GridPanel, ByVal Code_Employed As String)
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPContactsEmp", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Code_Employed)
            da = New SqlDataAdapter(Cmd)
            ds = New DataSet
            da.Fill(ds, "Telefonos")
            DataGridViewProyect.DataSource = ds.Tables("Telefonos")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
    Public Sub CmdViewContactsEmp2(ByRef DataGridViewProyect As GridPanel, ByVal Code_Employed As String)
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPContactsEmp2", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Code_Employed)
            da = New SqlDataAdapter(Cmd)
            ds = New DataSet
            da.Fill(ds, "Emails")
            DataGridViewProyect.DataSource = ds.Tables("Emails")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
    Public Sub CmdViewContactsEmp3(ByRef DataGridViewProyect As GridPanel, ByVal Code_Client As String)
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPContactsEmp3", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Code_Client)
            da = New SqlDataAdapter(Cmd)
            ds = New DataSet
            da.Fill(ds, "Telefonos")
            DataGridViewProyect.DataSource = ds.Tables("Telefonos")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
    Public Sub CmdViewContactsEmp4(ByRef DataGridViewProyect As GridPanel, ByVal Code_Client As String)
        Try
            Connect.Open()
            Cmd = New SqlCommand("SPContactsEmp4", Connect)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("@Code", Code_Client)
            da = New SqlDataAdapter(Cmd)
            ds = New DataSet
            da.Fill(ds, "Emails")
            DataGridViewProyect.DataSource = ds.Tables("Emails")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub

End Module
