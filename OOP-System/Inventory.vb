Public Class Inventory
    Private UserDetails As Dictionary(Of String, String)

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Check if user details are passed via Tag
        If TypeOf Me.Tag Is Dictionary(Of String, String) Then
            UserDetails = CType(Me.Tag, Dictionary(Of String, String))

            ' Display user details in the label
            UpdateUserLabel()
        End If

        ' Initialize columns in the shared DataTable if they are not already added
        If SharedData.InventoryTable.Columns.Count = 0 Then
            SharedData.InventoryTable.Columns.Add("Product Number", GetType(Integer))
            SharedData.InventoryTable.Columns.Add("Product Name", GetType(String))
            SharedData.InventoryTable.Columns.Add("Stock", GetType(Integer))
            SharedData.InventoryTable.Columns.Add("Cost", GetType(Decimal))
            SharedData.InventoryTable.Columns.Add("Total Sales", GetType(Decimal))
        End If

        ' Bind the shared DataTable to dgvInventory
        dgvInventory.AutoGenerateColumns = True
        dgvInventory.DataSource = SharedData.InventoryTable
        dgvInventory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub UpdateUserLabel()
        ' Ensure UserDetails is not null
        If UserDetails IsNot Nothing Then
            Dim username = UserDetails("Username")
            Dim email = UserDetails("Email")
            Dim contact = UserDetails("ContactNo")

            ' Update the label with user information
            Label1.Text = $"{username}" & vbCrLf & $"{email}" & vbCrLf & $"{contact}"
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Check if required fields are filled
        If txtProductName.Text = "" Or txtStock.Text = "" Or txtCost.Text = "" Or txtSales.Text = "" Then
            MessageBox.Show("Please fill in all fields.")
            Exit Sub
        End If

        Try
            ' Add a new product row to the shared DataTable
            SharedData.InventoryTable.Rows.Add(
                SharedData.InventoryTable.Rows.Count + 1,
                txtProductName.Text,
                CInt(txtStock.Text),
                CDec(txtCost.Text),
                CDec(txtSales.Text)
            )

            ' Update total sales in the Dashboard
            Dashboard.UpdateTotalSales()

            ' Refresh the DataGridView
            dgvInventory.Refresh()

            MessageBox.Show("Product added successfully!")
        Catch ex As Exception
            MessageBox.Show("Error adding product: " & ex.Message)
        End Try
    End Sub

    ' This method updates the product numbers after a row is deleted or updated
    Public Sub RecalculateProductNumbers()
        Dim productNumber As Integer = 1
        For Each row As DataRow In SharedData.InventoryTable.Rows
            row("Product Number") = productNumber
            productNumber += 1
        Next

        ' Refresh the DataGridView to show updated product numbers
        dgvInventory.Refresh()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvInventory.SelectedRows.Count > 0 Then
            Try
                ' Remove the selected row from InventoryTable
                Dim selectedIndex As Integer = dgvInventory.SelectedRows(0).Index
                If selectedIndex >= 0 Then
                    SharedData.InventoryTable.Rows.RemoveAt(selectedIndex)

                    ' Recalculate product numbers after deletion
                    RecalculateProductNumbers()

                    ' Update total sales in the Dashboard
                    Dashboard.UpdateTotalSales()

                    MessageBox.Show("Product deleted successfully!")
                End If
            Catch ex As Exception
                MessageBox.Show("Error deleting product: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select a product to delete.")
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvInventory.SelectedRows.Count > 0 Then
            Try
                ' Get the selected row index
                Dim selectedIndex As Integer = dgvInventory.SelectedRows(0).Index
                Dim selectedRow As DataRow = SharedData.InventoryTable.Rows(selectedIndex)

                ' Update values in the selected row
                selectedRow("Product Name") = txtProductName.Text
                selectedRow("Stock") = CInt(txtStock.Text)
                selectedRow("Cost") = CDec(txtCost.Text)
                selectedRow("Total Sales") = CDec(txtSales.Text)

                ' Refresh the DataGridView
                dgvInventory.Refresh()

                ' Update total sales in the Dashboard
                Dashboard.UpdateTotalSales()

                MessageBox.Show("Product updated successfully!")
            Catch ex As Exception
                MessageBox.Show("Error updating product: " & ex.Message)
            End Try
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

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtProductName.Clear()
        txtStock.Clear()
        txtCost.Clear()
        txtSales.Clear()
    End Sub

    Private Sub dgvInventory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInventory.CellContentClick

    End Sub
End Class
