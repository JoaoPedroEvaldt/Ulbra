



class Program
{
    static void Main(string[] args)
    {
        Campeonato campeonato = new Campeonato("ESL-Major");

        // Criar jogadores
        Jogador jogador1 = new Jogador("Jogador 1", "Nick1");
        Jogador jogador2 = new Jogador("Jogador 2", "Nick2");
        Jogador jogador3 = new Jogador("Jogador 3", "Nick3");
        Jogador jogador4 = new Jogador("Jogador 4", "Nick4");
        Jogador jogador5 = new Jogador("Jogador 5", "Nick5");

        // Criar equipes
        Equipe equipe1 = new Equipe("SK-Gaming");
        Equipe equipe2 = new Equipe("Furia");

        // Adicionar jogadores às equipes
        equipe1.Jogadores[0] = jogador1;
        equipe1.Jogadores[1] = jogador2;
        equipe1.Jogadores[2] = jogador3;
        equipe2.Jogadores[0] = jogador4;
        equipe2.Jogadores[1] = jogador5;

        // Adicionar equipes ao campeonato
        campeonato.EquipesParticipantes[0] = equipe1;
        campeonato.EquipesParticipantes[1] = equipe2;

        // Iniciar uma partida
        campeonato.IniciarPartida(equipe1, equipe2);

        // Mostrar a classificação
        campeonato.Classificacao();
    }
}
