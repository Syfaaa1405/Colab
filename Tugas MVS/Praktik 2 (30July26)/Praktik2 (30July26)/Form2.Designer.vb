<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        btnProses = New Button()
        Nama = New Label()
        txtNama = New TextBox()
        Label2 = New Label()
        txtKelas = New TextBox()
        Label3 = New Label()
        txtJurusan = New TextBox()
        SuspendLayout()
        ' 
        ' btnProses
        ' 
        btnProses.Location = New Point(180, 234)
        btnProses.Margin = New Padding(4, 3, 4, 3)
        btnProses.Name = "btnProses"
        btnProses.Size = New Size(497, 41)
        btnProses.TabIndex = 0
        btnProses.Text = "Proses"
        btnProses.UseVisualStyleBackColor = True
        ' 
        ' Nama
        ' 
        Nama.AutoSize = True
        Nama.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Nama.Location = New Point(180, 110)
        Nama.Margin = New Padding(4, 0, 4, 0)
        Nama.Name = "Nama"
        Nama.Size = New Size(150, 25)
        Nama.TabIndex = 1
        Nama.Text = "Nama                :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(346, 110)
        txtNama.Margin = New Padding(4, 3, 4, 3)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(330, 29)
        txtNama.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(180, 145)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 25)
        Label2.TabIndex = 3
        Label2.Text = "Kelas                 :"
        ' 
        ' txtKelas
        ' 
        txtKelas.Location = New Point(346, 145)
        txtKelas.Margin = New Padding(4, 3, 4, 3)
        txtKelas.Name = "txtKelas"
        txtKelas.Size = New Size(330, 29)
        txtKelas.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(180, 183)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(152, 25)
        Label3.TabIndex = 5
        Label3.Text = "Jurusan             :"
        ' 
        ' txtJurusan
        ' 
        txtJurusan.Location = New Point(346, 183)
        txtJurusan.Margin = New Padding(4, 3, 4, 3)
        txtJurusan.Name = "txtJurusan"
        txtJurusan.Size = New Size(330, 29)
        txtJurusan.TabIndex = 6
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(11F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(880, 378)
        Controls.Add(txtJurusan)
        Controls.Add(Label3)
        Controls.Add(txtKelas)
        Controls.Add(Label2)
        Controls.Add(txtNama)
        Controls.Add(Nama)
        Controls.Add(btnProses)
        Font = New Font("Swis721 Hv BT", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnProses As Button
    Friend WithEvents Nama As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKelas As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtJurusan As TextBox
End Class
