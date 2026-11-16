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
        Label2 = New Label()
        txtAngka1 = New TextBox()
        txtAngka2 = New TextBox()
        btnTambah = New Button()
        btnKurang = New Button()
        btnKali = New Button()
        btnBagi = New Button()
        Label3 = New Label()
        txtHasil = New TextBox()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.IndianRed
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(173, 99)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 25)
        Label1.TabIndex = 0
        Label1.Text = "Angka Pertama :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.IndianRed
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.MistyRose
        Label2.Location = New Point(173, 145)
        Label2.Name = "Label2"
        Label2.Size = New Size(145, 25)
        Label2.TabIndex = 1
        Label2.Text = "Angka Kedua    :"
        ' 
        ' txtAngka1
        ' 
        txtAngka1.Location = New Point(337, 96)
        txtAngka1.Name = "txtAngka1"
        txtAngka1.Size = New Size(302, 31)
        txtAngka1.TabIndex = 2
        ' 
        ' txtAngka2
        ' 
        txtAngka2.Location = New Point(337, 139)
        txtAngka2.Name = "txtAngka2"
        txtAngka2.Size = New Size(302, 31)
        txtAngka2.TabIndex = 3
        ' 
        ' btnTambah
        ' 
        btnTambah.BackColor = Color.IndianRed
        btnTambah.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTambah.ForeColor = Color.MistyRose
        btnTambah.Location = New Point(173, 202)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 54)
        btnTambah.TabIndex = 4
        btnTambah.Text = "+"
        btnTambah.UseVisualStyleBackColor = False
        ' 
        ' btnKurang
        ' 
        btnKurang.BackColor = Color.IndianRed
        btnKurang.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnKurang.ForeColor = Color.MistyRose
        btnKurang.Location = New Point(291, 202)
        btnKurang.Name = "btnKurang"
        btnKurang.Size = New Size(112, 54)
        btnKurang.TabIndex = 5
        btnKurang.Text = "-"
        btnKurang.UseVisualStyleBackColor = False
        ' 
        ' btnKali
        ' 
        btnKali.BackColor = Color.IndianRed
        btnKali.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnKali.ForeColor = Color.MistyRose
        btnKali.Location = New Point(409, 202)
        btnKali.Name = "btnKali"
        btnKali.Size = New Size(112, 54)
        btnKali.TabIndex = 6
        btnKali.Text = "x"
        btnKali.UseVisualStyleBackColor = False
        ' 
        ' btnBagi
        ' 
        btnBagi.BackColor = Color.IndianRed
        btnBagi.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnBagi.ForeColor = Color.MistyRose
        btnBagi.Location = New Point(527, 202)
        btnBagi.Name = "btnBagi"
        btnBagi.Size = New Size(112, 54)
        btnBagi.TabIndex = 7
        btnBagi.Text = "/"
        btnBagi.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.IndianRed
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.MistyRose
        Label3.Location = New Point(173, 293)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 25)
        Label3.TabIndex = 8
        Label3.Text = "Hasil     :"
        ' 
        ' txtHasil
        ' 
        txtHasil.Location = New Point(275, 287)
        txtHasil.Name = "txtHasil"
        txtHasil.Size = New Size(364, 31)
        txtHasil.TabIndex = 9
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.IndianRed
        btnClear.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnClear.ForeColor = Color.MistyRose
        btnClear.Location = New Point(527, 339)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 10
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.download__7_
        ClientSize = New Size(800, 450)
        Controls.Add(btnClear)
        Controls.Add(txtHasil)
        Controls.Add(Label3)
        Controls.Add(btnBagi)
        Controls.Add(btnKali)
        Controls.Add(btnKurang)
        Controls.Add(btnTambah)
        Controls.Add(txtAngka2)
        Controls.Add(txtAngka1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Kalkulator Sederhana"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAngka1 As TextBox
    Friend WithEvents txtAngka2 As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnKurang As Button
    Friend WithEvents btnKali As Button
    Friend WithEvents btnBagi As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHasil As TextBox
    Friend WithEvents btnClear As Button

End Class
