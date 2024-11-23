<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Panel1 = New Panel()
        Panel2 = New Panel()
        Button1 = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(174, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(652, 59)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(-6, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(199, 463)
        Panel2.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ControlLight
        Button1.Image = My.Resources.Resources.logout
        Button1.Location = New Point(71, 414)
        Button1.Name = "Button1"
        Button1.Size = New Size(44, 40)
        Button1.TabIndex = 3
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(13, 121)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 15)
        Label1.TabIndex = 2
        Label1.Text = "         "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(36, 10)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(110, 80)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(824, 468)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        Text = "Dashboard"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
