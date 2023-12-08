Imports System.Data
Imports System.Data.SqlClient

Module Module1
    Friend cn As New SqlConnection("Data source=localhost;Initial Catalog=Marathon;Integrated Security=SSPI;")
    Friend cmd As New SqlCommand
    Friend da As New SqlDataAdapter
    Friend dt As DataTable
    Friend ds As New DataSet
    Friend DR As SqlDataReader
    Friend sql As String = ""
    Friend Sub connect()
        If cn.State = ConnectionState.Closed Then
            MessageBox.Show("Connect")
            cn.Open()
        Else : MessageBox.Show("Not Connect")
        End If
    End Sub
    Friend Sub Country()
        sql = "SELECT * FROM Country"
        cmd = New SqlCommand(sql, cn)
        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
    End Sub

    Friend Sub Gender()
        sql = "SELECT * FROM Gender"
        cmd = New SqlCommand(sql, cn)
        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
    End Sub
    Friend Sub Rank()
        sql = "SELECT * FROM Rank"
        cmd = New SqlCommand(sql, cn)
        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)

    End Sub
    Friend Function cmd_excuteNonqueryUpdete() As Integer
        cmd = New SqlCommand(sql, cn)
        Try
            cmd.ExecuteNonQuery()
            Return 1
        Catch ex As Exception
            Debug.Print(ex.Message)
            Debug.Print("Error =>" + ex.Message)
            Return 0

        End Try

    End Function
End Module