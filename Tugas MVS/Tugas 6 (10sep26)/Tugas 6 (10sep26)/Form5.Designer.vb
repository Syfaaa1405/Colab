<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        txtNama = New TextBox()
        txtNISN = New TextBox()
        txtEmail = New TextBox()
        txtUsia = New TextBox()
        btnDaftar = New Button()
        btnClear = New Button()
        lblNama = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        lblNISN = New Label()
        lblEmail = New Label()
        lblUsia = New Label()
        lblFinally = New Label()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(363, 100)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(150, 31)
        txtNama.TabIndex = 0
        ' 
        ' txtNISN
        ' 
        txtNISN.Location = New Point(363, 149)
        txtNISN.Name = "txtNISN"
        txtNISN.Size = New Size(150, 31)
        txtNISN.TabIndex = 1
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(363, 249)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(150, 31)
        txtEmail.TabIndex = 3
        ' 
        ' txtUsia
        ' 
        txtUsia.Location = New Point(363, 200)
        txtUsia.Name = "txtUsia"
        txtUsia.Size = New Size(150, 31)
        txtUsia.TabIndex = 2
        ' 
        ' btnDaftar
        ' 
        btnDaftar.Location = New Point(251, 304)
        btnDaftar.Name = "btnDaftar"
        btnDaftar.Size = New Size(112, 34)
        btnDaftar.TabIndex = 4
        btnDaftar.Text = "DAFTAR"
        btnDaftar.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(401, 304)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 5
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(251, 103)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(63, 25)
        lblNama.TabIndex = 6
        lblNama.Text = "Nama:"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' lblNISN
        ' 
        lblNISN.AutoSize = True
        lblNISN.Location = New Point(251, 152)
        lblNISN.Name = "lblNISN"
        lblNISN.Size = New Size(57, 25)
        lblNISN.TabIndex = 7
        lblNISN.Text = "NISN:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(251, 252)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(58, 25)
        lblEmail.TabIndex = 9
        lblEmail.Text = "Email:"
        ' 
        ' lblUsia
        ' 
        lblUsia.AutoSize = True
        lblUsia.Location = New Point(251, 203)
        lblUsia.Name = "lblUsia"
        lblUsia.Size = New Size(49, 25)
        lblUsia.TabIndex = 8
        lblUsia.Text = "Usia:"
        ' 
        ' lblFinally
        ' 
        lblFinally.AutoSize = True
        lblFinally.Location = New Point(251, 364)
        lblFinally.Name = "lblFinally"
        lblFinally.Size = New Size(0, 25)
        lblFinally.TabIndex = 10
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblFinally)
        Controls.Add(lblEmail)
        Controls.Add(lblUsia)
        Controls.Add(lblNISN)
        Controls.Add(lblNama)
        Controls.Add(btnClear)
        Controls.Add(btnDaftar)
        Controls.Add(txtEmail)
        Controls.Add(txtUsia)
        Controls.Add(txtNISN)
        Controls.Add(txtNama)
        Name = "Form5"
        Text = "Form5"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNISN As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtUsia As TextBox
    Friend WithEvents btnDaftar As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblNama As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblUsia As Label
    Friend WithEvents lblNISN As Label
    Friend WithEvents lblFinally As Label
End Class
