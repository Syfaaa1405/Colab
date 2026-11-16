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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtNama = New TextBox()
        txtGaji = New TextBox()
        txtTunjangan = New TextBox()
        SuspendLayout()
        ' 
        ' btnHitung
        ' 
        btnHitung.Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnHitung.Location = New Point(374, 255)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(112, 34)
        btnHitung.TabIndex = 0
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(231, 123)
        Label1.Name = "Label1"
        Label1.Size = New Size(137, 25)
        Label1.TabIndex = 1
        Label1.Text = "Nama              :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(231, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(137, 25)
        Label2.TabIndex = 2
        Label2.Text = "Gaji Pokok      :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(231, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(142, 25)
        Label3.TabIndex = 3
        Label3.Text = "Tunjangan       :"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(374, 120)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(195, 31)
        txtNama.TabIndex = 4
        ' 
        ' txtGaji
        ' 
        txtGaji.Location = New Point(374, 162)
        txtGaji.Name = "txtGaji"
        txtGaji.Size = New Size(195, 31)
        txtGaji.TabIndex = 5
        ' 
        ' txtTunjangan
        ' 
        txtTunjangan.Location = New Point(374, 203)
        txtTunjangan.Name = "txtTunjangan"
        txtTunjangan.Size = New Size(195, 31)
        txtTunjangan.TabIndex = 6
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtTunjangan)
        Controls.Add(txtGaji)
        Controls.Add(txtNama)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnHitung)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnHitung As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtGaji As TextBox
    Friend WithEvents txtTunjangan As TextBox
End Class
