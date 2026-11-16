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
        Label1 = New Label()
        lblAngka = New Label()
        txtAngka = New TextBox()
        lstHasil = New ListBox()
        btnProses = New Button()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Font = New Font("Segoe UI Semibold", 16F, FontStyle.Bold Or FontStyle.Italic)
        Label1.Location = New Point(243, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(287, 45)
        Label1.TabIndex = 0
        Label1.Text = "TABLE PERKALIAN"
        ' 
        ' lblAngka
        ' 
        lblAngka.AutoSize = True
        lblAngka.BackColor = SystemColors.Control
        lblAngka.Font = New Font("Segoe UI", 9F)
        lblAngka.Location = New Point(203, 156)
        lblAngka.Name = "lblAngka"
        lblAngka.Size = New Size(152, 25)
        lblAngka.TabIndex = 1
        lblAngka.Text = "Masukkan Angka:"
        ' 
        ' txtAngka
        ' 
        txtAngka.Location = New Point(401, 156)
        txtAngka.Name = "txtAngka"
        txtAngka.Size = New Size(180, 31)
        txtAngka.TabIndex = 2
        ' 
        ' lstHasil
        ' 
        lstHasil.FormattingEnabled = True
        lstHasil.Location = New Point(401, 204)
        lstHasil.Name = "lstHasil"
        lstHasil.Size = New Size(180, 129)
        lstHasil.TabIndex = 3
        ' 
        ' btnProses
        ' 
        btnProses.Location = New Point(243, 259)
        btnProses.Name = "btnProses"
        btnProses.Size = New Size(112, 34)
        btnProses.TabIndex = 4
        btnProses.Text = "Proses"
        btnProses.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(243, 299)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClear)
        Controls.Add(btnProses)
        Controls.Add(lstHasil)
        Controls.Add(txtAngka)
        Controls.Add(lblAngka)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Table Perkalian"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblAngka As Label
    Friend WithEvents txtAngka As TextBox
    Friend WithEvents lstHasil As ListBox
    Friend WithEvents btnProses As Button
    Friend WithEvents btnClear As Button

End Class
