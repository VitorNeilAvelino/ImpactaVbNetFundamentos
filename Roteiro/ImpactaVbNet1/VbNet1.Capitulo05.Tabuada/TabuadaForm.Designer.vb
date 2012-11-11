<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TabuadaForm
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
        Me.tabuadaTextBox = New System.Windows.Forms.TextBox()
        Me.tabuadaListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'tabuadaTextBox
        '
        Me.tabuadaTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabuadaTextBox.Location = New System.Drawing.Point(12, 12)
        Me.tabuadaTextBox.Name = "tabuadaTextBox"
        Me.tabuadaTextBox.Size = New System.Drawing.Size(274, 20)
        Me.tabuadaTextBox.TabIndex = 0
        '
        'tabuadaListBox
        '
        Me.tabuadaListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabuadaListBox.FormattingEnabled = True
        Me.tabuadaListBox.Location = New System.Drawing.Point(12, 38)
        Me.tabuadaListBox.Name = "tabuadaListBox"
        Me.tabuadaListBox.Size = New System.Drawing.Size(274, 277)
        Me.tabuadaListBox.TabIndex = 1
        '
        'TabuadaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 335)
        Me.Controls.Add(Me.tabuadaListBox)
        Me.Controls.Add(Me.tabuadaTextBox)
        Me.KeyPreview = True
        Me.Name = "TabuadaForm"
        Me.Text = "Tabuada"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabuadaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents tabuadaListBox As System.Windows.Forms.ListBox

End Class
