Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim nama As String = txtNama.Text
        Dim kelas As String = txtKelas.Text

        Dim tugas As Double = CDbl(txtTugas.Text)
        Dim uts As Double = CDbl(txtUTS.Text)
        Dim uas As Double = CDbl(txtUAS.Text)

        Dim hasil As Double
        hasil = (tugas + uts + uas) / 3

        txtHasil.Text = hasil.ToString("0.00")
        'txtHsil.Text = "Nama  : " & nama & vbCrLf & "Kelas  : " & kelas & vbCrLf & "Uts  : " & uts & vbCrLf & "Uas  : " & uas & vbCrLf & "Hasil  : " & hasil

        'MessageBox.Show("Nama  : " & nama & vbCrLf & "Kelas  : " & kelas & vbCrLf & "Uts  : " & uts & vbCrLf & "Uas  : " & uas & vbCrLf & "Hasil  : " & hasil)

    End Sub

    Private Sub btnBersih_Click(sender As Object, e As EventArgs) Handles btnBersih.Click
        txtNama.Clear()
        txtKelas.Clear()
        txtTugas.Clear()
        txtUTS.Clear()
        txtUAS.Clear()
        txtHasil.Clear()

        txtNama.Focus()
    End Sub
End Class
