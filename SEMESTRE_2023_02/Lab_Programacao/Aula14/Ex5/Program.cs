
/*Exercício 5: Classe Concatenador
Classe: Concatenador
Métodos: Sobrecargas do método Concatenar()
Descrição: Crie sobrecargas do método Concatenar como especificado previamente, sem utilizar atributos.*/



class Program
{
    static void Main()
    {
        Concatenador concatenador = new Concatenador();

        string result1 = concatenador.Concatenar("Hello, ", "world!");
        Console.WriteLine(result1); 

        string result2 = concatenador.Concatenar("C#", " is ", "awesome!");
        Console.WriteLine(result2); 

        string result3 = concatenador.Concatenar("This", " is", " a", " sentence.");
        Console.WriteLine(result3);

        string result4 = concatenador.Concatenar(10, 20);
        Console.WriteLine(result4); 
    }
}