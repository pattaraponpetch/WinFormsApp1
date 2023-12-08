<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Button1 = New Button()
        dtgrank = New DataGridView()
        lblProfile = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(dtgrank, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(82, 41)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 0
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' dtgrank
        ' 
        dtgrank.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgrank.Location = New Point(132, 118)
        dtgrank.Name = "dtgrank"
        dtgrank.RowHeadersWidth = 51
        dtgrank.RowTemplate.Height = 29
        dtgrank.Size = New Size(657, 150)
        dtgrank.TabIndex = 1
        ' 
        ' lblProfile
        ' 
        lblProfile.AutoSize = True
        lblProfile.Location = New Point(229, 50)
        lblProfile.Name = "lblProfile"
        lblProfile.Size = New Size(15, 20)
        lblProfile.TabIndex = 2
        lblProfile.Text = "-"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(173, 294)
        Label2.Name = "Label2"
        Label2.Size = New Size(15, 20)
        Label2.TabIndex = 2
        Label2.Text = "-"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(173, 353)
        Label3.Name = "Label3"
        Label3.Size = New Size(15, 20)
        Label3.TabIndex = 3
        Label3.Text = "-"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(173, 412)
        Label4.Name = "Label4"
        Label4.Size = New Size(15, 20)
        Label4.TabIndex = 4
        Label4.Text = "-"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightBlue
        ClientSize = New Size(891, 506)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblProfile)
        Controls.Add(dtgrank)
        Controls.Add(Button1)
        ForeColor = Color.Black
        Name = "Form4"
        Text = "Form4"
        CType(dtgrank, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents dtgrank As DataGridView
    Friend WithEvents lblProfile As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
