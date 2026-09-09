Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbRole.Items.Clear()

        cmbRole.Items.Add("Staff")
        cmbRole.Items.Add("Manager")

        cmbRole.SelectedIndex = -1

    End Sub

    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged

        If cmbRole.Text = "Staff" Then

            picImage.Image = Image.FromFile(
            IO.Path.Combine(Application.StartupPath, "Image", "staff.jpg")
        )

        ElseIf cmbRole.Text = "Manager" Then

            picImage.Image = Image.FromFile(
            IO.Path.Combine(Application.StartupPath, "Image", "manager.jpg")
        )

        Else

            picImage.Image = Nothing

        End If

    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress

        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtNim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNim.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim role As String = cmbRole.Text.Trim()
        Dim nama As String = txtNama.Text.Trim()
        Dim nim As String = txtNim.Text.Trim()

        'Validasi role
        If role = "" Then
            MessageBox.Show("Silakan pilih role terlebih dahulu.",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            cmbRole.Focus()
            Return
        End If

        'Validasi nama
        If nama = "" Then
            MessageBox.Show("Nama tidak boleh kosong.",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            txtNama.Focus()
            Return
        End If

        'Validasi NIM
        If nim = "" Then
            MessageBox.Show("NIM tidak boleh kosong.",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            txtNim.Focus()
            Return
        End If

        'Memastikan NIM berupa angka
        Dim nimAngka As Long

        If Not Long.TryParse(nim, nimAngka) Then
            MessageBox.Show("NIM harus berupa angka.",
                            "Peringatan",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)

            txtNim.Focus()
            Return
        End If

        'Validasi akun
        If role = "Staff" AndAlso
           nama.Equals("Nadya", StringComparison.OrdinalIgnoreCase) AndAlso
           nim = "241712051" Then

            MessageBox.Show("Login berhasil sebagai Staff.",
                            "Login Berhasil",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            FrmPajak.Show()
            Me.Hide()

            txtNama.Clear()
            txtNim.Clear()

        ElseIf role = "Manager" AndAlso
               nama.Equals("Shata Diyaul Haq", StringComparison.OrdinalIgnoreCase) AndAlso
               nim = "241712061" Then

            MessageBox.Show("Login berhasil sebagai Manager.",
                            "Login Berhasil",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            FrmPajak.Show()
            Me.Hide()

            txtNama.Clear()
            txtNim.Clear()

        Else

            MessageBox.Show("Role, nama, atau NIM tidak sesuai.",
                            "Login Gagal",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)

            txtNim.Focus()

        End If

    End Sub

End Class