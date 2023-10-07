/* Exercício 5: Diferentes Atributos
Utilizando a classe Carro criada durante a aula, instancie três objetos diferentes e exiba suas propriedades no console.*/

class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public double Preco { get; set; }

    public Carro(string marca, string modelo, int ano, double preco)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Preco = preco;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Instanciando três objetos da classe Carro com diferentes propriedades
        Carro carro1 = new Carro("VW", "Jetta", 2022, 35000.0);
        Carro carro2 = new Carro("Ford", "Fusion", 2021, 60000.0);
        Carro carro3 = new Carro("Honda", "Civic", 2020, 30000.0);

        // Exibindo as propriedades dos carros no console
        Console.WriteLine("Carro 1:");
        Console.WriteLine("Marca: " + carro1.Marca);
        Console.WriteLine("Modelo: " + carro1.Modelo);
        Console.WriteLine("Ano: " + carro1.Ano);
        Console.WriteLine("Preço: $" + carro1.Preco);

        Console.WriteLine("\nCarro 2:");
        Console.WriteLine("Marca: " + carro2.Marca);
        Console.WriteLine("Modelo: " + carro2.Modelo);
        Console.WriteLine("Ano: " + carro2.Ano);
        Console.WriteLine("Preço: $" + carro2.Preco);

        Console.WriteLine("\nCarro 3:");
        Console.WriteLine("Marca: " + carro3.Marca);
        Console.WriteLine("Modelo: " + carro3.Modelo);
        Console.WriteLine("Ano: " + carro3.Ano);
        Console.WriteLine("Preço: $" + carro3.Preco);

        // Aguarde até que o usuário pressione Enter para encerrar o programa
        Console.ReadLine();
    }
}
