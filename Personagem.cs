using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

public class Personagem
{
    public string nome { get; }
    public string tipo { get; }
    protected Queue<string> mensagens;
    private static readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1, 1);

    public Personagem(string nome, string tipo = "Homem")
    {
        this.nome = nome;
        this.tipo = tipo;
        mensagens = new Queue<string>();
    }

    public void DialogoSync(int tempoFala = 80)
    {
        if (mensagens.Count == 0)
            return;
        string msn = mensagens.Dequeue();
        Console.Write($"{tipo}: ");
        fala(msn, tempoFala);
        Console.WriteLine("");
        Thread.Sleep(800);
    }

    public async Task DialogoAsync(int tempoFala = 80)
    {
        if (mensagens.Count == 0)
            return;

        string msn = mensagens.Dequeue();

        await _semaphore.WaitAsync();
        try
        {
            Console.Write($"{tipo}: ");
            foreach (char c in msn)
            {
                Console.Write($"{c}");
                await Task.Delay(tempoFala);
            }
            Console.Write("  ");
        }
        finally
        {
            _semaphore.Release();
        }
        await Task.Delay(200);
    }

    private void fala(string msn, int tempo = 80)
    {
        foreach (char c in msn)
        {
            Console.Write($"{c}");
            Thread.Sleep(tempo);
        }
        Console.Write(" ");
    }
}   