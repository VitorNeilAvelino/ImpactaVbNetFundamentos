<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CursorAEsquerdaMaskedTextBoxUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.cursorAEsquerdaMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'cursorAEsquerdaMaskedTextBox
        '
        Me.cursorAEsquerdaMaskedTextBox.Location = New System.Drawing.Point(0, 0)
        Me.cursorAEsquerdaMaskedTextBox.Name = "cursorAEsquerdaMaskedTextBox"
        Me.cursorAEsquerdaMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.cursorAEsquerdaMaskedTextBox.TabIndex = 0
        '
        'CursorAEsquerdaMaskedTextBoxUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cursorAEsquerdaMaskedTextBox)
        Me.Name = "CursorAEsquerdaMaskedTextBoxUserControl"
        Me.Size = New System.Drawing.Size(100, 20)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cursorAEsquerdaMaskedTextBox As System.Windows.Forms.MaskedTextBox

End Class
