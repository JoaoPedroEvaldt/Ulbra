

// Classe Campeonato
public class Campeonato
{
    public string NomeCampeonato;
    public Equipe[] EquipesParticipantes = new Equipe[10]; // Suporta até 10 equipes.
    private int equipeCount = 0;

    public Campeonato(string nomeCampeonato)
    {
        NomeCampeonato = nomeCampeonato;
    }

    
public void IniciarPartida(Equipe e1, Equipe e2)
{
    // Verifique se as equipes não são nulas antes de iniciar a partida.
    if (e1 != null && e2 != null)
    {
        int jogadoresNaoNulosEquipe1 = e1.QuantidadeJogadoresNaoNulos();
        int jogadoresNaoNulosEquipe2 = e2.QuantidadeJogadoresNaoNulos();

        if (jogadoresNaoNulosEquipe1 == 5 || jogadoresNaoNulosEquipe2 == 5)
        {
            foreach (var jogador in e1.Jogadores)
            {
                if (jogador != null)
                {
                    jogador.Jogar();
                }
            }

            foreach (var jogador in e2.Jogadores)
            {
                if (jogador != null)
                {
                    jogador.Jogar();
                }
            }
            Console.WriteLine($"Partida entre {e1.NomeEquipe} e {e2.NomeEquipe} simulada.");
        }
        else
        {
            Console.WriteLine("Pelo menos uma equipe deve ter exatamente 5 jogadores para iniciar a partida.");
        }
    }
    else
    {
        Console.WriteLine("Uma das equipes é nula. Não é possível iniciar a partida.");
    }
}


    public void Classificacao()
    {
        for (int i = 0; i < equipeCount; i++)
        {
            for (int j = i + 1; j < equipeCount; j++)
            {
                if (EquipesParticipantes[j].PontosTotal() > EquipesParticipantes[i].PontosTotal())
                {
                    Equipe temp = EquipesParticipantes[i];
                    EquipesParticipantes[i] = EquipesParticipantes[j];
                    EquipesParticipantes[j] = temp;
                }
            }
        }

        Console.WriteLine("Classificação:");
        for (int i = 0; i < equipeCount; i++)
        {
            Console.WriteLine($"{i + 1}. {EquipesParticipantes[i].NomeEquipe} - Pontos: {EquipesParticipantes[i].PontosTotal()}");
        }
    }
}
