Public Class Form1
    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim angka As Integer
        lstHasil.Items.Clear()

        If Integer.TryParse(txtAngka.Text, angka) Then

            For i As Integer = 1 To 10
                lstHasil.Items.Add(angka & " x " & i & " = " & (angka * i))

            Next

        Else

            MessageBox.Show("Masukkan angka yang valid!")

        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAngka.Clear()
        lstHasil.Items.Clear()

        txtAngka.Focus()
    End Sub
End Class
