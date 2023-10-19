/*Exercício: Sistema de Biblioteca
Contexto
Uma biblioteca deseja criar um sistema simples para gerenciar livros e empréstimos. O objetivo é criar classes e objetos que permitam representar os livros e os empréstimos feitos.
Requisitos
Classe Livro
Atributos: titulo (string), autor (string), anoPublicacao (int), disponivel (bool).
Classe Usuario
Atributos: nome (string), endereco (string), telefone (string).
Classe Emprestimo
Atributos: usuario (Usuario), livro (Livro), dataEmprestimo (DateTime), dataDevolucao (DateTime).
Orientações
Crie instâncias dos objetos de Livro, Usuario e Emprestimo, e atribua valores aos seus atributos.
Verifique a consistência dos dados criando cenários, por exemplo: se um livro está emprestado, seu atributo disponivel deve ser false; se o livro está disponível, true.
Considere a lógica para verificar se um empréstimo não ultrapassa a data de devolução.*/

class Program
{
    static void Main()
    {
        Livro livro1 = new Livro("O Senhor dos Anéis", "J.R.R. Tolkien", 1954);
        Livro livro2 = new Livro("Harry Potter e a Pedra Filosofal", "J.K. Rowling", 1997);

        Usuario usuario1 = new Usuario("João", "Rua A, 123", "0800-3667");
        Usuario usuario2 = new Usuario("Pedro", "Rua B, 085", "4002-8922");

        Emprestimo emprestimo1 = new Emprestimo(usuario1, livro1, DateTime.Now, DateTime.Now.AddDays(14));
        livro1.Disponivel = false;

        Console.WriteLine($"Livro: {livro1.Titulo}, Disponível: {livro1.Disponivel}");

        if (DateTime.Now > emprestimo1.DataDevolucao)
        {
            Console.WriteLine("Livro está atrasado!");
        }
        else
        {
            Console.WriteLine("Livro está dentro do prazo de uso.");
        }
    }
}
