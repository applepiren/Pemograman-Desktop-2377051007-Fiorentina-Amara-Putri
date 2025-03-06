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
        ' Pastikan semua input diisi
        If txtNPM.Text = "" Or txtNama.Text = "" Or cmbFakultas.Text = "" Or cmbJurusan.Text = "" Then
            MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Mengirim data ke Form2 dengan parameter yang benar
        Dim hasilForm As New Form2(txtNpm.Text, txtNama.Text, cmbFakultas.Text, cmbJurusan.Text)
        hasilForm.Show()
        Me.Hide()
    End Sub
End Class