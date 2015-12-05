Public Class Form6
    Dim c2 As New Class2
    Dim c3 As New Class3
    Public form6Id As String
    Private Sub Form6_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        employeeLogin()
    End Sub

    Private Sub employeeLogin()
        Try
            Dim employeeid As String = TextBox1.Text
            Dim password As String = TextBox2.Text
            c3 = c2.c2EmployeeLogin(employeeid, password)
            If c3.c3B = True And password <> "" Then

                form6Id = TextBox1.Text
                Me.Hide()
                Form7.Show()
            Else
                MsgBox(False)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class