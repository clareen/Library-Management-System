Imports MySql.Data.MySqlClient

Public Class BookIn

    Private Sub btn_proceed_Click(sender As Object, e As EventArgs) Handles btn_proceed.Click
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("update  librarymanagment.booklentouttable set returnstatus='" & cmb_returnstatus.SelectedItem & "'  where borrowcode='" & txt_borrowcode.Text & "' and stdcardid='" & txt_cardid.Text & "' ", mycon)
            Dim myReader As MySqlDataReader

            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("BOOK RETURN REGISTERED", "SUCCESSFULL", MessageBoxButtons.OK, MessageBoxIcon.Information)
            mycon.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Hide()
        Home.Show()

    End Sub
End Class