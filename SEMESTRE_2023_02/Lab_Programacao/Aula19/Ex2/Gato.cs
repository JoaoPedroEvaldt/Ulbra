public class Gato : Animal
{
    // Construtor da classe derivada Gato
    public Gato(string nome, int idade) : base(nome, idade)
    {

    }

    public override void EmitirSom()
    {
        Console.WriteLine("Gato emitindo som: MIAU, MIAUUUU");
        base.EmitirSom();
    }
}



