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
        btnTambah = New Button()
        btnSelesai = New Button()
        lblTotal = New Label()
        SuspendLayout()
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(265, 181)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 41)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnSelesai
        ' 
        btnSelesai.Location = New Point(395, 181)
        btnSelesai.Name = "btnSelesai"
        btnSelesai.Size = New Size(112, 41)
        btnSelesai.TabIndex = 3
        btnSelesai.Text = "Selesai"
        btnSelesai.UseVisualStyleBackColor = True
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(265, 229)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(171, 25)
        lblTotal.TabIndex = 4
        lblTotal.Text = "Total Penjumlahan ="
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblTotal)
        Controls.Add(btnSelesai)
        Controls.Add(btnTambah)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnSelesai As Button
    Friend WithEvents lblTotal As Label
End Class
