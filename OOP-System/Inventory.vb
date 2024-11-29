Imports System.Data.SQLite
Imports System.IO
Imports System.Windows.Forms

Public Class Inventory
    Private connString As String = "Data Source=C:\Users\QCU\source\Local Repos\OOP-System\bin\Debug\net8.0-windows\mydatabase.sqlite;Version=3;"
    Private connection As SQLiteConnection

    ' Form Load: Initialize connection and load data into DataGridView
    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New SQLiteConnection(connString)
        LoadData()
    End Sub

    ' Load data from SQLite database into DataGridView
    Private Sub LoadData()
        Try
            connection.Open()
            Dim query As String = "SELECT * FROM Inventory"
            Dim adapter As New SQLiteDataAdapter(query, connection)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvInventory.DataSource = table
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Navigate to Dashboard form
    Private Sub btnInv_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnInv.LinkClicked
        Dashboard.Show()
        Me.Hide()
    End Sub

    ' Logout functionality
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    ' Add new record to Inventory
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If ValidateFields() Then
            Try
                connection.Open()
                Dim query As String = "INSERT INTO Inventory (ProductName, Stock, Cost, TotalSales) VALUES (@ProductName, @Stock, @Cost, @TotalSales)"
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@ProductName", txtProductName.Text)
                    command.Parameters.AddWithValue("@Stock", Integer.Parse(txtStock.Text))
                    command.Parameters.AddWithValue("@Cost", Double.Parse(txtCost.Text))
                    command.Parameters.AddWithValue("@TotalSales", Double.Parse(txtSales.Text))
                    command.ExecuteNonQuery()
                End Using
                MessageBox.Show("Record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearFields()
                LoadData()
            Catch ex As SQLiteException When ex.Message.Contains("no such table")
                MessageBox.Show("Error: The 'Inventory' table does not exist. Please verify your database schema.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show("Error adding record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
        End If
    End Sub

    ' Clear the text fields
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFields()
    End Sub

    ' Delete selected record from Inventory
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If dgvInventory.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim id As Integer = Integer.Parse(dgvInventory.SelectedRows(0).Cells("ID").Value)

        Try
            connection.Open()
            Dim query As String = "DELETE FROM Inventory WHERE ID = @ID"
            Using command As New SQLiteCommand(query, connection)
                command.Parameters.AddWithValue("@ID", id)
                command.ExecuteNonQuery()
            End Using

            MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadData()
        Catch ex As Exception
            MessageBox.Show("Error deleting record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            connection.Close()
        End Try
    End Sub

    ' Validate the fields before any CRUD operation
    Private Function ValidateFields() As Boolean
        If txtProductName.Text = "" OrElse txtStock.Text = "" OrElse txtCost.Text = "" OrElse txtSales.Text = "" Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If Not Integer.TryParse(txtStock.Text, New Integer) OrElse
           Not Double.TryParse(txtCost.Text, New Double) OrElse
           Not Double.TryParse(txtSales.Text, New Double) Then
            MessageBox.Show("Please enter valid numeric values for Stock, Cost, and Total Sales.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    ' Clear the text fields
    Private Sub ClearFields()
        txtProductName.Clear()
        txtStock.Clear()
        txtCost.Clear()
        txtSales.Clear()
    End Sub

    ' Update the selected record in Inventory
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If dgvInventory.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a record to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If ValidateFields() Then
            Dim id As Integer = Integer.Parse(dgvInventory.SelectedRows(0).Cells("ID").Value)

            Try
                connection.Open()
                Dim query As String = "UPDATE Inventory SET ProductName = @ProductName, Stock = @Stock, Cost = @Cost, TotalSales = @TotalSales WHERE ID = @ID"
                Using command As New SQLiteCommand(query, connection)
                    command.Parameters.AddWithValue("@ProductName", txtProductName.Text)
                    command.Parameters.AddWithValue("@Stock", Integer.Parse(txtStock.Text))
                    command.Parameters.AddWithValue("@Cost", Double.Parse(txtCost.Text))
                    command.Parameters.AddWithValue("@TotalSales", Double.Parse(txtSales.Text))
                    command.Parameters.AddWithValue("@ID", id)
                    command.ExecuteNonQuery()
                End Using
                MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadData()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Error updating record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                connection.Close()
            End Try
        End If
    End Sub
End Class
