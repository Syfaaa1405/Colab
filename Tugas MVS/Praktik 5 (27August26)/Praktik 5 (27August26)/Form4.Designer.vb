<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        btnClear = New Button()
        btnCek = New Button()
        txtHasil = New TextBox()
        txtAngka = New TextBox()
        lblHasil = New Label()
        lblAngka = New Label()
        SuspendLayout()
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(475, 212)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 22
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnCek
        ' 
        btnCek.Location = New Point(357, 212)
        btnCek.Name = "btnCek"
        btnCek.Size = New Size(112, 34)
        btnCek.TabIndex = 21
        btnCek.Text = "Cek"
        btnCek.UseVisualStyleBackColor = True
        ' 
        ' txtHasil
        ' 
        txtHasil.Location = New Point(272, 262)
        txtHasil.Name = "txtHasil"
        txtHasil.Size = New Size(315, 31)
        txtHasil.TabIndex = 20
        ' 
        ' txtAngka
        ' 
        txtAngka.Location = New Point(366, 158)
        txtAngka.Name = "txtAngka"
        txtAngka.Size = New Size(221, 31)
        txtAngka.TabIndex = 19
        ' 
        ' lblHasil
        ' 
        lblHasil.AutoSize = True
        lblHasil.Location = New Point(213, 262)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(59, 25)
        lblHasil.TabIndex = 18
        lblHasil.Text = "Hasil :"
        ' 
        ' lblAngka
        ' 
        lblAngka.AutoSize = True
        lblAngka.Location = New Point(213, 158)
        lblAngka.Name = "lblAngka"
        lblAngka.Size = New Size(157, 25)
        lblAngka.TabIndex = 17
        lblAngka.Text = "Masukkan Angka :"
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClear)
        Controls.Add(btnCek)
        Controls.Add(txtHasil)
        Controls.Add(txtAngka)
        Controls.Add(lblHasil)
        Controls.Add(lblAngka)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnCek As Button
    Friend WithEvents txtHasil As TextBox
    Friend WithEvents txtAngka As TextBox
    Friend WithEvents lblHasil As Label
    Friend WithEvents lblAngka As Label
End Class
