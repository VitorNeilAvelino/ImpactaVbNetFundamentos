<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualizadorForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VisualizadorForm))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.abrirToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.imagemPictureBox = New System.Windows.Forms.PictureBox()
        Me.visualizadorOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.imagemPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.abrirToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(844, 25)
        Me.ToolStrip1.TabIndex = 0
        '
        'abrirToolStripButton
        '
        Me.abrirToolStripButton.Image = Global.VbNet1.Capitulo02.Visualizador.My.Resources.Resources.pastaAbertaImagem
        Me.abrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.abrirToolStripButton.Name = "abrirToolStripButton"
        Me.abrirToolStripButton.Size = New System.Drawing.Size(53, 22)
        Me.abrirToolStripButton.Text = "Abrir"
        '
        'imagemPictureBox
        '
        Me.imagemPictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imagemPictureBox.Location = New System.Drawing.Point(0, 25)
        Me.imagemPictureBox.Name = "imagemPictureBox"
        Me.imagemPictureBox.Size = New System.Drawing.Size(844, 418)
        Me.imagemPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.imagemPictureBox.TabIndex = 1
        Me.imagemPictureBox.TabStop = False
        '
        'VisualizadorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 443)
        Me.Controls.Add(Me.imagemPictureBox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VisualizadorForm"
        Me.Text = "Visualizador de imagens"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.imagemPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents abrirToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents imagemPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents visualizadorOpenFileDialog As System.Windows.Forms.OpenFileDialog

End Class
