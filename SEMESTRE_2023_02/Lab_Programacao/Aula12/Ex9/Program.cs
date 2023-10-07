/*Exercício 9: Classe Smartphone
Implemente uma classe Smartphone com atributos marca, modelo e anoLancamento. Inicialize um objeto dessa classe e imprima suas informações.*/
class Smartphone
{
    // Atributos da classe
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int AnoLancamento { get; set; }

    // Construtor da classe
    public Smartphone(string marca, string modelo, int anoLancamento)
    {
        Marca = marca;
        Modelo = modelo;
        AnoLancamento = anoLancamento;
    }
}
class Program {
    static void Main(string [] args){
        Smartphone meuSmartphone = new  Smartphone("Apple", "Iphone 15 pro max", 2023);
        Console.WriteLine("Informações do Smartphone:");
        Console.WriteLine($"Marca: {meuSmartphone.Marca}");
        Console.WriteLine($"Modelo: {meuSmartphone.Modelo}");
        Console.WriteLine($"Ano de Lançamento: {meuSmartphone.AnoLancamento}");

        
        Console.ReadKey();
    }
    
    }


