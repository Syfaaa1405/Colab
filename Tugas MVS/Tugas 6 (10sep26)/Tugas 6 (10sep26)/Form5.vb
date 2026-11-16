Imports System.Text.RegularExpressions

Public Class Form5
    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        Dim usia As Integer
        Dim adaError As Boolean = False

        ErrorProvider1.Clear()

        Try

            If String.IsNullOrWhiteSpace(txtNama.Text) Then
                ErrorProvider1.SetError(txtNama, "Nama tidak boleh kosong.")
                txtNama.Focus()
                adaError = True
                Throw New FormatException("Nama tidak boleh kosong.")
            End If

            If Not Regex.IsMatch(txtNISN.Text.Trim(), "^\d{10}$") Then
                ErrorProvider1.SetError(txtNISN, "NISN harus terdiri dari 10 digit angka.")
                txtNISN.Focus()
                adaError = True
                Throw New FormatException("NISN harus terdiri dari 10 digit angka.")
            End If

            If Not Integer.TryParse(txtUsia.Text.Trim(), usia) Then
                ErrorProvider1.SetError(txtUsia, "Usia harus berupa angka.")
                txtUsia.Focus()
                adaError = True
                Throw New FormatException("Usia harus berupa angka.")
            End If

            If usia < 10 OrElse usia > 20 Then
                ErrorProvider1.SetError(txtUsia, "Usia harus antara 10 sampai 20 tahun.")
                txtUsia.Focus()
                adaError = True
                Throw New FormatException("Usia harus antara 10 sampai 20 tahun.")
            End If

            If Not Regex.IsMatch(
                txtEmail.Text.Trim(),
                "^[^@\s]+@[^@\s]+\.[^@\s]+$"
            ) Then

                ErrorProvider1.SetError(txtEmail, "Format email tidak valid.")
                txtEmail.Focus()
                adaError = True
                Throw New FormatException("Format email tidak valid.")
            End If

            If adaError = False Then
                MessageBox.Show(
                    "Pendaftaran berhasil!",
                    "Pendaftaran",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )
            End If

        Catch ex As FormatException

            adaError = True

            MessageBox.Show(
                ex.Message,
                "Data Tidak Valid",
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
                lblFinally.Text = "Pendaftaran gagal. Periksa kembali data."
            Else
                lblFinally.Text = "Proses pendaftaran selesai."
            End If

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNama.Clear()
        txtNISN.Clear()
        txtUsia.Clear()
        txtEmail.Clear()

        ErrorProvider1.Clear()
        lblFinally.Text = ""

        txtNama.Focus()
    End Sub
End Class