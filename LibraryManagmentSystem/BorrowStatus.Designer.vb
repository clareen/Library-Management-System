<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowStatus
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
        Me.dgv_bookstatus = New System.Windows.Forms.DataGridView()
        Me.txt_borrowcode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_returnstatus = New System.Windows.Forms.ComboBox()
        Me.btn_srch = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgv_bookstatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_bookstatus
        '
        Me.dgv_bookstatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_bookstatus.Location = New System.Drawing.Point(36, 190)
        Me.dgv_bookstatus.Name = "dgv_bookstatus"
        Me.dgv_bookstatus.Size = New System.Drawing.Size(750, 209)
        Me.dgv_bookstatus.TabIndex = 0
        '
        'txt_borrowcode
        '
        Me.txt_borrowcode.Location = New System.Drawing.Point(329, 30)
        Me.txt_borrowcode.Name = "txt_borrowcode"
        Me.txt_borrowcode.Size = New System.Drawing.Size(224, 20)
        Me.txt_borrowcode.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(218, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "BORROW CODE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(209, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "RETURN STATUS"
        '
        'cmb_returnstatus
        '
        Me.cmb_returnstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_returnstatus.FormattingEnabled = True
        Me.cmb_returnstatus.Items.AddRange(New Object() {"NOT RETURNED", "RETURNED"})
        Me.cmb_returnstatus.Location = New System.Drawing.Point(329, 70)
        Me.cmb_returnstatus.Name = "cmb_returnstatus"
        Me.cmb_returnstatus.Size = New System.Drawing.Size(224, 21)
        Me.cmb_returnstatus.TabIndex = 71
        '
        'btn_srch
        '
        Me.btn_srch.Location = New System.Drawing.Point(221, 141)
        Me.btn_srch.Name = "btn_srch"
        Me.btn_srch.Size = New System.Drawing.Size(129, 23)
        Me.btn_srch.TabIndex = 73
        Me.btn_srch.Text = "SEARCH"
        Me.btn_srch.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(424, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 23)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BorrowStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 414)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_srch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_returnstatus)
        Me.Controls.Add(Me.txt_borrowcode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dgv_bookstatus)
        Me.Name = "BorrowStatus"
        Me.Text = "BorrowStatus"
        CType(Me.dgv_bookstatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_bookstatus As System.Windows.Forms.DataGridView
    Friend WithEvents txt_borrowcode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_returnstatus As System.Windows.Forms.ComboBox
    Friend WithEvents btn_srch As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
