Public Class Form3
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim umur As Integer
        umur = CInt(txtUmur.Text)

        Dim tahunDepan As Integer
        tahunDepan = umur + 1

        MessageBox.Show("Umur tahun depan : " & tahunDepan)
    End Sub
End Class