/*  Classe Estudante
Desenvolva uma classe chamada Estudante com os atributos nome, curso e idade. Inicialize dois objetos desta classe e exiba suas informações. Es*/

class Estudante{

    public string Nome {get; set;}
    public string Curso { get; set;}
    public int Idade {get; set;}

    public Estudante( string nome, string curso, int idade){
        Nome = nome;
        Curso = curso;
        Idade = idade;

    }
}

class Program {

    static void Main (string [] args){

        Estudante estudante1 = new Estudante( "Joao", "ADS", 21);
         Estudante estudante2 = new Estudante( "Renata", "Farmacia", 22);

        Console.WriteLine("Informações do Estudante");
        Console.WriteLine($"Estudante 1 - Nome: {estudante1.Nome}, Curso: {estudante1.Curso}, Idade: {estudante1.Idade}");
        Console.WriteLine($"Estudante 2 - Nome: {estudante2.Nome}, Curso: {estudante2.Curso}, Idade: {estudante2.Idade}");

        Console.ReadKey();
        

    }
}