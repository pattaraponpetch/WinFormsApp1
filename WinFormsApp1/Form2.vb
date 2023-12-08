Public Class Form2
    Private Sub ButtonEditProfile_Click(sender As Object, e As EventArgs) Handles ButtonEditProfile.Click
        Hide()
        Form3.Show()
        Form3.LabelEmail.Text = LabelEmail.Text
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ButtonRank_Click(sender As Object, e As EventArgs) Handles ButtonRank.Click
        Hide()
        Form4.Show()
    End Sub
    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles ButtonLogout.Click
        Hide()
        Form1.Show()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class