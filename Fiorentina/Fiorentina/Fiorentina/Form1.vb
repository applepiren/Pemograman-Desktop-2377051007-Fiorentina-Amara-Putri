Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menghapus item sebelumnya agar tidak duplikasi
        cmbFakultas.Items.Clear()
        cmbJurusan.Items.Clear()

        ' Menambahkan pilihan fakultas ke ComboBox
        cmbFakultas.Items.Add("Fakultas Ekonomi dan Bisnis")
        cmbFakultas.Items.Add("Fakultas Teknik")
        cmbFakultas.Items.Add("Fakultas Kedokteran")
        cmbFakultas.Items.Add("Fakultas Matematika dan Ilmu Pengetahuan Alam")

        ' Menambahkan pilihan jurusan ke ComboBox
        cmbJurusan.Items.Add("Informatika")
        cmbJurusan.Items.Add("Ilmu Komputer")
        cmbJurusan.Items.Add("Akuntansi")
        cmbJurusan.Items.Add("Manajemen")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Ambil nilai dari TextBox
        Dim nilaiTugas As Double = Double.Parse(txtTugas.Text)
        Dim nilaiUTS As Double = Double.Parse(txtUTS.Text)
        Dim nilaiUAS As Double = Double.Parse(txtUAS.Text)

        ' Hitung total nilai dengan bobot
        Dim totalNilai As Double = (nilaiTugas * 0.3) + (nilaiUTS * 0.3) + (nilaiUAS * 0.4)

        ' Tentukan grade berdasarkan total nilai
        Dim grade As String
        Select Case totalNilai
            Case Is >= 78
                grade = "A"
            Case Is >= 65
                grade = "B"
            Case Is >= 50
                grade = "C"
            Case Is >= 40
                grade = "D"
            Case Else
                grade = "E"
        End Select

        ' Pastikan semua input diisi
        If txtNpm.Text = "" Or txtNama.Text = "" Or cmbFakultas.Text = "" Or cmbJurusan.Text = "" Or (Not rbLaki.Checked And Not rbPerempuan.Checked) Then
            MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Tentukan jenis kelamin berdasarkan radio button yang dipilih
        Dim jenisKelamin As String = ""
        If rbLaki.Checked Then
            jenisKelamin = "Laki-laki"
        ElseIf rbPerempuan.Checked Then
            jenisKelamin = "Perempuan"
        End If

        ' Buat pesan untuk MessageBox
        Dim pesan As String = "Hai: " & txtNama.Text & vbCrLf &
                              "NIP: " & txtNpm.Text & vbCrLf &
                              "Fakultas: " & cmbFakultas.Text & vbCrLf &
                              "Jurusan: " & cmbJurusan.Text & vbCrLf &
                              "Jenis Kelamin: " & jenisKelamin & vbCrLf &
                              "Nilai Akhir: " & totalNilai.ToString("F2") & vbCrLf &
                              "GRADE: " & grade

        ' Tampilkan MessageBox
        MessageBox.Show(pesan, "Informasi Data", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Mengirim data ke Form2 dengan parameter yang benar
        Dim hasilForm As New Form2(txtNpm.Text, txtNama.Text, cmbFakultas.Text, cmbJurusan.Text, jenisKelamin)
        hasilForm.Show() ' Menampilkan Form2
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lbNilai.Click
        ' Event handler untuk klik pada Label7
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lbTugas.Click
        ' Event handler untuk klik pada Label8
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtTugas.TextChanged
        ' Event handler untuk perubahan teks pada TextBox1
    End Sub
End Class
