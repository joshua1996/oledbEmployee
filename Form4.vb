Public Class Form4

    Dim c2 As New Class2
    Dim c3 As New Class3

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        leaveFill()
        Panel3.Visible = False
        TextBox1.Enabled = False
        DateTimePicker1.Enabled = False
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

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        DataGridView1.Enabled = False
        Panel3.Visible = True
        DateTimePicker1.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        leaveUpd()
        leaveFill()
        Panel3.Visible = False
        DataGridView1.Enabled = False
        DateTimePicker1.Enabled = False
    End Sub

    Private Sub leaveUpd()
        Try
            Dim leavedate As Date = DateTimePicker1.Value
            Dim id As Integer = DataGridView1.CurrentRow.Cells(0).Value
            c3 = c2.c2LeaveUpd(leavedate, id)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class