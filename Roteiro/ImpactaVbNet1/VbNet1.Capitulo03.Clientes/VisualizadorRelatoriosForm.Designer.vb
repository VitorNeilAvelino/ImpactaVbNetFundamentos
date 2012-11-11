<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisualizadorRelatoriosForm
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
        Me.geralReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'geralReportViewer
        '
        Me.geralReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.geralReportViewer.Location = New System.Drawing.Point(0, 0)
        Me.geralReportViewer.Name = "geralReportViewer"
        Me.geralReportViewer.Size = New System.Drawing.Size(601, 502)
        Me.geralReportViewer.TabIndex = 0
        '
        'VisualizadorRelatoriosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(601, 502)
        Me.Controls.Add(Me.geralReportViewer)
        Me.Name = "VisualizadorRelatoriosForm"
        Me.Text = "VisualizadorRelatoriosForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents geralReportViewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
