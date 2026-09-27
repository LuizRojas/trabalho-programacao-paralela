public class Mago : Personagem
{
    public Mago(string nome) : base(nome, "Mago")
    {
        mensagens.Enqueue("Quem é você viajante ?...");
        mensagens.Enqueue("OK, sou Gandalf do senhor dos anés...");
        mensagens.Enqueue("Se diz ser quem é, então diga as palavras secretas comigo...");
        mensagens.Enqueue("E as portão se abriram...");
        mensagens.Enqueue("Anah");
        mensagens.Enqueue("Passi-cii-fiik");
        mensagens.Enqueue("Perim");
    }
}   