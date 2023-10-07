/*Exercício 8: Classe TimeFutebol
Crie uma classe TimeFutebol com os atributos nome, cidade e anoFundacao. Crie dois objetos com atributos diferentes e mostre-os no console.*/

class TimeFutebol{

    
      // Atributos da classe
    public string Nome { get; set; }
    public string Cidade { get; set; }
    public int AnoFundacao { get; set; }

      // Construtor da classe
    public TimeFutebol(string nome, string cidade, int anoFundacao)
    {
        Nome = nome;
        Cidade = cidade;
        AnoFundacao = anoFundacao;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando dois objetos da classe TimeFutebol com atributos diferentes
        TimeFutebol time1 = new TimeFutebol("Grêmio", "Porto Alegre", 1903);
        TimeFutebol time2 = new TimeFutebol("Real Madrid", "Madrid", 1902);

        // Mostrando os objetos no console
        Console.WriteLine("Time 1:");
        Console.WriteLine($"Nome: {time1.Nome}");
        Console.WriteLine($"Cidade: {time1.Cidade}");
        Console.WriteLine($"Ano de Fundação: {time1.AnoFundacao}");

        Console.WriteLine("\nTime 2:");
        Console.WriteLine($"Nome: {time2.Nome}");
        Console.WriteLine($"Cidade: {time2.Cidade}");
        Console.WriteLine($"Ano de Fundação: {time2.AnoFundacao}");

        // Aguarda o usuário pressionar uma tecla antes de encerrar
        Console.ReadKey();
    }
}

