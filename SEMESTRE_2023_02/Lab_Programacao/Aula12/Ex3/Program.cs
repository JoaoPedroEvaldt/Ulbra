/*  Classe Animal
Implemente uma classe Animal com os atributos especie, nome e idade. Inicialize dois objetos desta classe com diferentes atributos e exiba-os no console. */


class Animal
{
    public string Especie { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Animal(string especie, string nome, int idade)
    {
        Especie = especie;
        Nome = nome;
        Idade = idade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando dois objetos da classe Animal com diferentes atributos
        Animal animal1 = new Animal("Cachorro", "Meg", 7);
        Animal animal2 = new Animal("Passarinho", "Chicão", 2);

        // Exibindo os atributos dos animais no console
        Console.WriteLine("Animal 1:");
        Console.WriteLine("Espécie: " + animal1.Especie);
        Console.WriteLine("Nome: " + animal1.Nome);
        Console.WriteLine("Idade: " + animal1.Idade);

        Console.WriteLine("\nAnimal 2:");
        Console.WriteLine("Espécie: " + animal2.Especie);
        Console.WriteLine("Nome: " + animal2.Nome);
        Console.WriteLine("Idade: " + animal2.Idade);

        // Aguarde até que o usuário pressione Enter para encerrar o programa
        Console.ReadLine();
    }
}



