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
        chkX = New CheckBox()
        chkY = New CheckBox()
        btnProses = New Button()
        lblHasil = New Label()
        SuspendLayout()
        ' 
        ' chkX
        ' 
        chkX.AutoSize = True
        chkX.Location = New Point(255, 151)
        chkX.Name = "chkX"
        chkX.Size = New Size(96, 29)
        chkX.TabIndex = 0
        chkX.Text = "X (True)"
        chkX.UseVisualStyleBackColor = True
        ' 
        ' chkY
        ' 
        chkY.AutoSize = True
        chkY.Location = New Point(406, 151)
        chkY.Name = "chkY"
        chkY.Size = New Size(101, 29)
        chkY.TabIndex = 1
        chkY.Text = "Y (False)"
        chkY.UseVisualStyleBackColor = True
        ' 
        ' btnProses
        ' 
        btnProses.Location = New Point(325, 195)
        btnProses.Name = "btnProses"
        btnProses.Size = New Size(112, 34)
        btnProses.TabIndex = 2
        btnProses.Text = "Proses"
        btnProses.UseVisualStyleBackColor = True
        ' 
        ' lblHasil
        ' 
        lblHasil.AutoSize = True
        lblHasil.Location = New Point(255, 253)
        lblHasil.Name = "lblHasil"
        lblHasil.Size = New Size(59, 25)
        lblHasil.TabIndex = 3
        lblHasil.Text = "Hasil :"
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblHasil)
        Controls.Add(btnProses)
        Controls.Add(chkY)
        Controls.Add(chkX)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents chkX As CheckBox
    Friend WithEvents chkY As CheckBox
    Friend WithEvents btnProses As Button
    Friend WithEvents lblHasil As Label
End Class
