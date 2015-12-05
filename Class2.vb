Public Class Class2
    Dim c3 As New Class3
    Dim c1 As New Class1

#Region "admin login"
    Public Function c2AdminLogin(ByVal adminid As String, ByVal password As String) As Class3
        Try
            c3 = c1.c1AdminLogin(adminid, password)
            If c3.c3Dt.Rows.Count > 0 Then
                c3.c3B = True
            Else
                c3.c3B = False
            End If
            Return c3
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "employee fill"
    Public Function c2EmployeeFill() As Class3
        Try
            c3 = c1.c1EmployeeFill()
            If c3.c3Dt.Rows.Count > 0 Then
                c3.c3B = True
            Else
                c3.c3B = False
            End If
            Return c3
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "employee insert"
    Public Function c2EmployeeInsr(ByVal employeeId As String, ByVal name As String, ByVal age As String, ByVal ic As String, ByVal address As String, ByVal email As String, ByVal phone As String) As Class3
        Try
            c3 = c1.c1EmployeeInsr(employeeId, name, age, ic, address, email, phone)
            c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region
#Region "employee upd"
    Public Function c2EmployeeUpd(ByVal employeeId As String, ByVal name As String, ByVal age As String, ByVal ic As String, ByVal address As String, ByVal email As String, ByVal phone As String, ByVal id As Integer) As Class3
        Try
            c3 = c1.c1EmployeeUpd(employeeId, name, age, ic, address, email, phone, id)
            c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "employee del"
    Public Function c2EmployeeDel(ByVal id As Integer) As Class3
        Try
            c3 = c1.c1EmployeeDel(id)
            c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "salary insert"
    Public Function c2SalaryInsr(ByVal employeeId As String, ByVal salary As String) As Class3
        Try
            c3 = c1.c1SalaryInsr(employeeId, salary)
            c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "salary fill"
    Public Function c2SalaryFill(ByVal employeeId As String) As Class3
        Try
            c3 = c1.c1SalaryFill(employeeId)
            If c3.c3Dt.Rows.Count > 0 Then
                c3.c3B = True
            Else
                c3.c3B = False
            End If
            Return c3
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "leave fill"
    Public Function c2LeaveFill(ByVal employeeId As String) As Class3
        Try
            c3 = c1.c1LeaveFill(employeeId)
            If c3.c3Dt.Rows.Count > 0 Then
                c3.c3B = True
            Else
                c3.c3B = False
            End If
            Return c3
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "employee login fill"
    Public Function c2EmployeeLoginFill(ByVal employeeId As String) As Class3
        Try
            c3 = c1.c1EmployeeLoginFill(employeeId)
            If c3.c3Dt.Rows.Count > 0 Then
                c3.c3B = True
            Else
                c3.c3B = False
            End If
            Return c3
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "leave insert"
    Public Function c2LeaveInsr(ByVal employeeId As String) As Class3
        Try
            c3 = c1.c1LeaveInsr(employeeId)
            c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "employee login insert"
    Public Function c2EmployeeLoginInsr(ByVal employeeId As String, ByVal password As String) As Class3
        Try
            c3 = c1.c1EmployeeLoginInsr(employeeId, password)
            c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "salary del"
    Public Function c2SalaryDel(ByVal employeeid As String) As Class3
        Try
            c3 = c1.c1SalaryDel(employeeid)
            c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "leave del"
    Public Function c2LeaveDel(ByVal employeeid As String) As Class3
        Try
            c3 = c1.c1LeaveDel(employeeid)
            c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "employee login del"
    Public Function c2EmployeeLoginDel(ByVal employeeid As String) As Class3
        Try
            c3 = c1.c1EmployeeLoginDel(employeeid)
            c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "salary upd"
    Public Function c2SalaryUpd(ByVal salary As String, ByVal id As Integer) As Class3
        Try
            c3 = c1.c1SalaryUpd(salary, id)
            c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "leave upd"
    Public Function c2LeaveUpd(ByVal leavedate As Date, ByVal id As Integer) As Class3
        Try
            c3 = c1.c1LeaveUpd(leavedate, id)
            c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

#Region "employeelogin upd"
    Public Function c2EmployeeLoginUpd(ByVal password As String, ByVal id As Integer) As Class3
        Try
            c3 = c1.c1EmployeeLoginUpd(password, id)
            c3.c3B = True
            Return c3
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region
End Class
