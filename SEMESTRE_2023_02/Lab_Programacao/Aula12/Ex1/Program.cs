
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string CidadeNatal { get; set; }

    public Pessoa(string nome, int idade, string cidadeNatal)
    {
        Nome = nome;
        Idade = idade;
        CidadeNatal = cidadeNatal;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Inicializando um objeto da classe Pessoa
        Pessoa pessoa1 = new Pessoa("João", 21, "Três Cachoeiras");

        // Exibindo os atributos no console
        Console.WriteLine("Nome: " + pessoa1.Nome);
        Console.WriteLine("Idade: " + pessoa1.Idade);
        Console.WriteLine("Cidade Natal: " + pessoa1.CidadeNatal);

        // Aguarde até que o usuário pressione Enter para encerrar o programa
        Console.ReadLine();
    }
}
