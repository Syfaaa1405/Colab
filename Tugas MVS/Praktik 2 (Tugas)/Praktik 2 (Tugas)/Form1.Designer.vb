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
        btnHitung = New Button()
        btnBersih = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtNama = New TextBox()
        txtKelas = New TextBox()
        txtTugas = New TextBox()
        txtUTS = New TextBox()
        txtUAS = New TextBox()
        txtHasil = New TextBox()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' btnHitung
        ' 
        btnHitung.BackColor = Color.Brown
        btnHitung.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnHitung.ForeColor = Color.SeaShell
        btnHitung.Location = New Point(423, 263)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(122, 41)
        btnHitung.TabIndex = 0
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = False
        ' 
        ' btnBersih
        ' 
        btnBersih.BackColor = Color.Brown
        btnBersih.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnBersih.ForeColor = Color.SeaShell
        btnBersih.Location = New Point(551, 263)
        btnBersih.Name = "btnBersih"
        btnBersih.Size = New Size(127, 41)
        btnBersih.TabIndex = 1
        btnBersih.Text = "Bersih"
        btnBersih.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.SeaShell
        Label1.Location = New Point(134, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 25)
        Label1.TabIndex = 2
        Label1.Text = "Nama            :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.SeaShell
        Label2.Location = New Point(134, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(127, 25)
        Label2.TabIndex = 3
        Label2.Text = "Kelas             :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.SeaShell
        Label3.Location = New Point(134, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 25)
        Label3.TabIndex = 4
        Label3.Text = "Nilai Tugas   :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.SeaShell
        Label4.Location = New Point(134, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(125, 25)
        Label4.TabIndex = 5
        Label4.Text = "Nilai UTS      :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.SeaShell
        Label5.Location = New Point(134, 216)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 25)
        Label5.TabIndex = 6
        Label5.Text = "Nilai UAS      :"
        ' 
        ' txtNama
        ' 
        txtNama.BackColor = Color.White
        txtNama.Location = New Point(265, 66)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(413, 31)
        txtNama.TabIndex = 7
        ' 
        ' txtKelas
        ' 
        txtKelas.BackColor = Color.White
        txtKelas.Location = New Point(265, 103)
        txtKelas.Name = "txtKelas"
        txtKelas.Size = New Size(413, 31)
        txtKelas.TabIndex = 8
        ' 
        ' txtTugas
        ' 
        txtTugas.BackColor = Color.White
        txtTugas.Location = New Point(265, 140)
        txtTugas.Name = "txtTugas"
        txtTugas.Size = New Size(413, 31)
        txtTugas.TabIndex = 9
        ' 
        ' txtUTS
        ' 
        txtUTS.BackColor = Color.White
        txtUTS.Location = New Point(265, 177)
        txtUTS.Name = "txtUTS"
        txtUTS.Size = New Size(413, 31)
        txtUTS.TabIndex = 10
        ' 
        ' txtUAS
        ' 
        txtUAS.BackColor = Color.White
        txtUAS.Location = New Point(265, 214)
        txtUAS.Name = "txtUAS"
        txtUAS.Size = New Size(413, 31)
        txtUAS.TabIndex = 11
        ' 
        ' txtHasil
        ' 
        txtHasil.BackColor = Color.White
        txtHasil.Location = New Point(134, 362)
        txtHasil.Name = "txtHasil"
        txtHasil.ReadOnly = True
        txtHasil.Size = New Size(544, 31)
        txtHasil.TabIndex = 12
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.SeaShell
        Label6.Location = New Point(134, 334)
        Label6.Name = "Label6"
        Label6.Size = New Size(154, 25)
        Label6.TabIndex = 13
        Label6.Text = "Hasil Rata-Rata :"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        BackgroundImage = My.Resources.Resources._1
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(txtHasil)
        Controls.Add(txtUAS)
        Controls.Add(txtUTS)
        Controls.Add(txtTugas)
        Controls.Add(txtKelas)
        Controls.Add(txtNama)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnBersih)
        Controls.Add(btnHitung)
        Name = "Form1"
        Text = "Data Nilai Siswa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnHitung As Button
    Friend WithEvents btnBersih As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtKelas As TextBox
    Friend WithEvents txtTugas As TextBox
    Friend WithEvents txtUTS As TextBox
    Friend WithEvents txtUAS As TextBox
    Friend WithEvents txtHasil As TextBox
    Friend WithEvents Label6 As Label

End Class
