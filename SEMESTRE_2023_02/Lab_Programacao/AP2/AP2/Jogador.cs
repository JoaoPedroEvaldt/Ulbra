// Classe Jogador
public class Jogador
{
    public string Nome;
    public string Nickname;
    public int Pontos;
    private Random random = new Random();

    public Jogador(string nome, string nickname)
    {
        Nome = nome;
        Nickname = nickname;
        Pontos = 0;
    }

    public void Jogar()
    {
        int pontosPartida = random.Next(1, 101);
        Pontos += pontosPartida;
    }
}
