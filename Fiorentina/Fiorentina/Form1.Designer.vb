<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtNip = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.cbjurusan = New System.Windows.Forms.ComboBox()
        Me.cbmatkul = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbLaki = New System.Windows.Forms.RadioButton()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUAS = New System.Windows.Forms.TextBox()
        Me.txtUTS = New System.Windows.Forms.TextBox()
        Me.txtTugas = New System.Windows.Forms.TextBox()
        Me.lblgrade = New System.Windows.Forms.Label()
        Me.lbUAS = New System.Windows.Forms.Label()
        Me.lbUTS = New System.Windows.Forms.Label()
        Me.lbTugas = New System.Windows.Forms.Label()
        Me.lbNilai = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvdata = New System.Windows.Forms.DataGridView()
        Me.dgnip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgnama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgjeniskelamin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgjurusan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgmatkul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dggrade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnnew = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 163)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jurusan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 209)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Mata Kuliah"
        '
        'btnSubmit
        '
        Me.btnSubmit.Enabled = False
        Me.btnSubmit.Location = New System.Drawing.Point(395, 61)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(100, 28)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtNip
        '
        Me.txtNip.Location = New System.Drawing.Point(140, 60)
        Me.txtNip.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNip.Name = "txtNip"
        Me.txtNip.Size = New System.Drawing.Size(198, 22)
        Me.txtNip.TabIndex = 5
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(140, 106)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(251, 22)
        Me.txtNama.TabIndex = 6
        '
        'cbjurusan
        '
        Me.cbjurusan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbjurusan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbjurusan.FormattingEnabled = True
        Me.cbjurusan.Location = New System.Drawing.Point(140, 202)
        Me.cbjurusan.Margin = New System.Windows.Forms.Padding(4)
        Me.cbjurusan.Name = "cbjurusan"
        Me.cbjurusan.Size = New System.Drawing.Size(441, 24)
        Me.cbjurusan.TabIndex = 7
        '
        'cbmatkul
        '
        Me.cbmatkul.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbmatkul.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbmatkul.FormattingEnabled = True
        Me.cbmatkul.Location = New System.Drawing.Point(140, 248)
        Me.cbmatkul.Margin = New System.Windows.Forms.Padding(4)
        Me.cbmatkul.Name = "cbmatkul"
        Me.cbmatkul.Size = New System.Drawing.Size(441, 24)
        Me.cbmatkul.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 121)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(340, 214)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 17)
        Me.Label6.TabIndex = 10
        '
        'rbLaki
        '
        Me.rbLaki.AutoSize = True
        Me.rbLaki.Location = New System.Drawing.Point(174, 161)
        Me.rbLaki.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbLaki.Name = "rbLaki"
        Me.rbLaki.Size = New System.Drawing.Size(86, 21)
        Me.rbLaki.TabIndex = 11
        Me.rbLaki.TabStop = True
        Me.rbLaki.Text = "Laki-Laki"
        Me.rbLaki.UseVisualStyleBackColor = True
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Location = New System.Drawing.Point(289, 161)
        Me.rbPerempuan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(102, 21)
        Me.rbPerempuan.TabIndex = 12
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSubmit)
        Me.GroupBox1.Controls.Add(Me.txtUAS)
        Me.GroupBox1.Controls.Add(Me.txtUTS)
        Me.GroupBox1.Controls.Add(Me.txtTugas)
        Me.GroupBox1.Controls.Add(Me.lblgrade)
        Me.GroupBox1.Controls.Add(Me.lbUAS)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lbUTS)
        Me.GroupBox1.Controls.Add(Me.lbTugas)
        Me.GroupBox1.Controls.Add(Me.lbNilai)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 42)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(791, 283)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'txtUAS
        '
        Me.txtUAS.Location = New System.Drawing.Point(488, 243)
        Me.txtUAS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUAS.Name = "txtUAS"
        Me.txtUAS.Size = New System.Drawing.Size(89, 22)
        Me.txtUAS.TabIndex = 7
        '
        'txtUTS
        '
        Me.txtUTS.Location = New System.Drawing.Point(350, 243)
        Me.txtUTS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtUTS.Name = "txtUTS"
        Me.txtUTS.Size = New System.Drawing.Size(89, 22)
        Me.txtUTS.TabIndex = 6
        '
        'txtTugas
        '
        Me.txtTugas.Location = New System.Drawing.Point(186, 245)
        Me.txtTugas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTugas.Name = "txtTugas"
        Me.txtTugas.Size = New System.Drawing.Size(89, 22)
        Me.txtTugas.TabIndex = 5
        '
        'lblgrade
        '
        Me.lblgrade.AutoSize = True
        Me.lblgrade.Location = New System.Drawing.Point(599, 248)
        Me.lblgrade.Name = "lblgrade"
        Me.lblgrade.Size = New System.Drawing.Size(77, 17)
        Me.lblgrade.TabIndex = 4
        Me.lblgrade.Text = "--GRADE--"
        '
        'lbUAS
        '
        Me.lbUAS.AutoSize = True
        Me.lbUAS.Location = New System.Drawing.Point(444, 248)
        Me.lbUAS.Name = "lbUAS"
        Me.lbUAS.Size = New System.Drawing.Size(36, 17)
        Me.lbUAS.TabIndex = 3
        Me.lbUAS.Text = "UAS"
        '
        'lbUTS
        '
        Me.lbUTS.AutoSize = True
        Me.lbUTS.Location = New System.Drawing.Point(299, 248)
        Me.lbUTS.Name = "lbUTS"
        Me.lbUTS.Size = New System.Drawing.Size(36, 17)
        Me.lbUTS.TabIndex = 2
        Me.lbUTS.Text = "UTS"
        '
        'lbTugas
        '
        Me.lbTugas.AutoSize = True
        Me.lbTugas.Location = New System.Drawing.Point(132, 248)
        Me.lbTugas.Name = "lbTugas"
        Me.lbTugas.Size = New System.Drawing.Size(48, 17)
        Me.lbTugas.TabIndex = 1
        Me.lbTugas.Text = "Tugas"
        '
        'lbNilai
        '
        Me.lbNilai.AutoSize = True
        Me.lbNilai.Location = New System.Drawing.Point(59, 248)
        Me.lbNilai.Name = "lbNilai"
        Me.lbNilai.Size = New System.Drawing.Size(35, 17)
        Me.lbNilai.TabIndex = 0
        Me.lbNilai.Text = "Nilai"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(1, 399)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(794, 172)
        Me.Panel1.TabIndex = 8
        '
        'dgvdata
        '
        Me.dgvdata.AllowUserToAddRows = False
        Me.dgvdata.AllowUserToDeleteRows = False
        Me.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdata.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgnip, Me.dgnama, Me.dgjeniskelamin, Me.dgjurusan, Me.dgmatkul, Me.dggrade})
        Me.dgvdata.Location = New System.Drawing.Point(4, 408)
        Me.dgvdata.Name = "dgvdata"
        Me.dgvdata.ReadOnly = True
        Me.dgvdata.RowTemplate.Height = 24
        Me.dgvdata.Size = New System.Drawing.Size(788, 150)
        Me.dgvdata.TabIndex = 0
        '
        'dgnip
        '
        Me.dgnip.HeaderText = "NIP"
        Me.dgnip.Name = "dgnip"
        Me.dgnip.ReadOnly = True
        '
        'dgnama
        '
        Me.dgnama.HeaderText = "Nama"
        Me.dgnama.Name = "dgnama"
        Me.dgnama.ReadOnly = True
        '
        'dgjeniskelamin
        '
        Me.dgjeniskelamin.HeaderText = "Jenis Kelamin"
        Me.dgjeniskelamin.Name = "dgjeniskelamin"
        Me.dgjeniskelamin.ReadOnly = True
        '
        'dgjurusan
        '
        Me.dgjurusan.HeaderText = "Jurusan"
        Me.dgjurusan.Name = "dgjurusan"
        Me.dgjurusan.ReadOnly = True
        '
        'dgmatkul
        '
        Me.dgmatkul.HeaderText = "Mata Kuliah"
        Me.dgmatkul.Name = "dgmatkul"
        Me.dgmatkul.ReadOnly = True
        '
        'dggrade
        '
        Me.dggrade.HeaderText = "GRADE"
        Me.dggrade.Name = "dggrade"
        Me.dggrade.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnclose)
        Me.Panel2.Controls.Add(Me.btndelete)
        Me.Panel2.Controls.Add(Me.btnsave)
        Me.Panel2.Controls.Add(Me.btnnew)
        Me.Panel2.Location = New System.Drawing.Point(4, 330)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(791, 63)
        Me.Panel2.TabIndex = 14
        '
        'btnclose
        '
        Me.btnclose.BackColor = System.Drawing.Color.LightCoral
        Me.btnclose.Location = New System.Drawing.Point(469, 17)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(306, 32)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = False
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(276, 17)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(187, 32)
        Me.btndelete.TabIndex = 2
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(136, 17)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(126, 32)
        Me.btnsave.TabIndex = 1
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnnew
        '
        Me.btnnew.Location = New System.Drawing.Point(10, 17)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.Size = New System.Drawing.Size(120, 32)
        Me.btnnew.TabIndex = 0
        Me.btnnew.Text = "New"
        Me.btnnew.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 580)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvdata)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.rbPerempuan)
        Me.Controls.Add(Me.rbLaki)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbmatkul)
        Me.Controls.Add(Me.cbjurusan)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNip)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtNip As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents cbjurusan As System.Windows.Forms.ComboBox
    Friend WithEvents cbmatkul As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rbLaki As System.Windows.Forms.RadioButton
    Friend WithEvents rbPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbNilai As System.Windows.Forms.Label
    Friend WithEvents lbTugas As System.Windows.Forms.Label
    Friend WithEvents lblgrade As System.Windows.Forms.Label
    Friend WithEvents lbUAS As System.Windows.Forms.Label
    Friend WithEvents lbUTS As System.Windows.Forms.Label
    Friend WithEvents txtTugas As System.Windows.Forms.TextBox
    Friend WithEvents txtUAS As System.Windows.Forms.TextBox
    Friend WithEvents txtUTS As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgvdata As System.Windows.Forms.DataGridView
    Friend WithEvents dgnip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgnama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgjeniskelamin As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgjurusan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgmatkul As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dggrade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnnew As System.Windows.Forms.Button

End Class
