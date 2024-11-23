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
        Panel1 = New Panel()
        Label3 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Panel2 = New Panel()
        Label7 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnRegister
        ' 
        btnRegister.BackColor = SystemColors.ButtonHighlight
        btnRegister.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnRegister.Location = New Point(181, 254)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(97, 37)
        btnRegister.TabIndex = 1
        btnRegister.Text = "Register"
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(88, 312)
        Label2.Name = "Label2"
        Label2.Size = New Size(187, 20)
        Label2.TabIndex = 2
        Label2.Text = "Already have an Account?"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LinkLabel1.Location = New Point(271, 312)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(64, 20)
        LinkLabel1.TabIndex = 3
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Register"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 12F)
        txtUsername.Location = New Point(181, 73)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(171, 29)
        txtUsername.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 12F)
        txtEmail.Location = New Point(181, 114)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(171, 29)
        txtEmail.TabIndex = 5
        ' 
        ' txtContact
        ' 
        txtContact.Font = New Font("Segoe UI", 12F)
        txtContact.Location = New Point(181, 158)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(171, 29)
        txtContact.TabIndex = 6
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Segoe UI", 12F)
        txtPassword.Location = New Point(181, 203)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(171, 29)
        txtPassword.TabIndex = 7
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(2), CByte(48), CByte(71))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label3)
        Panel1.Enabled = False
        Panel1.ForeColor = SystemColors.ControlLightLight
        Panel1.Location = New Point(-1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(802, 44)
        Panel1.TabIndex = 9
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(142), CByte(202), CByte(230))
        Label3.Location = New Point(293, 5)
        Label3.Name = "Label3"
        Label3.Size = New Size(280, 30)
        Label3.TabIndex = 4
        Label3.Text = "INVENTORY MANAGEMENT"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(86, 77)
        Label1.Name = "Label1"
        Label1.Size = New Size(93, 21)
        Label1.TabIndex = 10
        Label1.Text = "Username:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(122, 118)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 21)
        Label4.TabIndex = 11
        Label4.Text = "Email:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(106, 161)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 21)
        Label5.TabIndex = 12
        Label5.Text = "Contact:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(90, 207)
        Label6.Name = "Label6"
        Label6.Size = New Size(89, 21)
        Label6.TabIndex = 13
        Label6.Text = "Password:"
        ' 
        ' Panel2
        ' 
        Panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Panel2.BackColor = Color.FromArgb(CByte(142), CByte(202), CByte(230))
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(btnRegister)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(LinkLabel1)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(txtUsername)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(txtEmail)
        Panel2.Controls.Add(txtContact)
        Panel2.Controls.Add(txtPassword)
        Panel2.Location = New Point(202, 65)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(444, 359)
        Panel2.TabIndex = 14
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(177, 32)
        Label7.Name = "Label7"
        Label7.Size = New Size(75, 21)
        Label7.TabIndex = 14
        Label7.Text = "Register"
        ' 
        ' RegisterForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "RegisterForm"
        Text = "RegisterForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnRegister As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
End Class
