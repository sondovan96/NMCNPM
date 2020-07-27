<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDoanhThuNam
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
        Me.cbNam = New System.Windows.Forms.ComboBox()
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
        Me.Label1.Location = New System.Drawing.Point(154, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(421, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "BÁO CÁO DOANH THU NĂM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(145, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Năm"
        '
        'cbNam
        '
        Me.cbNam.FormattingEnabled = True
        Me.cbNam.Location = New System.Drawing.Point(215, 75)
        Me.cbNam.Name = "cbNam"
        Me.cbNam.Size = New System.Drawing.Size(121, 21)
        Me.cbNam.TabIndex = 2
        '
        'btBaoCao
        '
        Me.btBaoCao.Location = New System.Drawing.Point(148, 120)
        Me.btBaoCao.Name = "btBaoCao"
        Me.btBaoCao.Size = New System.Drawing.Size(75, 23)
        Me.btBaoCao.TabIndex = 3
        Me.btBaoCao.Text = "Báo Cáo"
        Me.btBaoCao.UseVisualStyleBackColor = True
        '
        'btThoat
        '
        Me.btThoat.Location = New System.Drawing.Point(245, 120)
        Me.btThoat.Name = "btThoat"
        Me.btThoat.Size = New System.Drawing.Size(75, 23)
        Me.btThoat.TabIndex = 4
        Me.btThoat.Text = "Thoát"
        Me.btThoat.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btBaoCao)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbNam)
        Me.Panel1.Controls.Add(Me.btThoat)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(719, 165)
        Me.Panel1.TabIndex = 5
        '
        'frmDoanhThuNam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 261)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDoanhThuNam"
        Me.Text = "DoanhThuNam"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbNam As ComboBox
    Friend WithEvents btBaoCao As Button
    Friend WithEvents btThoat As Button
    Friend WithEvents Panel1 As Panel
End Class
