Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbMataUang.Items.Add("USD")
        cmbMataUang.Items.Add("EUR")
        cmbMataUang.Items.Add("JPY")
    End Sub

    Private Sub btnKonversi_Click(sender As Object, e As EventArgs) Handles btnKonversi.Click
        Dim rupiah As Double = CDbl(txtRupiah.Text)
        Dim hasil As Double

        If cmbMataUang.Text = "USD" Then
            hasil = rupiah / 17920

        ElseIf cmbMataUang.Text = "EUR" Then
            hasil = rupiah / 20696

        Else cmbMataUang.Text = "JPY"
            hasil = rupiah / 113
        End If

        lblHasil.Text = "Hasil           : " & FormatNumber(hasil, 2)
    End Sub
End Class
