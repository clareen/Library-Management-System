Public Class Home

    Private Sub NEWENTRYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NEWENTRYToolStripMenuItem.Click
        RegisterLibrarian.Show()
        Me.Hide()
    End Sub

    Private Sub UPDATEENTRYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEENTRYToolStripMenuItem.Click
        LibrarianView.Show()
        Me.Hide()
    End Sub

    Private Sub NEWENTRYToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NEWENTRYToolStripMenuItem1.Click
        NewStudent.Show()
        Me.Hide()
    End Sub

    Private Sub UPDATEENTRYToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UPDATEENTRYToolStripMenuItem1.Click
        StudentView.Show()
        Me.Hide()
    End Sub

    Private Sub ADDBOOKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ADDBOOKToolStripMenuItem.Click
        AddBook.Show()
        Me.Hide()
    End Sub

    Private Sub UPDATEBOOKSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UPDATEBOOKSToolStripMenuItem.Click
        BooksView.Show()
        Me.Hide()
    End Sub

    Private Sub SEARCHBOOKSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SEARCHBOOKSToolStripMenuItem.Click
        BooksView.Show()
        Me.Hide()
    End Sub

    Private Sub LENDOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LENDOUTToolStripMenuItem.Click
        BookOut.Show()
        Me.Hide()
    End Sub

    Private Sub RETURNINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RETURNINToolStripMenuItem.Click
        BookIn.Show()
        Me.Hide()
    End Sub

    Private Sub SEARCHBORROWDETAILSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SEARCHBORROWDETAILSToolStripMenuItem.Click
        BorrowStatus.Show()
        Me.Hide()
    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class