
Public Class Inventory
    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' Initialize columns in the shared DataTable if they are not already added
        If SharedData.InventoryTable.Columns.Count = 0 Then
            SharedData.InventoryTable.Columns.Add("Product Number", GetType(Integer))
            SharedData.InventoryTable.Columns.Add("Product Name", GetType(String))
            SharedData.InventoryTable.Columns.Add("Stock", GetType(Integer))
            SharedData.InventoryTable.Columns.Add("Cost", GetType(Decimal))
            SharedData.InventoryTable.Columns.Add("Total Sales", GetType(Decimal))
        End If

        ' Bind the shared DataTable to dgvInventory
        dgvInventory.DataSource = SharedData.InventoryTable


    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click


        ' Check if required fields are filled
        If txtProductName.Text = "" Or txtStock.Text = "" Or txtCost.Text = "" Or txtSales.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Exit Sub
        End If
        ' Add a new product row to the shared DataTable
        SharedData.InventoryTable.Rows.Add(SharedData.InventoryTable.Rows.Count + 1, txtProductName.Text, CInt(txtStock.Text), CDec(txtCost.Text), CDec(txtSales.Text))

        ' Refresh the DataGridView
        dgvInventory.Refresh()

        ' Update total sales in the Dashboard
        Dashboard.UpdateTotalSales()

        MessageBox.Show("Product added successfully!")
    End Sub

    Public Sub RecalculateProductNumbers()
        Dim productNumber As Integer = 1

        For Each row As DataRow In SharedData.InventoryTable.Rows
            row("Product Number") = productNumber
            productNumber += 1
        Next

        dgvInventory.Refresh()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvInventory.SelectedRows.Count > 0 Then
            ' Remove the selected row
            SharedData.InventoryTable.Rows.RemoveAt(dgvInventory.SelectedRows(0).Index)

            ' Recalculate product numbers
            RecalculateProductNumbers()

            ' Refresh DataGridView
            dgvInventory.Refresh()

            ' Update total sales in the Dashboard
            Dashboard.UpdateTotalSales()
            MessageBox.Show("Product deleted successfully!")
        Else
            MessageBox.Show("Please select a product to delete.")
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvInventory.SelectedRows.Count > 0 Then
            ' Get the selected row and update its values
            Dim selectedRow As DataGridViewRow = dgvInventory.SelectedRows(0)
            selectedRow.Cells("Product Name").Value = txtProductName.Text
            selectedRow.Cells("Stock").Value = CInt(txtStock.Text)
            selectedRow.Cells("Cost").Value = CDec(txtCost.Text)
            selectedRow.Cells("Total Sales").Value = CDec(txtSales.Text)

            ' Refresh the DataGridView
            dgvInventory.Refresh()

            ' Update total sales in Dashboard
            Dashboard.UpdateTotalSales()

            MessageBox.Show("Product updated successfully!")
        Else
            MessageBox.Show("Please select a product to update.")
        End If
    End Sub

    Private Sub btnDashboard_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnDashboard.LinkClicked
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Close()
    End Sub
End Class
