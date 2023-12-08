<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBoxEmail = New TextBox()
        TextBoxPassword = New TextBox()
        TextBoxRePassword = New TextBox()
        TextBoxFirstName = New TextBox()
        TextBoxLastName = New TextBox()
        ComboBoxGender = New ComboBox()
        DateTimePickerDateOfBirth = New DateTimePicker()
        ComboBoxCountry = New ComboBox()
        ButtonRegister = New Button()
        ButtonBack = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        ButtonRegisterfrom = New Button()
        SuspendLayout()
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Location = New Point(194, 162)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(125, 27)
        TextBoxEmail.TabIndex = 0
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Location = New Point(194, 213)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.Size = New Size(125, 27)
        TextBoxPassword.TabIndex = 0
        ' 
        ' TextBoxRePassword
        ' 
        TextBoxRePassword.Location = New Point(194, 267)
        TextBoxRePassword.Name = "TextBoxRePassword"
        TextBoxRePassword.Size = New Size(125, 27)
        TextBoxRePassword.TabIndex = 0
        ' 
        ' TextBoxFirstName
        ' 
        TextBoxFirstName.Location = New Point(194, 316)
        TextBoxFirstName.Name = "TextBoxFirstName"
        TextBoxFirstName.Size = New Size(125, 27)
        TextBoxFirstName.TabIndex = 0
        ' 
        ' TextBoxLastName
        ' 
        TextBoxLastName.Location = New Point(194, 374)
        TextBoxLastName.Name = "TextBoxLastName"
        TextBoxLastName.Size = New Size(125, 27)
        TextBoxLastName.TabIndex = 0
        ' 
        ' ComboBoxGender
        ' 
        ComboBoxGender.FormattingEnabled = True
        ComboBoxGender.Location = New Point(629, 162)
        ComboBoxGender.Name = "ComboBoxGender"
        ComboBoxGender.Size = New Size(151, 28)
        ComboBoxGender.TabIndex = 1
        ' 
        ' DateTimePickerDateOfBirth
        ' 
        DateTimePickerDateOfBirth.Location = New Point(629, 213)
        DateTimePickerDateOfBirth.Name = "DateTimePickerDateOfBirth"
        DateTimePickerDateOfBirth.Size = New Size(250, 27)
        DateTimePickerDateOfBirth.TabIndex = 2
        ' 
        ' ComboBoxCountry
        ' 
        ComboBoxCountry.FormattingEnabled = True
        ComboBoxCountry.Location = New Point(629, 266)
        ComboBoxCountry.Name = "ComboBoxCountry"
        ComboBoxCountry.Size = New Size(151, 28)
        ComboBoxCountry.TabIndex = 3
        ' 
        ' ButtonRegister
        ' 
        ButtonRegister.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonRegister.Location = New Point(327, 457)
        ButtonRegister.Name = "ButtonRegister"
        ButtonRegister.Size = New Size(120, 49)
        ButtonRegister.TabIndex = 4
        ButtonRegister.Text = "Register"
        ButtonRegister.UseVisualStyleBackColor = True
        ' 
        ' ButtonBack
        ' 
        ButtonBack.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonBack.Location = New Point(57, 27)
        ButtonBack.Name = "ButtonBack"
        ButtonBack.Size = New Size(119, 37)
        ButtonBack.TabIndex = 5
        ButtonBack.Text = "Back"
        ButtonBack.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(366, -3)
        Label1.Name = "Label1"
        Label1.Size = New Size(219, 67)
        Label1.TabIndex = 6
        Label1.Text = "ลงทะเบียน"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(121, 165)
        Label2.Name = "Label2"
        Label2.RightToLeft = RightToLeft.No
        Label2.Size = New Size(55, 20)
        Label2.TabIndex = 6
        Label2.Text = "Email :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(98, 218)
        Label3.Name = "Label3"
        Label3.Size = New Size(84, 20)
        Label3.TabIndex = 6
        Label3.Text = "Password :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(67, 269)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 20)
        Label4.TabIndex = 6
        Label4.Text = "Re - Password :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(92, 316)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 20)
        Label5.TabIndex = 6
        Label5.Text = "FirstName :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(92, 377)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 20)
        Label6.TabIndex = 6
        Label6.Text = "LastName :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(536, 165)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 20)
        Label7.TabIndex = 6
        Label7.Text = "Gender :"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(530, 216)
        Label8.Name = "Label8"
        Label8.Size = New Size(79, 20)
        Label8.TabIndex = 6
        Label8.Text = "BrithDay :"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(536, 269)
        Label9.Name = "Label9"
        Label9.Size = New Size(74, 20)
        Label9.TabIndex = 6
        Label9.Text = "Country :"
        ' 
        ' ButtonRegisterfrom
        ' 
        ButtonRegisterfrom.Font = New Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonRegisterfrom.Location = New Point(499, 457)
        ButtonRegisterfrom.Name = "ButtonRegisterfrom"
        ButtonRegisterfrom.Size = New Size(128, 51)
        ButtonRegisterfrom.TabIndex = 7
        ButtonRegisterfrom.Text = "Registerfrom"
        ButtonRegisterfrom.UseVisualStyleBackColor = True
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(981, 552)
        Controls.Add(ButtonRegisterfrom)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ButtonBack)
        Controls.Add(ButtonRegister)
        Controls.Add(ComboBoxCountry)
        Controls.Add(DateTimePickerDateOfBirth)
        Controls.Add(ComboBoxGender)
        Controls.Add(TextBoxLastName)
        Controls.Add(TextBoxFirstName)
        Controls.Add(TextBoxRePassword)
        Controls.Add(TextBoxPassword)
        Controls.Add(TextBoxEmail)
        Name = "Form5"
        Text = "Form5"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxRePassword As TextBox
    Friend WithEvents TextBoxFirstName As TextBox
    Friend WithEvents TextBoxLastName As TextBox
    Friend WithEvents ComboBoxGender As ComboBox
    Friend WithEvents DateTimePickerDateOfBirth As DateTimePicker
    Friend WithEvents ComboBoxCountry As ComboBox
    Friend WithEvents ButtonRegister As Button
    Friend WithEvents ButtonBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ButtonRegisterfrom As Button
End Class
