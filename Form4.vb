Public Class Form4

    Dim c2 As New Class2
    Dim c3 As New Class3

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        leaveFill()
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub leaveFill()
        Try
            Dim employeeid As String = Form2.form2EmployedId
            c3 = c2.c2LeaveFill(employeeid)
            DataGridView1.DataSource = c3.c3Dt
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class