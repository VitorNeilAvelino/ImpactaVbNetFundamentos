<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelecaoArquivoForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelecaoArquivoForm))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.abrirArquivoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.selecaoArquivoOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.arquivoRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.abrirArquivoToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(659, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'abrirArquivoToolStripButton
        '
        Me.abrirArquivoToolStripButton.Image = CType(resources.GetObject("abrirArquivoToolStripButton.Image"), System.Drawing.Image)
        Me.abrirArquivoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.abrirArquivoToolStripButton.Name = "abrirArquivoToolStripButton"
        Me.abrirArquivoToolStripButton.Size = New System.Drawing.Size(53, 22)
        Me.abrirArquivoToolStripButton.Text = "&Abrir"
        '
        'selecaoArquivoOpenFileDialog
        '
        Me.selecaoArquivoOpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        Me.selecaoArquivoOpenFileDialog.Title = "Abrir arquivo"
        '
        'arquivoRichTextBox
        '
        Me.arquivoRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.arquivoRichTextBox.Location = New System.Drawing.Point(0, 25)
        Me.arquivoRichTextBox.Name = "arquivoRichTextBox"
        Me.arquivoRichTextBox.Size = New System.Drawing.Size(659, 376)
        Me.arquivoRichTextBox.TabIndex = 1
        Me.arquivoRichTextBox.Text = ""
        '
        'SelecaoArquivoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 401)
        Me.Controls.Add(Me.arquivoRichTextBox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "SelecaoArquivoForm"
        Me.Text = "Seleção de arquivo para conversão"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents abrirArquivoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents selecaoArquivoOpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents arquivoRichTextBox As System.Windows.Forms.RichTextBox

End Class
