Public Class Form4
    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        lstHasil.Items.Clear()

        For i As Integer = 1 To 10

            Dim baris As String = ""

            For j As Integer = 1 To i
                baris &= "* "
            Next

            lstHasil.Items.Add(baris)

        Next

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstHasil.Items.Clear()
    End Sub
End Class