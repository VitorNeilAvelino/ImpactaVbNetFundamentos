Imports PowerMessenger.Dominio.Entidades

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MensageiroForm))
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.mensageiroLeftToolStripPanel = New System.Windows.Forms.ToolStripPanel()
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel()
        Me.mensageiroToolStripContainer = New System.Windows.Forms.ToolStripContainer()
        Me.clientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.LoginDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SituacaoConectividadeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.mensageiroToolStrip = New System.Windows.Forms.ToolStrip()
        Me.contatosToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.mensagemTextBox = New System.Windows.Forms.TextBox()
        Me.enviarButton = New System.Windows.Forms.Button()
        Me.conversaTextBox = New System.Windows.Forms.TextBox()
        Me.mensageiroBackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.logarButton = New System.Windows.Forms.Button()
        Me.mensageiroToolStripContainer.ContentPanel.SuspendLayout()
        Me.mensageiroToolStripContainer.LeftToolStripPanel.SuspendLayout()
        Me.mensageiroToolStripContainer.SuspendLayout()
        CType(Me.clientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.mensageiroToolStripContainer.ContentPanel.Controls.Add(Me.clientesDataGridView)
        Me.mensageiroToolStripContainer.ContentPanel.Size = New System.Drawing.Size(214, 549)
        Me.mensageiroToolStripContainer.Dock = System.Windows.Forms.DockStyle.Left
        '
        'mensageiroToolStripContainer.LeftToolStripPanel
        '
        Me.mensageiroToolStripContainer.LeftToolStripPanel.Controls.Add(Me.mensageiroToolStrip)
        Me.mensageiroToolStripContainer.Location = New System.Drawing.Point(0, 0)
        Me.mensageiroToolStripContainer.Name = "mensageiroToolStripContainer"
        Me.mensageiroToolStripContainer.RightToolStripPanelVisible = False
        Me.mensageiroToolStripContainer.Size = New System.Drawing.Size(238, 549)
        Me.mensageiroToolStripContainer.TabIndex = 0
        Me.mensageiroToolStripContainer.TopToolStripPanelVisible = False
        '
        'clientesDataGridView
        '
        Me.clientesDataGridView.AllowUserToAddRows = False
        Me.clientesDataGridView.AllowUserToDeleteRows = False
        Me.clientesDataGridView.AutoGenerateColumns = False
        Me.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.clientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LoginDataGridViewTextBoxColumn, Me.SituacaoConectividadeDataGridViewTextBoxColumn})
        Me.clientesDataGridView.DataSource = Me.ClienteBindingSource
        Me.clientesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clientesDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.clientesDataGridView.Name = "clientesDataGridView"
        Me.clientesDataGridView.ReadOnly = True
        Me.clientesDataGridView.Size = New System.Drawing.Size(214, 549)
        Me.clientesDataGridView.TabIndex = 0
        '
        'LoginDataGridViewTextBoxColumn
        '
        Me.LoginDataGridViewTextBoxColumn.DataPropertyName = "Login"
        Me.LoginDataGridViewTextBoxColumn.HeaderText = "Login"
        Me.LoginDataGridViewTextBoxColumn.Name = "LoginDataGridViewTextBoxColumn"
        Me.LoginDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SituacaoConectividadeDataGridViewTextBoxColumn
        '
        Me.SituacaoConectividadeDataGridViewTextBoxColumn.DataPropertyName = "SituacaoConectividade"
        Me.SituacaoConectividadeDataGridViewTextBoxColumn.HeaderText = "SituacaoConectividade"
        Me.SituacaoConectividadeDataGridViewTextBoxColumn.Name = "SituacaoConectividadeDataGridViewTextBoxColumn"
        Me.SituacaoConectividadeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataSource = GetType(PowerMessenger.Dominio.Entidades.Contato)
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
        Me.mensagemTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mensagemTextBox.Location = New System.Drawing.Point(244, 485)
        Me.mensagemTextBox.Multiline = True
        Me.mensagemTextBox.Name = "mensagemTextBox"
        Me.mensagemTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.mensagemTextBox.Size = New System.Drawing.Size(171, 52)
        Me.mensagemTextBox.TabIndex = 0
        '
        'enviarButton
        '
        Me.enviarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.enviarButton.Location = New System.Drawing.Point(421, 514)
        Me.enviarButton.Name = "enviarButton"
        Me.enviarButton.Size = New System.Drawing.Size(49, 23)
        Me.enviarButton.TabIndex = 1
        Me.enviarButton.Text = "Transmitir"
        Me.enviarButton.UseVisualStyleBackColor = True
        '
        'conversaTextBox
        '
        Me.conversaTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.conversaTextBox.Location = New System.Drawing.Point(245, 12)
        Me.conversaTextBox.Multiline = True
        Me.conversaTextBox.Name = "conversaTextBox"
        Me.conversaTextBox.ReadOnly = True
        Me.conversaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.conversaTextBox.Size = New System.Drawing.Size(225, 467)
        Me.conversaTextBox.TabIndex = 3
        '
        'mensageiroBackgroundWorker
        '
        '
        'logarButton
        '
        Me.logarButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.logarButton.Location = New System.Drawing.Point(421, 485)
        Me.logarButton.Name = "logarButton"
        Me.logarButton.Size = New System.Drawing.Size(49, 23)
        Me.logarButton.TabIndex = 2
        Me.logarButton.Text = "Logar"
        Me.logarButton.UseVisualStyleBackColor = True
        Me.logarButton.Visible = False
        '
        'MensageiroForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 549)
        Me.Controls.Add(Me.logarButton)
        Me.Controls.Add(Me.conversaTextBox)
        Me.Controls.Add(Me.enviarButton)
        Me.Controls.Add(Me.mensagemTextBox)
        Me.Controls.Add(Me.mensageiroToolStripContainer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MensageiroForm"
        Me.Text = "Power Messenger"
        Me.mensageiroToolStripContainer.ContentPanel.ResumeLayout(False)
        Me.mensageiroToolStripContainer.LeftToolStripPanel.ResumeLayout(False)
        Me.mensageiroToolStripContainer.LeftToolStripPanel.PerformLayout()
        Me.mensageiroToolStripContainer.ResumeLayout(False)
        Me.mensageiroToolStripContainer.PerformLayout()
        CType(Me.clientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents mensageiroBackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents logarButton As System.Windows.Forms.Button
    Friend WithEvents clientesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents LoginDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SituacaoConectividadeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteBindingSource As System.Windows.Forms.BindingSource

End Class
