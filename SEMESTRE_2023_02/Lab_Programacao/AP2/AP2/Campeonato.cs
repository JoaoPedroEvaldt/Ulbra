public class Campeonato
{
    public string NomeCampeonato;
    public Equipe[] EquipesParticipantes = new Equipe[10]; // Suporta até 10 equipes.
    private int equipeCount = 0;

    public Campeonato(string nomeCampeonato)
    {
        NomeCampeonato = nomeCampeonato;
    }

    public void AdicionarEquipe(Equipe equipe) 
    {
        if (equipeCount < 10)
        {
            EquipesParticipantes[equipeCount] = equipe;
            equipeCount++;
        }
        else
        {
            Console.WriteLine("O campeonato já atingiu o limite de equipes participantes.");
        }
    }

    public void IniciarPartida(Equipe e1, Equipe e2)
    {
        if (e1 != null && e2 != null)
        {
            int jogadoresNaoNulosEquipe1 = e1.QuantidadeJogadoresNaoNulos();
            int jogadoresNaoNulosEquipe2 = e2.QuantidadeJogadoresNaoNulos();

            if (jogadoresNaoNulosEquipe1 == 5 && jogadoresNaoNulosEquipe2 == 5)
            {
               

                Console.WriteLine($"Iniciando partida entre {e1.NomeEquipe} e {e2.NomeEquipe}.");

                Console.WriteLine("=================================");
                foreach (var jogador in e1.Jogadores)
                {
                    if (jogador != null)
                    {
                        jogador.Jogar();
                    }
                }

                foreach (var jogador in e2.Jogadores)
                {
                    if (jogador != null)   // Verifica se a variável 'jogador' não é nula.
                    {
                        jogador.Jogar();
                    }
                }
            
              
            }
            else
            {
                Console.WriteLine("Ambas as equipes devem ter exatamente 5 jogadores para iniciar a partida.");
            }
        }
        else
        {
            Console.WriteLine("Uma das equipes é nula. Não é possível iniciar a partida.");
        }
    }

    public void Classificacao() // Método para exibir a classificação das equipes no campeonato.
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
