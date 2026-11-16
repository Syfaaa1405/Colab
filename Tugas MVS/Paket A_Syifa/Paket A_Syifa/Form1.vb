Public Class Form1
    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Dim berat As Double
        Dim total As Integer
        Dim tarif As Integer
        Dim biayatambahan As Integer

        If Not Double.TryParse(txtBerat.Text, berat) Then
            MessageBox.Show("Masukkan berat berupa angka!",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            txtBerat.Focus()
            Exit Sub
        End If

        berat = CDbl(txtBerat.Text)

        If berat <= 1 Then
            tarif = 9000

        ElseIf berat >= 1 And berat <= 5 Then
            tarif = 18000

        Else
            tarif = 30000
        End If

        If cmbTujuan.Text = "Dalam Kota" Then
            biayatambahan = 0

        ElseIf cmbTujuan.Text = "Luar Kota" Then
            biayatambahan = 10000

        Else cmbTujuan.Text = "Luar Pulau"
            biayatambahan = 25000
        End If

        total = tarif + biayatambahan
        lblTotal.Text = "Total Ongkos Kirim : Rp" & total.ToString
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbTujuan.Items.Add("Dalam Kota")
        cmbTujuan.Items.Add("Luar Kota")
        cmbTujuan.Items.Add("Luar Pulau")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBerat.Clear()
        cmbTujuan.SelectedIndex = -1
        lblTotal.Text = "Total Ongkos Kirim : Rp0"

        txtBerat.Focus()
    End Sub
End Class
