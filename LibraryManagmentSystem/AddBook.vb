Imports MySql.Data.MySqlClient

Public Class AddBook

    Private Sub btn_reg_Click(sender As Object, e As EventArgs) Handles btn_reg.Click
        If (txt_code.Text = "" Or txt_name.Text = "" Or txt_subject.Text = "" Or txt_author.Text = "") Then
            'validating empty fields
            MessageBox.Show("PLEASE FILL ALL FIELDS", "WARNING")

        Else
            Try
                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into librarymanagment.bookstable(code,name,subject,author) values('" & txt_code.Text & "','" & txt_name.Text & "','" & txt_subject.Text & "','" & txt_author.Text & "') ", mycon)
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

    Private Sub btn_cncl_Click(sender As Object, e As EventArgs) Handles btn_cncl.Click
        Me.Hide()
        Home.Show()
    End Sub
End Class