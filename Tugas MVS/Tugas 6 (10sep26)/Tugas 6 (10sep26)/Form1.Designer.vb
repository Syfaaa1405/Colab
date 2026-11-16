<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblSuhu = New Label()
        lblCelsius = New Label()
        txtCelsius = New TextBox()
        lblFahrenheit = New Label()
        txtFahrenheit = New TextBox()
        btnHitung = New Button()
        btnClear = New Button()
        lblStatus = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblSuhu
        ' 
        lblSuhu.AutoSize = True
        lblSuhu.Location = New Point(326, 97)
        lblSuhu.Name = "lblSuhu"
        lblSuhu.Size = New Size(133, 25)
        lblSuhu.TabIndex = 0
        lblSuhu.Text = "Koverensi Suhu"
        ' 
        ' lblCelsius
        ' 
        lblCelsius.AutoSize = True
        lblCelsius.Location = New Point(244, 177)
        lblCelsius.Name = "lblCelsius"
        lblCelsius.Size = New Size(111, 25)
        lblCelsius.TabIndex = 1
        lblCelsius.Text = "Suhu Celsius"
        ' 
        ' txtCelsius
        ' 
        txtCelsius.Location = New Point(401, 174)
        txtCelsius.Name = "txtCelsius"
        txtCelsius.Size = New Size(150, 31)
        txtCelsius.TabIndex = 2
        ' 
        ' lblFahrenheit
        ' 
        lblFahrenheit.AutoSize = True
        lblFahrenheit.Location = New Point(244, 228)
        lblFahrenheit.Name = "lblFahrenheit"
        lblFahrenheit.Size = New Size(138, 25)
        lblFahrenheit.TabIndex = 3
        lblFahrenheit.Text = "Suhu Fahrenheit"
        ' 
        ' txtFahrenheit
        ' 
        txtFahrenheit.Location = New Point(401, 225)
        txtFahrenheit.Name = "txtFahrenheit"
        txtFahrenheit.Size = New Size(150, 31)
        txtFahrenheit.TabIndex = 4
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(244, 278)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(112, 34)
        btnHitung.TabIndex = 5
        btnHitung.Text = "HITUNG"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(439, 278)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 6
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Location = New Point(22, 404)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(64, 25)
        lblStatus.TabIndex = 7
        lblStatus.Text = "Status:"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblStatus)
        Controls.Add(btnClear)
        Controls.Add(btnHitung)
        Controls.Add(txtFahrenheit)
        Controls.Add(lblFahrenheit)
        Controls.Add(txtCelsius)
        Controls.Add(lblCelsius)
        Controls.Add(lblSuhu)
        Name = "Form1"
        Text = "Form1"
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblSuhu As Label
    Friend WithEvents lblCelsius As Label
    Friend WithEvents txtCelsius As TextBox
    Friend WithEvents lblFahrenheit As Label
    Friend WithEvents txtFahrenheit As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblStatus As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
