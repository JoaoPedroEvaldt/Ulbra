// Classe derivada Gato
public class Gato : Animal
{
    // Construtor que configura a propriedade NumeroDePatas
    public Gato()
    {
        NumeroDePatas = 4;
    }

    // Sobrescreve o método EmitirSom e chama ExibirNumeroDePatas
    public override void EmitirSom()
    {
        base.EmitirSom(); // Chama o método da classe base
        Console.WriteLine("O gato mia.");
        ExibirNumeroDePatas(); // Chama o método protegido da classe base
    }
}