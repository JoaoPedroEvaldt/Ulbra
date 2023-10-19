public class CalculadoraArea
{
    // Método para calcular a área de um quadrado
    public double CalcularAreaQuadrado(double lado)
    {
        return lado * lado;
    }

    // Método para calcular a área de um retângulo
    public double CalcularAreaRetangulo(double comprimento, double largura)
    {
        return comprimento * largura;
    }

    // Método para calcular a área de um círculo
    public double CalcularAreaCirculo(double raio)
    {
        return Math.PI * raio * raio;
    }
}
