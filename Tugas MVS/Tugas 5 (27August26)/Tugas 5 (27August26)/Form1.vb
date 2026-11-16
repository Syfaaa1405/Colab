Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim harga As Double
        Dim diskon As Double
        Dim nominalDiskon As Double
        Dim hargaAkhir As Double

        harga = CInt(txtHarga.Text)
        diskon = CInt(txtDiskon.Text)

        nominalDiskon = harga * diskon / 100

        hargaAkhir = harga - nominalDiskon

        txtNominal.Text = nominalDiskon.ToString
        txtAkhir.Text = hargaAkhir.ToString

        If diskon >= 20% Then
            txtPresent.Text = "Diskon Spesial"
            txtPresent.BackColor = Color.Red

        ElseIf diskon >= 10% And diskon <= 19% Then
            txtPresent.Text = "Diskon Menengah"
            txtPresent.BackColor = Color.Blue

        Else
            txtPresent.Text = "Diskon Kecil"
            txtPresent.BackColor = Color.Green
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtHarga.Clear()
        txtDiskon.Clear()
        txtAkhir.Clear()
        txtPresent.Clear()

        txtHarga.Focus()
    End Sub
End Class