Public Class Form5
    Dim c2 As New Class2
    Dim c3 As New Class3
    Private Sub Form5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        employeeLoginFill()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub employeeLoginFill()
        Try
            Dim employeeid As String = Form2.form2EmployedId
            c3 = c2.c2EmployeeLoginFill(employeeid)
            DataGridView1.DataSource = c3.c3Dt
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class