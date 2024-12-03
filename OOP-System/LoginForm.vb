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

        ' Query to retrieve user details
        Dim query As String = "SELECT Username, Email, ContactNo FROM Users WHERE Username = @Username AND Password = @Password;"

        Using conn As New SQLiteConnection(connectionString)
            conn.Open()
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", txtLoginUsername.Text)
                cmd.Parameters.AddWithValue("@Password", txtLoginPassword.Text)
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Retrieve user details
                        Dim username As String = reader("Username").ToString()
                        Dim email As String = reader("Email").ToString()
                        Dim contact As String = reader("ContactNo").ToString()

                        ' Pass user details to Dashboard
                        Dim dashboard As New Dashboard()
                        dashboard.Tag = New Dictionary(Of String, String) From {
                        {"Username", username},
                        {"Email", email},
                        {"ContactNo", contact}
                    }
                        dashboard.Show()
                        Me.Hide()
                    Else
                        ' Show error message if no matching user is found
                        MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
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

    Private Sub txtLoginUsername_TextChanged(sender As Object, e As EventArgs) Handles txtLoginUsername.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
