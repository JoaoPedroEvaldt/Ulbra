/*Exercício 4: Classe Curso
Crie uma classe Curso com os atributos nome, duracao e professor. Crie três objetos desta classe e imprima suas informações no console.*/


class Curso
{
    public string Nome { get; set; }
    public int Duracao { get; set; }
    public string Professor { get; set; }

    public Curso(string nome, int duracao, string professor)
    {
        Nome = nome;
        Duracao = duracao;
        Professor = professor;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando três objetos da classe Curso com diferentes informações
        Curso curso1 = new Curso("Programação em C#", 10, "João");
        Curso curso2 = new Curso("Introdução à Web ", 8, "Maria");
        Curso curso3 = new Curso("Banco de Dados", 12, "Carlos");

        // Exibindo as informações dos cursos no console
        Console.WriteLine("Curso 1:");
        Console.WriteLine("Nome: " + curso1.Nome);
        Console.WriteLine("Duração (em semanas): " + curso1.Duracao);
        Console.WriteLine("Professor: " + curso1.Professor);

        Console.WriteLine("\nCurso 2:");
        Console.WriteLine("Nome: " + curso2.Nome);
        Console.WriteLine("Duração (em semanas): " + curso2.Duracao);
        Console.WriteLine("Professor: " + curso2.Professor);

        Console.WriteLine("\nCurso 3:");
        Console.WriteLine("Nome: " + curso3.Nome);
        Console.WriteLine("Duração (em semanas): " + curso3.Duracao);
        Console.WriteLine("Professor: " + curso3.Professor);

        // Aguarde até que o usuário pressione Enter para encerrar o programa
        Console.ReadLine();
    }
}
