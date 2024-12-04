﻿Imports System.Data.SQLite
Imports System.IO
Public Class Dashboard

    Private UserDetails As Dictionary(Of String, String)


    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvDashboardInventory.DataSource = SharedData.InventoryTable
        UpdateTotalSales()
        UpdateProductCount()
        CalculateTotalSales()

        ' Check if user details are passed via Tag
        If TypeOf Me.Tag Is Dictionary(Of String, String) Then
            UserDetails = CType(Me.Tag, Dictionary(Of String, String))

            ' Display user details in the label
            UpdateUserLabel()
        End If
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
    Public Sub CalculateTotalSales()
        ' Initialize the total sales value
        Dim totalSales As Decimal = 0

        ' Loop through each row in the shared DataTable
        For Each row As DataRow In SharedData.InventoryTable.Rows
            totalSales += CDec(row("Total Sales"))
        Next

        ' Display the total sales in a label or text box
        lblTotalSales.Text = totalSales.ToString("N2") ' Formats as currency

    End Sub
    Public Sub UpdateTotalSales()
        ' Calculate total sales using the shared module and display it
        Dim totalSales As Decimal = SharedData.CalculateTotalSales()
        lblTotalSales.Text = totalSales.ToString("N2") ' Formats as currency
    End Sub

    Public Sub UpdateProductCount()
        ' Display the total number of products in the shared DataTable
        lblProductCount.Text = SharedData.InventoryTable.Rows.Count.ToString()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Close the application
            Application.Exit()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnInv_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnInv.LinkClicked
        Inventory.Show()
        Me.Hide()
    End Sub

    Private Sub btnDashboard_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles btnDashboard.LinkClicked

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
