Imports MySql.Data.MySqlClient

Public Class BookOut

    Private Sub btn_book_check_Click(sender As Object, e As EventArgs) Handles btn_book_check.Click
        If (txt_code.Text = "") Then
            'validating empty fields
            MessageBox.Show("EMPTY FIELDS", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                Dim myConnection As String = "datasource=localhost;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from  librarymanagment.bookstable where code='" & txt_code.Text & "' ;", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()
                myReader = SelectCommand.ExecuteReader()
                Dim count As Integer = 0
                If (myReader.HasRows()) Then
                    count = count + 1
                End If
                If (count = 1) Then
                    MessageBox.Show("BOOK AVAILABLE", "AVAILABLE", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("NO BOOK WITH SUCH CODE", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop)
                End If
                mycon.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_student_check_Click(sender As Object, e As EventArgs) Handles btn_student_check.Click
        If (txt_name.Text = "" Or txt_cardid.Text = "") Then
            'validating empty fields
            MessageBox.Show("EMPTY FIELDS", "WARNING")

        Else
            Try
                Dim myConnection As String = "datasource=localhost;username=root;"
                Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
                Dim SelectCommand As MySqlCommand = New MySqlCommand("Select * from  librarymanagment.studentstable where name='" & txt_name.Text & "' and librarycard_id='" & txt_cardid.Text & "';", mycon)
                Dim myReader As MySqlDataReader

                mycon.Open()
                myReader = SelectCommand.ExecuteReader()
                Dim count As Integer = 0
                If (myReader.HasRows()) Then
                    count = count + 1
                End If
                If (count = 1) Then
                    MessageBox.Show("CORRECT STUDENT DETAILS", "AVAILABLE")
                Else
                    MessageBox.Show("NO STUDENT WITH SUCH DETAILS", "ERROR")
                End If
                mycon.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Hide()
        Home.Show()
    End Sub

    Private Sub btn_proceed_Click(sender As Object, e As EventArgs) Handles btn_proceed.Click

        Dim returned As String = "not returned"
        Try
            Dim myConnection As String = "datasource=localhost;port=3306;username=root;"
            Dim mycon As MySqlConnection = New MySqlConnection(myConnection)
            Dim SelectCommand As MySqlCommand = New MySqlCommand("insert into librarymanagment.booklentouttable(borrowcode,bookcode,stdcardid,name,issuedate,returndate,returnstatus) values('" & txt_borrowcode.Text & "','" & txt_code.Text & "','" & txt_cardid.Text & "','" & txt_name.Text & "','" & dtp_out.Text & "','" & dtp_in.Text & "','" & returned & "') ", mycon)
            Dim myReader As MySqlDataReader
            mycon.Open()
            myReader = SelectCommand.ExecuteReader()
            MessageBox.Show("RECORD SUCCESS FULLY CREATED", "SUCCESS")
            mycon.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class