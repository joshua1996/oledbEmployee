Public Class Form2
    Dim c2 As New Class2
    Dim c3 As New Class3
    Dim isUpdate As Boolean
    Public form2EmployedId As String
    Dim idDel As Integer

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        employeeFill()
        Panel2.Enabled = False
        Panel3.Visible = False
    End Sub

    Public Sub employeeFill()
        Try
            c3 = c2.c2EmployeeFill
            DataGridView1.DataSource = c3.c3Dt


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Dim rightindex As Integer = DataGridView1.HitTest(e.X, e.Y).RowIndex
            If rightindex >= 0 Then
                DataGridView1.CurrentCell = DataGridView1.Rows(rightindex).Cells(0)
                ContextMenuStrip1.Show(DataGridView1, e.X, e.Y)

            End If
        End If
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged
        TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value
        TextBox3.Text = DataGridView1.CurrentRow.Cells(3).Value
        TextBox4.Text = DataGridView1.CurrentRow.Cells(4).Value
        TextBox5.Text = DataGridView1.CurrentRow.Cells(5).Value
        TextBox6.Text = DataGridView1.CurrentRow.Cells(6).Value
        TextBox7.Text = DataGridView1.CurrentRow.Cells(7).Value
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Panel1.Enabled = False
        DataGridView1.Enabled = False
        Panel2.Enabled = True
        Panel3.Visible = True
        For Each a As TextBox In Panel2.Controls
            a.Text = ""
        Next
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Panel1.Enabled = False
        DataGridView1.Enabled = False
        Panel2.Enabled = True
        Panel3.Visible = True
        isUpdate = True

    End Sub

  

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Panel1.Enabled = True
        DataGridView1.Enabled = True
        Panel2.Enabled = False
        Panel3.Visible = False

        If isUpdate = True Then
            employeeUpd()
        Else
            employeeInsr()
            salaryInsr()
            leaveInsr()
            employeeLoginInsr()
        End If
        employeeFill()
        isUpdate = False
    End Sub

    Private Sub employeeLoginInsr()
        Try
            Dim employeeid As String = TextBox1.Text
            Dim password As String = ""
            c3 = c2.c2EmployeeLoginInsr(employeeid, password)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub leaveInsr()
        Try
            Dim employeeid As String = TextBox1.Text

            c3 = c2.c2LeaveInsr(employeeid)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub salaryInsr()
        Try
            Dim employeeid As String = TextBox1.Text
            Dim salary As String = ""
            c3 = c2.c2SalaryInsr(employeeid, salary)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub employeeUpd()
        Try
            Dim employeeid As String = TextBox1.Text
            Dim names As String = TextBox2.Text
            Dim age As String = TextBox3.Text
            Dim ic As String = TextBox4.Text
            Dim address As String = TextBox5.Text
            Dim email As String = TextBox6.Text
            Dim phone As String = TextBox7.Text
            Dim id As Integer = DataGridView1.CurrentRow.Cells(0).Value
            c3 = c2.c2EmployeeUpd(employeeid, names, age, ic, address, email, phone, id)
            If c3.c3B = True Then
                MsgBox("update")
            Else
                MsgBox(False)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub employeeInsr()
        Try
            Dim employeeid As String = TextBox1.Text
            Dim names As String = TextBox2.Text
            Dim age As String = TextBox3.Text
            Dim ic As String = TextBox4.Text
            Dim address As String = TextBox5.Text
            Dim email As String = TextBox6.Text
            Dim phone As String = TextBox7.Text
            c3 = c2.c2EmployeeInsr(employeeid, names, age, ic, address, email, phone)
            If c3.c3B = True Then
                MsgBox("save")
            Else
                MsgBox(False)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Panel1.Enabled = True
        DataGridView1.Enabled = True
        Panel2.Enabled = False
        Panel3.Visible = False
    End Sub

    Private Sub SalaryToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalaryToolStripMenuItem.Click
        form2EmployedId = DataGridView1.CurrentRow.Cells(1).Value
        Form3.Show()
    End Sub



    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Close()
        Form1.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        employeeLoginDel()
        leaveDel()
        salaryDel()
        employeeDel()
        employeeFill()
    End Sub

    Private Sub employeeLoginDel()
        Try
            Dim id As String = DataGridView1.CurrentRow.Cells(1).Value
            c3 = c2.c2EmployeeLoginDel(id)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub leaveDel()
        Try
            Dim id As String = DataGridView1.CurrentRow.Cells(1).Value
            c3 = c2.c2LeaveDel(id)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub salaryDel()
        Try
            Dim id As String = DataGridView1.CurrentRow.Cells(1).Value
            c3 = c2.c2SalaryDel(id)
            If c3.c3B = True Then
                MsgBox("delete")
            Else
                ' MsgBox(False)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub employeeDel()
        Try
            Dim id As Integer = DataGridView1.CurrentRow.Cells(0).Value
            c3 = c2.c2EmployeeDel(id)
            If c3.c3B = True Then
                ' MsgBox("delete")
            Else
                ' MsgBox(False)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LeaveRecordToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles LeaveRecordToolStripMenuItem.Click
        form2EmployedId = DataGridView1.CurrentRow.Cells(1).Value
        Form4.ShowDialog()
    End Sub

   
    Private Sub RegisterToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles RegisterToolStripMenuItem1.Click
        form2EmployedId = DataGridView1.CurrentRow.Cells(1).Value
        Form5.ShowDialog()
    End Sub
End Class