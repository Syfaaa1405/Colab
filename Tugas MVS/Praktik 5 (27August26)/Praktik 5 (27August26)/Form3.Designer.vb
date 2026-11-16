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
        btnClear = New Button()
        btnCek = New Button()
        txtGrade = New TextBox()
        txtNilai = New TextBox()
        lblGrade = New Label()
        lblNilai = New Label()
        SuspendLayout()
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(475, 212)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 16
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnCek
        ' 
        btnCek.Location = New Point(357, 212)
        btnCek.Name = "btnCek"
        btnCek.Size = New Size(112, 34)
        btnCek.TabIndex = 15
        btnCek.Text = "Cek"
        btnCek.UseVisualStyleBackColor = True
        ' 
        ' txtGrade
        ' 
        txtGrade.Location = New Point(288, 262)
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(299, 31)
        txtGrade.TabIndex = 14
        ' 
        ' txtNilai
        ' 
        txtNilai.Location = New Point(357, 158)
        txtNilai.Name = "txtNilai"
        txtNilai.Size = New Size(230, 31)
        txtNilai.TabIndex = 13
        ' 
        ' lblGrade
        ' 
        lblGrade.AutoSize = True
        lblGrade.Location = New Point(213, 262)
        lblGrade.Name = "lblGrade"
        lblGrade.Size = New Size(68, 25)
        lblGrade.TabIndex = 12
        lblGrade.Text = "Grade :"
        ' 
        ' lblNilai
        ' 
        lblNilai.AutoSize = True
        lblNilai.Location = New Point(213, 158)
        lblNilai.Name = "lblNilai"
        lblNilai.Size = New Size(140, 25)
        lblNilai.TabIndex = 11
        lblNilai.Text = "Masukkan Nilai :"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClear)
        Controls.Add(btnCek)
        Controls.Add(txtGrade)
        Controls.Add(txtNilai)
        Controls.Add(lblGrade)
        Controls.Add(lblNilai)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnCek As Button
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents txtNilai As TextBox
    Friend WithEvents lblGrade As Label
    Friend WithEvents lblNilai As Label
End Class
