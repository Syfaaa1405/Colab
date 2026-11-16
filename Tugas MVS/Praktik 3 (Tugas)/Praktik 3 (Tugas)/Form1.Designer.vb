<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtRupiah = New TextBox()
        cmbMataUang = New ComboBox()
        Label1 = New Label()
        lblHasil = New Label()
        Label3 = New Label()
        btnKonversi = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Label2 = New Label()
        Label4 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtRupiah
        ' 
        txtRupiah.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        txtRupiah.Location = New Point(321, 210)
        txtRupiah.Name = "txtRupiah"
        txtRupiah.Size = New Size(237, 32)
        txtRupiah.TabIndex = 0
        ' 
        ' cmbMataUang
        ' 
        cmbMataUang.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        cmbMataUang.FormattingEnabled = True
        cmbMataUang.Location = New Point(321, 261)
        cmbMataUang.Name = "cmbMataUang"
        cmbMataUang.Size = New Size(237, 33)
        cmbMataUang.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(203, 213)
        Label1.Name = "Label1"
        Label1.Size = New Size(112, 25)
        Label1.TabIndex = 3
        Label1.Text = "Rupiah       :"
        ' 
        ' lblHasil
        ' 
        lblHasil.AutoSize = True
        lblHasil.BackColor = Color.Black
        lblHasil.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHasil.ForeColor = Color.White
        lblHasil.Location = New Point(41, 147)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(114, 25)
        lblHasil.TabIndex = 4
        lblHasil.Text = "Hasil           :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Black
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(203, 261)
        Label3.Name = "Label3"
        Label3.Size = New Size(116, 25)
        Label3.TabIndex = 5
        Label3.Text = "Mata Uang :"
        ' 
        ' btnKonversi
        ' 
        btnKonversi.BackColor = Color.Gray
        btnKonversi.FlatAppearance.BorderColor = Color.White
        btnKonversi.FlatAppearance.BorderSize = 2
        btnKonversi.FlatStyle = FlatStyle.Flat
        btnKonversi.Font = New Font("Segoe UI Black", 10F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnKonversi.ForeColor = Color.White
        btnKonversi.Location = New Point(637, 374)
        btnKonversi.Name = "btnKonversi"
        btnKonversi.Size = New Size(137, 53)
        btnKonversi.TabIndex = 6
        btnKonversi.Text = "KONVERSI"
        btnKonversi.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Controls.Add(lblHasil)
        Panel1.Location = New Point(164, 167)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(429, 217)
        Panel1.TabIndex = 7
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Gray
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label4)
        Panel2.Location = New Point(164, 44)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(429, 127)
        Panel2.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(81, 14)
        Label2.Name = "Label2"
        Label2.Size = New Size(274, 67)
        Label2.TabIndex = 0
        Label2.Text = "KONVERSI"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(112, 68)
        Label4.Name = "Label4"
        Label4.Size = New Size(207, 45)
        Label4.TabIndex = 9
        Label4.Text = "MATA UANG"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(Panel2)
        Controls.Add(btnKonversi)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(cmbMataUang)
        Controls.Add(txtRupiah)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtRupiah As TextBox
    Friend WithEvents txtHasil As TextBox
    Friend WithEvents cmbMataUang As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblHasil As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnKonversi As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label

End Class
