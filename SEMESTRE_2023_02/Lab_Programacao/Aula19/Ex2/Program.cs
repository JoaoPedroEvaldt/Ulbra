class Program
{
    static void Main()
    {
        //Criando instâncias das classes derivadas usando construtores

        Cachorro meuCachorro = new Cachorro("Meg", 3);
        Gato meuGato = new Gato("Whiskers", 2);  
        //Chamando método EmitirSom de Cachorro e Gato.

        Console.WriteLine($"Cachorro {meuCachorro.Nome}, {meuCachorro.Idade} anos:");
        meuCachorro.EmitirSom();

        Console.WriteLine($"Gato {meuGato.Nome}, {meuGato.Idade} anos:");
        meuGato.EmitirSom();

    }
}