Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim celsius As Double
        Dim fahrenheit As Double

        If Not Double.TryParse(txtCelsius.Text.Trim(), celsius) Then

            ErrorProvider1.SetError(
                txtCelsius,
                "Masukkan suhu Celsius berupa angka!"
                )

            txtCelsius.Focus()

            Throw New FormatException(
                "Input suhu Celsius harus berupa angka."
                )

        End If

        Try
            ErrorProvider1.Clear()

            fahrenheit = (celsius * 9 / 5) + 32

            txtFahrenheit.Text = fahrenheit.ToString("0.00")

            MessageBox.Show(
            celsius & " °C = " & fahrenheit.ToString("0.00") & " °F",
            "Hasil Konversi",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
            )

        Catch ex As FormatException

            MessageBox.Show(
            ex.Message,
            "Input Tidak Valid",
            MessageBoxButtons.OK,
            MessageBoxIcon.Warning
        )

        Catch ex As Exception

            MessageBox.Show(
            "Terjadi kesalahan: " & ex.Message,
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        Finally

            lblStatus.Text = "Status: Proses konversi selesai."

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtCelsius.Clear()
        txtFahrenheit.Clear()
        ErrorProvider1.Clear()
        lblStatus.Text = "Status: Form telah dikosongkan."
        txtCelsius.Focus()
    End Sub
End Class
