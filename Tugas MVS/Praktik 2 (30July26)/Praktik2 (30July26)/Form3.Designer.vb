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
        btnHitung = New Button()
        Label1 = New Label()
        txtUmur = New TextBox()
        SuspendLayout()
        ' 
        ' btnHitung
        ' 
        btnHitung.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHitung.Location = New Point(335, 236)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(123, 45)
        btnHitung.TabIndex = 0
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(284, 181)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 25)
        Label1.TabIndex = 1
        Label1.Text = "Umur     :"
        ' 
        ' txtUmur
        ' 
        txtUmur.Location = New Point(370, 181)
        txtUmur.Name = "txtUmur"
        txtUmur.Size = New Size(150, 31)
        txtUmur.TabIndex = 2
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtUmur)
        Controls.Add(Label1)
        Controls.Add(btnHitung)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnHitung As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUmur As TextBox
End Class
