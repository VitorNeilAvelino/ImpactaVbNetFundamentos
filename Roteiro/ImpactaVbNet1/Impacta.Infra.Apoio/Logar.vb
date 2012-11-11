Imports System.Net.Mail

Public Class Logar
    Public Shared Sub PorEmail(ex As Exception)
        Dim smtpClient As New SmtpClient()
        smtpClient.Credentials = New Net.NetworkCredential("avelino.vitor@gmail.com", "senha")
        smtpClient.Port = 587
        smtpClient.Host = "smtp.gmail.com"
        smtpClient.EnableSsl = True

        Dim mensagem = New MailMessage()
        mensagem.From = New MailAddress("avelino.vitor@gmail.com", "Nome do seu Aplicativo", System.Text.Encoding.UTF8)
        mensagem.To.Add("vitoravelino@ig.com.br")

        mensagem.Subject = ex.Message.Replace(Environment.NewLine, String.Empty)
        mensagem.Body = ex.StackTrace
        mensagem.IsBodyHtml = True

        Try
            smtpClient.Send(mensagem)
        Catch
        End Try
    End Sub
End Class