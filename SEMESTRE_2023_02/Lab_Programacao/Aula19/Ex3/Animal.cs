// Classe base Animal
public class Animal
{
    // Propriedade protegida NumeroDePatas
    protected int NumeroDePatas;

    // Método protegido ExibirNumeroDePatas
    protected void ExibirNumeroDePatas()
    {
        Console.WriteLine($"Este animal tem {NumeroDePatas} patas.");
    }

    // Método virtual EmitirSom
    public virtual void EmitirSom()
    {
        Console.WriteLine("O animal emitiu um som.");
    }
}
