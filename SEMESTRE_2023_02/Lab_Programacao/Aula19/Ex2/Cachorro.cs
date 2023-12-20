public class Cachorro : Animal
{
    // Construtor da classe derivada Cachorro

    public Cachorro(string nome, int idade) : base(nome, idade)
    {

    }

    // Sobrescreve o método EmitirSom da classe base

    public override void EmitirSom()
    {
        Console.WriteLine("Cachorro:AU, AU, AUUU!");
        base.EmitirSom();

    }
}