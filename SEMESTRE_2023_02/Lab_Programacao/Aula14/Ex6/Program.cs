/* Classe ConversorTemperatura
Classe: ConversorTemperatura
Atributos: temperaturaCelsius
Método: ConverterParaFahrenheit()
Descrição: Crie um método que retorne a temperaturaCelsius convertida para Fahrenheit.*/

class Program
{
    static void Main()
    {
        // Cria um objeto ConversorTemperatura com uma temperatura inicial de 25 graus Celsius
        ConversorTemperatura conversor = new ConversorTemperatura(25);

        // Obtém a temperatura em Fahrenheit e a exibe
        double temperaturaFahrenheit = conversor.ConverterParaFahrenheit();
        Console.WriteLine("Temperatura em Fahrenheit: " + temperaturaFahrenheit);
    }
}
