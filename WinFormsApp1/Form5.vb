Imports System.Data.SqlClient

Public Class Form5


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Country()
        sql = "SELECT * FROM Country"
        cmd = New SqlCommand(sql, cn)
        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
        ComboBoxCountry.DataSource = dt
        ComboBoxCountry.DisplayMember = dt.Columns.Item("CountryName").ColumnName
        ComboBoxCountry.SelectedItem = dt.Columns.Item("CountryCode").ColumnName

        'Gender()
        sql = "SELECT * FROM Gender"
        cmd = New SqlCommand(sql, cn)
        da = New SqlDataAdapter(cmd)
        dt = New DataTable
        da.Fill(dt)
        ComboBoxGender.DataSource = dt
        ComboBoxGender.DisplayMember = dt.Columns.Item("Gender").ColumnName
        ComboBoxGender.SelectedItem = dt.Columns.Item("Gender").ColumnName
        ButtonRegisterfrom.Enabled = False
    End Sub



    Private Sub ButtonRegister_Click_1(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        If TextBoxEmail.Text <> "" And
            TextBoxFirstName.Text <> "" And
            TextBoxLastName.Text <> "" And
            TextBoxRePassword.Text <> "" And
            TextBoxRePassword.Text Then
            Try
                sql = String.Format("USE Marathon;
                INSERT INTO Users 
                    (Email,Password,FirstName,LastName,RoleId)
                VALUES
                ('{0}','{1}','{2}','{3}','R');
                ", TextBoxEmail.Text, TextBoxRePassword.Text, TextBoxFirstName.Text, TextBoxLastName.Text)
                cmd = New SqlCommand(sql, cn)
                cmd.ExecuteNonQuery()
                sql = String.Format("SELECT CountryCode FROM Country WHERE CountryName = '{0}'", ComboBoxCountry.Text.ToString)
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                ds = New DataSet
                da.Fill(ds, "Country")
                Dim countryCode = ds.Tables("Country").Rows(0).Item(0).ToString
                sql = String.Format("INSERT INTO Runner
                    (Email, Gender, DateOfBirth,CountryCode)
                VALUES('{0}','{1}','{2}','{3}')", TextBoxEmail.Text, ComboBoxGender.Text, DateTimePickerDateOfBirth.Value.ToString("yyyy-MM-dd"), countryCode)
                cmd = New SqlCommand(sql, cn)
                'cmd.ExecuteNonQuery()
                If cmd.ExecuteNonQuery() = 0 Then
                    cn.Close()
                    Return
                Else
                    'disconnect()
                    ButtonRegister.Enabled = False
                    ButtonRegisterfrom.Enabled = True
                End If
            Catch ex As Exception
                MessageBox.Show("กรุฌาตรวจสอบการทำงานใหม่", "ข้อผิดพลาด")
                Debug.WriteLine(ex.StackTrace)
                Debug.WriteLine("Register Error => " & ex.Message)
            End Try
        Else
            MessageBox.Show("กรุฌากรอกข้อมูลให้ครบ")
        End If
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Hide()
        Form1.Show()
    End Sub
End Class