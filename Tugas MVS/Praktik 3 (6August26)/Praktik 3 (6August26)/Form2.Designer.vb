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
        btnCek = New Button()
        txtA = New TextBox()
        txtB = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        lblHasil = New Label()
        SuspendLayout()
        ' 
        ' btnCek
        ' 
        btnCek.Location = New Point(328, 243)
        btnCek.Name = "btnCek"
        btnCek.Size = New Size(112, 34)
        btnCek.TabIndex = 0
        btnCek.Text = "Cek"
        btnCek.UseVisualStyleBackColor = True
        ' 
        ' txtA
        ' 
        txtA.Location = New Point(328, 140)
        txtA.Name = "txtA"
        txtA.Size = New Size(150, 31)
        txtA.TabIndex = 1
        ' 
        ' txtB
        ' 
        txtB.Location = New Point(328, 183)
        txtB.Name = "txtB"
        txtB.Size = New Size(150, 31)
        txtB.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(220, 140)
        Label1.Name = "Label1"
        Label1.Size = New Size(72, 25)
        Label1.TabIndex = 3
        Label1.Text = "Nilai A :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(220, 183)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 25)
        Label2.TabIndex = 4
        Label2.Text = "Nilai B :"
        ' 
        ' lblHasil
        ' 
        lblHasil.AutoSize = True
        lblHasil.Location = New Point(220, 295)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(59, 25)
        lblHasil.TabIndex = 5
        lblHasil.Text = "Hasil :"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblHasil)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtB)
        Controls.Add(txtA)
        Controls.Add(btnCek)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCek As Button
    Friend WithEvents txtA As TextBox
    Friend WithEvents txtB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblHasil As Label
End Class
