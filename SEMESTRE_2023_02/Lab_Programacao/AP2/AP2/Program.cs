

class Program
{
    static void Main(string[] args)
    {
        // Cria um objeto Campeonato com o nome "ESL-Major"

        Campeonato campeonato = new Campeonato("ESL-Major");

         // Cria duas equipes, "SK-Gaming" e "MIBR"

        Equipe equipe1 = new Equipe("SK-Gaming");
        Equipe equipe2 = new Equipe("MIBR");
      
        Console.WriteLine("=================================");

           // Cria 5 jogadores para a equipe 1, cada um com um nome

        Jogador jogador1 = new Jogador("Jogador 1", "Fallen");
        Jogador jogador2 = new Jogador("Jogador 2", "Colzera");
        Jogador jogador3 = new Jogador("Jogador 3", "Fnx");
        Jogador jogador4 = new Jogador("Jogador 4", "Taco");
        Jogador jogador5 = new Jogador("Jogador 5", "Fer");

         // Cria 5 jogadores para a equipe 2, cada um com um nome

        Jogador jogador6 = new Jogador("Jogador 6", "Vini");
        Jogador jogador7 = new Jogador("Jogador 7", "Boltz");
        Jogador jogador8 = new Jogador("Jogador 8", "Felps");
        Jogador jogador9 = new Jogador("Jogador 9", "Hen1");
        Jogador jogador10 = new Jogador("Jogador 10", "Lucas1");

        equipe1.AdicionarJogador(jogador1);
        equipe1.AdicionarJogador(jogador2);
        equipe1.AdicionarJogador(jogador3);
        equipe1.AdicionarJogador(jogador4);
        equipe1.AdicionarJogador(jogador5);

        Console.WriteLine("=================================");

          // Adiciona os jogadores à equipe 2

        equipe2.AdicionarJogador(jogador6);
        equipe2.AdicionarJogador(jogador7);
        equipe2.AdicionarJogador(jogador8);
        equipe2.AdicionarJogador(jogador9);
        equipe2.AdicionarJogador(jogador10);

        //Adicionas as 2 equipes no campeonato

        campeonato.AdicionarEquipe(equipe1);
        campeonato.AdicionarEquipe(equipe2);

        Console.WriteLine("=================================");

        //Inicia a partida entre as 2 equipes

        campeonato.IniciarPartida(equipe1, equipe2);

        Console.WriteLine("=================================");

        //Classificação das equipes

        campeonato.Classificacao();
    }
}
