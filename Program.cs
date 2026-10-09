using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Mago mago = new Mago("Gandalf");
        Elfo elfo = new Elfo("Link");

        mago.DialogoSync();
        elfo.DialogoSync();
        mago.DialogoSync();
        mago.DialogoSync();
        mago.DialogoSync();

        Task[] tarefas = {
            mago.DialogoAsync(600),
            elfo.DialogoAsync(),
            mago.DialogoAsync(1000),
            elfo.DialogoAsync(),
            mago.DialogoAsync(800),
            elfo.DialogoAsync()
        };

        await Task.WhenAll(tarefas);
        Console.WriteLine();
        BarraProgresso.loading();
    }
}   