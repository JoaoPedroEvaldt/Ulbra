/*Exercício 1: Hierarquia Básica de Classes

Descrição:
Crie uma classe base chamada Animal com propriedades Nome e Idade e um método EmitirSom(). Em seguida, crie duas classes derivadas: Cachorro e Gato. Sobrescreva o método EmitirSom() para que o Cachorro emita um latido e o Gato um miado.
 
Objetivos:
 
Praticar a criação de uma classe base e classes derivadas.
Entender o conceito de sobrescrever métodos.*/




class Program
{
    static void Main()
    {
        // Criando instâncias das classes derivadas
        Cachorro meuCachorro = new Cachorro { Nome = "Rex", Idade = 3 };
        Gato meuGato = new Gato { Nome = "Whiskers", Idade = 2 };

        // Chamando o método EmitirSom de cada instância
        Console.WriteLine($"Cachorro {meuCachorro.Nome}, {meuCachorro.Idade} anos: ");
        meuCachorro.EmitirSom();

        Console.WriteLine($"Gato {meuGato.Nome}, {meuGato.Idade} anos: ");
        meuGato.EmitirSom();
    }
}
