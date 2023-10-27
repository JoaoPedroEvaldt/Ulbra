//
// Classe Equipe
public class Equipe
{
    public string NomeEquipe;
    public Jogador[] Jogadores = new Jogador[5]; // Cada equipe tem exatamente 5 jogadores.
    private int jogadorCount = 0;

    public Equipe(string nomeEquipe)
    {
        NomeEquipe = nomeEquipe;
    }

    public int PontosTotal()
    {
        int pontosTotal = 0;
        for (int i = 0; i < jogadorCount; i++)
        {
            pontosTotal += Jogadores[i].Pontos;
        }
        return pontosTotal;
    }

    public int QuantidadeJogadoresNaoNulos()
    {
        int quantidadeNaoNulos = 0;
        for (int i = 0; i < jogadorCount; i++)
        {
            if (Jogadores[i] != null)
            {
                quantidadeNaoNulos++;
            }
        }
        return quantidadeNaoNulos;
    }

    public void AdicionarJogador(Jogador jogador)
    {
        if (jogadorCount < 5)
        {
            Jogadores[jogadorCount] = jogador;
            jogadorCount++;
        }
        else
        {
            Console.WriteLine("A equipe já possui 5 jogadores. Não é possível adicionar mais.");
        }
    }
}
