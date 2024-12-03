<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        btnRegister = New Button()
        Label2 = New Label()
        LinkLabel1 = New LinkLabel()
        txtUsername = New TextBox()
        txtEmail = New TextBox()
        txtContact = New TextBox()
        txtPassword = New TextBox()
        PictureBox1 = New PictureBox()
        btnClose = New Button()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = Color.FromArgb(CByte(57), CByte(103), CByte(181))
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnRegister.ForeColor = SystemColors.ControlLightLight
        btnRegister.Location = New Point(43, 383)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(283, 36)
        btnRegister.TabIndex = 1
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F)
        Label2.Location = New Point(75, 8)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 15)
        Label2.TabIndex = 2
        Label2.Text = "Already have an Account?"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 9F)
        LinkLabel1.Location = New Point(218, 8)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(37, 15)
        LinkLabel1.TabIndex = 3
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Login"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 12F)
        txtUsername.Location = New Point(43, 241)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Username"
        txtUsername.Size = New Size(283, 29)
        txtUsername.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 12F)
        txtEmail.Location = New Point(43, 276)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "Email"
        txtEmail.Size = New Size(283, 29)
        txtEmail.TabIndex = 5
        ' 
        ' txtContact
        ' 
        txtContact.Font = New Font("Segoe UI", 12F)
        txtContact.Location = New Point(43, 312)
        txtContact.Name = "txtContact"
        txtContact.PlaceholderText = "Contact Number"
        txtContact.Size = New Size(283, 29)
        txtContact.TabIndex = 6
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 12F)
        txtPassword.Location = New Point(43, 347)
        txtPassword.Name = "txtPassword"
        txtPassword.PlaceholderText = "Password"
        txtPassword.Size = New Size(283, 29)
        txtPassword.TabIndex = 7
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Logo2
        PictureBox1.Location = New Point(53, 37)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(263, 187)
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Transparent
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.ForeColor = SystemColors.ControlText
        btnClose.Image = My.Resources.Resources.Close
        btnClose.Location = New Point(319, 2)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(33, 30)
        btnClose.TabIndex = 15
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Location = New Point(12, 430)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(340, 27)
        Panel1.TabIndex = 16
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(362, 464)
        Controls.Add(Panel1)
        Controls.Add(btnClose)
        Controls.Add(PictureBox1)
        Controls.Add(btnRegister)
        Controls.Add(txtPassword)
        Controls.Add(txtContact)
        Controls.Add(txtEmail)
        Controls.Add(txtUsername)
        FormBorderStyle = FormBorderStyle.None
        Name = "RegisterForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "RegisterForm"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClose As Button
    Friend WithEvents Panel1 As Panel
End Class
