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
        txtBerat = New TextBox()
        cmbTujuan = New ComboBox()
        btnTotal = New Button()
        btnClear = New Button()
        lblBerat = New Label()
        lblTujuan = New Label()
        lblTotal = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtBerat
        ' 
        txtBerat.Location = New Point(372, 164)
        txtBerat.Name = "txtBerat"
        txtBerat.Size = New Size(230, 31)
        txtBerat.TabIndex = 0
        ' 
        ' cmbTujuan
        ' 
        cmbTujuan.FormattingEnabled = True
        cmbTujuan.Location = New Point(372, 217)
        cmbTujuan.Name = "cmbTujuan"
        cmbTujuan.Size = New Size(230, 33)
        cmbTujuan.TabIndex = 1
        ' 
        ' btnTotal
        ' 
        btnTotal.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnTotal.Location = New Point(372, 321)
        btnTotal.Name = "btnTotal"
        btnTotal.Size = New Size(112, 34)
        btnTotal.TabIndex = 2
        btnTotal.Text = "Total"
        btnTotal.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(490, 321)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 3
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lblBerat
        ' 
        lblBerat.AutoSize = True
        lblBerat.BackColor = Color.Transparent
        lblBerat.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblBerat.ForeColor = Color.Ivory
        lblBerat.Location = New Point(174, 164)
        lblBerat.Name = "lblBerat"
        lblBerat.Size = New Size(189, 28)
        lblBerat.TabIndex = 4
        lblBerat.Text = "Berat Paket (KG)    :"
        ' 
        ' lblTujuan
        ' 
        lblTujuan.AutoSize = True
        lblTujuan.BackColor = Color.Transparent
        lblTujuan.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTujuan.ForeColor = Color.LightYellow
        lblTujuan.Location = New Point(174, 217)
        lblTujuan.Name = "lblTujuan"
        lblTujuan.Size = New Size(192, 28)
        lblTujuan.TabIndex = 5
        lblTujuan.Text = "Tujuan Pengiriman :"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.BackColor = Color.Transparent
        lblTotal.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.ForeColor = Color.LightYellow
        lblTotal.Location = New Point(174, 275)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(237, 28)
        lblTotal.TabIndex = 6
        lblTotal.Text = "Total Ongkos Kirim : Rp0"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DarkOliveGreen
        Label1.Font = New Font("Segoe Print", 16F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Ivory
        Label1.Location = New Point(103, 60)
        Label1.Name = "Label1"
        Label1.Size = New Size(580, 57)
        Label1.TabIndex = 7
        Label1.Text = "APLIKASI ONGKOS KIRIM PAKET"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources._10
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(lblTotal)
        Controls.Add(lblTujuan)
        Controls.Add(lblBerat)
        Controls.Add(btnClear)
        Controls.Add(btnTotal)
        Controls.Add(cmbTujuan)
        Controls.Add(txtBerat)
        Name = "Form1"
        Text = "Test_Syifa"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtBerat As TextBox
    Friend WithEvents cmbTujuan As ComboBox
    Friend WithEvents btnTotal As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblBerat As Label
    Friend WithEvents lblTujuan As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label1 As Label

End Class
