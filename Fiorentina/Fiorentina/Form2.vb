Public Class Form2

    Private _p1 As String
    Private _p2 As String
    Private _p3 As String
    Private _p4 As String
    Private _jenisKelamin As String

    ' Constructor untuk menerima data dari Form1
    Public Sub New(npm As String, nama As String, fakultas As String, jurusan As String)
        ' Inisialisasi komponen
        InitializeComponent()

        ' Menampilkan data ke Label
        lblNpm.Text = "NPM: " & npm
        lblNama.Text = "Nama: " & nama
        lblFakultas.Text = "Fakultas: " & fakultas
        lblJurusan.Text = "Jurusan: " & jurusan
    End Sub

    Sub New(p1 As String, p2 As String, p3 As String, p4 As String, jenisKelamin As String)
        ' TODO: Complete member initialization 
        _p1 = p1
        _p2 = p2
        _p3 = p3
        _p4 = p4
        _jenisKelamin = jenisKelamin
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        ' Kembali ke Form1
        Dim inputForm As New Form1()
        inputForm.Show()
        Me.Close()
    End Sub
End Class