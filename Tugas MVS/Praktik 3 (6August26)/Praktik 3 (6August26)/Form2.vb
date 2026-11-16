Public Class Form2
    Private Sub btnCek_Click(sender As Object, e As EventArgs) Handles btnCek.Click
        Dim a As Integer = CInt(txtA.Text)
        Dim b As Integer = CInt(txtB.Text)
        Dim teks As String

        If a >= b Then
            teks = "A lebih besar atau sama dengan B"

        Else
            teks = "A lebih kecil dari B"
        End If

        lblHasil.Text = "Hasil : " & teks
    End Sub
End Class