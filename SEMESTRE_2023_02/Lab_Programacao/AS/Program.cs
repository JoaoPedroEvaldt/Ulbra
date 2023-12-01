


using System;
using System.Collections.Generic;






// Ponto de entrada do programa
class Program
{
    static void Main()
    {
        // Criar instâncias de Biblioteca e Livro
        Biblioteca biblioteca = new Biblioteca();
        Livro livro = new Livro(1, "Senhor dos Anéis", "Autor Exemplo");

        // Demonstrar a adição de um livro à biblioteca
        biblioteca.AdicionarItem(livro);

        // Demonstrar a busca de um livro por título
        ItemBiblioteca livroEncontradoPorTitulo = biblioteca.BuscarItemPorTitulo("Senhor dos Anéis");

        // Demonstrar a busca de um livro por ID
        ItemBiblioteca livroEncontradoPorId = biblioteca.BuscarItemPorId(1);

        if (livroEncontradoPorTitulo != null)
        {
            // Demonstrar a remoção do livro da biblioteca
            biblioteca.RemoverItem(livroEncontradoPorTitulo);

            // Exibir a DescricaoInterna do livro
            ((Livro)livroEncontradoPorTitulo).ExibirDescricaoInterna();
        }
    }
}


