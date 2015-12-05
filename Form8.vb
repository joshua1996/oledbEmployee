Public Class Form8
    Dim c2 As New Class2
    Dim c3 As New Class3
    Dim isUpd As Boolean
    Private Sub Form8_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        adminFill()
        Panel2.Visible = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False

    End Sub

    Private Sub adminFill()
        Try
            c3 = c2.c2AdminFill
            DataGridView1.DataSource = c3.c3Dt
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged
        TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        DataGridView1.Enabled = False
        Panel2.Visible = True
        Panel1.Enabled = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Enabled = True
        TextBox2.Enabled = True

    End Sub

    Private Sub adminInsr()
        Try
            Dim adminid As String = TextBox1.Text
            Dim password As String = TextBox2.Text
            c3 = c2.c2AdminInsr(adminid, password)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        DataGridView1.Enabled = True
        Panel2.Visible = False
        Panel1.Enabled = True
        If isUpd = True Then
            adminUpd()
            adminFill()
        Else
            adminInsr()
            adminFill()
        End If
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        isUpd = False
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        isUpd = True
        DataGridView1.Enabled = False
        Panel2.Visible = True
        Panel1.Enabled = False
        TextBox1.Enabled = True
        TextBox2.Enabled = True
    End Sub

    Private Sub adminUpd()
        Try
            Dim adminid As String = TextBox1.Text
            Dim password As String = TextBox2.Text
            Dim id As Integer = DataGridView1.CurrentRow.Cells(0).Value
            c3 = c2.c2AdminUpd(adminid, password, id)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        DataGridView1.Enabled = True
        Panel2.Visible = False
        Panel1.Enabled = True
        TextBox1.Enabled = False
        TextBox2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        adminDel()
        adminFill()

    End Sub

    Private Sub adminDel()
        Try
            Dim adminid As String = DataGridView1.CurrentRow.Cells(1).Value
            c3 = c2.c2AdminDel(adminid)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class