Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class Form4
    Private bind As BindingSource

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Assuming cn is your SqlConnection instance, make sure to open the connection.

        lblProfile.Text = Form2.LabelEmail.Text

        ' Use String.Format with parameters to build the SQL query
        sql = String.Format("SELECT MarathonName, EventName, EventTypeName, RaceTime, Cost FROM Rank WHERE Email = '{0}'", lblProfile.Text)
        cmd = New SqlCommand(sql, cn)
        da = New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        bind = New BindingSource()

        da.Fill(ds, "Rank")
        bind.DataSource = ds.Tables("Rank")

        If ds.Tables("Rank").Rows.Count > 0 Then
            dtgrank.DataSource = ds.Tables("Rank")
            Label2.Text = ""
            Label3.Text = ""
            Label4.Text = ""

            ' Use a For Each loop to iterate through columns
            For i As Integer = 0 To ds.Tables("Rank").Columns.Count - 1
                Label2.Text += ds.Tables("Rank").Rows(0).Item(i).ToString + vbTab
                Label3.Text += ds.Tables("Rank").Rows(0).Item(i).ToString + vbTab

                ' Add other columns as needed
            Next
        End If


        MessageBox.Show("Data set successfully.")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Form2.Show()
    End Sub

    Private Sub dtgrank_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgrank.CellContentClick

    End Sub
End Class