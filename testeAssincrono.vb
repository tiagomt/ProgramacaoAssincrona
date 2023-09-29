Public Class testeAssincrono

    Friend Sub chamadaAssincrona()

        Console.WriteLine("Início do programa")

        ' Iniciar uma Task assíncrona
        Dim resultado As Task = MinhaTarefaAsync()

        ' Continuar a execução de outras tarefas na thread principal
        Console.WriteLine("Outras tarefas na thread principal")

        Console.WriteLine("Outras tarefas na thread principal 2")

        ' Aguardar a conclusão da Task antes de encerrar o programa
        resultado.Wait()

        Console.WriteLine("Fim do programa")

    End Sub

    Private Async Function MinhaTarefaAsync() As Task

        Console.WriteLine("Início da MinhaTarefaAsync")

        ' Simular uma operação assíncrona com Await Task.Delay
        Await Task.Delay(2000) ' Aguarda por 2 segundos de forma assíncrona

        Console.WriteLine("Fim da MinhaTarefaAsync")

    End Function
End Class
