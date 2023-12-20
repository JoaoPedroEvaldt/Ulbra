/*Exercício 3: Propriedades e Métodos Protegidos

Descrição:
Na classe base Animal, adicione uma propriedade protegida NumeroDePatas e um método protegido ExibirNumeroDePatas() que imprime o número de patas. Nas classes derivadas, configure esta propriedade no construtor e chame o método ExibirNumeroDePatas() dentro do método EmitirSom().
 
Objetivos:
Praticar o uso de membros protegidos e entender sua visibilidade.
Compreender como métodos e propriedades protegidos podem ser usados em classes derivadas.*/


class Program
{
    static void Main()
    {
        // Criando instâncias das classes derivadas
        Cachorro cachorro = new Cachorro();
        Gato gato = new Gato();

        // Chamando o método EmitirSom das classes derivadas
        cachorro.EmitirSom();
        gato.EmitirSom();
    }
}
