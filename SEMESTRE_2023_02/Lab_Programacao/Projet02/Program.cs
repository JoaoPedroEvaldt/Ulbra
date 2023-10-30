 public class Carro {

    public string Nome;
    public string Marca;
    public string Potencia;

    public Carro(string nome, string marca, double potencia )
    {
      Nome = nome;
      Marca = marca;
      Potencia = potencia;
    }
    public Carro()
    {

    }
    class Construtor
    {
        static void Main(string[] args)
        {
            var carro = new Carro();
            carro.Nome = "Civic";
            carro.Marca = "Honda";
            carro.Potencia = 2.5;
            Console.WriteLine($"{ carro.Nome} {carro.Marca} {carro.Potencia}");

            var carro2 = new Carro("Golf", "Volkswagen", 1.4);

            Console.WriteLine($"{carro2.Nome} {carro2.Marca} {carro2.Potencia}");
        }
    }
    
}
