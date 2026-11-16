Public Class Form3
    Private Sub btnCek_Click(sender As Object, e As EventArgs) Handles btnCek.Click
        Dim nilai As Integer =
            CInt(txtNilai.Text)
        Dim grade As String
        If nilai >= 85 Then
            grade = "A"
        ElseIf nilai >= 70 Then
            grade = "B"
        ElseIf nilai >= 55 Then
            grade = "C"
        Else
            grade = "D"
        End If
        txtGrade.Text = grade
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNilai.Clear()
        txtGrade.Clear()

        txtNilai.Focus()
    End Sub
End Class