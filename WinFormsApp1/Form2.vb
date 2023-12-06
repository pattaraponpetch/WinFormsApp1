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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Hide()
        Form4.Show()
    End Sub
End Class