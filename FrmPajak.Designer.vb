<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPajak
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblLimaJuta = New Label()
        lblTigaPuluhJuta = New Label()
        lblSeratusJuta = New Label()
        lblPendapatan = New Label()
        lblRupiah = New Label()
        txtPendapatan = New TextBox()
        btnHitung = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' lblLimaJuta
        ' 
        lblLimaJuta.AutoSize = True
        lblLimaJuta.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLimaJuta.Location = New Point(74, 43)
        lblLimaJuta.Name = "lblLimaJuta"
        lblLimaJuta.Size = New Size(348, 25)
        lblLimaJuta.TabIndex = 0
        lblLimaJuta.Text = "Pendapatan lebih dari 5 juta, 10% pajak"
        lblLimaJuta.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblTigaPuluhJuta
        ' 
        lblTigaPuluhJuta.AutoSize = True
        lblTigaPuluhJuta.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTigaPuluhJuta.Location = New Point(68, 79)
        lblTigaPuluhJuta.Name = "lblTigaPuluhJuta"
        lblTigaPuluhJuta.Size = New Size(358, 25)
        lblTigaPuluhJuta.TabIndex = 1
        lblTigaPuluhJuta.Text = "Pendapatan lebih dari 30 juta, 20% pajak"
        lblTigaPuluhJuta.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblSeratusJuta
        ' 
        lblSeratusJuta.AutoSize = True
        lblSeratusJuta.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSeratusJuta.Location = New Point(64, 117)
        lblSeratusJuta.Name = "lblSeratusJuta"
        lblSeratusJuta.Size = New Size(368, 25)
        lblSeratusJuta.TabIndex = 2
        lblSeratusJuta.Text = "Pendapatan lebih dari 100 juta, 30% pajak"
        lblSeratusJuta.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblPendapatan
        ' 
        lblPendapatan.AutoSize = True
        lblPendapatan.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPendapatan.Location = New Point(135, 188)
        lblPendapatan.Name = "lblPendapatan"
        lblPendapatan.Size = New Size(205, 25)
        lblPendapatan.TabIndex = 3
        lblPendapatan.Text = "Masukkan Pendapatan"
        lblPendapatan.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lblRupiah
        ' 
        lblRupiah.AutoSize = True
        lblRupiah.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblRupiah.Location = New Point(90, 232)
        lblRupiah.Name = "lblRupiah"
        lblRupiah.Size = New Size(45, 25)
        lblRupiah.TabIndex = 4
        lblRupiah.Text = "Rp :"
        lblRupiah.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtPendapatan
        ' 
        txtPendapatan.Location = New Point(139, 229)
        txtPendapatan.Name = "txtPendapatan"
        txtPendapatan.Size = New Size(180, 31)
        txtPendapatan.TabIndex = 5
        ' 
        ' btnHitung
        ' 
        btnHitung.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHitung.Location = New Point(170, 289)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(112, 40)
        btnHitung.TabIndex = 6
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnKeluar.Location = New Point(170, 347)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(112, 40)
        btnKeluar.TabIndex = 7
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' FrmPajak
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(478, 544)
        Controls.Add(btnKeluar)
        Controls.Add(btnHitung)
        Controls.Add(txtPendapatan)
        Controls.Add(lblRupiah)
        Controls.Add(lblPendapatan)
        Controls.Add(lblSeratusJuta)
        Controls.Add(lblTigaPuluhJuta)
        Controls.Add(lblLimaJuta)
        MaximizeBox = False
        Name = "FrmPajak"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Perhitungan Pajak"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLimaJuta As Label
    Friend WithEvents lblTigaPuluhJuta As Label
    Friend WithEvents lblSeratusJuta As Label
    Friend WithEvents lblPendapatan As Label
    Friend WithEvents lblRupiah As Label
    Friend WithEvents txtPendapatan As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnKeluar As Button
End Class
