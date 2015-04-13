<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdangnhap
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
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.btndangnhap = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Location = New System.Drawing.Point(56, 49)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(55, 13)
        Me.lblname.TabIndex = 0
        Me.lblname.Text = "Username"
        Me.lblname.UseWaitCursor = True
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Location = New System.Drawing.Point(56, 95)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(53, 13)
        Me.lblpass.TabIndex = 1
        Me.lblpass.Text = "Password"
        '
        'btndangnhap
        '
        Me.btndangnhap.Location = New System.Drawing.Point(59, 152)
        Me.btndangnhap.Name = "btndangnhap"
        Me.btndangnhap.Size = New System.Drawing.Size(75, 23)
        Me.btndangnhap.TabIndex = 2
        Me.btndangnhap.Text = "Đăng Nhập"
        Me.btndangnhap.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(223, 152)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 23)
        Me.btnthoat.TabIndex = 3
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(132, 42)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(147, 20)
        Me.txtname.TabIndex = 4
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(132, 88)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(147, 20)
        Me.txtpass.TabIndex = 5
        '
        'frmdangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 262)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btndangnhap)
        Me.Controls.Add(Me.lblpass)
        Me.Controls.Add(Me.lblname)
        Me.Name = "frmdangnhap"
        Me.Text = "Đăng Nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents btndangnhap As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox

End Class
