Public Class Form3
    Dim c2 As New Class2
    Dim c3 As New Class3

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        salaryFill()
    End Sub
    Private Sub salaryFill()
        Try
            Dim employeeId As String = Form2.form2EmployedId
            c3 = c2.c2SalaryFill(employeeId)
            DataGridView1.DataSource = c3.c3Dt
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

    End Sub
End Class