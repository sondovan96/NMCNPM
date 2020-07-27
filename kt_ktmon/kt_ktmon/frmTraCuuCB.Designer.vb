<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTraCuuCB
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
        Me.lbSanBayDi = New System.Windows.Forms.Label()
        Me.lbSanBayDen = New System.Windows.Forms.Label()
        Me.lbNgayKhoiHanh = New System.Windows.Forms.Label()
        Me.lbTu = New System.Windows.Forms.Label()
        Me.lbDen = New System.Windows.Forms.Label()
        Me.dtpTu = New System.Windows.Forms.DateTimePicker()
        Me.dtpDen = New System.Windows.Forms.DateTimePicker()
        Me.cbSanBayDen = New System.Windows.Forms.ComboBox()
        Me.cbSanBayDi = New System.Windows.Forms.ComboBox()
        Me.btTim = New System.Windows.Forms.Button()
        Me.lsvDanhSachChuyenBay = New System.Windows.Forms.ListView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(257, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TRA CỨU CHUYẾN BAY"
        '
        'lbSanBayDi
        '
        Me.lbSanBayDi.AutoSize = True
        Me.lbSanBayDi.Location = New System.Drawing.Point(138, 62)
        Me.lbSanBayDi.Name = "lbSanBayDi"
        Me.lbSanBayDi.Size = New System.Drawing.Size(60, 13)
        Me.lbSanBayDi.TabIndex = 1
        Me.lbSanBayDi.Text = "Sân Bay Đi"
        '
        'lbSanBayDen
        '
        Me.lbSanBayDen.AutoSize = True
        Me.lbSanBayDen.Location = New System.Drawing.Point(471, 62)
        Me.lbSanBayDen.Name = "lbSanBayDen"
        Me.lbSanBayDen.Size = New System.Drawing.Size(70, 13)
        Me.lbSanBayDen.TabIndex = 2
        Me.lbSanBayDen.Text = "Sân Bay Đến"
        '
        'lbNgayKhoiHanh
        '
        Me.lbNgayKhoiHanh.AutoSize = True
        Me.lbNgayKhoiHanh.Location = New System.Drawing.Point(138, 99)
        Me.lbNgayKhoiHanh.Name = "lbNgayKhoiHanh"
        Me.lbNgayKhoiHanh.Size = New System.Drawing.Size(85, 13)
        Me.lbNgayKhoiHanh.TabIndex = 3
        Me.lbNgayKhoiHanh.Text = "Ngày Khởi Hành"
        '
        'lbTu
        '
        Me.lbTu.AutoSize = True
        Me.lbTu.Location = New System.Drawing.Point(237, 126)
        Me.lbTu.Name = "lbTu"
        Me.lbTu.Size = New System.Drawing.Size(20, 13)
        Me.lbTu.TabIndex = 4
        Me.lbTu.Text = "Từ"
        '
        'lbDen
        '
        Me.lbDen.AutoSize = True
        Me.lbDen.Location = New System.Drawing.Point(427, 126)
        Me.lbDen.Name = "lbDen"
        Me.lbDen.Size = New System.Drawing.Size(27, 13)
        Me.lbDen.TabIndex = 5
        Me.lbDen.Text = "Đến"
        '
        'dtpTu
        '
        Me.dtpTu.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTu.Location = New System.Drawing.Point(277, 126)
        Me.dtpTu.Name = "dtpTu"
        Me.dtpTu.Size = New System.Drawing.Size(109, 20)
        Me.dtpTu.TabIndex = 8
        '
        'dtpDen
        '
        Me.dtpDen.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDen.Location = New System.Drawing.Point(495, 126)
        Me.dtpDen.Name = "dtpDen"
        Me.dtpDen.Size = New System.Drawing.Size(105, 20)
        Me.dtpDen.TabIndex = 9
        '
        'cbSanBayDen
        '
        Me.cbSanBayDen.FormattingEnabled = True
        Me.cbSanBayDen.Location = New System.Drawing.Point(576, 59)
        Me.cbSanBayDen.Name = "cbSanBayDen"
        Me.cbSanBayDen.Size = New System.Drawing.Size(121, 21)
        Me.cbSanBayDen.TabIndex = 10
        '
        'cbSanBayDi
        '
        Me.cbSanBayDi.FormattingEnabled = True
        Me.cbSanBayDi.Location = New System.Drawing.Point(265, 59)
        Me.cbSanBayDi.Name = "cbSanBayDi"
        Me.cbSanBayDi.Size = New System.Drawing.Size(121, 21)
        Me.cbSanBayDi.TabIndex = 11
        '
        'btTim
        '
        Me.btTim.Location = New System.Drawing.Point(23, 164)
        Me.btTim.Name = "btTim"
        Me.btTim.Size = New System.Drawing.Size(75, 23)
        Me.btTim.TabIndex = 12
        Me.btTim.Text = "Tìm"
        Me.btTim.UseVisualStyleBackColor = True
        '
        'lsvDanhSachChuyenBay
        '
        Me.lsvDanhSachChuyenBay.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.lsvDanhSachChuyenBay.FullRowSelect = True
        Me.lsvDanhSachChuyenBay.GridLines = True
        Me.lsvDanhSachChuyenBay.HideSelection = False
        Me.lsvDanhSachChuyenBay.Location = New System.Drawing.Point(13, 219)
        Me.lsvDanhSachChuyenBay.Name = "lsvDanhSachChuyenBay"
        Me.lsvDanhSachChuyenBay.Size = New System.Drawing.Size(769, 232)
        Me.lsvDanhSachChuyenBay.TabIndex = 13
        Me.lsvDanhSachChuyenBay.UseCompatibleStateImageBehavior = False
        Me.lsvDanhSachChuyenBay.View = System.Windows.Forms.View.Details
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 203)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Danh Sách Chuyến Bay"
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(13, 457)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(75, 23)
        Me.btThoat.TabIndex = 15
        Me.btThoat.Text = "Thoát"
        Me.btThoat.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbSanBayDi)
        Me.Panel1.Controls.Add(Me.btThoat)
        Me.Panel1.Controls.Add(Me.lbSanBayDen)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lsvDanhSachChuyenBay)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lbNgayKhoiHanh)
        Me.Panel1.Controls.Add(Me.lbTu)
        Me.Panel1.Controls.Add(Me.btTim)
        Me.Panel1.Controls.Add(Me.dtpTu)
        Me.Panel1.Controls.Add(Me.cbSanBayDen)
        Me.Panel1.Controls.Add(Me.cbSanBayDi)
        Me.Panel1.Controls.Add(Me.dtpDen)
        Me.Panel1.Controls.Add(Me.lbDen)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(839, 494)
        Me.Panel1.TabIndex = 16
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Mã chuyến bay"
        Me.ColumnHeader1.Width = 95
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Sân bay đi"
        Me.ColumnHeader2.Width = 155
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Sân bay đến"
        Me.ColumnHeader3.Width = 126
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Khởi hành"
        Me.ColumnHeader4.Width = 96
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Thời gian bay"
        Me.ColumnHeader5.Width = 95
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Số ghế trống"
        Me.ColumnHeader6.Width = 97
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Số ghế đặt"
        Me.ColumnHeader7.Width = 106
        '
        'TraCuuChuyenBay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 529)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "TraCuuChuyenBay"
        Me.Text = "TraCuuChuyenBay"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbSanBayDi As Label
    Friend WithEvents lbSanBayDen As Label
    Friend WithEvents lbNgayKhoiHanh As Label
    Friend WithEvents lbTu As Label
    Friend WithEvents lbDen As Label
    Friend WithEvents dtpTu As DateTimePicker
    Friend WithEvents dtpDen As DateTimePicker
    Friend WithEvents cbSanBayDen As ComboBox
    Friend WithEvents cbSanBayDi As ComboBox
    Friend WithEvents btTim As Button
    Friend WithEvents lsvDanhSachChuyenBay As ListView
    Friend WithEvents Label7 As Label
    Friend WithEvents btThoat As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
End Class
