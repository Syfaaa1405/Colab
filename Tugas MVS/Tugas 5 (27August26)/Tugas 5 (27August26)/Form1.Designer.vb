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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        txtHarga = New TextBox()
        txtDiskon = New TextBox()
        txtAkhir = New TextBox()
        lblHarga = New Label()
        lblDiskon = New Label()
        lblAkhir = New Label()
        btnHitung = New Button()
        btnClear = New Button()
        lblPresent = New Label()
        txtPresent = New TextBox()
        lblNominal = New Label()
        txtNominal = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(207, 181)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(150, 31)
        txtHarga.TabIndex = 0
        ' 
        ' txtDiskon
        ' 
        txtDiskon.Location = New Point(492, 181)
        txtDiskon.Name = "txtDiskon"
        txtDiskon.Size = New Size(226, 31)
        txtDiskon.TabIndex = 1
        ' 
        ' txtAkhir
        ' 
        txtAkhir.Location = New Point(193, 243)
        txtAkhir.Name = "txtAkhir"
        txtAkhir.Size = New Size(164, 31)
        txtAkhir.TabIndex = 2
        ' 
        ' lblHarga
        ' 
        lblHarga.AutoSize = True
        lblHarga.BackColor = Color.Transparent
        lblHarga.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHarga.ForeColor = Color.PeachPuff
        lblHarga.Location = New Point(72, 181)
        lblHarga.Name = "lblHarga"
        lblHarga.Size = New Size(133, 25)
        lblHarga.TabIndex = 3
        lblHarga.Text = "Harga Barang :"
        ' 
        ' lblDiskon
        ' 
        lblDiskon.AutoSize = True
        lblDiskon.BackColor = Color.Transparent
        lblDiskon.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDiskon.ForeColor = Color.PeachPuff
        lblDiskon.Location = New Point(380, 181)
        lblDiskon.Name = "lblDiskon"
        lblDiskon.Size = New Size(110, 25)
        lblDiskon.TabIndex = 4
        lblDiskon.Text = "Diskon (%) :"
        ' 
        ' lblAkhir
        ' 
        lblAkhir.AutoSize = True
        lblAkhir.BackColor = Color.Transparent
        lblAkhir.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAkhir.ForeColor = Color.PeachPuff
        lblAkhir.Location = New Point(72, 243)
        lblAkhir.Name = "lblAkhir"
        lblAkhir.Size = New Size(118, 25)
        lblAkhir.TabIndex = 5
        lblAkhir.Text = "Harga Akhir :"
        ' 
        ' btnHitung
        ' 
        btnHitung.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnHitung.Location = New Point(488, 303)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(112, 34)
        btnHitung.TabIndex = 6
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(606, 303)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lblPresent
        ' 
        lblPresent.AutoSize = True
        lblPresent.BackColor = Color.Transparent
        lblPresent.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPresent.ForeColor = Color.PeachPuff
        lblPresent.Location = New Point(72, 303)
        lblPresent.Name = "lblPresent"
        lblPresent.Size = New Size(186, 25)
        lblPresent.TabIndex = 9
        lblPresent.Text = "Presentence Diskon :"
        ' 
        ' txtPresent
        ' 
        txtPresent.Location = New Point(257, 303)
        txtPresent.Name = "txtPresent"
        txtPresent.Size = New Size(207, 31)
        txtPresent.TabIndex = 8
        ' 
        ' lblNominal
        ' 
        lblNominal.AutoSize = True
        lblNominal.BackColor = Color.Transparent
        lblNominal.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNominal.ForeColor = Color.PeachPuff
        lblNominal.Location = New Point(380, 243)
        lblNominal.Name = "lblNominal"
        lblNominal.Size = New Size(154, 25)
        lblNominal.TabIndex = 11
        lblNominal.Text = "Nominal Diskon :"
        ' 
        ' txtNominal
        ' 
        txtNominal.Location = New Point(534, 240)
        txtNominal.Name = "txtNominal"
        txtNominal.Size = New Size(184, 31)
        txtNominal.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Lucida Calligraphy", 20F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.PeachPuff
        Label1.Location = New Point(113, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(573, 52)
        Label1.TabIndex = 12
        Label1.Text = "KALKULATOR DISKON"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(lblNominal)
        Controls.Add(txtNominal)
        Controls.Add(lblPresent)
        Controls.Add(txtPresent)
        Controls.Add(btnClear)
        Controls.Add(btnHitung)
        Controls.Add(lblAkhir)
        Controls.Add(lblDiskon)
        Controls.Add(lblHarga)
        Controls.Add(txtAkhir)
        Controls.Add(txtDiskon)
        Controls.Add(txtHarga)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtDiskon As TextBox
    Friend WithEvents txtAkhir As TextBox
    Friend WithEvents lblHarga As Label
    Friend WithEvents lblDiskon As Label
    Friend WithEvents lblAkhir As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblPresent As Label
    Friend WithEvents txtPresent As TextBox
    Friend WithEvents lblNominal As Label
    Friend WithEvents txtNominal As TextBox
    Friend WithEvents Label1 As Label

End Class
