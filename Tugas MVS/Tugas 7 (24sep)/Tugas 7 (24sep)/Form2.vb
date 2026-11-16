Public Class Form2
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim total As Integer = 0
        Dim angka As Integer

        Do
            Dim input As String = InputBox("Masukkan angka (0 untuk berhenti):")

            If Integer.TryParse(input, angka) Then
                total += angka
            Else
                MessageBox.Show("Masukkan angka yang valid!")
            End If

        Loop While angka <> 0

        lblTotal.Text = "Total Penjumlahan = " & total
    End Sub
End Class