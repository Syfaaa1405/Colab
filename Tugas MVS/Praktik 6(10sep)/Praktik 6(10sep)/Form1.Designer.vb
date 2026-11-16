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
        btnClear = New Button()
        btnBagi = New Button()
        lblHasil = New Label()
        lblPembagi = New Label()
        lblAngka = New Label()
        txtPembagi = New TextBox()
        txtAngka = New TextBox()
        SuspendLayout()
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(442, 285)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(107, 34)
        btnClear.TabIndex = 22
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnBagi
        ' 
        btnBagi.Location = New Point(329, 285)
        btnBagi.Name = "btnBagi"
        btnBagi.Size = New Size(107, 34)
        btnBagi.TabIndex = 21
        btnBagi.Text = "BAGI"
        btnBagi.UseVisualStyleBackColor = True
        ' 
        ' lblHasil
        ' 
        lblHasil.AutoSize = True
        lblHasil.Location = New Point(251, 241)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(59, 25)
        lblHasil.TabIndex = 20
        lblHasil.Text = "Hasil: "
        ' 
        ' lblPembagi
        ' 
        lblPembagi.AutoSize = True
        lblPembagi.Location = New Point(251, 190)
        lblPembagi.Name = "lblPembagi"
        lblPembagi.Size = New Size(85, 25)
        lblPembagi.TabIndex = 19
        lblPembagi.Text = "Pembagi:"
        ' 
        ' lblAngka
        ' 
        lblAngka.AutoSize = True
        lblAngka.Location = New Point(251, 137)
        lblAngka.Name = "lblAngka"
        lblAngka.Size = New Size(136, 25)
        lblAngka.TabIndex = 18
        lblAngka.Text = "Angka Pertama:"
        ' 
        ' txtPembagi
        ' 
        txtPembagi.Location = New Point(399, 187)
        txtPembagi.Name = "txtPembagi"
        txtPembagi.Size = New Size(150, 31)
        txtPembagi.TabIndex = 17
        ' 
        ' txtAngka
        ' 
        txtAngka.Location = New Point(399, 131)
        txtAngka.Name = "txtAngka"
        txtAngka.Size = New Size(150, 31)
        txtAngka.TabIndex = 16
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClear)
        Controls.Add(btnBagi)
        Controls.Add(lblHasil)
        Controls.Add(lblPembagi)
        Controls.Add(lblAngka)
        Controls.Add(txtPembagi)
        Controls.Add(txtAngka)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnBagi As Button
    Friend WithEvents lblHasil As Label
    Friend WithEvents lblPembagi As Label
    Friend WithEvents lblAngka As Label
    Friend WithEvents txtPembagi As TextBox
    Friend WithEvents txtAngka As TextBox

End Class
