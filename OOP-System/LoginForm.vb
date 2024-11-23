Imports System.Data.SQLite
Imports System.IO

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim dbFilePath As String = Path.Combine(Application.StartupPath, "mydatabase.sqlite")
        Dim connectionString As String = $"Data Source={dbFilePath};Version=3;"

        ' Validation: Ensure all fields are filled
        If String.IsNullOrWhiteSpace(txtLoginUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtLoginPassword.Text) Then
            MessageBox.Show("Please enter your username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Check user in the database
        Dim query As String = "SELECT COUNT(1) FROM Users WHERE Username = @Username AND Password = @Password;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", txtLoginUsername.Text)
                cmd.Parameters.AddWithValue("@Password", txtLoginPassword.Text)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                If count = 1 Then
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Navigate to the next form or dashboard
                Else
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set PasswordChar to hide password input
        txtLoginPassword.PasswordChar = "*"c
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        RegisterForm.Show()
        Me.Hide()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
