<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        txtLoginUsername = New TextBox()
        txtLoginPassword = New TextBox()
        btnLogin = New Button()
        PictureBox1 = New PictureBox()
        btnClose = New Button()
        Label6 = New Label()
        LinkLabel1 = New LinkLabel()
        Panel1 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(385, 6)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' txtLoginUsername
        ' 
        txtLoginUsername.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLoginUsername.Location = New Point(43, 249)
        txtLoginUsername.Name = "txtLoginUsername"
        txtLoginUsername.PlaceholderText = "Username"
        txtLoginUsername.Size = New Size(283, 29)
        txtLoginUsername.TabIndex = 1
        ' 
        ' txtLoginPassword
        ' 
        txtLoginPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLoginPassword.Location = New Point(43, 284)
        txtLoginPassword.Name = "txtLoginPassword"
        txtLoginPassword.PlaceholderText = "Password"
        txtLoginPassword.Size = New Size(283, 29)
        txtLoginPassword.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.FromArgb(CByte(57), CByte(103), CByte(181))
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = SystemColors.ButtonFace
        btnLogin.Location = New Point(43, 328)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(283, 36)
        btnLogin.TabIndex = 3
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(52, 37)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(263, 187)
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' btnClose
        ' 
        btnClose.BackColor = Color.Transparent
        btnClose.FlatAppearance.BorderSize = 0
        btnClose.FlatStyle = FlatStyle.Flat
        btnClose.ForeColor = SystemColors.ControlText
        btnClose.Image = My.Resources.Resources.Close
        btnClose.Location = New Point(321, 2)
        btnClose.Name = "btnClose"
        btnClose.Size = New Size(33, 30)
        btnClose.TabIndex = 14
        btnClose.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F)
        Label6.Location = New Point(74, 8)
        Label6.Name = "Label6"
        Label6.Size = New Size(144, 15)
        Label6.TabIndex = 10
        Label6.Text = "Already have an Account?"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 9F)
        LinkLabel1.Location = New Point(214, 8)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(49, 15)
        LinkLabel1.TabIndex = 11
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Register"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        Panel1.Controls.Add(LinkLabel1)
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(4, 381)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(346, 30)
        Panel1.TabIndex = 13
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(362, 417)
        Controls.Add(btnClose)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(txtLoginPassword)
        Controls.Add(btnLogin)
        Controls.Add(txtLoginUsername)
        FormBorderStyle = FormBorderStyle.None
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtLoginUsername As TextBox
    Friend WithEvents txtLoginPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClose As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel1 As Panel

End Class
