<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BooksView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.dgv_books = New System.Windows.Forms.DataGridView()
        Me.txt_author = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_subject = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv_books, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(274, 372)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(120, 23)
        Me.btn_close.TabIndex = 52
        Me.btn_close.Text = "CLOSE"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.Location = New System.Drawing.Point(466, 120)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(155, 23)
        Me.btn_del.TabIndex = 51
        Me.btn_del.Text = "DELETE"
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(466, 66)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(155, 23)
        Me.btn_search.TabIndex = 50
        Me.btn_search.Text = "SEARCH"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(466, 15)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(155, 23)
        Me.btn_update.TabIndex = 49
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'dgv_books
        '
        Me.dgv_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_books.Location = New System.Drawing.Point(28, 174)
        Me.dgv_books.Name = "dgv_books"
        Me.dgv_books.Size = New System.Drawing.Size(593, 192)
        Me.dgv_books.TabIndex = 47
        '
        'txt_author
        '
        Me.txt_author.Location = New System.Drawing.Point(115, 126)
        Me.txt_author.Name = "txt_author"
        Me.txt_author.Size = New System.Drawing.Size(233, 20)
        Me.txt_author.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "AUTHOR"
        '
        'txt_subject
        '
        Me.txt_subject.Location = New System.Drawing.Point(115, 88)
        Me.txt_subject.Name = "txt_subject"
        Me.txt_subject.Size = New System.Drawing.Size(233, 20)
        Me.txt_subject.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "SUBJECT"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(115, 52)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(233, 20)
        Me.txt_name.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "NAME"
        '
        'txt_code
        '
        Me.txt_code.Location = New System.Drawing.Point(115, 17)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(233, 20)
        Me.txt_code.TabIndex = 54
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "BOOK CODE"
        '
        'BooksView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 402)
        Me.Controls.Add(Me.txt_author)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_subject)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.dgv_books)
        Me.Name = "BooksView"
        Me.Text = "BooksView"
        CType(Me.dgv_books, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents dgv_books As System.Windows.Forms.DataGridView
    Friend WithEvents txt_author As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_subject As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_code As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
