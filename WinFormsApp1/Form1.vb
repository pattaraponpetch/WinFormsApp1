Imports System.Data.SqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        sql = String.Format("SELECT * FROM Users WHERE Email = '{0}' AND Password = '{1}';",
        TextBoxEmail.Text, TextBoxPassword.Text)
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet()
        da.Fill(ds, "Users")
        If ds.Tables("Users").Rows.Count <= 0 Then
            MessageBox.Show("Login Failed")
            TextBoxEmail.Text = ""
            TextBoxPassword.Text = ""
            Return
        Else
            MessageBox.Show("Login Success")
            Me.Hide()
            Form2.Show()
            Form2.LabelEmail.Text = TextBoxEmail.Text
            Form2.LabelPassword.Text = TextBoxPassword.Text
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Hide()
        Form5.Show()
    End Sub
End Class
