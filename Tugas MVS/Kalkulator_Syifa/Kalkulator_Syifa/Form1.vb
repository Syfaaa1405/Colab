Public Class Form1
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim angka1, angka2, hasil As Double

        angka1 = txtAngka1.Text
        angka2 = txtAngka2.Text

        hasil = angka1 + angka2
        txtHasil.Text = hasil
    End Sub

    Private Sub btnKurang_Click(sender As Object, e As EventArgs) Handles btnKurang.Click
        Dim angka1, angka2, hasil As Double

        angka1 = txtAngka1.Text
        angka2 = txtAngka2.Text

        hasil = angka1 - angka2
        txtHasil.Text = hasil
    End Sub

    Private Sub btnKali_Click(sender As Object, e As EventArgs) Handles btnKali.Click
        Dim angka1, angka2, hasil As Double

        angka1 = txtAngka1.Text
        angka2 = txtAngka2.Text

        hasil = angka1 * angka2
        txtHasil.Text = hasil
    End Sub

    Private Sub btnBagi_Click(sender As Object, e As EventArgs) Handles btnBagi.Click
        Dim angka1, angka2, hasil As Double

        angka1 = txtAngka1.Text
        angka2 = txtAngka2.Text

        hasil = angka1 / angka2
        txtHasil.Text = hasil
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAngka1.Clear()
        txtAngka2.Clear()
        txtHasil.Clear()

        txtAngka1.Focus()
    End Sub
End Class
