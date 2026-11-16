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
        btnHitung = New Button()
        txtDiskon = New TextBox()
        txtTotal = New TextBox()
        lblDiskon = New Label()
        lblHari = New Label()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(351, 210)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(112, 34)
        btnHitung.TabIndex = 9
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' txtDiskon
        ' 
        txtDiskon.Location = New Point(282, 260)
        txtDiskon.Name = "txtDiskon"
        txtDiskon.Size = New Size(299, 31)
        txtDiskon.TabIndex = 8
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(351, 156)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(230, 31)
        txtTotal.TabIndex = 7
        ' 
        ' lblDiskon
        ' 
        lblDiskon.AutoSize = True
        lblDiskon.Location = New Point(207, 260)
        lblDiskon.Name = "lblDiskon"
        lblDiskon.Size = New Size(76, 25)
        lblDiskon.TabIndex = 6
        lblDiskon.Text = "Diskon :"
        ' 
        ' lblHari
        ' 
        lblHari.AutoSize = True
        lblHari.Location = New Point(207, 156)
        lblHari.Name = "lblHari"
        lblHari.Size = New Size(143, 25)
        lblHari.TabIndex = 5
        lblHari.Text = "Masukkan Total :"
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(469, 210)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 10
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClear)
        Controls.Add(btnHitung)
        Controls.Add(txtDiskon)
        Controls.Add(txtTotal)
        Controls.Add(lblDiskon)
        Controls.Add(lblHari)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnHitung As Button
    Friend WithEvents txtDiskon As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblDiskon As Label
    Friend WithEvents lblHari As Label
    Friend WithEvents btnClear As Button
End Class
