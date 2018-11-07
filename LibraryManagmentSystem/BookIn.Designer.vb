<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookIn
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
        Me.txt_cardid = New System.Windows.Forms.TextBox()
        Me.txt_borrowcode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_returnstatus = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_proceed = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_cardid
        '
        Me.txt_cardid.Location = New System.Drawing.Point(149, 86)
        Me.txt_cardid.Name = "txt_cardid"
        Me.txt_cardid.Size = New System.Drawing.Size(224, 20)
        Me.txt_cardid.TabIndex = 66
        '
        'txt_borrowcode
        '
        Me.txt_borrowcode.Location = New System.Drawing.Point(149, 42)
        Me.txt_borrowcode.Name = "txt_borrowcode"
        Me.txt_borrowcode.Size = New System.Drawing.Size(224, 20)
        Me.txt_borrowcode.TabIndex = 68
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "BORROW CODE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "CARD NUMBER"
        '
        'cmb_returnstatus
        '
        Me.cmb_returnstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_returnstatus.FormattingEnabled = True
        Me.cmb_returnstatus.Items.AddRange(New Object() {"NOT RETURNED", "RETURNED"})
        Me.cmb_returnstatus.Location = New System.Drawing.Point(149, 133)
        Me.cmb_returnstatus.Name = "cmb_returnstatus"
        Me.cmb_returnstatus.Size = New System.Drawing.Size(224, 21)
        Me.cmb_returnstatus.TabIndex = 69
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "RETURN STATUS"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(274, 190)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(99, 23)
        Me.btn_cancel.TabIndex = 72
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_proceed
        '
        Me.btn_proceed.Location = New System.Drawing.Point(43, 190)
        Me.btn_proceed.Name = "btn_proceed"
        Me.btn_proceed.Size = New System.Drawing.Size(99, 23)
        Me.btn_proceed.TabIndex = 71
        Me.btn_proceed.Text = "PROCEED"
        Me.btn_proceed.UseVisualStyleBackColor = True
        '
        'BookIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 243)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_proceed)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_returnstatus)
        Me.Controls.Add(Me.txt_cardid)
        Me.Controls.Add(Me.txt_borrowcode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Name = "BookIn"
        Me.Text = "BookIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_cardid As System.Windows.Forms.TextBox
    Friend WithEvents txt_borrowcode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_returnstatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_proceed As System.Windows.Forms.Button
End Class
