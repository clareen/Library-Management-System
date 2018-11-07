<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddBook
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
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_subject = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_author = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_reg = New System.Windows.Forms.Button()
        Me.btn_cncl = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BOOK CODE"
        '
        'txt_code
        '
        Me.txt_code.Location = New System.Drawing.Point(136, 31)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(233, 20)
        Me.txt_code.TabIndex = 1
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(136, 57)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(233, 20)
        Me.txt_name.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NAME"
        '
        'txt_subject
        '
        Me.txt_subject.Location = New System.Drawing.Point(136, 83)
        Me.txt_subject.Name = "txt_subject"
        Me.txt_subject.Size = New System.Drawing.Size(233, 20)
        Me.txt_subject.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "SUBJECT"
        '
        'txt_author
        '
        Me.txt_author.Location = New System.Drawing.Point(136, 109)
        Me.txt_author.Name = "txt_author"
        Me.txt_author.Size = New System.Drawing.Size(233, 20)
        Me.txt_author.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(73, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "AUTHOR"
        '
        'btn_reg
        '
        Me.btn_reg.Location = New System.Drawing.Point(59, 153)
        Me.btn_reg.Name = "btn_reg"
        Me.btn_reg.Size = New System.Drawing.Size(104, 23)
        Me.btn_reg.TabIndex = 8
        Me.btn_reg.Text = "REGISTER"
        Me.btn_reg.UseVisualStyleBackColor = True
        '
        'btn_cncl
        '
        Me.btn_cncl.Location = New System.Drawing.Point(260, 153)
        Me.btn_cncl.Name = "btn_cncl"
        Me.btn_cncl.Size = New System.Drawing.Size(109, 23)
        Me.btn_cncl.TabIndex = 9
        Me.btn_cncl.Text = "CANCEL"
        Me.btn_cncl.UseVisualStyleBackColor = True
        '
        'AddBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 207)
        Me.Controls.Add(Me.btn_cncl)
        Me.Controls.Add(Me.btn_reg)
        Me.Controls.Add(Me.txt_author)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_subject)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddBook"
        Me.Text = "AddBook"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_code As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_subject As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_author As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_reg As System.Windows.Forms.Button
    Friend WithEvents btn_cncl As System.Windows.Forms.Button
End Class
