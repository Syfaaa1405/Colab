Public Class Form1
    Private Sub btnTampil_Click(sender As Object, e As EventArgs) Handles btnTampil.Click
        Dim nama As String = "Syifa"
        Dim umur As Integer = 17
        Dim tinggi As Double = 161
        Dim aktif As Boolean = True

        MessageBox.Show("Nama : " &
        nama & vbCrLf & "Umur  : " &
        umur & vbCrLf & "Tinggi : " &
        tinggi & vbCrLf & "Aktif    : " &
        aktif)

    End Sub
End Class
