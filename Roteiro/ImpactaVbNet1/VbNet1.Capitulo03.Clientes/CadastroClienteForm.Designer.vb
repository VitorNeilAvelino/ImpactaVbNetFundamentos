<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroClienteForm
    Inherits VbNet1.Capitulo03.Clientes.BaseForm

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
        Me.femininoRadioButton = New System.Windows.Forms.RadioButton()
        Me.masculinoRadioButton = New System.Windows.Forms.RadioButton()
        Me.nomeTextBox = New System.Windows.Forms.TextBox()
        Me.enderecoTextBox = New System.Windows.Forms.TextBox()
        Me.ajudaLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.estadoCivilComboBox = New System.Windows.Forms.ComboBox()
        Me.preferencialCheckBox = New System.Windows.Forms.CheckBox()
        Me.paisListBox = New System.Windows.Forms.ListBox()
        Me.limparButton = New System.Windows.Forms.Button()
        Me.gravarButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Endereço:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 199)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Estado civil:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.femininoRadioButton)
        Me.GroupBox1.Controls.Add(Me.masculinoRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 51)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sexo"
        '
        'femininoRadioButton
        '
        Me.femininoRadioButton.AutoSize = True
        Me.femininoRadioButton.Location = New System.Drawing.Point(200, 17)
        Me.femininoRadioButton.Name = "femininoRadioButton"
        Me.femininoRadioButton.Size = New System.Drawing.Size(67, 17)
        Me.femininoRadioButton.TabIndex = 1
        Me.femininoRadioButton.TabStop = True
        Me.femininoRadioButton.Text = "&Feminino"
        Me.femininoRadioButton.UseVisualStyleBackColor = True
        '
        'masculinoRadioButton
        '
        Me.masculinoRadioButton.AutoSize = True
        Me.masculinoRadioButton.Location = New System.Drawing.Point(104, 17)
        Me.masculinoRadioButton.Name = "masculinoRadioButton"
        Me.masculinoRadioButton.Size = New System.Drawing.Size(73, 17)
        Me.masculinoRadioButton.TabIndex = 0
        Me.masculinoRadioButton.TabStop = True
        Me.masculinoRadioButton.Text = "&Masculino"
        Me.masculinoRadioButton.UseVisualStyleBackColor = True
        '
        'nomeTextBox
        '
        Me.nomeTextBox.Location = New System.Drawing.Point(84, 28)
        Me.nomeTextBox.Name = "nomeTextBox"
        Me.nomeTextBox.Size = New System.Drawing.Size(300, 20)
        Me.nomeTextBox.TabIndex = 1
        '
        'enderecoTextBox
        '
        Me.enderecoTextBox.Location = New System.Drawing.Point(82, 89)
        Me.enderecoTextBox.Name = "enderecoTextBox"
        Me.enderecoTextBox.Size = New System.Drawing.Size(300, 20)
        Me.enderecoTextBox.TabIndex = 2
        '
        'ajudaLinkLabel
        '
        Me.ajudaLinkLabel.AutoSize = True
        Me.ajudaLinkLabel.Location = New System.Drawing.Point(12, 240)
        Me.ajudaLinkLabel.Name = "ajudaLinkLabel"
        Me.ajudaLinkLabel.Size = New System.Drawing.Size(34, 13)
        Me.ajudaLinkLabel.TabIndex = 9
        Me.ajudaLinkLabel.TabStop = True
        Me.ajudaLinkLabel.Text = "&Ajuda"
        '
        'estadoCivilComboBox
        '
        Me.estadoCivilComboBox.FormattingEnabled = True
        Me.estadoCivilComboBox.Items.AddRange(New Object() {"Casado", "Solteiro", "Viúvo", "Apaixonado"})
        Me.estadoCivilComboBox.Location = New System.Drawing.Point(82, 196)
        Me.estadoCivilComboBox.Name = "estadoCivilComboBox"
        Me.estadoCivilComboBox.Size = New System.Drawing.Size(121, 21)
        Me.estadoCivilComboBox.TabIndex = 4
        '
        'preferencialCheckBox
        '
        Me.preferencialCheckBox.AutoSize = True
        Me.preferencialCheckBox.Location = New System.Drawing.Point(209, 198)
        Me.preferencialCheckBox.Name = "preferencialCheckBox"
        Me.preferencialCheckBox.Size = New System.Drawing.Size(82, 17)
        Me.preferencialCheckBox.TabIndex = 5
        Me.preferencialCheckBox.Text = "&Preferencial"
        Me.preferencialCheckBox.UseVisualStyleBackColor = True
        '
        'paisListBox
        '
        Me.paisListBox.FormattingEnabled = True
        Me.paisListBox.Items.AddRange(New Object() {"Brasil", "México", "Chile"})
        Me.paisListBox.Location = New System.Drawing.Point(388, 28)
        Me.paisListBox.Name = "paisListBox"
        Me.paisListBox.Size = New System.Drawing.Size(120, 147)
        Me.paisListBox.TabIndex = 6
        '
        'limparButton
        '
        Me.limparButton.Location = New System.Drawing.Point(388, 210)
        Me.limparButton.Name = "limparButton"
        Me.limparButton.Size = New System.Drawing.Size(120, 23)
        Me.limparButton.TabIndex = 8
        Me.limparButton.Text = "&Limpar"
        Me.limparButton.UseVisualStyleBackColor = True
        '
        'gravarButton
        '
        Me.gravarButton.Location = New System.Drawing.Point(388, 181)
        Me.gravarButton.Name = "gravarButton"
        Me.gravarButton.Size = New System.Drawing.Size(120, 23)
        Me.gravarButton.TabIndex = 7
        Me.gravarButton.Text = "&Gravar"
        Me.gravarButton.UseVisualStyleBackColor = True
        '
        'CadastroClienteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 411)
        Me.Controls.Add(Me.paisListBox)
        Me.Controls.Add(Me.gravarButton)
        Me.Controls.Add(Me.limparButton)
        Me.Controls.Add(Me.nomeTextBox)
        Me.Controls.Add(Me.preferencialCheckBox)
        Me.Controls.Add(Me.estadoCivilComboBox)
        Me.Controls.Add(Me.ajudaLinkLabel)
        Me.Controls.Add(Me.enderecoTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "CadastroClienteForm"
        Me.Text = "Clientes"
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.enderecoTextBox, 0)
        Me.Controls.SetChildIndex(Me.ajudaLinkLabel, 0)
        Me.Controls.SetChildIndex(Me.estadoCivilComboBox, 0)
        Me.Controls.SetChildIndex(Me.preferencialCheckBox, 0)
        Me.Controls.SetChildIndex(Me.nomeTextBox, 0)
        Me.Controls.SetChildIndex(Me.limparButton, 0)
        Me.Controls.SetChildIndex(Me.gravarButton, 0)
        Me.Controls.SetChildIndex(Me.paisListBox, 0)
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
    Friend WithEvents ajudaLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents estadoCivilComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents preferencialCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents femininoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents masculinoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents paisListBox As System.Windows.Forms.ListBox
    Friend WithEvents limparButton As System.Windows.Forms.Button
    Friend WithEvents gravarButton As System.Windows.Forms.Button
End Class
