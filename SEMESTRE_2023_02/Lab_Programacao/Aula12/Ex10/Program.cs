/*Exercício 10: Classe Filme
Desenvolva uma classe Filme com atributos titulo, diretor e anoLancamento. Crie um objeto e mostre suas propriedades no console.*/


class Filme
{
    // Atributos da classe
    public string Titulo { get; set; }
    public string Diretor { get; set; }
    public int AnoLancamento { get; set; }

    // Construtor da classe
    public Filme(string titulo, string diretor, int anoLancamento)
    {
        Titulo = titulo;
        Diretor = diretor;
        AnoLancamento = anoLancamento;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Filme
        Filme meuFilme = new Filme("Título do Filme", "Diretor do Filme", 2022);

        // Mostrando as propriedades do filme no console
        Console.WriteLine("Informações do Filme:");
        Console.WriteLine($"Título: {meuFilme.Titulo}");
        Console.WriteLine($"Diretor: {meuFilme.Diretor}");
        Console.WriteLine($"Ano de Lançamento: {meuFilme.AnoLancamento}");

        // Aguarde o usuário pressionar uma tecla antes de encerrar
        Console.ReadKey();
    }
}
