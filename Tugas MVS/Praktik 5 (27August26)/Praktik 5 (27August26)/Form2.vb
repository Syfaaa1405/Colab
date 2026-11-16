Public Class Form2
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim total As Integer =
            CInt(txtTotal.Text)
        Dim diskon As Integer = 0
        If total >= 500000 Then
            diskon = 20
        ElseIf total >= 200000 Then
            diskon = 10
        Else
            diskon = 0
        End If
        txtDiskon.Text = diskon & "%"
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtTotal.Clear()
        txtDiskon.Clear()

        txtTotal.Focus()
    End Sub
End Class