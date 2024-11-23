Imports System.IO

Module DatabaseModule1
    Public Sub SetupDatabase()
        Dim dbFilePath As String = Path.Combine(Application.StartupPath, "mydatabase.sqlite")
        Dim connectionString As String = $"Data Source={dbFilePath};Version=3;"

        If Not IO.File.Exists(dbFilePath) Then
            SQLite.SQLiteConnection.CreateFile(dbFilePath)
        End If

        Dim createTableQuery As String = "
            CREATE TABLE IF NOT EXISTS Users (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Username TEXT NOT NULL,
                Email TEXT NOT NULL,
                ContactNo TEXT NOT NULL,
                Password TEXT NOT NULL
            );"

        Using conn As New SQLite.SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLite.SQLiteCommand(createTableQuery, conn)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Module
