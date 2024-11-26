<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventory))
        ID = New Label()
        Product = New Label()
        Stock = New Label()
        TableLayoutPanel1 = New TableLayoutPanel()
        Cost = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel3 = New Panel()
        LinkLabel1 = New LinkLabel()
        PictureBox6 = New PictureBox()
        Panel10 = New Panel()
        PictureBox5 = New PictureBox()
        btnInv = New LinkLabel()
        Panel9 = New Panel()
        btnDashboard = New LinkLabel()
        PictureBox4 = New PictureBox()
        Panel8 = New Panel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel2 = New Panel()
        Label2 = New Label()
        Panel1 = New Panel()
        Sales = New Label()
        Delete = New Label()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        Panel10.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel9.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        FlowLayoutPanel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ID
        ' 
        ID.AutoSize = True
        ID.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ID.Location = New Point(7, 6)
        ID.Margin = New Padding(6, 5, 3, 0)
        ID.Name = "ID"
        ID.Size = New Size(16, 17)
        ID.TabIndex = 7
        ID.Text = "#"
        ' 
        ' Product
        ' 
        Product.AutoSize = True
        Product.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Product.Location = New Point(66, 4)
        Product.Margin = New Padding(35, 3, 3, 0)
        Product.Name = "Product"
        Product.Size = New Size(115, 21)
        Product.TabIndex = 8
        Product.Text = "Product Name"
        ' 
        ' Stock
        ' 
        Stock.AutoSize = True
        Stock.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Stock.Location = New Point(236, 8)
        Stock.Margin = New Padding(6, 7, 3, 0)
        Stock.Name = "Stock"
        Stock.Size = New Size(39, 15)
        Stock.TabIndex = 9
        Stock.Text = "Stock"
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.BackgroundImageLayout = ImageLayout.Center
        TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
        TableLayoutPanel1.ColumnCount = 6
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 12.9464283F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 87.05357F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 54F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 54F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 84F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 46F))
        TableLayoutPanel1.Controls.Add(Delete, 5, 0)
        TableLayoutPanel1.Controls.Add(ID, 0, 0)
        TableLayoutPanel1.Controls.Add(Product, 1, 0)
        TableLayoutPanel1.Controls.Add(Stock, 2, 0)
        TableLayoutPanel1.Controls.Add(Cost, 3, 0)
        TableLayoutPanel1.Controls.Add(Sales, 4, 0)
        TableLayoutPanel1.Location = New Point(233, 101)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 6
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.0919533F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 13.7931032F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 19.54023F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.666666F))
        TableLayoutPanel1.Size = New Size(473, 175)
        TableLayoutPanel1.TabIndex = 14
        ' 
        ' Cost
        ' 
        Cost.AutoSize = True
        Cost.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Cost.Location = New Point(294, 8)
        Cost.Margin = New Padding(9, 7, 3, 0)
        Cost.Name = "Cost"
        Cost.Size = New Size(31, 15)
        Cost.TabIndex = 10
        Cost.Text = "Cost"
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
        btnInv.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
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
        ' Panel9
        ' 
        Panel9.Controls.Add(PictureBox5)
        Panel9.Controls.Add(btnInv)
        Panel9.Location = New Point(3, 59)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(200, 50)
        Panel9.TabIndex = 1
        ' 
        ' btnDashboard
        ' 
        btnDashboard.AutoSize = True
        btnDashboard.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold)
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
        ' Panel8
        ' 
        Panel8.Controls.Add(btnDashboard)
        Panel8.Controls.Add(PictureBox4)
        Panel8.Location = New Point(3, 3)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(200, 50)
        Panel8.TabIndex = 0
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(27), CByte(40), CByte(74))
        Panel2.Controls.Add(FlowLayoutPanel1)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(-21, -16)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(203, 482)
        Panel2.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(43, 27)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 20)
        Label2.TabIndex = 0
        Label2.Text = "Inventory"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(163, -16)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(659, 69)
        Panel1.TabIndex = 8
        ' 
        ' Sales
        ' 
        Sales.AutoSize = True
        Sales.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Sales.Location = New Point(351, 7)
        Sales.Margin = New Padding(11, 6, 3, 0)
        Sales.Name = "Sales"
        Sales.Size = New Size(63, 15)
        Sales.TabIndex = 11
        Sales.Text = "Total Sales"
        ' 
        ' Delete
        ' 
        Delete.AutoSize = True
        Delete.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Delete.Location = New Point(425, 7)
        Delete.Margin = New Padding(0, 6, 3, 0)
        Delete.Name = "Delete"
        Delete.Size = New Size(42, 15)
        Delete.TabIndex = 15
        Delete.Text = "Action"
        ' 
        ' Inventory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TableLayoutPanel1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Inventory"
        Text = "Inventory"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        FlowLayoutPanel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ID As Label
    Friend WithEvents Product As Label
    Friend WithEvents Stock As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Cost As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Panel10 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnInv As LinkLabel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btnDashboard As LinkLabel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Sales As Label
    Friend WithEvents Delete As Label
End Class
