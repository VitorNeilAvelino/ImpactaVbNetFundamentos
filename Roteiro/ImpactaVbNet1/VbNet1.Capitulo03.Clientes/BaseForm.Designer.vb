<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseForm
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
        Me.baseToolStrip = New System.Windows.Forms.ToolStrip()
        Me.fecharToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.baseToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'baseToolStrip
        '
        Me.baseToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.baseToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.fecharToolStripButton, Me.ToolStripSeparator1})
        Me.baseToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.baseToolStrip.Name = "baseToolStrip"
        Me.baseToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.baseToolStrip.Size = New System.Drawing.Size(953, 25)
        Me.baseToolStrip.TabIndex = 0
        '
        'fecharToolStripButton
        '
        Me.fecharToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.fecharToolStripButton.Image = Global.VbNet1.Capitulo03.Clientes.My.Resources.Resources.fecharIcone
        Me.fecharToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.fecharToolStripButton.Name = "fecharToolStripButton"
        Me.fecharToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.fecharToolStripButton.Text = "Fechar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BaseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(953, 565)
        Me.Controls.Add(Me.baseToolStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BaseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.baseToolStrip.ResumeLayout(False)
        Me.baseToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents baseToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents fecharToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
