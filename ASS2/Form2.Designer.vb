<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmquanly
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
        Me.lblma = New System.Windows.Forms.Label()
        Me.lblten = New System.Windows.Forms.Label()
        Me.lblma2 = New System.Windows.Forms.Label()
        Me.lblma3 = New System.Windows.Forms.Label()
        Me.txtma = New System.Windows.Forms.TextBox()
        Me.txtten = New System.Windows.Forms.TextBox()
        Me.txtdongia = New System.Windows.Forms.TextBox()
        Me.txtsoluong = New System.Windows.Forms.TextBox()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.bntthoat = New System.Windows.Forms.Button()
        Me.lblma4 = New System.Windows.Forms.Label()
        Me.txtchitiet = New System.Windows.Forms.TextBox()
        Me.dataview = New System.Windows.Forms.DataGridView()
        Me.txtLoai = New System.Windows.Forms.TextBox()
        Me.lblloai = New System.Windows.Forms.Label()
        CType(Me.dataview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblma
        '
        Me.lblma.AutoSize = True
        Me.lblma.Location = New System.Drawing.Point(27, 22)
        Me.lblma.Name = "lblma"
        Me.lblma.Size = New System.Drawing.Size(22, 13)
        Me.lblma.TabIndex = 0
        Me.lblma.Text = "Mã"
        '
        'lblten
        '
        Me.lblten.AutoSize = True
        Me.lblten.Location = New System.Drawing.Point(23, 58)
        Me.lblten.Name = "lblten"
        Me.lblten.Size = New System.Drawing.Size(26, 13)
        Me.lblten.TabIndex = 1
        Me.lblten.Text = "Tên"
        '
        'lblma2
        '
        Me.lblma2.AutoSize = True
        Me.lblma2.Location = New System.Drawing.Point(27, 94)
        Me.lblma2.Name = "lblma2"
        Me.lblma2.Size = New System.Drawing.Size(46, 13)
        Me.lblma2.TabIndex = 2
        Me.lblma2.Text = "Đơn Giá"
        '
        'lblma3
        '
        Me.lblma3.AutoSize = True
        Me.lblma3.Location = New System.Drawing.Point(27, 135)
        Me.lblma3.Name = "lblma3"
        Me.lblma3.Size = New System.Drawing.Size(49, 13)
        Me.lblma3.TabIndex = 3
        Me.lblma3.Text = "Số lượng"
        '
        'txtma
        '
        Me.txtma.Location = New System.Drawing.Point(110, 19)
        Me.txtma.Name = "txtma"
        Me.txtma.Size = New System.Drawing.Size(204, 20)
        Me.txtma.TabIndex = 0
        '
        'txtten
        '
        Me.txtten.Location = New System.Drawing.Point(110, 55)
        Me.txtten.Name = "txtten"
        Me.txtten.Size = New System.Drawing.Size(204, 20)
        Me.txtten.TabIndex = 1
        '
        'txtdongia
        '
        Me.txtdongia.Location = New System.Drawing.Point(110, 91)
        Me.txtdongia.Name = "txtdongia"
        Me.txtdongia.Size = New System.Drawing.Size(100, 20)
        Me.txtdongia.TabIndex = 2
        '
        'txtsoluong
        '
        Me.txtsoluong.Location = New System.Drawing.Point(110, 132)
        Me.txtsoluong.Name = "txtsoluong"
        Me.txtsoluong.Size = New System.Drawing.Size(100, 20)
        Me.txtsoluong.TabIndex = 3
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(12, 230)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 8
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(178, 230)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 9
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(346, 230)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 10
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'bntthoat
        '
        Me.bntthoat.Location = New System.Drawing.Point(518, 230)
        Me.bntthoat.Name = "bntthoat"
        Me.bntthoat.Size = New System.Drawing.Size(75, 23)
        Me.bntthoat.TabIndex = 11
        Me.bntthoat.Text = "Thoát"
        Me.bntthoat.UseVisualStyleBackColor = True
        '
        'lblma4
        '
        Me.lblma4.AutoSize = True
        Me.lblma4.Location = New System.Drawing.Point(27, 174)
        Me.lblma4.Name = "lblma4"
        Me.lblma4.Size = New System.Drawing.Size(39, 13)
        Me.lblma4.TabIndex = 13
        Me.lblma4.Text = "Chi tiết"
        '
        'txtchitiet
        '
        Me.txtchitiet.Location = New System.Drawing.Point(110, 171)
        Me.txtchitiet.Name = "txtchitiet"
        Me.txtchitiet.Size = New System.Drawing.Size(100, 20)
        Me.txtchitiet.TabIndex = 4
        '
        'dataview
        '
        Me.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataview.Location = New System.Drawing.Point(12, 270)
        Me.dataview.Name = "dataview"
        Me.dataview.Size = New System.Drawing.Size(702, 150)
        Me.dataview.TabIndex = 14
        '
        'txtLoai
        '
        Me.txtLoai.Location = New System.Drawing.Point(110, 197)
        Me.txtLoai.Name = "txtLoai"
        Me.txtLoai.Size = New System.Drawing.Size(100, 20)
        Me.txtLoai.TabIndex = 5
        '
        'lblloai
        '
        Me.lblloai.AutoSize = True
        Me.lblloai.Location = New System.Drawing.Point(27, 204)
        Me.lblloai.Name = "lblloai"
        Me.lblloai.Size = New System.Drawing.Size(27, 13)
        Me.lblloai.TabIndex = 5
        Me.lblloai.Text = "Loại"
        '
        'frmquanly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 432)
        Me.Controls.Add(Me.lblloai)
        Me.Controls.Add(Me.txtLoai)
        Me.Controls.Add(Me.dataview)
        Me.Controls.Add(Me.txtchitiet)
        Me.Controls.Add(Me.lblma4)
        Me.Controls.Add(Me.bntthoat)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.txtsoluong)
        Me.Controls.Add(Me.txtdongia)
        Me.Controls.Add(Me.txtten)
        Me.Controls.Add(Me.txtma)
        Me.Controls.Add(Me.lblma3)
        Me.Controls.Add(Me.lblma2)
        Me.Controls.Add(Me.lblten)
        Me.Controls.Add(Me.lblma)
        Me.Name = "frmquanly"
        Me.Text = "QLSanPham"
        CType(Me.dataview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblma As System.Windows.Forms.Label
    Friend WithEvents lblten As System.Windows.Forms.Label
    Friend WithEvents lblma2 As System.Windows.Forms.Label
    Friend WithEvents lblma3 As System.Windows.Forms.Label
    Friend WithEvents txtma As System.Windows.Forms.TextBox
    Friend WithEvents txtten As System.Windows.Forms.TextBox
    Friend WithEvents txtdongia As System.Windows.Forms.TextBox
    Friend WithEvents txtsoluong As System.Windows.Forms.TextBox
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents bntthoat As System.Windows.Forms.Button
    Friend WithEvents lblma4 As System.Windows.Forms.Label
    Friend WithEvents txtchitiet As System.Windows.Forms.TextBox
    Friend WithEvents dataview As System.Windows.Forms.DataGridView
    Friend WithEvents txtLoai As System.Windows.Forms.TextBox
    Friend WithEvents lblloai As System.Windows.Forms.Label
End Class
