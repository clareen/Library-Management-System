Imports MySql.Data.MySqlClient

Public Class RegisterLibrarian

    Private Sub btn_reg_Click(sender As Object, e As EventArgs) Handles btn_reg.Click
        If (txt_id.Text = "" Or txt_contact.Text = "" Or txt_password.Text = "" Or txt_name.Text = "") Then
            'validating empty fields
            MessageBox.Show("PLEASE FILL ALL FIELDS", "WARNING")

        Else
            Try
                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into librarymanagment.librariantable(l_id,l_name,branch,contact,password) values('" & txt_id.Text & "','" & txt_name.Text & "','" & txt_branch.Text & "','" & txt_contact.Text & "','" & txt_password.Text & "') ", mycon)
                Dim myReader As MySqlDataReader
                mycon.Open()
                myReader = SelectCommand.ExecuteReader()
                MessageBox.Show("REGISTRATION SUCCESSFULL", "SUCCESS")
                mycon.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Hide()
        Home.Show()
    End Sub
End Class