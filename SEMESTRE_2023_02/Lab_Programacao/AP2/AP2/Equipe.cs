//
// Classe Equipe
public class Equipe
{
    public string NomeEquipe;
    public Jogador[] Jogadores = new Jogador[5]; // Cada equipe tem exatamente 5 jogadores.
    private int jogadorCt = 0;

    public Equipe(string nomeEquipe)
    {
        NomeEquipe = nomeEquipe;
    }

    public int PontosTotal()
    {
        int pontosTotal = 0;
        for (int i = 0; i < jogadorCt; i++)
        {
            pontosTotal += Jogadores[i].Pontos;
        }
        return pontosTotal;
    }

    public int QuantidadeJogadoresNaoNulos()
    {
        int quantidadeNaoNulos = 0;
        for (int i = 0; i < jogadorCt; i++)
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
        if (jogadorCt < 5)
        {
            Jogadores[jogadorCt] = jogador;
           jogadorCt++;
        }
        else
        {
            Console.WriteLine("A equipe já possui 5 jogadores. Não é possível adicionar mais.");
            
            Console.WriteLine($"Jogador {jogador.Nome} adicionado à equipe {NomeEquipe}.");
        }
    }
}
