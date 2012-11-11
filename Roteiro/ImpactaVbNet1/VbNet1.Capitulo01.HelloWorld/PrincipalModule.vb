'Namespace VbNet1.Capitulo01.HelloWorld
Module PrincipalModule

    'Class Programa
    'Shared Sub Main()
    Private Const RespostaCorreta As String = "42"

    Sub Main()


        Console.WriteLine("Qual a resposta para a vida, o universo e tudo mais?")

        Dim resposta = Console.ReadLine()
        Dim tentativas = 2

        While resposta <> 42 '<> RespostaCorreta AndAlso tentativas > 0
            Console.WriteLine("Resposta incorreta. Você tem mais {0} tentativa(s).", tentativas)
            resposta = Console.ReadLine()
            tentativas -= 1
        End While
        'Loop apenas se for Do While

        If resposta = RespostaCorreta Then
            Console.WriteLine("Resposta correta!")
        Else
            Console.WriteLine("Suas tentativas esgotaram-se!")
            Process.Start("http://www.google.com.br/#hl=pt-BR&gs_nf=1&cp=15&gs_id=1m&xhr=t&q=answer+to+life+the+universe+and+everything&pf=p&output=search&sclient=psy-ab&oq=answer+to+life+&aq=0&aqi=g3&aql=&gs_l=&pbx=1&bav=on.2,or.r_gc.r_pw.r_qf.,cf.osb&fp=528b6fc787221f1&biw=1257&bih=655")
        End If

        'Console.WriteLine("Digite qualquer Enter para sair.")
        'Dim teclaPressionada = Console.ReadKey()

        'While teclaPressionada.Key <> ConsoleKey.Enter
        '    Console.WriteLine("Digite qualquer Enter para sair.")
        '    teclaPressionada = Console.ReadKey(True)
        'End While

        Do
            Console.WriteLine("Digite Enter para sair.")
        Loop While Console.ReadKey(True).Key <> ConsoleKey.Enter
        'Loop Until Console.ReadKey(True).Key = ConsoleKey.Enter

    End Sub
    'End Class
End Module
'End Namespace