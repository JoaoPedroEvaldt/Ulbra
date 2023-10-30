

class Program
{
    static void Main(string[] args)
    {
        Campeonato campeonato = new Campeonato("ESL-Major");

        Equipe equipe1 = new Equipe("SK-Gaming");
        Equipe equipe2 = new Equipe("MIBR");

        Console.WriteLine("=================================");

        Jogador jogador1 = new Jogador("Jogador 1", "Fallen");
        Jogador jogador2 = new Jogador("Jogador 2", "Colzera");
        Jogador jogador3 = new Jogador("Jogador 3", "Fnx");
        Jogador jogador4 = new Jogador("Jogador 4", "Taco");
        Jogador jogador5 = new Jogador("Jogador 5", "Fer");

        Jogador jogador6 = new Jogador("Jogador 6", "OutroNome1");
        Jogador jogador7 = new Jogador("Jogador 7", "OutroNome2");
        Jogador jogador8 = new Jogador("Jogador 8", "OutroNome3");
        Jogador jogador9 = new Jogador("Jogador 9", "OutroNome4");
        Jogador jogador10 = new Jogador("Jogador 10", "OutroNome5");

        equipe1.AdicionarJogador(jogador1);
        equipe1.AdicionarJogador(jogador2);
        equipe1.AdicionarJogador(jogador3);
        equipe1.AdicionarJogador(jogador4);
        equipe1.AdicionarJogador(jogador5);

        Console.WriteLine("=================================");

        equipe2.AdicionarJogador(jogador6);
        equipe2.AdicionarJogador(jogador7);
        equipe2.AdicionarJogador(jogador8);
        equipe2.AdicionarJogador(jogador9);
        equipe2.AdicionarJogador(jogador10);

        campeonato.AdicionarEquipe(equipe1);
        campeonato.AdicionarEquipe(equipe2);

        Console.WriteLine("=================================");

        campeonato.IniciarPartida(equipe1, equipe2);

        Console.WriteLine("=================================");

        campeonato.Classificacao();
    }
}
