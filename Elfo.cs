public class Elfo : Personagem
{
    public Elfo(string nome) : base(nome, "Elfo")
    {
        mensagens.Enqueue("Sou link do jogo zelda...");
        mensagens.Enqueue("Milac");
        mensagens.Enqueue("Teish");
        mensagens.Enqueue("Salaa-saa-aah");
    }
}   