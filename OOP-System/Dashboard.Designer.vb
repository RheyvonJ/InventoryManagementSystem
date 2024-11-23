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
        Label2 = New Label()
        Panel2 = New Panel()
        btnDashboard = New LinkLabel()
        PictureBox4 = New PictureBox()
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        LinkLabel1 = New LinkLabel()
        Panel4 = New Panel()
        PictureBox2 = New PictureBox()
        Panel5 = New Panel()
        Label4 = New Label()
        Label3 = New Label()
        Panel6 = New Panel()
        PictureBox3 = New PictureBox()
        Panel7 = New Panel()
        Label5 = New Label()
        Label6 = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        btnInv = New LinkLabel()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(174, -8)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(659, 69)
        Panel1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(43, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 0
        Label2.Text = "Dashboard"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(27), CByte(40), CByte(74))
        Panel2.Controls.Add(PictureBox6)
        Panel2.Controls.Add(PictureBox5)
        Panel2.Controls.Add(btnInv)
        Panel2.Controls.Add(btnDashboard)
        Panel2.Controls.Add(PictureBox4)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(LinkLabel1)
        Panel2.Location = New Point(-10, -8)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(203, 482)
        Panel2.TabIndex = 1
        ' 
        ' btnDashboard
        ' 
        btnDashboard.AutoSize = True
        btnDashboard.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnDashboard.ForeColor = SystemColors.ButtonHighlight
        btnDashboard.LinkBehavior = LinkBehavior.HoverUnderline
        btnDashboard.LinkColor = SystemColors.ButtonHighlight
        btnDashboard.Location = New Point(72, 234)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(89, 21)
        btnDashboard.TabIndex = 8
        btnDashboard.TabStop = True
        btnDashboard.Text = "Dashboard"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.dashboard
        PictureBox4.Location = New Point(21, 220)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(53, 50)
        PictureBox4.TabIndex = 7
        PictureBox4.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(3, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(200, 184)
        Panel3.TabIndex = 5
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(38, 16)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(110, 80)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(15, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 16)
        Label1.TabIndex = 2
        Label1.Text = "         "
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.FromArgb(CByte(27), CByte(40), CByte(74))
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(70, 424)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(49, 17)
        LinkLabel1.TabIndex = 4
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Logout"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(2), CByte(188), CByte(237))
        Panel4.Controls.Add(PictureBox2)
        Panel4.Location = New Point(255, 98)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(99, 86)
        Panel4.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Sales1
        PictureBox2.Location = New Point(18, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(65, 63)
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(254), CByte(254), CByte(254))
        Panel5.Controls.Add(Label4)
        Panel5.Controls.Add(Label3)
        Panel5.Location = New Point(354, 98)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(118, 86)
        Panel5.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(23, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(59, 21)
        Label4.TabIndex = 1
        Label4.Text = "19,999"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(36, 60)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 15)
        Label3.TabIndex = 0
        Label3.Text = "Sales"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(239), CByte(154), CByte(17))
        Panel6.Controls.Add(PictureBox3)
        Panel6.Location = New Point(538, 98)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(99, 86)
        Panel6.TabIndex = 4
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.Product
        PictureBox3.Location = New Point(22, 11)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(65, 64)
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(254), CByte(254), CByte(254))
        Panel7.Controls.Add(Label5)
        Panel7.Controls.Add(Label6)
        Panel7.Location = New Point(637, 98)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(118, 86)
        Panel7.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(38, 27)
        Label5.Name = "Label5"
        Label5.Size = New Size(34, 25)
        Label5.TabIndex = 1
        Label5.Text = "10"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(30, 60)
        Label6.Name = "Label6"
        Label6.Size = New Size(49, 15)
        Label6.TabIndex = 0
        Label6.Text = "Product"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackgroundImageLayout = ImageLayout.Center
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        TableLayoutPanel1.ColumnCount = 4
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.9464283F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 87.05357F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 46F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 72F))
        TableLayoutPanel1.Controls.Add(Label7, 0, 0)
        TableLayoutPanel1.Controls.Add(Label8, 1, 0)
        TableLayoutPanel1.Controls.Add(Label9, 2, 0)
        TableLayoutPanel1.Controls.Add(Label10, 3, 0)
        TableLayoutPanel1.Location = New Point(330, 258)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.Size = New Size(346, 175)
        TableLayoutPanel1.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(7, 6)
        Label7.Margin = New Padding(6, 5, 3, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(16, 17)
        Label7.TabIndex = 7
        Label7.Text = "#"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(65, 4)
        Label8.Margin = New Padding(35, 3, 3, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(115, 21)
        Label8.TabIndex = 8
        Label8.Text = "Product Name"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(231, 8)
        Label9.Margin = New Padding(6, 7, 3, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(34, 15)
        Label9.TabIndex = 9
        Label9.Text = "Date"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(277, 8)
        Label10.Margin = New Padding(5, 7, 3, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(65, 15)
        Label10.TabIndex = 10
        Label10.Text = "Total Sales"
        ' 
        ' btnInv
        ' 
        btnInv.AutoSize = True
        btnInv.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
        btnInv.ForeColor = SystemColors.ButtonHighlight
        btnInv.LinkBehavior = LinkBehavior.HoverUnderline
        btnInv.LinkColor = SystemColors.ButtonHighlight
        btnInv.Location = New Point(72, 315)
        btnInv.Name = "btnInv"
        btnInv.Size = New Size(81, 21)
        btnInv.TabIndex = 9
        btnInv.TabStop = True
        btnInv.Text = "Inventory"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.inventory
        PictureBox5.Location = New Point(21, 300)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(52, 50)
        PictureBox5.TabIndex = 10
        PictureBox5.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = My.Resources.Resources.logout1
        PictureBox6.Location = New Point(33, 415)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(36, 40)
        PictureBox6.TabIndex = 11
        PictureBox6.TabStop = False
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(824, 468)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnDashboard As LinkLabel
    Friend WithEvents btnInv As LinkLabel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
