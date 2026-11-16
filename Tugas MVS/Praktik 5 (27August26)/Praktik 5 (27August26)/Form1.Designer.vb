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
        lblUmur = New Label()
        lblHasil = New Label()
        txtUmur = New TextBox()
        txtHasil = New TextBox()
        btnCek = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Location = New Point(206, 148)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(150, 25)
        lblUmur.TabIndex = 0
        lblUmur.Text = "Masukkan Umur :"
        ' 
        ' lblHasil
        ' 
        lblHasil.AutoSize = True
        lblHasil.Location = New Point(206, 252)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(59, 25)
        lblHasil.TabIndex = 1
        lblHasil.Text = "Hasil :"
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(362, 148)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(218, 31)
        txtUmur.TabIndex = 2
        ' 
        ' txtHasil
        ' 
        txtHasil.Location = New Point(271, 252)
        txtHasil.Name = "txtHasil"
        txtHasil.Size = New Size(309, 31)
        txtHasil.TabIndex = 3
        ' 
        ' btnCek
        ' 
        btnCek.Location = New Point(362, 203)
        btnCek.Name = "btnCek"
        btnCek.Size = New Size(105, 34)
        btnCek.TabIndex = 4
        btnCek.Text = "Cek"
        btnCek.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(475, 203)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 34)
        Button1.TabIndex = 5
        Button1.Text = "Clear"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(btnCek)
        Controls.Add(txtHasil)
        Controls.Add(txtUmur)
        Controls.Add(lblHasil)
        Controls.Add(lblUmur)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblUmur As Label
    Friend WithEvents lblHasil As Label
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtHasil As TextBox
    Friend WithEvents btnCek As Button
    Friend WithEvents Button1 As Button

End Class
