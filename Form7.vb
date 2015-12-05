Public Class Form7
    Dim c2 As New Class2
    Dim c3 As New Class3
    Private Sub Form7_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MsgBox(Form6.form6Id)
        salaryFill()
        leaveFill()
    End Sub

    Private Sub salaryFill()
        Try
            c3 = c2.c2SalaryFill(Form6.form6Id)
            Label1.Text = c3.c3Dt.Rows(0).Item("salary").ToString
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub leaveFill()
        Try
            c3 = c2.c2LeaveFill(Form6.form6Id)
            Label2.Text = CDate(c3.c3Dt.Rows(0).Item("leavedate")).Date
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class