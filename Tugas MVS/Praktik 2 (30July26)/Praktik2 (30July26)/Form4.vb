Public Class Form4
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim nama As String
        Dim gajiPokok As Double
        Dim tunjangan As Decimal
        Dim total As Decimal

        nama = txtNama.Text
        gajiPokok = CDbl(txtGaji.Text)
        tunjangan = CDec(txtTunjangan.Text)
        total = gajiPokok + tunjangan

        MessageBox.Show("Nama : " & nama & vbCrLf & "Total Gaji : Rp " & Format(total, "#,##0"))
    End Sub
End Class