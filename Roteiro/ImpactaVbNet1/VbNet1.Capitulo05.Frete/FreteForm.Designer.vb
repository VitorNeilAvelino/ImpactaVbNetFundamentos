﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.freteErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.clienteTextBox = New System.Windows.Forms.TextBox()
        Me.valorTextBox = New System.Windows.Forms.TextBox()
        Me.ufComboBox = New System.Windows.Forms.ComboBox()
        Me.freteLabel = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.gravarButton = New System.Windows.Forms.Button()
        CType(Me.freteErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'freteErrorProvider
        '
        Me.freteErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.freteErrorProvider.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Valor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "UF:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "% Frete:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total:"
        '
        'clienteTextBox
        '
        Me.clienteTextBox.Location = New System.Drawing.Point(63, 6)
        Me.clienteTextBox.Name = "clienteTextBox"
        Me.clienteTextBox.Size = New System.Drawing.Size(270, 20)
        Me.clienteTextBox.TabIndex = 1
        Me.clienteTextBox.Tag = "*"
        '
        'valorTextBox
        '
        Me.valorTextBox.Location = New System.Drawing.Point(63, 41)
        Me.valorTextBox.Name = "valorTextBox"
        Me.valorTextBox.Size = New System.Drawing.Size(121, 20)
        Me.valorTextBox.TabIndex = 2
        Me.valorTextBox.Tag = "*Decimal"
        '
        'ufComboBox
        '
        Me.ufComboBox.FormattingEnabled = True
        Me.ufComboBox.Items.AddRange(New Object() {"SP", "RJ", "MG", "AM", "Outros"})
        Me.ufComboBox.Location = New System.Drawing.Point(63, 76)
        Me.ufComboBox.Name = "ufComboBox"
        Me.ufComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ufComboBox.TabIndex = 3
        Me.ufComboBox.Tag = "*"
        '
        'freteLabel
        '
        Me.freteLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.freteLabel.Location = New System.Drawing.Point(60, 107)
        Me.freteLabel.Name = "freteLabel"
        Me.freteLabel.Size = New System.Drawing.Size(124, 26)
        Me.freteLabel.TabIndex = 0
        Me.freteLabel.Text = "0%"
        Me.freteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalLabel
        '
        Me.totalLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.totalLabel.Location = New System.Drawing.Point(60, 142)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(124, 26)
        Me.totalLabel.TabIndex = 0
        Me.totalLabel.Text = "0,00"
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gravarButton
        '
        Me.gravarButton.Location = New System.Drawing.Point(278, 144)
        Me.gravarButton.Name = "gravarButton"
        Me.gravarButton.Size = New System.Drawing.Size(75, 23)
        Me.gravarButton.TabIndex = 4
        Me.gravarButton.Text = "&Gravar"
        Me.gravarButton.UseVisualStyleBackColor = True
        '
        'FreteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 175)
        Me.Controls.Add(Me.gravarButton)
        Me.Controls.Add(Me.ufComboBox)
        Me.Controls.Add(Me.valorTextBox)
        Me.Controls.Add(Me.clienteTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.freteLabel)
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
    Friend WithEvents freteErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ufComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents valorTextBox As System.Windows.Forms.TextBox
    Friend WithEvents clienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents freteLabel As System.Windows.Forms.Label
    Friend WithEvents totalLabel As System.Windows.Forms.Label
    Friend WithEvents gravarButton As System.Windows.Forms.Button

End Class
