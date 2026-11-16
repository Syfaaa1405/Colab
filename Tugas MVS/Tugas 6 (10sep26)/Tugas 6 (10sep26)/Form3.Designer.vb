<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        txt1 = New TextBox()
        txt2 = New TextBox()
        txt3 = New TextBox()
        txt5 = New TextBox()
        txt4 = New TextBox()
        lbl1 = New Label()
        lbl2 = New Label()
        lbl4 = New Label()
        lbl3 = New Label()
        lbl5 = New Label()
        txtRataRata = New TextBox()
        lblFinally = New Label()
        btnHitung = New Button()
        btnClear = New Button()
        ErrorProvider1 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txt1
        ' 
        txt1.Location = New Point(238, 86)
        txt1.Name = "txt1"
        txt1.Size = New Size(150, 31)
        txt1.TabIndex = 0
        ' 
        ' txt2
        ' 
        txt2.Location = New Point(238, 144)
        txt2.Name = "txt2"
        txt2.Size = New Size(150, 31)
        txt2.TabIndex = 1
        ' 
        ' txt3
        ' 
        txt3.Location = New Point(238, 211)
        txt3.Name = "txt3"
        txt3.Size = New Size(150, 31)
        txt3.TabIndex = 2
        ' 
        ' txt5
        ' 
        txt5.Location = New Point(238, 337)
        txt5.Name = "txt5"
        txt5.Size = New Size(150, 31)
        txt5.TabIndex = 4
        ' 
        ' txt4
        ' 
        txt4.Location = New Point(238, 279)
        txt4.Name = "txt4"
        txt4.Size = New Size(150, 31)
        txt4.TabIndex = 3
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.Location = New Point(142, 89)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(61, 25)
        lbl1.TabIndex = 5
        lbl1.Text = "Nilai 1"
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.Location = New Point(142, 147)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(61, 25)
        lbl2.TabIndex = 6
        lbl2.Text = "Nilai 2"
        ' 
        ' lbl4
        ' 
        lbl4.AutoSize = True
        lbl4.Location = New Point(142, 282)
        lbl4.Name = "lbl4"
        lbl4.Size = New Size(61, 25)
        lbl4.TabIndex = 8
        lbl4.Text = "Nilai 4"
        ' 
        ' lbl3
        ' 
        lbl3.AutoSize = True
        lbl3.Location = New Point(142, 214)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(61, 25)
        lbl3.TabIndex = 7
        lbl3.Text = "Nilai 3"
        ' 
        ' lbl5
        ' 
        lbl5.AutoSize = True
        lbl5.Location = New Point(142, 340)
        lbl5.Name = "lbl5"
        lbl5.Size = New Size(61, 25)
        lbl5.TabIndex = 9
        lbl5.Text = "Nilai 5"
        ' 
        ' txtRataRata
        ' 
        txtRataRata.Location = New Point(478, 179)
        txtRataRata.Name = "txtRataRata"
        txtRataRata.Size = New Size(206, 31)
        txtRataRata.TabIndex = 10
        ' 
        ' lblFinally
        ' 
        lblFinally.AutoSize = True
        lblFinally.Location = New Point(478, 285)
        lblFinally.Name = "lblFinally"
        lblFinally.Size = New Size(0, 25)
        lblFinally.TabIndex = 11
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(478, 236)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(95, 33)
        btnHitung.TabIndex = 12
        btnHitung.Text = "HITUNG"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(589, 236)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(95, 33)
        btnClear.TabIndex = 13
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonFace
        ClientSize = New Size(800, 450)
        Controls.Add(btnClear)
        Controls.Add(btnHitung)
        Controls.Add(lblFinally)
        Controls.Add(txtRataRata)
        Controls.Add(lbl5)
        Controls.Add(lbl4)
        Controls.Add(lbl3)
        Controls.Add(lbl2)
        Controls.Add(lbl1)
        Controls.Add(txt5)
        Controls.Add(txt4)
        Controls.Add(txt3)
        Controls.Add(txt2)
        Controls.Add(txt1)
        Name = "Form3"
        Text = "Form3"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txt1 As TextBox
    Friend WithEvents txt2 As TextBox
    Friend WithEvents txt3 As TextBox
    Friend WithEvents txt5 As TextBox
    Friend WithEvents txt4 As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents txtRataRata As TextBox
    Friend WithEvents lblFinally As Label
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
