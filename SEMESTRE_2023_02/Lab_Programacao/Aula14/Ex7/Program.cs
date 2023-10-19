/* Classe Data
Classe: Data
Atributos: dia, mes, ano
Método: ImprimirDataFormatada()
Descrição: Crie um método que imprima a data formatada armazenada nos atributos.*/
using System;


class Program
{
    static void Main()
    {
        // Exemplo de uso da classe Data
        Data data = new Data(28, 10, 2023);
        data.ImprimirDataFormatada();
    }
}
