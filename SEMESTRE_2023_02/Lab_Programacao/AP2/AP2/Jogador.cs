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
        if (Pontos < 100) // Limita a pontuação máxima a 100
        {
            int pontosPartida = random.Next(1, 101 - Pontos); // Gera pontos entre 1 e a diferença até 100
            Pontos += pontosPartida;
            Console.WriteLine($"Jogador {Nome} jogou e acumulou {pontosPartida} pontos. Pontuação total: {Pontos}.");
        }
        else
        {
            Console.WriteLine($"O jogador {Nome} atingiu a pontuação máxima (100 pontos) e não pode acumular mais pontos.");
        }
    }
}
