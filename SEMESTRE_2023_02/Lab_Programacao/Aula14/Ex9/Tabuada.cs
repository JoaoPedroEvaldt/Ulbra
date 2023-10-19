public class Tabuada
{
    // Atributo para armazenar o número base
    private int numeroBase;

    // Construtor da classe
    public Tabuada(int numeroBase)
    {
        this.numeroBase = numeroBase;
    }

    // Método para imprimir a tabuada
    public void ImprimirTabuada()
    {
        Console.WriteLine($"Tabuada do {numeroBase}:");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numeroBase * i;
            
            Console.WriteLine($"{numeroBase} x {i} = {resultado}");

        }
    }
}
