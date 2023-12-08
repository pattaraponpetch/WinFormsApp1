<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TextBoxEmail = New TextBox()
        TextBoxPassword = New TextBox()
        ButtonLogin = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Location = New Point(124, 124)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(299, 27)
        TextBoxEmail.TabIndex = 0
        TextBoxEmail.Text = "aquarles91@manda.com"
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Location = New Point(124, 209)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.Size = New Size(299, 27)
        TextBoxPassword.TabIndex = 1
        TextBoxPassword.Text = "bN1LwKzR"
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.AutoSize = True
        ButtonLogin.BackColor = SystemColors.ButtonFace
        ButtonLogin.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonLogin.Location = New Point(124, 259)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(94, 30)
        ButtonLogin.TabIndex = 2
        ButtonLogin.Text = "เข้าสู่ระบบ"
        ButtonLogin.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.BackColor = SystemColors.ButtonFace
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(329, 259)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 30)
        Button2.TabIndex = 3
        Button2.Text = "ออก"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.AutoSize = True
        Button3.BackColor = SystemColors.ButtonFace
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(229, 259)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 30)
        Button3.TabIndex = 4
        Button3.Text = "ลงทะเบียน"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(124, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 20)
        Label1.TabIndex = 5
        Label1.Text = "อีเมล"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(124, 186)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 20)
        Label2.TabIndex = 5
        Label2.Text = "รหัสผ่าน"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(546, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(ButtonLogin)
        Controls.Add(TextBoxPassword)
        Controls.Add(TextBoxEmail)
        Name = "Form1"
        Text = "From1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
