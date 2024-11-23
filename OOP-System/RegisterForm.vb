Imports System.Data.SQLite
Imports System.IO
Imports System.Text.RegularExpressions

Public Class RegisterForm
    Private Sub RegisterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set PasswordChar to hide password input
        txtPassword.PasswordChar = "*"c
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Validation: Ensure all fields are filled
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
           String.IsNullOrWhiteSpace(txtContact.Text) OrElse
           String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validation: Contact should be numeric
        If Not Regex.IsMatch(txtContact.Text, "^\d+$") Then
            MessageBox.Show("Contact number must contain only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validation: Email should end with @gmail.com or @yahoo.com
        If Not (txtEmail.Text.EndsWith("@gmail.com") OrElse txtEmail.Text.EndsWith("@yahoo.com")) Then
            MessageBox.Show("Email must end with @gmail.com or @yahoo.com.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim dbFilePath As String = Path.Combine(Application.StartupPath, "mydatabase.sqlite")
        Dim connectionString As String = $"Data Source={dbFilePath};Version=3;"

        ' Insert user into the database
        Dim query As String = "INSERT INTO Users (Username, Email, ContactNo, Password) VALUES (@Username, @Email, @ContactNo, @Password);"

        Dim attempts As Integer = 0
        Dim success As Boolean = False
        While attempts < 3 AndAlso Not success
            Try
                ' Open connection and execute query
                Using conn As New SQLiteConnection(connectionString)
                    conn.Open()
                    Using cmd As New SQLiteCommand(query, conn)
                        cmd.Parameters.AddWithValue("@Username", txtUsername.Text)
                        cmd.Parameters.AddWithValue("@Email", txtEmail.Text)
                        cmd.Parameters.AddWithValue("@ContactNo", txtContact.Text)
                        cmd.Parameters.AddWithValue("@Password", txtPassword.Text)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using

                ' If operation is successful, exit loop
                success = True
            Catch ex As SQLiteException When ex.ResultCode = SQLiteErrorCode.Locked
                ' If database is locked, wait and retry
                attempts += 1
                Threading.Thread.Sleep(1000) ' Sleep for 1 second before retrying
            Catch ex As Exception
                ' Catch any other exceptions
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try
        End While

        ' If after 3 attempts it fails, show an error
        If Not success Then
            MessageBox.Show("Database is locked. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Success message and clear fields
        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ClearFields()
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub ClearFields()
        txtUsername.Clear()
        txtEmail.Clear()
        txtContact.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
