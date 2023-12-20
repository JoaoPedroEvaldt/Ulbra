public class Gato : Animal
{
    // Sobrescreve o método EmitirSom da classe base
    public override void EmitirSom()
    {
        Console.WriteLine("Gato emitindo miado: Miau Miau!");
    }
}