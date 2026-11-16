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
        txtPassword = New TextBox()
        lblStatus = New Label()
        btnMasuk = New Button()
        SuspendLayout()
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(316, 175)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(230, 31)
        txtPassword.TabIndex = 1
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(229, 181)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(64, 25)
        lblStatus.TabIndex = 2
        lblStatus.Text = "Status:"
        ' 
        ' btnMasuk
        ' 
        btnMasuk.Location = New Point(316, 230)
        btnMasuk.Name = "btnMasuk"
        btnMasuk.Size = New Size(112, 34)
        btnMasuk.TabIndex = 6
        btnMasuk.Text = "Masuk"
        btnMasuk.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnMasuk)
        Controls.Add(lblStatus)
        Controls.Add(txtPassword)
        Name = "Form2"
        Text = "Validasi Password"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblStatus As Label
    Friend WithEvents btnMasuk As Button
End Class
