Public Class Form1
    Private Sub btnCek_Click(sender As Object, e As EventArgs) Handles btnCek.Click
        Dim umur As Integer =
            txtUmur.Text

        If umur >= 17 Then
            txtHasil.Text = "Dewasa"
        Else
            txtHasil.Text = "Belum Dewasa"
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtUmur.Clear()
        txtHasil.Clear()

        txtUmur.Focus()
    End Sub
End Class