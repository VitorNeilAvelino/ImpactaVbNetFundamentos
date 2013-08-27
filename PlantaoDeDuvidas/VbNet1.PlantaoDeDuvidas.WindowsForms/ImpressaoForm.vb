Public Class ImpressaoForm
    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontFamily As New FontFamily("Lucida Console")
        Dim font As New Font(fontFamily, 10, FontStyle.Regular, GraphicsUnit.Point)

        e.Graphics.TranslateTransform(50, 100)
        e.Graphics.RotateTransform(-90)
        e.Graphics.DrawString("ASP.NET", font, New SolidBrush(Color.Red), 0, 0)
        e.Graphics.ResetTransform()
    End Sub
End Class