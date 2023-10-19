/*  Classe CalculadoraArea
Classe: CalculadoraArea
Métodos: Sobrecargas do método CalcularArea()
Descrição: Crie sobrecargas do método CalcularArea() conforme especificado anteriormente. Não utilize atributos.*/



public class Program
{
    static void Main()
    {
        CalculadoraArea calculadora = new CalculadoraArea();

        // Calcular a área de um quadrado
        double areaQuadrado = calculadora.CalcularAreaQuadrado(5.0);
        Console.WriteLine($"Área do quadrado: {areaQuadrado}");

        // Calcular a área de um retângulo
        double areaRetangulo = calculadora.CalcularAreaRetangulo(4.0, 6.0);
        Console.WriteLine($"Área do retângulo: {areaRetangulo}");

        // Calcular a área de um círculo
        double areaCirculo = calculadora.CalcularAreaCirculo(3.0);
        Console.WriteLine($"Área do círculo: {areaCirculo}");
    }
}
