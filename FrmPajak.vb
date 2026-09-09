Public Class FrmPajak
    Private Sub txtPendapatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPendapatan.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click

        Dim pendapatan As Decimal

        'Validasi input pendapatan
        If txtPendapatan.Text.Trim() = "" Then

            MessageBox.Show("Pendapatan tidak boleh kosong.",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            txtPendapatan.Focus()
            Return

        End If

        'Memastikan input berupa angka
        If Not Decimal.TryParse(txtPendapatan.Text, pendapatan) Then

            MessageBox.Show("Pendapatan harus berupa angka.",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            txtPendapatan.Focus()
            Return

        End If

        'Validasi agar pendapatan tidak negatif
        If pendapatan < 0 Then

            MessageBox.Show("Pendapatan tidak boleh negatif.",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            txtPendapatan.Focus()
            Return

        End If

        'Menentukan persentase pajak
        Dim persentasePajak As Decimal

        If pendapatan <= 5000000D Then

            persentasePajak = 0D

        ElseIf pendapatan <= 30000000D Then

            persentasePajak = 0.1D

        ElseIf pendapatan <= 100000000D Then

            persentasePajak = 0.2D

        Else

            persentasePajak = 0.3D

        End If

        'Menghitung pajak
        Dim pajak As Decimal = pendapatan * persentasePajak

        'Menampilkan hasil
        MessageBox.Show(
            "Pendapatan : Rp " & pendapatan.ToString("N0") & vbCrLf &
            "Pajak      : " & (persentasePajak * 100).ToString("N0") & "%" & vbCrLf &
            "Jumlah Pajak: Rp " & pajak.ToString("N0"),
            "Hasil Perhitungan Pajak",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click

        Me.Close()
        FrmLogin.Show()

    End Sub
End Class