public class ConversorTemperatura
{
    // Atributo para armazenar a temperatura em graus Celsius
    private double temperaturaCelsius;

    // Construtor da classe
    public ConversorTemperatura(double temperaturaCelsius)
    {
        // Inicializa o atributo temperaturaCelsius 
        this.temperaturaCelsius = temperaturaCelsius;
    }

    // Método para converter a temperatura de Celsius para Fahrenheit
    public double ConverterParaFahrenheit()
    {
        // A fórmula de conversão de Celsius para Fahrenheit é: (Celsius * 9/5) + 32
        double temperaturaFahrenheit = (temperaturaCelsius * 9 / 5) + 32;

        // Retorna a temperatura em Fahrenheit
        return temperaturaFahrenheit;
    }
}