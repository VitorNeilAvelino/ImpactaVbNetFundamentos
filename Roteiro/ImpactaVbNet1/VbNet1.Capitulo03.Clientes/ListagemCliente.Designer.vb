<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListagemCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListagemCliente))
        Me.clientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.listagemClientesToolStrip = New System.Windows.Forms.ToolStrip()
        Me.imprimirToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.clientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.listagemClientesToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'clientesDataGridView
        '
        Me.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.clientesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clientesDataGridView.Location = New System.Drawing.Point(0, 25)
        Me.clientesDataGridView.Name = "clientesDataGridView"
        Me.clientesDataGridView.Size = New System.Drawing.Size(750, 381)
        Me.clientesDataGridView.TabIndex = 1
        '
        'listagemClientesToolStrip
        '
        Me.listagemClientesToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.listagemClientesToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.imprimirToolStripButton})
        Me.listagemClientesToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.listagemClientesToolStrip.Name = "listagemClientesToolStrip"
        Me.listagemClientesToolStrip.Size = New System.Drawing.Size(116, 25)
        Me.listagemClientesToolStrip.TabIndex = 2
        '
        'imprimirToolStripButton
        '
        Me.imprimirToolStripButton.Image = CType(resources.GetObject("imprimirToolStripButton.Image"), System.Drawing.Image)
        Me.imprimirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.imprimirToolStripButton.Name = "imprimirToolStripButton"
        Me.imprimirToolStripButton.Size = New System.Drawing.Size(73, 22)
        Me.imprimirToolStripButton.Text = "&Imprimir"
        '
        'ListagemCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 406)
        Me.Controls.Add(Me.listagemClientesToolStrip)
        Me.Controls.Add(Me.clientesDataGridView)
        Me.Name = "ListagemCliente"
        Me.Text = "Clientes"
        Me.Controls.SetChildIndex(Me.clientesDataGridView, 0)
        Me.Controls.SetChildIndex(Me.listagemClientesToolStrip, 0)
        CType(Me.clientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.listagemClientesToolStrip.ResumeLayout(False)
        Me.listagemClientesToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents clientesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents listagemClientesToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents imprimirToolStripButton As System.Windows.Forms.ToolStripButton
End Class
