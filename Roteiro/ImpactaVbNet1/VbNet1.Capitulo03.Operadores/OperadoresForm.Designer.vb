<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OperadoresForm
    'Inherits System.Windows.Forms.Form

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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OperadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.aritmeticosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReduzidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BooleanosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.logicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.resultadoListBox = New System.Windows.Forms.ListBox()
        Me.ternarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.precedenciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperadoresToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(284, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OperadoresToolStripMenuItem
        '
        Me.OperadoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.aritmeticosToolStripMenuItem, Me.ReduzidosToolStripMenuItem, Me.BooleanosToolStripMenuItem, Me.logicosToolStripMenuItem, Me.ternarioToolStripMenuItem, Me.precedenciaToolStripMenuItem})
        Me.OperadoresToolStripMenuItem.Name = "OperadoresToolStripMenuItem"
        Me.OperadoresToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.OperadoresToolStripMenuItem.Text = "&Operadores"
        '
        'aritmeticosToolStripMenuItem
        '
        Me.aritmeticosToolStripMenuItem.Name = "aritmeticosToolStripMenuItem"
        Me.aritmeticosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.aritmeticosToolStripMenuItem.Text = "&Aritméticos"
        '
        'ReduzidosToolStripMenuItem
        '
        Me.ReduzidosToolStripMenuItem.Name = "ReduzidosToolStripMenuItem"
        Me.ReduzidosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ReduzidosToolStripMenuItem.Text = "&Reduzidos"
        '
        'BooleanosToolStripMenuItem
        '
        Me.BooleanosToolStripMenuItem.Name = "BooleanosToolStripMenuItem"
        Me.BooleanosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BooleanosToolStripMenuItem.Text = "&Booleanos"
        '
        'logicosToolStripMenuItem
        '
        Me.logicosToolStripMenuItem.Name = "logicosToolStripMenuItem"
        Me.logicosToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.logicosToolStripMenuItem.Text = "&Lógicos"
        '
        'resultadoListBox
        '
        Me.resultadoListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.resultadoListBox.FormattingEnabled = True
        Me.resultadoListBox.Location = New System.Drawing.Point(0, 24)
        Me.resultadoListBox.Name = "resultadoListBox"
        Me.resultadoListBox.ScrollAlwaysVisible = True
        Me.resultadoListBox.Size = New System.Drawing.Size(284, 238)
        Me.resultadoListBox.TabIndex = 1
        '
        'ternarioToolStripMenuItem
        '
        Me.ternarioToolStripMenuItem.Name = "ternarioToolStripMenuItem"
        Me.ternarioToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ternarioToolStripMenuItem.Text = "Ternários"
        '
        'precedenciaToolStripMenuItem
        '
        Me.precedenciaToolStripMenuItem.Name = "precedenciaToolStripMenuItem"
        Me.precedenciaToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.precedenciaToolStripMenuItem.Text = "Precedência"
        '
        'OperadoresForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.resultadoListBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "OperadoresForm"
        Me.Text = "Variáveis e operadores"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents OperadoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents aritmeticosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents resultadoListBox As System.Windows.Forms.ListBox
    Friend WithEvents ReduzidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BooleanosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents logicosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ternarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents precedenciaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
