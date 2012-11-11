<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrincipalForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PrincipalForm))
        Me.principalToolStrip = New System.Windows.Forms.ToolStrip()
        Me.clientesToolStripSplitButton = New System.Windows.Forms.ToolStripSplitButton()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.principalToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'principalToolStrip
        '
        Me.principalToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.clientesToolStripSplitButton})
        Me.principalToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.principalToolStrip.Name = "principalToolStrip"
        Me.principalToolStrip.Size = New System.Drawing.Size(921, 25)
        Me.principalToolStrip.TabIndex = 1
        Me.principalToolStrip.Text = "ToolStrip1"
        '
        'clientesToolStripSplitButton
        '
        Me.clientesToolStripSplitButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem})
        Me.clientesToolStripSplitButton.Image = CType(resources.GetObject("clientesToolStripSplitButton.Image"), System.Drawing.Image)
        Me.clientesToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.clientesToolStripSplitButton.Name = "clientesToolStripSplitButton"
        Me.clientesToolStripSplitButton.Size = New System.Drawing.Size(81, 22)
        Me.clientesToolStripSplitButton.Text = "&Clientes"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NovoToolStripMenuItem.Text = "&Novo"
        '
        'PrincipalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 553)
        Me.Controls.Add(Me.principalToolStrip)
        Me.IsMdiContainer = True
        Me.Name = "PrincipalForm"
        Me.Text = "Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.principalToolStrip.ResumeLayout(False)
        Me.principalToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents principalToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents clientesToolStripSplitButton As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents NovoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class
