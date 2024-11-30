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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Panel1 = New Panel()
        Label2 = New Label()
        Panel2 = New Panel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel8 = New Panel()
        btnDashboard = New LinkLabel()
        PictureBox4 = New PictureBox()
        Panel9 = New Panel()
        PictureBox5 = New PictureBox()
        btnInv = New LinkLabel()
        Panel10 = New Panel()
        LinkLabel1 = New LinkLabel()
        PictureBox6 = New PictureBox()
        Panel3 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel4 = New Panel()
        PictureBox2 = New PictureBox()
        Panel5 = New Panel()
        lblTotalSales = New Label()
        Label3 = New Label()
        Panel6 = New Panel()
        PictureBox3 = New PictureBox()
        Panel7 = New Panel()
        lblProductCount = New Label()
        Label6 = New Label()
        Label11 = New Label()
        dgvDashboardInventory = New DataGridView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        Panel8.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel9.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel10.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel7.SuspendLayout()
        CType(dgvDashboardInventory, ComponentModel.ISupportInitialize).BeginInit()
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
        Panel2.Controls.Add(FlowLayoutPanel1)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(-10, -8)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(203, 482)
        Panel2.TabIndex = 1
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(Panel8)
        FlowLayoutPanel1.Controls.Add(Panel9)
        FlowLayoutPanel1.Controls.Add(Panel10)
        FlowLayoutPanel1.Location = New Point(10, 189)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(193, 284)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(btnDashboard)
        Panel8.Controls.Add(PictureBox4)
        Panel8.Location = New Point(3, 3)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(200, 50)
        Panel8.TabIndex = 0
        ' 
        ' btnDashboard
        ' 
        btnDashboard.AutoSize = True
        btnDashboard.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        btnDashboard.ForeColor = SystemColors.ButtonHighlight
        btnDashboard.LinkBehavior = LinkBehavior.HoverUnderline
        btnDashboard.LinkColor = SystemColors.ButtonHighlight
        btnDashboard.Location = New Point(57, 16)
        btnDashboard.Name = "btnDashboard"
        btnDashboard.Size = New Size(89, 21)
        btnDashboard.TabIndex = 8
        btnDashboard.TabStop = True
        btnDashboard.Text = "Dashboard"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(22, 16)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(31, 27)
        PictureBox4.TabIndex = 7
        PictureBox4.TabStop = False
        ' 
        ' Panel9
        ' 
        Panel9.Controls.Add(PictureBox5)
        Panel9.Controls.Add(btnInv)
        Panel9.Location = New Point(3, 59)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(200, 50)
        Panel9.TabIndex = 1
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(20, 18)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(33, 28)
        PictureBox5.TabIndex = 10
        PictureBox5.TabStop = False
        ' 
        ' btnInv
        ' 
        btnInv.AutoSize = True
        btnInv.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        btnInv.ForeColor = SystemColors.ButtonHighlight
        btnInv.LinkBehavior = LinkBehavior.HoverUnderline
        btnInv.LinkColor = SystemColors.ButtonHighlight
        btnInv.Location = New Point(54, 18)
        btnInv.Name = "btnInv"
        btnInv.Size = New Size(81, 21)
        btnInv.TabIndex = 9
        btnInv.TabStop = True
        btnInv.Text = "Inventory"
        ' 
        ' Panel10
        ' 
        Panel10.Controls.Add(LinkLabel1)
        Panel10.Controls.Add(PictureBox6)
        Panel10.Location = New Point(3, 162)
        Panel10.Margin = New Padding(3, 50, 3, 3)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(200, 50)
        Panel10.TabIndex = 9
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.ActiveLinkColor = Color.FromArgb(CByte(27), CByte(40), CByte(74))
        LinkLabel1.AutoSize = True
        LinkLabel1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LinkLabel1.LinkBehavior = LinkBehavior.NeverUnderline
        LinkLabel1.LinkColor = Color.White
        LinkLabel1.Location = New Point(40, 16)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(49, 17)
        LinkLabel1.TabIndex = 4
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Logout"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(18, 16)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(31, 31)
        PictureBox6.TabIndex = 5
        PictureBox6.TabStop = False
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
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(18, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(65, 63)
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(254), CByte(254), CByte(254))
        Panel5.Controls.Add(lblTotalSales)
        Panel5.Controls.Add(Label3)
        Panel5.Location = New Point(354, 98)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(118, 86)
        Panel5.TabIndex = 3
        ' 
        ' lblTotalSales
        ' 
        lblTotalSales.AutoSize = True
        lblTotalSales.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalSales.Location = New Point(19, 20)
        lblTotalSales.Name = "lblTotalSales"
        lblTotalSales.Size = New Size(0, 30)
        lblTotalSales.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(22, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(60, 30)
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
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(22, 11)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(65, 64)
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(254), CByte(254), CByte(254))
        Panel7.Controls.Add(lblProductCount)
        Panel7.Controls.Add(Label6)
        Panel7.Location = New Point(637, 98)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(118, 86)
        Panel7.TabIndex = 5
        ' 
        ' lblProductCount
        ' 
        lblProductCount.AutoSize = True
        lblProductCount.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProductCount.Location = New Point(16, 15)
        lblProductCount.Name = "lblProductCount"
        lblProductCount.Size = New Size(0, 30)
        lblProductCount.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(16, 45)
        Label6.Name = "Label6"
        Label6.Size = New Size(85, 30)
        Label6.TabIndex = 0
        Label6.Text = "Product"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(448, 234)
        Label11.Name = "Label11"
        Label11.Size = New Size(119, 21)
        Label11.TabIndex = 7
        Label11.Text = "TOP PRODUCT"
        ' 
        ' dgvDashboardInventory
        ' 
        dgvDashboardInventory.AllowUserToAddRows = False
        dgvDashboardInventory.BackgroundColor = SystemColors.Control
        dgvDashboardInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDashboardInventory.Location = New Point(269, 260)
        dgvDashboardInventory.Name = "dgvDashboardInventory"
        dgvDashboardInventory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvDashboardInventory.RowHeadersVisible = False
        dgvDashboardInventory.Size = New Size(476, 189)
        dgvDashboardInventory.TabIndex = 27
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(824, 468)
        Controls.Add(dgvDashboardInventory)
        Controls.Add(Label11)
        Controls.Add(Panel7)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        FlowLayoutPanel1.ResumeLayout(False)
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
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
        CType(dgvDashboardInventory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents lblTotalSales As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblProductCount As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnDashboard As LinkLabel
    Friend WithEvents btnInv As LinkLabel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dgvDashboardInventory As DataGridView
End Class
