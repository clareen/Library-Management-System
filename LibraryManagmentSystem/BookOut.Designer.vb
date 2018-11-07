<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookOut
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_book_check = New System.Windows.Forms.Button()
        Me.btn_student_check = New System.Windows.Forms.Button()
        Me.dtp_out = New System.Windows.Forms.DateTimePicker()
        Me.dtp_in = New System.Windows.Forms.DateTimePicker()
        Me.btn_proceed = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_cardid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_borrowcode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 326)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "RETURN DATE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "ISSUE DATE"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(128, 31)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(224, 20)
        Me.txt_name.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "NAME"
        '
        'txt_code
        '
        Me.txt_code.Location = New System.Drawing.Point(128, 29)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(224, 20)
        Me.txt_code.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "BOOK CODE"
        '
        'btn_book_check
        '
        Me.btn_book_check.Location = New System.Drawing.Point(372, 26)
        Me.btn_book_check.Name = "btn_book_check"
        Me.btn_book_check.Size = New System.Drawing.Size(75, 23)
        Me.btn_book_check.TabIndex = 55
        Me.btn_book_check.Text = "CHECK"
        Me.btn_book_check.UseVisualStyleBackColor = True
        '
        'btn_student_check
        '
        Me.btn_student_check.Location = New System.Drawing.Point(372, 44)
        Me.btn_student_check.Name = "btn_student_check"
        Me.btn_student_check.Size = New System.Drawing.Size(75, 23)
        Me.btn_student_check.TabIndex = 56
        Me.btn_student_check.Text = "CHECK"
        Me.btn_student_check.UseVisualStyleBackColor = True
        '
        'dtp_out
        '
        Me.dtp_out.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_out.Location = New System.Drawing.Point(142, 281)
        Me.dtp_out.Name = "dtp_out"
        Me.dtp_out.Size = New System.Drawing.Size(225, 20)
        Me.dtp_out.TabIndex = 57
        '
        'dtp_in
        '
        Me.dtp_in.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_in.Location = New System.Drawing.Point(142, 320)
        Me.dtp_in.Name = "dtp_in"
        Me.dtp_in.Size = New System.Drawing.Size(225, 20)
        Me.dtp_in.TabIndex = 58
        '
        'btn_proceed
        '
        Me.btn_proceed.Location = New System.Drawing.Point(81, 369)
        Me.btn_proceed.Name = "btn_proceed"
        Me.btn_proceed.Size = New System.Drawing.Size(99, 23)
        Me.btn_proceed.TabIndex = 59
        Me.btn_proceed.Text = "PROCEED"
        Me.btn_proceed.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(312, 369)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(99, 23)
        Me.btn_cancel.TabIndex = 60
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_cardid)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btn_student_check)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(463, 103)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "STUDENT INFO"
        '
        'txt_cardid
        '
        Me.txt_cardid.Location = New System.Drawing.Point(128, 66)
        Me.txt_cardid.Name = "txt_cardid"
        Me.txt_cardid.Size = New System.Drawing.Size(224, 20)
        Me.txt_cardid.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "CARD NUMBER"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_book_check)
        Me.GroupBox2.Controls.Add(Me.txt_code)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 77)
        Me.GroupBox2.TabIndex = 62
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BOOKS INFO"
        '
        'txt_borrowcode
        '
        Me.txt_borrowcode.Location = New System.Drawing.Point(140, 23)
        Me.txt_borrowcode.Name = "txt_borrowcode"
        Me.txt_borrowcode.Size = New System.Drawing.Size(224, 20)
        Me.txt_borrowcode.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "BORROW CODE"
        '
        'BookOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 418)
        Me.Controls.Add(Me.txt_borrowcode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_proceed)
        Me.Controls.Add(Me.dtp_in)
        Me.Controls.Add(Me.dtp_out)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "BookOut"
        Me.Text = "BookOut"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_code As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_book_check As System.Windows.Forms.Button
    Friend WithEvents btn_student_check As System.Windows.Forms.Button
    Friend WithEvents dtp_out As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_in As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_proceed As System.Windows.Forms.Button
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cardid As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_borrowcode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
