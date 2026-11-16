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
        lstHasil = New ListBox()
        btnProses = New Button()
        SuspendLayout()
        ' 
        ' lstHasil
        ' 
        lstHasil.FormattingEnabled = True
        lstHasil.Location = New Point(310, 136)
        lstHasil.Name = "lstHasil"
        lstHasil.Size = New Size(180, 129)
        lstHasil.TabIndex = 3
        ' 
        ' btnProses
        ' 
        btnProses.Location = New Point(310, 280)
        btnProses.Name = "btnProses"
        btnProses.Size = New Size(112, 34)
        btnProses.TabIndex = 2
        btnProses.Text = "Proses"
        btnProses.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstHasil)
        Controls.Add(btnProses)
        Name = "Form3"
        Text = "Form3"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lstHasil As ListBox
    Friend WithEvents btnProses As Button
End Class
