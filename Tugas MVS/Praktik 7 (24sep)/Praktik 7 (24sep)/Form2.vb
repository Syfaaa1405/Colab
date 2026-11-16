Public Class Form2
    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        Dim passwordBenar As String = "140509"
        Dim percobaan As Integer = 0
        Dim berhasil As Boolean = False

        Do While percobaan < 3 And Not berhasil
            Dim input As String = InputBox(
                "Masukkan password (percobaan ke-" & (percobaan + 1) & " dari 3): ")
            percobaan += 1

            If input = passwordBenar Then
                berhasil = True
                MessageBox.Show("Login berhasil!")
            ElseIf percobaan < 3 Then
                MessageBox.Show("Password salah. Sisa Percobaan: " & (3 - percobaan))
            Else
                MessageBox.Show("Anda salah memasukkan password 3 kali. Aplikasi terkunci!")
            End If
        Loop

        If Not berhasil Then
            Application.Exit()
        End If
    End Sub
End Class