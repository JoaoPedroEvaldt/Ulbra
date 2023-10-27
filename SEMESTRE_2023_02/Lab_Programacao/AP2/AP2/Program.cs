

class Program
{
    static void Main(string[] args)
    {
        Campeonato campeonato = new Campeonato("ESL-Major");

        // Criar equipes
        Equipe equipe1 = new Equipe("SK-Gaming");
        Equipe equipe2 = new Equipe("MIBR");

        Console.WriteLine("=================================");

        // Criar jogadores
        Jogador jogador1 = new Jogador("Jogador 1", "Fallen");
        Jogador jogador2 = new Jogador("Jogador 2", "Colzera");
        Jogador jogador3 = new Jogador("Jogador 3", "Fnx");
        Jogador jogador4 = new Jogador("Jogador 4", "Taco");
        Jogador jogador5 = new Jogador("Jogador 5", "Fer");

        

        // Adicionar jogadores às equipes
        equipe1.AdicionarJogador(jogador1);
        equipe1.AdicionarJogador(jogador2);
        equipe1.AdicionarJogador(jogador3);
        equipe1.AdicionarJogador(jogador3); 
        equipe1.AdicionarJogador(jogador3);
        
        Console.WriteLine("=================================");

        equipe2.AdicionarJogador(jogador4);
        equipe2.AdicionarJogador(jogador5);
        equipe2.AdicionarJogador(jogador4);
        equipe2.AdicionarJogador(jogador5);
        equipe2.AdicionarJogador(jogador4);

        // Adicionar equipes ao campeonato
        campeonato.AdicionarEquipe(equipe1);
        campeonato.AdicionarEquipe(equipe2);

        // Iniciar uma partida
        campeonato.IniciarPartida(equipe1, equipe2);

        Console.WriteLine("=================================");

        // Mostrar a classificação
        campeonato.Classificacao();
      
    }
}




