<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientesForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.masculinoRadioButton = New System.Windows.Forms.RadioButton()
        Me.femininoRadioButton = New System.Windows.Forms.RadioButton()
        Me.nomeTextBox = New System.Windows.Forms.TextBox()
        Me.enderecoTextBox = New System.Windows.Forms.TextBox()
        Me.estadoCivilComboBox = New System.Windows.Forms.ComboBox()
        Me.preferencialCheckBox = New System.Windows.Forms.CheckBox()
        Me.paisListBox = New System.Windows.Forms.ListBox()
        Me.gravarButton = New System.Windows.Forms.Button()
        Me.limparButton = New System.Windows.Forms.Button()
        Me.ajudaLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Endereço:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Estado &civil:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.masculinoRadioButton)
        Me.GroupBox1.Controls.Add(Me.femininoRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(279, 100)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo"
        '
        'masculinoRadioButton
        '
        Me.masculinoRadioButton.AutoSize = True
        Me.masculinoRadioButton.Location = New System.Drawing.Point(151, 42)
        Me.masculinoRadioButton.Name = "masculinoRadioButton"
        Me.masculinoRadioButton.Size = New System.Drawing.Size(73, 17)
        Me.masculinoRadioButton.TabIndex = 1
        Me.masculinoRadioButton.TabStop = True
        Me.masculinoRadioButton.Text = "&Masculino"
        Me.masculinoRadioButton.UseVisualStyleBackColor = True
        '
        'femininoRadioButton
        '
        Me.femininoRadioButton.AutoSize = True
        Me.femininoRadioButton.Location = New System.Drawing.Point(55, 42)
        Me.femininoRadioButton.Name = "femininoRadioButton"
        Me.femininoRadioButton.Size = New System.Drawing.Size(67, 17)
        Me.femininoRadioButton.TabIndex = 0
        Me.femininoRadioButton.TabStop = True
        Me.femininoRadioButton.Text = "&Feminino"
        Me.femininoRadioButton.UseVisualStyleBackColor = True
        '
        'nomeTextBox
        '
        Me.nomeTextBox.Location = New System.Drawing.Point(82, 6)
        Me.nomeTextBox.Name = "nomeTextBox"
        Me.nomeTextBox.Size = New System.Drawing.Size(212, 20)
        Me.nomeTextBox.TabIndex = 1
        '
        'enderecoTextBox
        '
        Me.enderecoTextBox.Location = New System.Drawing.Point(82, 40)
        Me.enderecoTextBox.Name = "enderecoTextBox"
        Me.enderecoTextBox.Size = New System.Drawing.Size(212, 20)
        Me.enderecoTextBox.TabIndex = 3
        '
        'estadoCivilComboBox
        '
        Me.estadoCivilComboBox.FormattingEnabled = True
        Me.estadoCivilComboBox.Items.AddRange(New Object() {"Casado", "Solteiro", "Viúvo", "Separado", "Outro"})
        Me.estadoCivilComboBox.Location = New System.Drawing.Point(82, 195)
        Me.estadoCivilComboBox.Name = "estadoCivilComboBox"
        Me.estadoCivilComboBox.Size = New System.Drawing.Size(99, 21)
        Me.estadoCivilComboBox.TabIndex = 6
        '
        'preferencialCheckBox
        '
        Me.preferencialCheckBox.AutoSize = True
        Me.preferencialCheckBox.Location = New System.Drawing.Point(187, 197)
        Me.preferencialCheckBox.Name = "preferencialCheckBox"
        Me.preferencialCheckBox.Size = New System.Drawing.Size(82, 17)
        Me.preferencialCheckBox.TabIndex = 7
        Me.preferencialCheckBox.Text = "&Preferencial"
        Me.preferencialCheckBox.UseVisualStyleBackColor = True
        '
        'paisListBox
        '
        Me.paisListBox.FormattingEnabled = True
        Me.paisListBox.Items.AddRange(New Object() {"Brasil", "Argentina", "México"})
        Me.paisListBox.Location = New System.Drawing.Point(300, 6)
        Me.paisListBox.Name = "paisListBox"
        Me.paisListBox.Size = New System.Drawing.Size(117, 199)
        Me.paisListBox.TabIndex = 8
        '
        'gravarButton
        '
        Me.gravarButton.Location = New System.Drawing.Point(300, 211)
        Me.gravarButton.Name = "gravarButton"
        Me.gravarButton.Size = New System.Drawing.Size(117, 23)
        Me.gravarButton.TabIndex = 9
        Me.gravarButton.Text = "&Gravar"
        Me.gravarButton.UseVisualStyleBackColor = True
        '
        'limparButton
        '
        Me.limparButton.Location = New System.Drawing.Point(300, 240)
        Me.limparButton.Name = "limparButton"
        Me.limparButton.Size = New System.Drawing.Size(117, 23)
        Me.limparButton.TabIndex = 10
        Me.limparButton.Text = "&Limpar"
        Me.limparButton.UseVisualStyleBackColor = True
        '
        'ajudaLinkLabel
        '
        Me.ajudaLinkLabel.AutoSize = True
        Me.ajudaLinkLabel.Location = New System.Drawing.Point(17, 245)
        Me.ajudaLinkLabel.Name = "ajudaLinkLabel"
        Me.ajudaLinkLabel.Size = New System.Drawing.Size(34, 13)
        Me.ajudaLinkLabel.TabIndex = 11
        Me.ajudaLinkLabel.TabStop = True
        Me.ajudaLinkLabel.Text = "&Ajuda"
        '
        'ClientesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 279)
        Me.Controls.Add(Me.ajudaLinkLabel)
        Me.Controls.Add(Me.limparButton)
        Me.Controls.Add(Me.gravarButton)
        Me.Controls.Add(Me.paisListBox)
        Me.Controls.Add(Me.preferencialCheckBox)
        Me.Controls.Add(Me.estadoCivilComboBox)
        Me.Controls.Add(Me.enderecoTextBox)
        Me.Controls.Add(Me.nomeTextBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ClientesForm"
        Me.Text = "Clientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents nomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents enderecoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents estadoCivilComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents masculinoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents femininoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents preferencialCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents paisListBox As System.Windows.Forms.ListBox
    Friend WithEvents gravarButton As System.Windows.Forms.Button
    Friend WithEvents limparButton As System.Windows.Forms.Button
    Friend WithEvents ajudaLinkLabel As System.Windows.Forms.LinkLabel

End Class
