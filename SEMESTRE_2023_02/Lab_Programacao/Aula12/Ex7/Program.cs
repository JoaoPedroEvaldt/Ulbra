/*Exercício 7: Atributos Numéricos
Crie uma classe Casa que possua os atributos quantidadeDeQuartos, numero e cor. Inicialize um objeto e mostre seus atributos.*/


class Casa
{
    public int quantidadeDeQuartos { get; set; }
    public string numero { get; set; }
    public string cor { get; set; }

    public Casa(int quantidadeDeQuartos, string numero, string cor)
    {
        this.quantidadeDeQuartos = quantidadeDeQuartos;
        this.numero = numero;
        this.cor = cor;
    }
}

class Program
{
    static void Main()
    {
        // Inicialize um objeto Casa
        Casa minhaCasa = new Casa(3, "123A", "Azul");

        // Mostre os atributos da casa
        Console.WriteLine("Quantidade de Quartos: " + minhaCasa.quantidadeDeQuartos);
        Console.WriteLine("Número: " + minhaCasa.numero);
        Console.WriteLine("Cor: " + minhaCasa.cor);
    }
}
