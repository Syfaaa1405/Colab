Public Class Form4
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim a As Integer = CInt(txtNilai.Text)
        a += 10     'a = a + 10
        a *= 2      'a = a * 2
        a -= 5      'a = a - 5
        a = a Mod 6 'sisa bagi 6
        lblHasil.Text = "Hasil : " & a
    End Sub
End Class