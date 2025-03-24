<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.lblNpm = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblFakultas = New System.Windows.Forms.Label()
        Me.lblJurusan = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Npm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fakultas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jurusan"
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(165, 190)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(75, 23)
        Me.btnKembali.TabIndex = 4
        Me.btnKembali.Text = "Submit"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'lblNpm
        '
        Me.lblNpm.AutoSize = True
        Me.lblNpm.Location = New System.Drawing.Point(102, 42)
        Me.lblNpm.Name = "lblNpm"
        Me.lblNpm.Size = New System.Drawing.Size(10, 13)
        Me.lblNpm.TabIndex = 5
        Me.lblNpm.Text = ":"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(102, 70)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(10, 13)
        Me.lblNama.TabIndex = 6
        Me.lblNama.Text = ":"
        '
        'lblFakultas
        '
        Me.lblFakultas.AutoSize = True
        Me.lblFakultas.Location = New System.Drawing.Point(102, 101)
        Me.lblFakultas.Name = "lblFakultas"
        Me.lblFakultas.Size = New System.Drawing.Size(10, 13)
        Me.lblFakultas.TabIndex = 7
        Me.lblFakultas.Text = ":"
        '
        'lblJurusan
        '
        Me.lblJurusan.AutoSize = True
        Me.lblJurusan.Location = New System.Drawing.Point(102, 134)
        Me.lblJurusan.Name = "lblJurusan"
        Me.lblJurusan.Size = New System.Drawing.Size(10, 13)
        Me.lblJurusan.TabIndex = 8
        Me.lblJurusan.Text = ":"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 252)
        Me.Controls.Add(Me.lblJurusan)
        Me.Controls.Add(Me.lblFakultas)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblNpm)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents lblNpm As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblFakultas As System.Windows.Forms.Label
    Friend WithEvents lblJurusan As System.Windows.Forms.Label
End Class
