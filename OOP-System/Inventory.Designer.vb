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
        txtProductName = New TextBox()
        txtStock = New TextBox()
        txtCost = New TextBox()
        txtSales = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        btnAdd = New Button()
        btnClear = New Button()
        btnDelete = New Button()
        dgvInventory = New DataGridView()
        btnUpdate = New Button()
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
        CType(dgvInventory, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ogo2
        PictureBox1.Location = New Point(46, 23)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(110, 80)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(15, 117)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 17)
        Label1.TabIndex = 2
        Label1.Text = "         "
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(11, 10)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(222, 183)
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
        Panel10.Location = New Point(3, 212)
        Panel10.Margin = New Padding(3, 100, 3, 3)
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
        FlowLayoutPanel1.Location = New Point(18, 196)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(215, 374)
        FlowLayoutPanel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(27), CByte(40), CByte(74))
        Panel2.Controls.Add(FlowLayoutPanel1)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(-21, -16)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(233, 573)
        Panel2.TabIndex = 9
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(54, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(109, 30)
        Label2.TabIndex = 0
        Label2.Text = "Inventory"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(163, -16)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(804, 87)
        Panel1.TabIndex = 8
        ' 
        ' txtProductName
        ' 
        txtProductName.Font = New Font("Segoe UI", 12F)
        txtProductName.Location = New Point(402, 377)
        txtProductName.Name = "txtProductName"
        txtProductName.Size = New Size(159, 29)
        txtProductName.TabIndex = 15
        ' 
        ' txtStock
        ' 
        txtStock.Font = New Font("Segoe UI", 12F)
        txtStock.Location = New Point(586, 377)
        txtStock.Name = "txtStock"
        txtStock.Size = New Size(159, 29)
        txtStock.TabIndex = 16
        ' 
        ' txtCost
        ' 
        txtCost.Font = New Font("Segoe UI", 12F)
        txtCost.Location = New Point(402, 433)
        txtCost.Name = "txtCost"
        txtCost.Size = New Size(159, 29)
        txtCost.TabIndex = 17
        ' 
        ' txtSales
        ' 
        txtSales.Font = New Font("Segoe UI", 12F)
        txtSales.Location = New Point(589, 433)
        txtSales.Name = "txtSales"
        txtSales.Size = New Size(159, 29)
        txtSales.TabIndex = 18
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(434, 356)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 21)
        Label3.TabIndex = 19
        Label3.Text = "Product Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(639, 356)
        Label4.Name = "Label4"
        Label4.Size = New Size(47, 21)
        Label4.TabIndex = 20
        Label4.Text = "Stock"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(460, 409)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 21)
        Label5.TabIndex = 21
        Label5.Text = "Cost"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F)
        Label6.Location = New Point(639, 409)
        Label6.Name = "Label6"
        Label6.Size = New Size(46, 21)
        Label6.TabIndex = 22
        Label6.Text = "Sales"
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI", 11.25F)
        btnAdd.Location = New Point(428, 485)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(63, 33)
        btnAdd.TabIndex = 23
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI", 11.25F)
        btnClear.Location = New Point(514, 485)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(63, 33)
        btnClear.TabIndex = 24
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Font = New Font("Segoe UI", 11.25F)
        btnDelete.Location = New Point(594, 485)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(63, 33)
        btnDelete.TabIndex = 25
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' dgvInventory
        ' 
        dgvInventory.AllowUserToAddRows = False
        dgvInventory.BackgroundColor = SystemColors.Control
        dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvInventory.Location = New Point(339, 107)
        dgvInventory.Name = "dgvInventory"
        dgvInventory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        dgvInventory.RowHeadersVisible = False
        dgvInventory.Size = New Size(504, 223)
        dgvInventory.TabIndex = 26
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Font = New Font("Segoe UI", 11.25F)
        btnUpdate.Location = New Point(667, 485)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(78, 33)
        btnUpdate.TabIndex = 27
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' Inventory
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(967, 555)
        Controls.Add(btnUpdate)
        Controls.Add(dgvInventory)
        Controls.Add(btnDelete)
        Controls.Add(btnClear)
        Controls.Add(btnAdd)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtSales)
        Controls.Add(txtCost)
        Controls.Add(txtStock)
        Controls.Add(txtProductName)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Inventory"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Inventory"
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
        CType(dgvInventory, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
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
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtStock As TextBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtSales As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents dgvInventory As DataGridView
    Friend WithEvents btnUpdate As Button
End Class
