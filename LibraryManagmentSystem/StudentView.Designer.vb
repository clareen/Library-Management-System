<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentView
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
        Me.dgv_students = New System.Windows.Forms.DataGridView()
        Me.txt_course = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_regid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cardid = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgv_students, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(295, 372)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(120, 23)
        Me.btn_close.TabIndex = 38
        Me.btn_close.Text = "CLOSE"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'btn_del
        '
        Me.btn_del.Location = New System.Drawing.Point(487, 120)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(155, 23)
        Me.btn_del.TabIndex = 37
        Me.btn_del.Text = "DELETE"
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(487, 66)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(155, 23)
        Me.btn_search.TabIndex = 36
        Me.btn_search.Text = "SEARCH"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(487, 15)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(155, 23)
        Me.btn_update.TabIndex = 35
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'dgv_students
        '
        Me.dgv_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_students.Location = New System.Drawing.Point(49, 174)
        Me.dgv_students.Name = "dgv_students"
        Me.dgv_students.Size = New System.Drawing.Size(593, 192)
        Me.dgv_students.TabIndex = 24
        '
        'txt_course
        '
        Me.txt_course.Location = New System.Drawing.Point(191, 136)
        Me.txt_course.Name = "txt_course"
        Me.txt_course.Size = New System.Drawing.Size(224, 20)
        Me.txt_course.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(130, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "COURSE"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(191, 90)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(224, 20)
        Me.txt_name.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "STUDENTS NAME"
        '
        'txt_regid
        '
        Me.txt_regid.Location = New System.Drawing.Point(191, 47)
        Me.txt_regid.Name = "txt_regid"
        Me.txt_regid.Size = New System.Drawing.Size(224, 20)
        Me.txt_regid.TabIndex = 42
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "REGISTRATION ID"
        '
        'txt_cardid
        '
        Me.txt_cardid.Location = New System.Drawing.Point(191, 8)
        Me.txt_cardid.Name = "txt_cardid"
        Me.txt_cardid.Size = New System.Drawing.Size(224, 20)
        Me.txt_cardid.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "LIBRARY CARD NUMBER"
        '
        'StudentView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 408)
        Me.Controls.Add(Me.txt_course)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_regid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cardid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_del)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.dgv_students)
        Me.Name = "StudentView"
        Me.Text = "StudentView"
        CType(Me.dgv_students, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_del As System.Windows.Forms.Button
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents dgv_students As System.Windows.Forms.DataGridView
    Friend WithEvents txt_course As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_regid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_cardid As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
