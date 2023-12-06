<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        LabelEmail = New Label()
        Label2 = New Label()
        LabelPassword = New Label()
        ButtonEditProfile = New Button()
        Button2 = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.LightBlue
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(157, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 20)
        Label1.TabIndex = 0
        Label1.Text = "Email:"
        ' 
        ' LabelEmail
        ' 
        LabelEmail.AutoSize = True
        LabelEmail.BackColor = SystemColors.Highlight
        LabelEmail.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LabelEmail.Location = New Point(231, 146)
        LabelEmail.Name = "LabelEmail"
        LabelEmail.Size = New Size(15, 20)
        LabelEmail.TabIndex = 1
        LabelEmail.Text = "-"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.LightBlue
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(157, 186)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 20)
        Label2.TabIndex = 2
        Label2.Text = "Password:"
        ' 
        ' LabelPassword
        ' 
        LabelPassword.AutoSize = True
        LabelPassword.BackColor = SystemColors.Highlight
        LabelPassword.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        LabelPassword.Location = New Point(267, 186)
        LabelPassword.Name = "LabelPassword"
        LabelPassword.Size = New Size(15, 20)
        LabelPassword.TabIndex = 3
        LabelPassword.Text = "-"
        ' 
        ' ButtonEditProfile
        ' 
        ButtonEditProfile.AutoSize = True
        ButtonEditProfile.BackColor = SystemColors.Control
        ButtonEditProfile.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ButtonEditProfile.Location = New Point(249, 272)
        ButtonEditProfile.Name = "ButtonEditProfile"
        ButtonEditProfile.Size = New Size(132, 30)
        ButtonEditProfile.TabIndex = 4
        ButtonEditProfile.Text = "Edit Your Profile"
        ButtonEditProfile.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.BackColor = SystemColors.Control
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(417, 272)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 30)
        Button2.TabIndex = 5
        Button2.Text = "Ranked"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(340, 48)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 37)
        Label3.TabIndex = 6
        Label3.Text = "DATA"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(ButtonEditProfile)
        Controls.Add(LabelPassword)
        Controls.Add(Label2)
        Controls.Add(LabelEmail)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonEditProfile As Button
End Class
