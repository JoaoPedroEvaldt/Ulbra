using System.Security.Cryptography.X509Certificates;

public class ArmazenamentoBD : IRepositoriodedados
{
    public void Salvar(string dados)
    {
        Console.WriteLine("Salvando no Banco de Dados");
    }

    public string Carregar()
    {
        return "Carregando no banco de Dados";
    }
}