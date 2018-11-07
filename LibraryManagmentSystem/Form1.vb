Imports MySql.Data.MySqlClient

Public Class Form1

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            Dim myConnection As String = "datasource=localhost;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from  librarymanagment.librariantable where l_id='" & txt_id.Text & "' and password='" & txt_password.Text & "';", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            Dim count As Integer = 0
            If (myReader.HasRows()) Then
                count = count + 1
            End If
            If (count = 1) Then
                MessageBox.Show("USERNAME AND PASSWORD ARE CORRECT", "SUCCESSFUL")

                Home.Show()
                Me.Hide()
            Else
                MessageBox.Show("WRONG CREDENTIALS", "LOGIN ERROR")
            End If
            mycon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
