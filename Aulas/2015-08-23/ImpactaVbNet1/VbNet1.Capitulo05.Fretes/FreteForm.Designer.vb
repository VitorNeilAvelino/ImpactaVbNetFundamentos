<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FreteForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.clienteComboBox = New System.Windows.Forms.ComboBox()
        Me.ufComboBox = New System.Windows.Forms.ComboBox()
        Me.valorTextBox = New System.Windows.Forms.TextBox()
        Me.percentualTextBox = New System.Windows.Forms.TextBox()
        Me.totalTextBox = New System.Windows.Forms.TextBox()
        Me.limparButton = New System.Windows.Forms.Button()
        Me.calcularButton = New System.Windows.Forms.Button()
        Me.freteErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.freteErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Valor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "&UF:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&Percentual:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "&Total:"
        '
        'clienteComboBox
        '
        Me.clienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.clienteComboBox.FormattingEnabled = True
        Me.clienteComboBox.Location = New System.Drawing.Point(79, 6)
        Me.clienteComboBox.Name = "clienteComboBox"
        Me.clienteComboBox.Size = New System.Drawing.Size(241, 21)
        Me.clienteComboBox.TabIndex = 1
        Me.clienteComboBox.Tag = "*"
        '
        'ufComboBox
        '
        Me.ufComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ufComboBox.FormattingEnabled = True
        Me.ufComboBox.Items.AddRange(New Object() {"SP", "RJ", "MG", "AM", "Outros"})
        Me.ufComboBox.Location = New System.Drawing.Point(79, 84)
        Me.ufComboBox.Name = "ufComboBox"
        Me.ufComboBox.Size = New System.Drawing.Size(100, 21)
        Me.ufComboBox.TabIndex = 5
        Me.ufComboBox.Tag = "*"
        '
        'valorTextBox
        '
        Me.valorTextBox.Location = New System.Drawing.Point(79, 45)
        Me.valorTextBox.Name = "valorTextBox"
        Me.valorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.valorTextBox.TabIndex = 3
        Me.valorTextBox.Tag = "*DECIMAL"
        '
        'percentualTextBox
        '
        Me.percentualTextBox.Location = New System.Drawing.Point(79, 123)
        Me.percentualTextBox.Name = "percentualTextBox"
        Me.percentualTextBox.ReadOnly = True
        Me.percentualTextBox.Size = New System.Drawing.Size(100, 20)
        Me.percentualTextBox.TabIndex = 7
        '
        'totalTextBox
        '
        Me.totalTextBox.Location = New System.Drawing.Point(79, 162)
        Me.totalTextBox.Name = "totalTextBox"
        Me.totalTextBox.ReadOnly = True
        Me.totalTextBox.Size = New System.Drawing.Size(100, 20)
        Me.totalTextBox.TabIndex = 9
        '
        'limparButton
        '
        Me.limparButton.Location = New System.Drawing.Point(245, 155)
        Me.limparButton.Name = "limparButton"
        Me.limparButton.Size = New System.Drawing.Size(75, 23)
        Me.limparButton.TabIndex = 11
        Me.limparButton.Text = "&Limpar"
        Me.limparButton.UseVisualStyleBackColor = True
        '
        'calcularButton
        '
        Me.calcularButton.Location = New System.Drawing.Point(245, 126)
        Me.calcularButton.Name = "calcularButton"
        Me.calcularButton.Size = New System.Drawing.Size(75, 23)
        Me.calcularButton.TabIndex = 10
        Me.calcularButton.Text = "&Calcular"
        Me.calcularButton.UseVisualStyleBackColor = True
        '
        'freteErrorProvider
        '
        Me.freteErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.freteErrorProvider.ContainerControl = Me
        '
        'FreteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 206)
        Me.Controls.Add(Me.calcularButton)
        Me.Controls.Add(Me.limparButton)
        Me.Controls.Add(Me.totalTextBox)
        Me.Controls.Add(Me.percentualTextBox)
        Me.Controls.Add(Me.valorTextBox)
        Me.Controls.Add(Me.ufComboBox)
        Me.Controls.Add(Me.clienteComboBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FreteForm"
        Me.Text = "Frete"
        CType(Me.freteErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents clienteComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ufComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents valorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents percentualTextBox As System.Windows.Forms.TextBox
    Friend WithEvents totalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents limparButton As System.Windows.Forms.Button
    Friend WithEvents calcularButton As System.Windows.Forms.Button
    Friend WithEvents freteErrorProvider As System.Windows.Forms.ErrorProvider

End Class
