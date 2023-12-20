// Classe derivada Cachorro
public class Cachorro : Animal
{
    // Construtor que configura a propriedade NumeroDePatas
    public Cachorro()
    {
        NumeroDePatas = 4;
    }

    // Sobrescreve o método EmitirSom e chama ExibirNumeroDePatas
    public override void EmitirSom()
    {
        base.EmitirSom(); // Chama o método da classe base
        Console.WriteLine("O cachorro late.");
        ExibirNumeroDePatas(); // Chama o método protegido da classe base
    }
}
