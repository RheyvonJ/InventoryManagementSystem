Imports System.Data.SQLite
Imports System.IO
Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Check if user details were passed
        If TypeOf Me.Tag Is Dictionary(Of String, String) Then
            Dim userDetails As Dictionary(Of String, String) = CType(Me.Tag, Dictionary(Of String, String))

            ' Extract and display user details without labels
            Dim username As String = userDetails("Username")
            Dim email As String = userDetails("Email")
            Dim contact As String = userDetails("ContactNo")

            ' Display only the values (no labels)
            Label1.Text = $"{username}" & vbCrLf &
                          $"{email}" & vbCrLf &
                          $"{contact}"
        Else
            ' Show error if details are missing
            Label1.Text = "User details not available."
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Close the application
            Application.Exit()
        End If

    End Sub
End Class
