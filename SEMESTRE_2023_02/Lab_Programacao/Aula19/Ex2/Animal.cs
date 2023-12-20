public class Animal
{

    // Propriedades

    public string Nome { get; set; }
    public int Idade { get; set; }

    //Construtor da classe base

    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;

    }

    //Metodo virtual pra emitir som

    public virtual void EmitirSom()
    {
        Console.WriteLine("Animal está emitindo algum som genérico");

    }
}