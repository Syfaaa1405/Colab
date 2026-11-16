Public Class Form1
    Private Sub btnBagi_Click(sender As Object, e As EventArgs) Handles btnBagi.Click
        Dim angka As Integer
        Dim pembagi As Integer
        Dim hasil As Integer

        Try
            If txtAngka.Text.Trim = "" OrElse txtPembagi.Text.Trim = "" Then
                MessageBox.Show("Kolom tidak boleh kosong!", "Peringatan",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            angka = CInt(txtAngka.Text)
            pembagi = CInt(txtPembagi.Text)
            hasil = angka \ pembagi

            lblHasil.Text = "Hasil: " & hasil
            MessageBox.Show("Hasil: " & hasil, "sukses",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As DivideByZeroException
            MessageBox.Show("Tidak bisa dibagi nol!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblHasil.Text = "Hasil: "

        Catch ex As FormatException
            MessageBox.Show("Masukkan angka valid!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblHasil.Text = "Hasil: "

        Catch ex As OverflowException
            MessageBox.Show("Angka terlalu besar!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblHasil.Text = "Hasil: "

        Finally
            MessageBox.Show("Proses selesai.", "Info",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHasil.Text = "Hasil: "
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAngka.Clear()
        txtPembagi.Clear()
        lblHasil.Text = ""

        txtAngka.Focus()
    End Sub
End Class
