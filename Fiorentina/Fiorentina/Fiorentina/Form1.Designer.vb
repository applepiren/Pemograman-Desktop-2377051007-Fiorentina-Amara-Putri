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
        Me.txtNpm = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.cmbFakultas = New System.Windows.Forms.ComboBox()
        Me.cmbJurusan = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbLaki = New System.Windows.Forms.RadioButton()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbNilai = New System.Windows.Forms.Label()
        Me.lbTugas = New System.Windows.Forms.Label()
        Me.lbUTS = New System.Windows.Forms.Label()
        Me.lbUAS = New System.Windows.Forms.Label()
        Me.lbGRADE = New System.Windows.Forms.Label()
        Me.txtTugas = New System.Windows.Forms.TextBox()
        Me.txtUTS = New System.Windows.Forms.TextBox()
        Me.txtUAS = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Npm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 132)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 252)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fakultas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 318)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jurusan"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(7, 81)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(112, 35)
        Me.btnSubmit.TabIndex = 4
        Me.btnSubmit.Text = "Process"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'txtNpm
        '
        Me.txtNpm.Location = New System.Drawing.Point(158, 75)
        Me.txtNpm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNpm.Name = "txtNpm"
        Me.txtNpm.Size = New System.Drawing.Size(222, 26)
        Me.txtNpm.TabIndex = 5
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(158, 132)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(222, 26)
        Me.txtNama.TabIndex = 6
        '
        'cmbFakultas
        '
        Me.cmbFakultas.FormattingEnabled = True
        Me.cmbFakultas.Location = New System.Drawing.Point(158, 252)
        Me.cmbFakultas.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbFakultas.Name = "cmbFakultas"
        Me.cmbFakultas.Size = New System.Drawing.Size(330, 28)
        Me.cmbFakultas.TabIndex = 7
        '
        'cmbJurusan
        '
        Me.cmbJurusan.FormattingEnabled = True
        Me.cmbJurusan.Location = New System.Drawing.Point(158, 310)
        Me.cmbJurusan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbJurusan.Name = "cmbJurusan"
        Me.cmbJurusan.Size = New System.Drawing.Size(330, 28)
        Me.cmbJurusan.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(58, 201)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(382, 267)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 20)
        Me.Label6.TabIndex = 10
        '
        'rbLaki
        '
        Me.rbLaki.AutoSize = True
        Me.rbLaki.Location = New System.Drawing.Point(196, 201)
        Me.rbLaki.Name = "rbLaki"
        Me.rbLaki.Size = New System.Drawing.Size(97, 24)
        Me.rbLaki.TabIndex = 11
        Me.rbLaki.TabStop = True
        Me.rbLaki.Text = "Laki-Laki"
        Me.rbLaki.UseVisualStyleBackColor = True
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Location = New System.Drawing.Point(325, 201)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(116, 24)
        Me.rbPerempuan.TabIndex = 12
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUAS)
        Me.GroupBox1.Controls.Add(Me.txtUTS)
        Me.GroupBox1.Controls.Add(Me.txtTugas)
        Me.GroupBox1.Controls.Add(Me.lbGRADE)
        Me.GroupBox1.Controls.Add(Me.lbUAS)
        Me.GroupBox1.Controls.Add(Me.lbUTS)
        Me.GroupBox1.Controls.Add(Me.lbTugas)
        Me.GroupBox1.Controls.Add(Me.lbNilai)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(829, 354)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSubmit)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 412)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(812, 124)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'lbNilai
        '
        Me.lbNilai.AutoSize = True
        Me.lbNilai.Location = New System.Drawing.Point(66, 310)
        Me.lbNilai.Name = "lbNilai"
        Me.lbNilai.Size = New System.Drawing.Size(38, 20)
        Me.lbNilai.TabIndex = 0
        Me.lbNilai.Text = "Nilai"
        '
        'lbTugas
        '
        Me.lbTugas.AutoSize = True
        Me.lbTugas.Location = New System.Drawing.Point(149, 310)
        Me.lbTugas.Name = "lbTugas"
        Me.lbTugas.Size = New System.Drawing.Size(53, 20)
        Me.lbTugas.TabIndex = 1
        Me.lbTugas.Text = "Tugas"
        '
        'lbUTS
        '
        Me.lbUTS.AutoSize = True
        Me.lbUTS.Location = New System.Drawing.Point(336, 310)
        Me.lbUTS.Name = "lbUTS"
        Me.lbUTS.Size = New System.Drawing.Size(41, 20)
        Me.lbUTS.TabIndex = 2
        Me.lbUTS.Text = "UTS"
        '
        'lbUAS
        '
        Me.lbUAS.AutoSize = True
        Me.lbUAS.Location = New System.Drawing.Point(500, 310)
        Me.lbUAS.Name = "lbUAS"
        Me.lbUAS.Size = New System.Drawing.Size(43, 20)
        Me.lbUAS.TabIndex = 3
        Me.lbUAS.Text = "UAS"
        '
        'lbGRADE
        '
        Me.lbGRADE.AutoSize = True
        Me.lbGRADE.Location = New System.Drawing.Point(674, 310)
        Me.lbGRADE.Name = "lbGRADE"
        Me.lbGRADE.Size = New System.Drawing.Size(88, 20)
        Me.lbGRADE.TabIndex = 4
        Me.lbGRADE.Text = "--GRADE--"
        '
        'txtTugas
        '
        Me.txtTugas.Location = New System.Drawing.Point(208, 310)
        Me.txtTugas.Name = "txtTugas"
        Me.txtTugas.Size = New System.Drawing.Size(100, 26)
        Me.txtTugas.TabIndex = 5
        '
        'txtUTS
        '
        Me.txtUTS.Location = New System.Drawing.Point(394, 304)
        Me.txtUTS.Name = "txtUTS"
        Me.txtUTS.Size = New System.Drawing.Size(100, 26)
        Me.txtUTS.TabIndex = 6
        '
        'txtUAS
        '
        Me.txtUAS.Location = New System.Drawing.Point(549, 304)
        Me.txtUAS.Name = "txtUAS"
        Me.txtUAS.Size = New System.Drawing.Size(100, 26)
        Me.txtUAS.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 555)
        Me.Controls.Add(Me.rbPerempuan)
        Me.Controls.Add(Me.rbLaki)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbJurusan)
        Me.Controls.Add(Me.cmbFakultas)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtNpm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtNpm As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents cmbFakultas As System.Windows.Forms.ComboBox
    Friend WithEvents cmbJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents rbLaki As System.Windows.Forms.RadioButton
    Friend WithEvents rbPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbNilai As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbTugas As System.Windows.Forms.Label
    Friend WithEvents lbGRADE As System.Windows.Forms.Label
    Friend WithEvents lbUAS As System.Windows.Forms.Label
    Friend WithEvents lbUTS As System.Windows.Forms.Label
    Friend WithEvents txtTugas As System.Windows.Forms.TextBox
    Friend WithEvents txtUAS As System.Windows.Forms.TextBox
    Friend WithEvents txtUTS As System.Windows.Forms.TextBox

End Class
