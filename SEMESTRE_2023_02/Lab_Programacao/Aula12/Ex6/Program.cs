/* Classe Funcionário
Desenvolva uma classe Funcionario com os atributos nome, salario e cargo. Instancie um objeto e exiba suas informações.
*/



class Funcionario
{
    public string Nome { get; set; }
    public double Salario { get; set; }
    public string Cargo { get; set; }

    public Funcionario(string nome, double salario, string cargo)
    {
        Nome = nome;
        Salario = salario;
        Cargo = cargo;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Salário: R${Salario:F2}");
        Console.WriteLine($"Cargo: {Cargo}");
    }
}

class Program
{
    static void Main()
    {
        // Instanciando um objeto da classe Funcionario
        Funcionario funcionario1 = new Funcionario("João", 5000.0, "Dev. Back-end JR");

        // Exibindo as informações do funcionário
        funcionario1.ExibirInformacoes();
    }
}
