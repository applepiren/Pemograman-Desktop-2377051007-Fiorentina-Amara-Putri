Public Class Form1

    Private Sub txtnip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNip.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbjurusan.Items.Add("Manajemen Informatika")
        cbjurusan.Items.Add("Ilmu Komputer")
        cbjurusan.Items.Add("Sistem Informasi")
    End Sub

    Private Sub cbfakultas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbjurusan.SelectedIndexChanged
        Dim fakultas As String = cbjurusan.SelectedItem
        cbmatkul.Items.Clear()
        Select Case (fakultas)
            Case "Manajemen Informatika"
                cbmatkul.Items.Add("Pemrograman Desktop")
                cbmatkul.Items.Add("PBWL")
            Case "Ilmu Komputer"
                cbmatkul.Items.Add("Kecerdasan Buatan")
                cbmatkul.Items.Add("Kalkulus")
            Case "Sistem Informasi"
                cbmatkul.Items.Add("Pemrograman Web")
                cbmatkul.Items.Add("Dasar Dasar Pemrograman")
        End Select
    End Sub

    Private Sub UpdateGrade()
        Dim tugas, uts, uas As Double
        If Double.TryParse(txtTugas.Text, tugas) AndAlso Double.TryParse(txtUTS.Text, uts) AndAlso Double.TryParse(txtUAS.Text, uas) Then
            Dim total As Double = (tugas * 0.3) + (uts * 0.3) + (uas * 0.4)
            Dim grade As String

            Select Case total
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

            lblgrade.Text = " " & grade
        Else
            lblgrade.Text = " -GRADE- "
        End If
    End Sub

    Private Sub txttugas_TextChanged(sender As Object, e As EventArgs) Handles txtTugas.TextChanged
        UpdateGrade()
    End Sub

    Private Sub txtuts_TextChanged(sender As Object, e As EventArgs) Handles txtUTS.TextChanged
        UpdateGrade()
    End Sub

    Private Sub txtuas_TextChanged(sender As Object, e As EventArgs) Handles txtUAS.TextChanged
        UpdateGrade()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtNip.Clear()
        txtNama.Clear()
        txtTugas.Clear()
        txtUTS.Clear()
        txtUAS.Clear()

        cbjurusan.SelectedIndex = -1
        cbmatkul.Items.Clear()
        cbmatkul.SelectedIndex = -1
        cbmatkul.Text = ""

        rbLaki.Checked = False
        rbPerempuan.Checked = False

        lblgrade.Text = " -GRADE- "

        txtNip.Enabled = True
        txtNip.Focus()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If txtNip.Text = "" Or txtNama.Text = "" Or cbmatkul.Text = "" Or (Not rbLaki.Checked And Not rbPerempuan.Checked) Then
            MessageBox.Show("Harap isi semua data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim rowIndex As Integer = -1
        For Each row As DataGridViewRow In dgvdata.Rows
            If row.Cells("dgnip").Value IsNot Nothing AndAlso row.Cells("dgnip").Value.ToString() = txtNip.Text Then
                rowIndex = row.Index
                Exit For
            End If
        Next

        If rowIndex = -1 Then
            dgvdata.Rows.Add(txtNip.Text, txtNama.Text, If(rbLaki.Checked, "Laki-Laki", "Perempuan"), cbjurusan.Text, cbmatkul.Text, lblgrade.Text)
        Else
            dgvdata.Rows(rowIndex).Cells("dgnip").Value = txtNip.Text
            dgvdata.Rows(rowIndex).Cells("dgnama").Value = txtNama.Text
            dgvdata.Rows(rowIndex).Cells("dgjeniskelamin").Value = If(rbLaki.Checked, "Laki-Laki", "Perempuan")
            dgvdata.Rows(rowIndex).Cells("dgjurusan").Value = cbjurusan.Text
            dgvdata.Rows(rowIndex).Cells("dgmatkul").Value = cbmatkul.Text
            dgvdata.Rows(rowIndex).Cells("dggrade").Value = lblgrade.Text
        End If
        btnnew.PerformClick()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If dgvdata.SelectedRows.Count > 0 Then
            Dim confirm As DialogResult = MessageBox.Show("Apakah yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If confirm = DialogResult.Yes Then
                dgvdata.Rows.RemoveAt(dgvdata.SelectedRows(0).Index)
                btnnew.PerformClick()
            End If
        Else
            MessageBox.Show("Pilih data yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub dgvdata_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdata.CellDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim row As DataGridViewRow = dgvdata.Rows(e.RowIndex)

            txtNip.Text = row.Cells("dgnip").Value.ToString()
            txtNama.Text = row.Cells("dgnama").Value.ToString()

            If row.Cells("dgjeniskelamin").Value.ToString() = "Laki-Laki" Then
                rbLaki.Checked = True
            Else
                rbPerempuan.Checked = True
            End If
            cbjurusan.Text = row.Cells("dgjurusan").Value.ToString()
            cbmatkul.Text = row.Cells("dgmatkul").Value.ToString()
            lblgrade.Text = row.Cells("dggrade").Value.ToString()
            txtNip.Enabled = False
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
    End Sub

End Class