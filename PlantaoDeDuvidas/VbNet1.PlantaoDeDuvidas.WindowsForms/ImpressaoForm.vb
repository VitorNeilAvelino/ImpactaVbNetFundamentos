Public Class ImpressaoForm

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim myText As String = "Vertical text"

        Dim fontFamily As New FontFamily("Lucida Console")
        Dim font As New Font(fontFamily, 14, FontStyle.Regular, GraphicsUnit.Point)
        Dim stringFormat As New StringFormat()
        Dim solidBrush As New SolidBrush(Color.FromArgb(255, 0, 0, 255))

        stringFormat.FormatFlags = StringFormatFlags.DirectionVertical

        'e.Graphics.DrawString(myText, font, solidBrush, 50, 50, stringFormat)

    End Sub
End Class