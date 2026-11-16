Public Class Form5
    Private Sub btnKonversi_Click(sender As Object, e As EventArgs) Handles btnKonversi.Click
        Dim angka As String = "150"
        Dim hasil As Integer = CInt(angka)

        MessageBox.Show("Hasil : " & hasil)
    End Sub
End Class