Public Class Form1
    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        lstHasil.Items.Clear()

        For i As Integer = 1 To 50
            If i Mod 2 = 0 Then
                lstHasil.Items.Add(i)
            End If
        Next
    End Sub
End Class
