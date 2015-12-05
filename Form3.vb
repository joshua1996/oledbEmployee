Public Class Form3
    Dim c2 As New Class2
    Dim c3 As New Class3

    Private Sub Form3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Panel2.Enabled = False
        Panel3.Visible = False
        salaryFill()
        TextBox1.Enabled = False
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
        salaryUpd()
        salaryFill()
        Panel1.Enabled = True
        Panel2.Enabled = False
        Panel3.Visible = False
        DataGridView1.Enabled = True
    End Sub

    Private Sub salaryUpd()
        Try
            Dim salary As String = TextBox2.Text
            Dim id As Integer = DataGridView1.CurrentRow.Cells(0).Value
            c3 = c2.c2SalaryUpd(salary, id)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Panel1.Enabled = False
        Panel2.Enabled = True
        Panel3.Visible = True
        DataGridView1.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Panel1.Enabled = True
        Panel2.Enabled = False
        Panel3.Visible = False
        DataGridView1.Enabled = True
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged
        TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value
    End Sub
End Class