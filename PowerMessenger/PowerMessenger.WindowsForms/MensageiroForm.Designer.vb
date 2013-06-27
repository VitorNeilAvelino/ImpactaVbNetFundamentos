<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MensageiroForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MensageiroForm))
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.mensageiroLeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.mensageiroToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.mensageiroToolStrip = New System.Windows.Forms.ToolStrip()
        Me.contatosToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.mensagemTextBox = New System.Windows.Forms.TextBox()
        Me.enviarButton = New System.Windows.Forms.Button()
        Me.conversaTextBox = New System.Windows.Forms.TextBox()
        Me.mensageiroToolStripContainer.LeftToolStripPanel.SuspendLayout()
        Me.mensageiroToolStripContainer.SuspendLayout()
        Me.mensageiroToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'mensageiroLeftToolStripPanel
        '
        Me.mensageiroLeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.mensageiroLeftToolStripPanel.Name = "mensageiroLeftToolStripPanel"
        Me.mensageiroLeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.mensageiroLeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.mensageiroLeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(736, 680)
        '
        'mensageiroToolStripContainer
        '
        Me.mensageiroToolStripContainer.BottomToolStripPanelVisible = False
        '
        'mensageiroToolStripContainer.ContentPanel
        '
        Me.mensageiroToolStripContainer.ContentPanel.Size = New System.Drawing.Size(214, 646)
        Me.mensageiroToolStripContainer.Dock = System.Windows.Forms.DockStyle.Left
        '
        'mensageiroToolStripContainer.LeftToolStripPanel
        '
        Me.mensageiroToolStripContainer.LeftToolStripPanel.Controls.Add(Me.mensageiroToolStrip)
        Me.mensageiroToolStripContainer.Location = New System.Drawing.Point(0, 0)
        Me.mensageiroToolStripContainer.Name = "mensageiroToolStripContainer"
        Me.mensageiroToolStripContainer.RightToolStripPanelVisible = False
        Me.mensageiroToolStripContainer.Size = New System.Drawing.Size(238, 646)
        Me.mensageiroToolStripContainer.TabIndex = 0
        Me.mensageiroToolStripContainer.TopToolStripPanelVisible = False
        '
        'mensageiroToolStrip
        '
        Me.mensageiroToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.mensageiroToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.mensageiroToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.contatosToolStripButton})
        Me.mensageiroToolStrip.Location = New System.Drawing.Point(0, 3)
        Me.mensageiroToolStrip.Name = "mensageiroToolStrip"
        Me.mensageiroToolStrip.Size = New System.Drawing.Size(24, 80)
        Me.mensageiroToolStrip.TabIndex = 0
        '
        'contatosToolStripButton
        '
        Me.contatosToolStripButton.Image = CType(resources.GetObject("contatosToolStripButton.Image"), System.Drawing.Image)
        Me.contatosToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.contatosToolStripButton.Name = "contatosToolStripButton"
        Me.contatosToolStripButton.Size = New System.Drawing.Size(22, 75)
        Me.contatosToolStripButton.Text = "Contatos"
        Me.contatosToolStripButton.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90
        Me.contatosToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'mensagemTextBox
        '
        Me.mensagemTextBox.Location = New System.Drawing.Point(244, 521)
        Me.mensagemTextBox.Multiline = True
        Me.mensagemTextBox.Name = "mensagemTextBox"
        Me.mensagemTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.mensagemTextBox.Size = New System.Drawing.Size(505, 113)
        Me.mensagemTextBox.TabIndex = 0
        '
        'enviarButton
        '
        Me.enviarButton.Location = New System.Drawing.Point(755, 521)
        Me.enviarButton.Name = "enviarButton"
        Me.enviarButton.Size = New System.Drawing.Size(49, 113)
        Me.enviarButton.TabIndex = 2
        Me.enviarButton.Text = "Enviar"
        Me.enviarButton.UseVisualStyleBackColor = True
        '
        'conversaTextBox
        '
        Me.conversaTextBox.Location = New System.Drawing.Point(245, 12)
        Me.conversaTextBox.Multiline = True
        Me.conversaTextBox.Name = "conversaTextBox"
        Me.conversaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.conversaTextBox.Size = New System.Drawing.Size(504, 503)
        Me.conversaTextBox.TabIndex = 4
        '
        'MensageiroForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(816, 646)
        Me.Controls.Add(Me.conversaTextBox)
        Me.Controls.Add(Me.enviarButton)
        Me.Controls.Add(Me.mensagemTextBox)
        Me.Controls.Add(Me.mensageiroToolStripContainer)
        Me.IsMdiContainer = True
        Me.Name = "MensageiroForm"
        Me.Text = "Power Messenger"
        Me.mensageiroToolStripContainer.LeftToolStripPanel.ResumeLayout(False)
        Me.mensageiroToolStripContainer.LeftToolStripPanel.PerformLayout()
        Me.mensageiroToolStripContainer.ResumeLayout(False)
        Me.mensageiroToolStripContainer.PerformLayout()
        Me.mensageiroToolStrip.ResumeLayout(False)
        Me.mensageiroToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents mensageiroLeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents mensageiroContentPanel As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents mensageiroToolStripContainer As System.Windows.Forms.ToolStripContainer
    Friend WithEvents mensageiroToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents contatosToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents mensagemTextBox As System.Windows.Forms.TextBox
    Friend WithEvents enviarButton As System.Windows.Forms.Button
    Friend WithEvents conversaTextBox As System.Windows.Forms.TextBox

End Class
