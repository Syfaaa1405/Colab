Public Class Form5
    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim a As Integer = CInt(txtA.Text)
        Dim b As Integer = CInt(txtB.Text)
        Dim hasil As Integer
        hasil = (a + b) ^ 2 - (a Mod b)
        lblHasil.Text = "Hasil : " & hasil
    End Sub
End Class