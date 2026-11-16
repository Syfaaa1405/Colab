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
        components = New ComponentModel.Container()
        txtTahun = New TextBox()
        txtUmur = New TextBox()
        btnHitung = New Button()
        btnClear = New Button()
        lblTahun = New Label()
        lblUmur = New Label()
        lblFinally = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtTahun
        ' 
        txtTahun.Location = New Point(360, 130)
        txtTahun.Name = "txtTahun"
        txtTahun.Size = New Size(150, 31)
        txtTahun.TabIndex = 0
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(360, 184)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(150, 31)
        txtUmur.TabIndex = 1
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(254, 259)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(112, 34)
        btnHitung.TabIndex = 2
        btnHitung.Text = "HITUNG"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(398, 259)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 3
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lblTahun
        ' 
        lblTahun.AutoSize = True
        lblTahun.Location = New Point(254, 133)
        lblTahun.Name = "lblTahun"
        lblTahun.Size = New Size(100, 25)
        lblTahun.TabIndex = 4
        lblTahun.Text = "Tahun Lahir"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Location = New Point(254, 187)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(56, 25)
        lblUmur.TabIndex = 5
        lblUmur.Text = "Umur"
        ' 
        ' lblFinally
        ' 
        lblFinally.AutoSize = True
        lblFinally.Location = New Point(254, 316)
        lblFinally.Name = "lblFinally"
        lblFinally.Size = New Size(0, 25)
        lblFinally.TabIndex = 6
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblFinally)
        Controls.Add(lblUmur)
        Controls.Add(lblTahun)
        Controls.Add(btnClear)
        Controls.Add(btnHitung)
        Controls.Add(txtUmur)
        Controls.Add(txtTahun)
        Name = "Form4"
        Text = "Form4"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTahun As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblTahun As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblFinally As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
