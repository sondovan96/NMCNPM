<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNhanlichbay
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnThem_LCB = New System.Windows.Forms.Button()
        Me.btnXoa_LCB = New System.Windows.Forms.Button()
        Me.btnThoat_LCB = New System.Windows.Forms.Button()
        Me.btnSua_LCB = New System.Windows.Forms.Button()
        Me.lvLichCB = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMaCB_LichBay = New System.Windows.Forms.TextBox()
        Me.txtSBdi_LichBay = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lvLichCB)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1164, 208)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin lịch chuyến bay"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.txtSBdi_LichBay)
        Me.GroupBox2.Controls.Add(Me.txtMaCB_LichBay)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 293)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1164, 130)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin chi tiết"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSua_LCB)
        Me.GroupBox3.Controls.Add(Me.btnThoat_LCB)
        Me.GroupBox3.Controls.Add(Me.btnXoa_LCB)
        Me.GroupBox3.Controls.Add(Me.btnThem_LCB)
        Me.GroupBox3.Location = New System.Drawing.Point(45, 429)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1098, 94)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'btnThem_LCB
        '
        Me.btnThem_LCB.Location = New System.Drawing.Point(143, 19)
        Me.btnThem_LCB.Name = "btnThem_LCB"
        Me.btnThem_LCB.Size = New System.Drawing.Size(93, 59)
        Me.btnThem_LCB.TabIndex = 0
        Me.btnThem_LCB.Text = "Thêm"
        Me.btnThem_LCB.UseVisualStyleBackColor = True
        '
        'btnXoa_LCB
        '
        Me.btnXoa_LCB.Location = New System.Drawing.Point(389, 19)
        Me.btnXoa_LCB.Name = "btnXoa_LCB"
        Me.btnXoa_LCB.Size = New System.Drawing.Size(93, 59)
        Me.btnXoa_LCB.TabIndex = 0
        Me.btnXoa_LCB.Text = "Xoá"
        Me.btnXoa_LCB.UseVisualStyleBackColor = True
        '
        'btnThoat_LCB
        '
        Me.btnThoat_LCB.Location = New System.Drawing.Point(874, 19)
        Me.btnThoat_LCB.Name = "btnThoat_LCB"
        Me.btnThoat_LCB.Size = New System.Drawing.Size(93, 59)
        Me.btnThoat_LCB.TabIndex = 0
        Me.btnThoat_LCB.Text = "Thoát"
        Me.btnThoat_LCB.UseVisualStyleBackColor = True
        '
        'btnSua_LCB
        '
        Me.btnSua_LCB.Location = New System.Drawing.Point(611, 19)
        Me.btnSua_LCB.Name = "btnSua_LCB"
        Me.btnSua_LCB.Size = New System.Drawing.Size(93, 59)
        Me.btnSua_LCB.TabIndex = 0
        Me.btnSua_LCB.Text = "Sửa"
        Me.btnSua_LCB.UseVisualStyleBackColor = True
        '
        'lvLichCB
        '
        Me.lvLichCB.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader1})
        Me.lvLichCB.FullRowSelect = True
        Me.lvLichCB.GridLines = True
        Me.lvLichCB.HideSelection = False
        Me.lvLichCB.Location = New System.Drawing.Point(6, 16)
        Me.lvLichCB.Name = "lvLichCB"
        Me.lvLichCB.Size = New System.Drawing.Size(1152, 186)
        Me.lvLichCB.TabIndex = 0
        Me.lvLichCB.UseCompatibleStateImageBehavior = False
        Me.lvLichCB.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(439, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "LỊCH CHUYẾN BAY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã chuyến bay:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Sân bay đi:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Ngày giờ bay:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Số lượng ghế hạng 1:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(695, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Thời gian bay:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(695, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Sân bay đến:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(695, 97)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Số lượng ghế hạng 2:"
        '
        'txtMaCB_LichBay
        '
        Me.txtMaCB_LichBay.Location = New System.Drawing.Point(193, 28)
        Me.txtMaCB_LichBay.Name = "txtMaCB_LichBay"
        Me.txtMaCB_LichBay.Size = New System.Drawing.Size(186, 20)
        Me.txtMaCB_LichBay.TabIndex = 2
        '
        'txtSBdi_LichBay
        '
        Me.txtSBdi_LichBay.Location = New System.Drawing.Point(193, 50)
        Me.txtSBdi_LichBay.Name = "txtSBdi_LichBay"
        Me.txtSBdi_LichBay.Size = New System.Drawing.Size(186, 20)
        Me.txtSBdi_LichBay.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(835, 50)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(186, 20)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(835, 72)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(186, 20)
        Me.TextBox4.TabIndex = 2
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(193, 94)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(186, 20)
        Me.TextBox5.TabIndex = 2
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(835, 94)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(186, 20)
        Me.TextBox6.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(193, 72)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(186, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mã Chuyến Bay"
        Me.ColumnHeader2.Width = 99
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Sân Bay Đi"
        Me.ColumnHeader3.Width = 156
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Sân Bay Đến"
        Me.ColumnHeader4.Width = 153
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Sân bay trung gian"
        Me.ColumnHeader5.Width = 148
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Ngày giờ bay"
        Me.ColumnHeader6.Width = 168
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Thời gian dừng"
        Me.ColumnHeader7.Width = 199
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Ghi Chú"
        Me.ColumnHeader1.Width = 226
        '
        'frmNhanlichbay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1189, 539)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmNhanlichbay"
        Me.Text = "frmNhanlichbay"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lvLichCB As ListView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSua_LCB As Button
    Friend WithEvents btnThoat_LCB As Button
    Friend WithEvents btnXoa_LCB As Button
    Friend WithEvents btnThem_LCB As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents txtSBdi_LichBay As TextBox
    Friend WithEvents txtMaCB_LichBay As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
End Class
