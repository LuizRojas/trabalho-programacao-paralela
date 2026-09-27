using System;
using System.Threading;

public static class BarraProgresso
{
    private static string progresso = "***=================================***\n";
    public static void loading(int tempo = 50)
    {
        Console.WriteLine(" ");
        foreach (char c in progresso)
        {
            Console.Write($"{c}");
            Thread.Sleep(tempo);
        }
        Console.WriteLine($"Portas abertas!");
    }
}   