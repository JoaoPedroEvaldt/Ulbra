/* Classe Tabuada
Classe: Tabuada
Atributos: numeroBase
Método: ImprimirTabuada()
Descrição: Crie um método que imprima a tabuada do numeroBase.*/


class Program
{
    static void Main()
    {
       
        Console.Write("Digite um número para gerar a tabuada: ");
        int numero = int.Parse(Console.ReadLine());

        Tabuada tabuada = new Tabuada(numero);
        tabuada.ImprimirTabuada();
    }
}
