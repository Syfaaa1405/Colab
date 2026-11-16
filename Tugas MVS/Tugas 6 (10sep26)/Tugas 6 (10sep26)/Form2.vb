Public Class Form2
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim loginError As Boolean = False

        Try
            ErrorProvider1.Clear()

            If txtUsername.Text.Trim() = "" Then
                ErrorProvider1.SetError(txtUsername, "Username tidak boleh kosong!")
                txtUsername.Focus()
                loginError = True
                Throw New FormatException("Username tidak boleh kosong!")
            End If

            If txtPassword.Text.Trim() = "" Then
                ErrorProvider1.SetError(txtPassword, "Password tidak boleh kosong!")
                txtPassword.Focus()
                loginError = True
                Throw New FormatException("Password tidak boleh kosong!")
            End If

            If txtPassword.Text.Length < 6 Then
                ErrorProvider1.SetError(
                    txtPassword,
                    "Password minimal 6 karakter!"
                )
                txtPassword.Focus()
                loginError = True
                Throw New FormatException(
                    "Password minimal 6 karakter!"
                )
            End If

            If txtUsername.Text = "syifa" AndAlso
               txtPassword.Text = "14052009" Then

                MessageBox.Show(
                    "Login berhasil!",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )

            Else

                ErrorProvider1.SetError(
                    txtPassword,
                    "Username atau password salah!"
                )

                loginError = True

                MessageBox.Show(
                    "Username atau password salah!",
                    "Login Gagal",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )

            End If

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

            If loginError = True Then

                lblFinally.Text = "Coba ulang login"

            Else

                lblFinally.Text = "Percobaan login selesai"

            End If

        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPassword.Clear()
        txtUsername.Clear()
        ErrorProvider1.Clear()

        txtUsername.Focus()
    End Sub
End Class