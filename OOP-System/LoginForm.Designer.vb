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
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Panel2 = New Panel()
        LinkLabel1 = New LinkLabel()
        Label6 = New Label()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(364, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' txtLoginUsername
        ' 
        txtLoginUsername.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLoginUsername.Location = New Point(143, 76)
        txtLoginUsername.Name = "txtLoginUsername"
        txtLoginUsername.Size = New Size(171, 29)
        txtLoginUsername.TabIndex = 1
        ' 
        ' txtLoginPassword
        ' 
        txtLoginPassword.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtLoginPassword.Location = New Point(143, 129)
        txtLoginPassword.Name = "txtLoginPassword"
        txtLoginPassword.Size = New Size(171, 29)
        txtLoginPassword.TabIndex = 2
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.ButtonHighlight
        btnLogin.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = SystemColors.ControlText
        btnLogin.Location = New Point(143, 183)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(90, 36)
        btnLogin.TabIndex = 3
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(47, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 21)
        Label3.TabIndex = 5
        Label3.Text = "Username:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(51, 133)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 21)
        Label4.TabIndex = 6
        Label4.Text = "Password:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(143, 31)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 21)
        Label5.TabIndex = 7
        Label5.Text = "LOGIN"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(142), CByte(202), CByte(230))
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(LinkLabel1)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(txtLoginPassword)
        Panel2.Controls.Add(txtLoginUsername)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(btnLogin)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Location = New Point(230, 62)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(391, 310)
        Panel2.TabIndex = 9
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(234, 244)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(64, 20)
        LinkLabel1.TabIndex = 11
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Register"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(51, 244)
        Label6.Name = "Label6"
        Label6.Size = New Size(187, 20)
        Label6.TabIndex = 10
        Label6.Text = "Already have an Account?"
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(Label1)
        Name = "LoginForm"
        Text = "Login"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtLoginUsername As TextBox
    Friend WithEvents txtLoginPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label6 As Label

End Class
