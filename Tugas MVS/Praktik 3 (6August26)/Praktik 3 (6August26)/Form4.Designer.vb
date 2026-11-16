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
        btnHitung = New Button()
        lblHasil = New Label()
        Label1 = New Label()
        txtNilai = New TextBox()
        SuspendLayout()
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(342, 205)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(112, 34)
        btnHitung.TabIndex = 0
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' lblHasil
        ' 
        lblHasil.AutoSize = True
        lblHasil.Location = New Point(196, 258)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(59, 25)
        lblHasil.TabIndex = 1
        lblHasil.Text = "Hasil :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(196, 154)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 25)
        Label1.TabIndex = 2
        Label1.Text = "Masukkan Nilai :"
        ' 
        ' txtNilai
        ' 
        txtNilai.Location = New Point(342, 154)
        txtNilai.Name = "txtNilai"
        txtNilai.Size = New Size(150, 31)
        txtNilai.TabIndex = 3
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtNilai)
        Controls.Add(Label1)
        Controls.Add(lblHasil)
        Controls.Add(btnHitung)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnHitung As Button
    Friend WithEvents lblHasil As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNilai As TextBox
End Class
