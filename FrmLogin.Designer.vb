<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        picImage = New PictureBox()
        lblRole = New Label()
        lblNim = New Label()
        lblNama = New Label()
        cmbRole = New ComboBox()
        txtNama = New TextBox()
        txtNim = New TextBox()
        btnLogin = New Button()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picImage
        ' 
        picImage.Location = New Point(174, 12)
        picImage.Name = "picImage"
        picImage.Size = New Size(130, 130)
        picImage.SizeMode = PictureBoxSizeMode.Zoom
        picImage.TabIndex = 0
        picImage.TabStop = False
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRole.Location = New Point(89, 180)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(75, 25)
        lblRole.TabIndex = 1
        lblRole.Text = "Role    :"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNim.Location = New Point(89, 272)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(74, 25)
        lblNim.TabIndex = 2
        lblNim.Text = "NIM    :"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNama.Location = New Point(89, 226)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(72, 25)
        lblNama.TabIndex = 3
        lblNama.Text = "Nama :"
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Location = New Point(165, 177)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(180, 33)
        cmbRole.TabIndex = 4
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(165, 223)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(180, 31)
        txtNama.TabIndex = 5
        ' 
        ' txtNim
        ' 
        txtNim.Location = New Point(165, 269)
        txtNim.Name = "txtNim"
        txtNim.Size = New Size(180, 31)
        txtNim.TabIndex = 6
        ' 
        ' btnLogin
        ' 
        btnLogin.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(183, 337)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(110, 40)
        btnLogin.TabIndex = 7
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' FrmLogin
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(478, 544)
        Controls.Add(btnLogin)
        Controls.Add(txtNim)
        Controls.Add(txtNama)
        Controls.Add(cmbRole)
        Controls.Add(lblNama)
        Controls.Add(lblNim)
        Controls.Add(lblRole)
        Controls.Add(picImage)
        MinimizeBox = False
        Name = "FrmLogin"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picImage As PictureBox
    Friend WithEvents lblRole As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNim As TextBox
    Friend WithEvents btnLogin As Button

End Class
