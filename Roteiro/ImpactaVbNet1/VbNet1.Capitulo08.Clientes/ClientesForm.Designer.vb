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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nomeTextBox = New System.Windows.Forms.TextBox()
        Me.enderecoTextBox = New System.Windows.Forms.TextBox()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.rendaTextBox = New System.Windows.Forms.TextBox()
        Me.gravarButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nascimentoMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.cpfMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.clientesErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.clientesErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Endereço:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Nascimento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "E-mail:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Renda:"
        '
        'nomeTextBox
        '
        Me.nomeTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nomeTextBox.Location = New System.Drawing.Point(88, 25)
        Me.nomeTextBox.Name = "nomeTextBox"
        Me.nomeTextBox.Size = New System.Drawing.Size(412, 20)
        Me.nomeTextBox.TabIndex = 1
        Me.nomeTextBox.Tag = "*"
        '
        'enderecoTextBox
        '
        Me.enderecoTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.enderecoTextBox.Location = New System.Drawing.Point(88, 56)
        Me.enderecoTextBox.Name = "enderecoTextBox"
        Me.enderecoTextBox.Size = New System.Drawing.Size(412, 20)
        Me.enderecoTextBox.TabIndex = 2
        Me.enderecoTextBox.Tag = "*"
        '
        'emailTextBox
        '
        Me.emailTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.emailTextBox.Location = New System.Drawing.Point(88, 149)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(412, 20)
        Me.emailTextBox.TabIndex = 5
        Me.emailTextBox.Tag = "*EMAIL"
        '
        'rendaTextBox
        '
        Me.rendaTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rendaTextBox.Location = New System.Drawing.Point(88, 180)
        Me.rendaTextBox.Name = "rendaTextBox"
        Me.rendaTextBox.Size = New System.Drawing.Size(412, 20)
        Me.rendaTextBox.TabIndex = 6
        Me.rendaTextBox.Tag = "*DECIMAL"
        '
        'gravarButton
        '
        Me.gravarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gravarButton.Location = New System.Drawing.Point(472, 241)
        Me.gravarButton.Name = "gravarButton"
        Me.gravarButton.Size = New System.Drawing.Size(75, 23)
        Me.gravarButton.TabIndex = 7
        Me.gravarButton.Text = "&Gravar"
        Me.gravarButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "CPF:"
        '
        'nascimentoMaskedTextBox
        '
        Me.nascimentoMaskedTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nascimentoMaskedTextBox.Location = New System.Drawing.Point(88, 87)
        Me.nascimentoMaskedTextBox.Mask = "00/00/0000"
        Me.nascimentoMaskedTextBox.Name = "nascimentoMaskedTextBox"
        Me.nascimentoMaskedTextBox.Size = New System.Drawing.Size(412, 20)
        Me.nascimentoMaskedTextBox.TabIndex = 3
        Me.nascimentoMaskedTextBox.Tag = "*DATETIME"
        Me.nascimentoMaskedTextBox.ValidatingType = GetType(Date)
        '
        'cpfMaskedTextBox
        '
        Me.cpfMaskedTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cpfMaskedTextBox.Location = New System.Drawing.Point(88, 118)
        Me.cpfMaskedTextBox.Mask = "000\.000\.000-00"
        Me.cpfMaskedTextBox.Name = "cpfMaskedTextBox"
        Me.cpfMaskedTextBox.Size = New System.Drawing.Size(412, 20)
        Me.cpfMaskedTextBox.TabIndex = 4
        Me.cpfMaskedTextBox.Tag = "*CPF"
        Me.cpfMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'clientesErrorProvider
        '
        Me.clientesErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.clientesErrorProvider.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cpfMaskedTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.nascimentoMaskedTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.rendaTextBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.emailTextBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.enderecoTextBox)
        Me.GroupBox1.Controls.Add(Me.nomeTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(535, 217)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dados pessoais"
        '
        'ClientesForm
        '
        Me.AcceptButton = Me.gravarButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 274)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gravarButton)
        Me.Name = "ClientesForm"
        Me.Text = "Cadastro de Cliente"
        CType(Me.clientesErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nomeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents enderecoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents emailTextBox As System.Windows.Forms.TextBox
    Friend WithEvents rendaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents gravarButton As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nascimentoMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cpfMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Friend WithEvents clientesErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
