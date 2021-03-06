﻿Imports System.Data.OleDb


Public Class Class1
    Dim c3 As New Class3
    Dim connection As String = ("provider=microsoft.ace.oledb.12.0;data source=oledbemployee.accdb;")
    Dim connect As New OleDbConnection(connection)

#Region "admin login"
    Public Function c1AdminLogin(ByVal adminid As String, ByVal password As String) As Class3
        Try
            connect.Open()
            Dim c1Adp As New OleDbDataAdapter("select * from adminlogin where adminid='" + adminid + "' and password='" + password + "'", connect)
            Dim c1Dt As New DataTable
            c1Adp.Fill(c1Dt)
            c3.c3Dt = c1Dt
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "employee fill"
    Public Function c1EmployeeFill() As Class3
        Try
            connect.Open()
            Dim c1Adp As New OleDbDataAdapter("select * from employeeinfo ", connect)
            Dim c1Dt As New DataTable
            c1Adp.Fill(c1Dt)
            c3.c3Dt = c1Dt
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "employee insr "
    Public Function c1EmployeeInsr(ByVal employeeId As String, ByVal name As String, ByVal age As String, ByVal ic As String, ByVal address As String, ByVal email As String, ByVal phone As String) As Class3
        Try
            connect.Open()
            Dim c1Cmd As New OleDbCommand("insert into employeeinfo (employeeid,[names],age,ic,address,email,phone) values (@employeeid,@names,@age,@ic,@address,@email,@phone) ", connect)
            c1Cmd.Parameters.AddWithValue("@employeeid", employeeId)
            c1Cmd.Parameters.AddWithValue("@names", name)
            c1Cmd.Parameters.AddWithValue("@age", age)
            c1Cmd.Parameters.AddWithValue("@ic", ic)
            c1Cmd.Parameters.AddWithValue("@address", address)
            c1Cmd.Parameters.AddWithValue("@email", email)
            c1Cmd.Parameters.AddWithValue("@phone", phone)
            c1Cmd.ExecuteNonQuery()
            '  c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "employee upd "
    Public Function c1EmployeeUpd(ByVal employeeId As String, ByVal name As String, ByVal age As String, ByVal ic As String, ByVal address As String, ByVal email As String, ByVal phone As String, ByVal id As Integer) As Class3
        Try
            connect.Open()
            Dim c1Cmd As New OleDbCommand("update employeeinfo set employeeid=@employeeid,[names]=@names,age=@age,ic=@ic,address=@address,email=@email,phone=@phone where id=@id", connect)
            c1Cmd.Parameters.AddWithValue("@employeeid", employeeId)
            c1Cmd.Parameters.AddWithValue("@names", name)
            c1Cmd.Parameters.AddWithValue("@age", age)
            c1Cmd.Parameters.AddWithValue("@ic", ic)
            c1Cmd.Parameters.AddWithValue("@address", address)
            c1Cmd.Parameters.AddWithValue("@email", email)
            c1Cmd.Parameters.AddWithValue("@phone", phone)
            c1Cmd.Parameters.AddWithValue("@id", id)
            c1Cmd.ExecuteNonQuery()
            '  c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "employee delete "
    Public Function c1EmployeeDel(ByVal id As Integer) As Class3
        Try
            connect.Open()
            Dim c1Cmd As New OleDbCommand("delete from employeeinfo where id=@id ", connect)
            c1Cmd.Parameters.AddWithValue("@id", id)
            c1Cmd.ExecuteNonQuery()
            '  c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "salary insr "
    Public Function c1SalaryInsr(ByVal employeeId As String, ByVal salary As String) As Class3
        Try
            connect.Open()
            Dim c1Cmd As New OleDbCommand("insert into salary (employeeid,salary) values (@employeeid,@salary)", connect)
            c1Cmd.Parameters.AddWithValue("@employeeid", employeeId)
            c1Cmd.Parameters.AddWithValue("@salary", salary)
            c1Cmd.ExecuteNonQuery()
            '  c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "salary fill"
    Public Function c1SalaryFill(ByVal employeeid As String) As Class3
        Try
            connect.Open()
            Dim c1Adp As New OleDbDataAdapter("select * from salary where employeeid='" + employeeid + "'", connect)
            Dim c1Dt As New DataTable
            c1Adp.Fill(c1Dt)
            c3.c3Dt = c1Dt
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "leave fill"
    Public Function c1LeaveFill(ByVal employeeid As String) As Class3
        Try
            connect.Open()
            Dim c1Adp As New OleDbDataAdapter("select * from leave where employeeid='" + employeeid + "'", connect)
            Dim c1Dt As New DataTable
            c1Adp.Fill(c1Dt)
            c3.c3Dt = c1Dt
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "employeelogin fill"
    Public Function c1EmployeeLoginFill(ByVal employeeid As String) As Class3
        Try
            connect.Open()
            Dim c1Adp As New OleDbDataAdapter("select * from employeelogin where employeeid='" + employeeid + "'", connect)
            Dim c1Dt As New DataTable
            c1Adp.Fill(c1Dt)
            c3.c3Dt = c1Dt
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "leave insr "
    Public Function c1LeaveInsr(ByVal employeeId As String) As Class3
        Try
            connect.Open()
            Dim c1Cmd As New OleDbCommand("insert into leave (employeeid,leavedate) values (@employeeid,null)", connect)
            c1Cmd.Parameters.AddWithValue("@employeeid", employeeId)
            ' c1Cmd.Parameters.AddWithValue("@leavedate", leave)
            c1Cmd.ExecuteNonQuery()
            '  c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "employee login insr "
    Public Function c1EmployeeLoginInsr(ByVal employeeId As String, ByVal password As String) As Class3
        Try
            connect.Open()
            Dim c1Cmd As New OleDbCommand("insert into employeelogin (employeeid,[password]) values (@employeeid,@password)", connect)
            c1Cmd.Parameters.AddWithValue("@employeeid", employeeId)
            c1Cmd.Parameters.AddWithValue("@password", password)
            c1Cmd.ExecuteNonQuery()
            '  c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "salary delete "
    Public Function c1SalaryDel(ByVal employeeid As String) As Class3
        Try
            connect.Open()
            Dim c1Cmd As New OleDbCommand("delete from salary where employeeid=@employeeid ", connect)
            c1Cmd.Parameters.AddWithValue("@employeeid", employeeid)
            c1Cmd.ExecuteNonQuery()
            '  c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "leave delete "
    Public Function c1LeaveDel(ByVal employeeid As String) As Class3
        Try
            connect.Open()
            Dim c1Cmd As New OleDbCommand("delete from leave where employeeid=@employeeid ", connect)
            c1Cmd.Parameters.AddWithValue("@employeeid", employeeid)
            c1Cmd.ExecuteNonQuery()
            '  c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "employee login delete "
    Public Function c1EmployeeLoginDel(ByVal employeeid As String) As Class3
        Try
            connect.Open()
            Dim c1Cmd As New OleDbCommand("delete from employeeLogin where employeeid=@employeeid ", connect)
            c1Cmd.Parameters.AddWithValue("@employeeid", employeeid)
            c1Cmd.ExecuteNonQuery()
            '  c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "salary upd "
    Public Function c1SalaryUpd(ByVal salary As String, ByVal id As Integer) As Class3
        Try
            connect.Open()
            Dim c1Cmd As New OleDbCommand("update salary set salary=@salary where id=@id", connect)
            c1Cmd.Parameters.AddWithValue("@salary", salary)
            c1Cmd.Parameters.AddWithValue("@id", id)
            c1Cmd.ExecuteNonQuery()
            '  c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "leave upd "
    Public Function c1LeaveUpd(ByVal leavedate As Date, ByVal id As Integer) As Class3
        Try
            connect.Open()
            Dim c1Cmd As New OleDbCommand("update leave set leavedate=@leavedate where id=@id", connect)
            c1Cmd.Parameters.AddWithValue("@leavedate", leavedate)
            c1Cmd.Parameters.AddWithValue("@id", id)
            c1Cmd.ExecuteNonQuery()
            '  c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "employeeLogin upd "
    Public Function c1EmployeeLoginUpd(ByVal password As String, ByVal id As Integer) As Class3
        Try
            connect.Open()
            Dim c1Cmd As New OleDbCommand("update employeelogin set [password]=@password where id=@id", connect)
            c1Cmd.Parameters.AddWithValue("@password", password)
            c1Cmd.Parameters.AddWithValue("@id", id)
            c1Cmd.ExecuteNonQuery()
            '  c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "employee login"
    Public Function c1EmployeeLogin(ByVal employeeid As String, ByVal password As String) As Class3
        Try
            connect.Open()
            Dim c1Adp As New OleDbDataAdapter("select * from employeelogin where employeeid='" + employeeid + "' and password='" + password + "'", connect)
            Dim c1Dt As New DataTable
            c1Adp.Fill(c1Dt)
            c3.c3Dt = c1Dt
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "admin login insr "
    Public Function c1AdminLoginInsr(ByVal adminid As String, ByVal password As String) As Class3
        Try
            connect.Open()
            Dim c1Cmd As New OleDbCommand("insert into adminlogin (adminid,[password]) values (@adminid,@password)", connect)
            c1Cmd.Parameters.AddWithValue("@adminid", adminid)
            c1Cmd.Parameters.AddWithValue("@password", password)
            c1Cmd.ExecuteNonQuery()
            '  c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "admin fill"
    Public Function c1AdminFill() As Class3
        Try
            connect.Open()
            Dim c1Adp As New OleDbDataAdapter("select * from adminlogin", connect)
            Dim c1Dt As New DataTable
            c1Adp.Fill(c1Dt)
            c3.c3Dt = c1Dt
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "admin insr "
    Public Function c1AdminInsr(ByVal adminid As String, ByVal password As String) As Class3
        Try
            connect.Open()
            Dim c1Cmd As New OleDbCommand("insert into adminlogin (adminid,[password]) values (@adminid,@password)", connect)
            c1Cmd.Parameters.AddWithValue("@adminid", adminid)
            c1Cmd.Parameters.AddWithValue("@password", password)
            ' c1Cmd.Parameters.AddWithValue("@leavedate", leave)
            c1Cmd.ExecuteNonQuery()
            '  c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "admin upd "
    Public Function c1AdminUpd(ByVal adminid As String, ByVal password As String, ByVal id As Integer) As Class3
        Try
            connect.Open()
            Dim c1Cmd As New OleDbCommand("update adminlogin set adminid=@adminid,[password]=@password where id=@id", connect)
            c1Cmd.Parameters.AddWithValue("@adminid", adminid)
            c1Cmd.Parameters.AddWithValue("@password", password)
            c1Cmd.Parameters.AddWithValue("@id", id)
            c1Cmd.ExecuteNonQuery()
            '  c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

#Region "admin delete "
    Public Function c1AdminDel(ByVal adminid As String) As Class3
        Try
            connect.Open()
            Dim c1Cmd As New OleDbCommand("delete from adminlogin where adminid=@adminid ", connect)
            c1Cmd.Parameters.AddWithValue("@adminid", adminid)
            c1Cmd.ExecuteNonQuery()
            '  c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        Finally
            connect.Close()
        End Try
    End Function
#End Region

End Class
