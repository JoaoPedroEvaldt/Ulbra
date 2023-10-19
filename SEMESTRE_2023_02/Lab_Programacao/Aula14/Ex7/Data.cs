public class Data
{
    // Atributos da classe
    private int dia;
    private int mes;
    private int ano;

    // Construtor da classe
    public Data(int dia, int mes, int ano)
    {
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
    }

    // Método para imprimir a data formatada
    public void ImprimirDataFormatada()
    {
        Console.WriteLine($"{dia:D2}/{mes:D2}/{ano:D4}");
    }
}
 