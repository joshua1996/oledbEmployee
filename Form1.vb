Public Class Form1
    Dim c3 As New Class3
    Dim c2 As New Class2
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        adminLogin()
    End Sub

    Private Sub adminLogin()
        Try
            Dim adminid As String = TextBox1.Text
            Dim password As String = TextBox2.Text
            c3 = c2.c2AdminLogin(adminid, password)
            If c3.c3B = True Then
                Me.Hide()
                Form2.Show()
            Else
                Me.Hide()
                Form2.Show()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form6.Show()

    End Sub
End Class
