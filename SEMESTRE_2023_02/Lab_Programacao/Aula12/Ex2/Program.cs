
class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public string Categoria { get; set; }

    public Produto(string nome, double preco, string categoria)
    {
        Nome = nome;
        Preco = preco;
        Categoria = categoria;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando um objeto da classe Produto
        Produto produto1 = new Produto("Iphone", 5400.0, "Eletrônicos");

        // Exibindo os atributos do produto no console
        Console.WriteLine("Dados do Produto:");
        Console.WriteLine("Nome: " + produto1.Nome);
        Console.WriteLine("Preço: $" + produto1.Preco);
        Console.WriteLine("Categoria: " + produto1.Categoria);

        // Aguarde até que o usuário pressione Enter para encerrar o programa
        Console.ReadLine();
    }
}
