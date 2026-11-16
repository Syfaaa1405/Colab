Public Class Form3
    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim x As Boolean = chkX.Checked
        Dim y As Boolean = chkY.Checked
        Dim z As String

        If x And y Then
            z = "Keduanya True"
        ElseIf x Or y Then
            z = "Salah satu True"
        Else
            z = "Keduanya False"
        End If

        lblHasil.Text = "Hasil : " & z
    End Sub
End Class