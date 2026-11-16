Public Class Form3
    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim a As Integer = 0
        Dim b As Integer = 1
        Dim c As Integer

        lstHasil.Items.Clear()

        For i As Integer = 1 To 10

            lstHasil.Items.Add(a)

            c = a + b
            a = b
            b = c
        Next
    End Sub
End Class