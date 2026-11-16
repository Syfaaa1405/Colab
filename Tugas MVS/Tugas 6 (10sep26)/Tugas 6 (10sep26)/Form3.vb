Public Class Form3
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim adaError As Boolean = False

        Try
            ErrorProvider1.Clear()

            Dim nilai1 As Double
            Dim nilai2 As Double
            Dim nilai3 As Double
            Dim nilai4 As Double
            Dim nilai5 As Double
            Dim rataRata As Double

            If Not Double.TryParse(txt1.Text.Trim(), nilai1) Then
                ErrorProvider1.SetError(txt1, "Nilai 1 harus berupa angka!")
                txt1.Focus()
                adaError = True
                Throw New FormatException("Nilai 1 harus berupa angka!")
            End If

            If Not Double.TryParse(txt2.Text.Trim(), nilai2) Then
                ErrorProvider1.SetError(txt2, "Nilai 2 harus berupa angka!")
                txt2.Focus()
                adaError = True
                Throw New FormatException("Nilai 2 harus berupa angka!")
            End If

            If Not Double.TryParse(txt3.Text.Trim(), nilai3) Then
                ErrorProvider1.SetError(txt3, "Nilai 3 harus berupa angka!")
                txt3.Focus()
                adaError = True
                Throw New FormatException("Nilai 3 harus berupa angka!")
            End If

            If Not Double.TryParse(txt4.Text.Trim(), nilai4) Then
                ErrorProvider1.SetError(txt4, "Nilai 4 harus berupa angka!")
                txt4.Focus()
                adaError = True
                Throw New FormatException("Nilai 4 harus berupa angka!")
            End If

            If Not Double.TryParse(txt5.Text.Trim(), nilai5) Then
                ErrorProvider1.SetError(txt5, "Nilai 5 harus berupa angka!")
                txt5.Focus()
                adaError = True
                Throw New FormatException("Nilai 5 harus berupa angka!")
            End If

            rataRata = (nilai1 + nilai2 + nilai3 + nilai4 + nilai5) / 5

            txtRataRata.Text = rataRata.ToString("0.00")

            MessageBox.Show(
                "Rata-rata 5 nilai adalah: " & rataRata.ToString("0.00"),
                "Hasil",
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

            adaError = True

            MessageBox.Show(
                "Terjadi kesalahan: " & ex.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )

        Finally

            If adaError = True Then
                lblFinally.Text = "Coba ulang input nilai"
            Else
                lblFinally.Text = "Perhitungan rata-rata selesai"
            End If

        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txt1.Clear()
        txt2.Clear()
        txt3.Clear()
        txt4.Clear()
        txt5.Clear()
        txtRataRata.Clear()
        ErrorProvider1.Clear()
        lblFinally.Text = ""

        txt1.Focus()
    End Sub
End Class