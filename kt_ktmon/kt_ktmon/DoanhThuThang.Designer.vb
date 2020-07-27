<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoanhThuThang
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbThang = New System.Windows.Forms.ComboBox()
        Me.cbNam = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btBaoCao = New System.Windows.Forms.Button()
        Me.btThoat = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(193, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(461, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BÁO CÁO DOANH THU THÁNG"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tháng"
        '
        'cbThang
        '
        Me.cbThang.FormattingEnabled = True
        Me.cbThang.Location = New System.Drawing.Point(271, 63)
        Me.cbThang.Name = "cbThang"
        Me.cbThang.Size = New System.Drawing.Size(121, 21)
        Me.cbThang.TabIndex = 2
        '
        'cbNam
        '
        Me.cbNam.FormattingEnabled = True
        Me.cbNam.Location = New System.Drawing.Point(271, 113)
        Me.cbNam.Name = "cbNam"
        Me.cbNam.Size = New System.Drawing.Size(121, 21)
        Me.cbNam.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(196, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Năm"
        '
        'btBaoCao
        '
        Me.btBaoCao.Location = New System.Drawing.Point(190, 178)
        Me.btBaoCao.Name = "btBaoCao"
        Me.btBaoCao.Size = New System.Drawing.Size(75, 23)
        Me.btBaoCao.TabIndex = 5
        Me.btBaoCao.Text = "Báo Cáo"
        Me.btBaoCao.UseVisualStyleBackColor = True
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(271, 178)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(75, 23)
        Me.btThoat.TabIndex = 6
        Me.btThoat.Text = "Thoát"
        Me.btThoat.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btThoat)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btBaoCao)
        Me.Panel1.Controls.Add(Me.cbThang)
        Me.Panel1.Controls.Add(Me.cbNam)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(788, 325)
        Me.Panel1.TabIndex = 7
        '
        'frmDoanhThuThang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(812, 349)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDoanhThuThang"
        Me.Text = "DoanhThuThang"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbThang As ComboBox
    Friend WithEvents cbNam As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btBaoCao As Button
    Friend WithEvents btThoat As Button
    Friend WithEvents Panel1 As Panel
End Class
