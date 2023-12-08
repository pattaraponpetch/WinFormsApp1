Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelEmail.Text = Form1.TextBoxEmail.Text
        sql = String.Format("SELECT Runner.Email,Users.Password,Users.FirstName,Users.LastName,Runner.Gender,Runner.DateOfBirth,Country.CountryName FROM Runner INNER JOIN Country ON Runner.CountryCode = Country.CountryCode INNER JOIN Users ON Runner.Email = Users.Email WHERE Users.Email='{0}'", LabelEmail.Text)
        cmd = New SqlCommand(sql, cn)
        da = New SqlDataAdapter(cmd)
        ds = New DataSet()
        da.Fill(ds, "12345Runner")
        Dim bind = New BindingSource
        bind.DataSource = ds.Tables("12345Runner")
        Try
            TextBoxFirstName.DataBindings.Add("Text", bind, "FirstName")
            TextBoxLastName.DataBindings.Add("Text", bind, "LastName")
            ComboBoxGender.DataBindings.Add("Text", bind, "Gender")
            DateTimePickerDateOfBirth.DataBindings.Add("Text", bind, "DateOfBirth")
            ComboBoxCountry.DataBindings.Add("Text", bind, "CountryName")
            TextBoxPassword.DataBindings.Add("Text", bind, "Password")
            textboxxx.DataBindings.Add("Text", bind, "DateOfBirth")
            LabelEmail.DataBindings.Add("Text", bind, "Email")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Country()
        ComboBoxCountry.DataSource = dt
        ComboBoxCountry.DisplayMember = dt.Columns.Item("CountryName").ColumnName
        ComboBoxCountry.SelectedItem = dt.Columns.Item("CountryName").ColumnName
        Gender()
        ComboBoxGender.DataSource = dt
        ComboBoxGender.DisplayMember = dt.Columns.Item("Gender").ColumnName
        ComboBoxGender.SelectedItem = dt.Columns.Item("Gender").ColumnName
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
        Form1.Show()
    End Sub

    Private Sub ButtonBack_Click(sender As Object, e As EventArgs) Handles ButtonBack.Click
        Hide()
        Form2.Show()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim result As DialogResult = MessageBox.Show("comfirm update ?", "comfirm update ?", MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            sql = String.Format("SELECT CountryCode FROM Country WHERE CountryName = '{0}'", ComboBoxCountry.Text)
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            ds = New DataSet()
            da.Fill(ds, "country")
            Dim CountryCode = ds.Tables("country").Rows(0).Item(0).ToString
            sql = ""
            sql = String.Format("Update Users set Password='{0}', Firstname='{1}',Lastname='{2}' WHERE Email='{3}'", TextBoxPassword.Text, TextBoxFirstName.Text, TextBoxLastName.Text, LabelEmail.Text)
            If cmd_excuteNonqueryUpdete() = 0 Then
                MessageBox.Show("เเก้ไขไม่สำเร็จ1 ", "warning !!", MessageBoxButtons.OK)
            Else
                sql = ""
                sql = String.Format("Update Runner set Gender='{0}', CountryCode='{1}',DateOfBirth='{2}' WHERE Email='{3}'", ComboBoxGender.Text, CountryCode, LabelEmail.Text, textboxxx.Text)
                If cmd_excuteNonqueryUpdete() = 0 Then
                    MessageBox.Show("เเก้ไขไม่สำเร็จ2", "warning !!", MessageBoxButtons.OK)
                Else
                    MessageBox.Show("เเก้ไขสำเร็จ", "Susses !!", MessageBoxButtons.OK)

                End If

            End If

        Else
            Return
        End If
    End Sub
End Class