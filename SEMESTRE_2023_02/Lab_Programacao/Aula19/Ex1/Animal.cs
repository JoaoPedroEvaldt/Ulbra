public class Animal
{
    // Propriedades
    public string Nome { get; set; }
    public int Idade { get; set; }

    // Método virtual para emitir som
    public virtual void EmitirSom()
    {
        Console.WriteLine("Animal emitindo som genérico");
    }
}