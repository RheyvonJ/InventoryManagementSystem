Module SharedData
    Public InventoryTable As New DataTable()

    ' Initialize the InventoryTable with necessary columns
    Sub InitializeTable()
        With InventoryTable.Columns
            .Add("Product Number", GetType(Integer))
            .Add("Product Name", GetType(String))
            .Add("Stock", GetType(Integer))
            .Add("Cost", GetType(Decimal))
            .Add("Total Sales", GetType(Decimal))
        End With
    End Sub

    ' Recalculate product numbers
    Public Sub RecalculateProductNumbers()
        Dim productNumber As Integer = 1
        For Each row As DataRow In InventoryTable.Rows
            row("Product Number") = productNumber
            productNumber += 1
        Next
    End Sub

    ' Calculate total sales for all products
    Public Function CalculateTotalSales() As Decimal
        Dim totalSales As Decimal = 0
        For Each row As DataRow In InventoryTable.Rows
            totalSales += CDec(row("Total Sales"))
        Next
        Return totalSales
    End Function
End Module
