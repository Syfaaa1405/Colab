Public Class Form4
    Private Sub btnCek_Click(sender As Object, e As EventArgs) Handles btnCek.Click
        Dim angka As Integer =
            CInt(txtAngka.Text)
        If angka > 0 Then
            txtHasil.Text = "Positif"
        ElseIf angka < 0 Then
            txtHasil.Text = "Negatif"
        Else
            txtHasil.Text = "Nol"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAngka.Clear()
        txtHasil.Clear()

        txtAngka.Focus()
    End Sub
End Class