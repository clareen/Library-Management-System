<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewStudent
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
        Me.txt_cardid = New System.Windows.Forms.TextBox()
        Me.txt_regid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_course = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_reg = New System.Windows.Forms.Button()
        Me.btn_cls = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LIBRARY CARD NUMBER"
        '
        'txt_cardid
        '
        Me.txt_cardid.Location = New System.Drawing.Point(175, 36)
        Me.txt_cardid.Name = "txt_cardid"
        Me.txt_cardid.Size = New System.Drawing.Size(224, 20)
        Me.txt_cardid.TabIndex = 3
        '
        'txt_regid
        '
        Me.txt_regid.Location = New System.Drawing.Point(175, 75)
        Me.txt_regid.Name = "txt_regid"
        Me.txt_regid.Size = New System.Drawing.Size(224, 20)
        Me.txt_regid.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "REGISTRATION ID"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(175, 118)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(224, 20)
        Me.txt_name.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "STUDENTS NAME"
        '
        'txt_course
        '
        Me.txt_course.Location = New System.Drawing.Point(175, 164)
        Me.txt_course.Name = "txt_course"
        Me.txt_course.Size = New System.Drawing.Size(224, 20)
        Me.txt_course.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(125, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CLASS"
        '
        'btn_reg
        '
        Me.btn_reg.Location = New System.Drawing.Point(33, 205)
        Me.btn_reg.Name = "btn_reg"
        Me.btn_reg.Size = New System.Drawing.Size(127, 32)
        Me.btn_reg.TabIndex = 10
        Me.btn_reg.Text = "REGISTER"
        Me.btn_reg.UseVisualStyleBackColor = True
        '
        'btn_cls
        '
        Me.btn_cls.Location = New System.Drawing.Point(272, 205)
        Me.btn_cls.Name = "btn_cls"
        Me.btn_cls.Size = New System.Drawing.Size(127, 32)
        Me.btn_cls.TabIndex = 11
        Me.btn_cls.Text = "CLOSE"
        Me.btn_cls.UseVisualStyleBackColor = True
        '
        'NewStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 255)
        Me.Controls.Add(Me.btn_cls)
        Me.Controls.Add(Me.btn_reg)
        Me.Controls.Add(Me.txt_course)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_regid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_cardid)
        Me.Controls.Add(Me.Label1)
        Me.Name = "NewStudent"
        Me.Text = "NewStudent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cardid As System.Windows.Forms.TextBox
    Friend WithEvents txt_regid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_course As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_reg As System.Windows.Forms.Button
    Friend WithEvents btn_cls As System.Windows.Forms.Button
End Class
