Imports MySql.Data.MySqlClient

Public Class NewStudent

    Private Sub btn_reg_Click(sender As Object, e As EventArgs) Handles btn_reg.Click
        If (txt_cardid.Text = "" Or txt_regid.Text = "" Or txt_name.Text = "" Or txt_course.Text = "") Then
            'validating empty fields
            MessageBox.Show("PLEASE FILL ALL FIELDS", "WARNING")

        Else
            Try
                Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into librarymanagment.studentstable(librarycard_id,reg_id,name,class) values('" & txt_cardid.Text & "','" & txt_regid.Text & "','" & txt_name.Text & "','" & txt_course.Text & "') ", mycon)
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

    Private Sub btn_cls_Click(sender As Object, e As EventArgs) Handles btn_cls.Click
        Me.Hide()
        Home.Show()

    End Sub
End Class