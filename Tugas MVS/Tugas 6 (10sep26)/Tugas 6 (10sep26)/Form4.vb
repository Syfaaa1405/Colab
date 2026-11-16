Public Class Form4
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim tahunLahir As Integer
        Dim umur As Integer
        Dim tahunSekarang As Integer = DateTime.Now.Year
        Dim adaError As Boolean = False

        ErrorProvider1.Clear()

        Try

            If Not Integer.TryParse(txtTahun.Text.Trim(), tahunLahir) Then
                ErrorProvider1.SetError(txtTahun, "Tahun lahir harus berupa angka.")
                txtTahun.Focus()
                adaError = True

                Throw New FormatException("Tahun lahir harus berupa angka.")
            End If

            If tahunLahir < 1900 OrElse tahunLahir > tahunSekarang Then

                ErrorProvider1.SetError(
                    txtTahun,
                    "Tahun lahir harus antara 1900 sampai " & tahunSekarang & "."
                )

                txtTahun.Focus()
                adaError = True

                Throw New FormatException(
                    "Tahun lahir harus antara 1900 sampai " & tahunSekarang & "."
                )

            End If

            umur = tahunSekarang - tahunLahir
            txtUmur.Text = umur.ToString()

        Catch ex As FormatException

            adaError = True

            MessageBox.Show(
                ex.Message,
                "Input Tidak Valid",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

        Catch ex As Exception

            adaError = True

            MessageBox.Show(
                "Terjadi kesalahan: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Finally

            If adaError = True Then
                lblFinally.Text = "Coba ulang input tahun lahir."
            Else
                lblFinally.Text = "Pengecekan umur selesai."
            End If

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTahun.Clear()
        txtUmur.Clear()
        ErrorProvider1.Clear()
        lblFinally.Text = ""

        txtTahun.Focus()
    End Sub
End Class