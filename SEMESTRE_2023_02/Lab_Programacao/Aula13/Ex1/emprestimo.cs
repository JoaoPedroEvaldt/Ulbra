class Emprestimo
{
    public Usuario Usuario { get; set; }
    public Livro Livro { get; set; }
    public DateTime DataEmprestimo { get; set; }
    public DateTime DataDevolucao { get; set; }

    public Emprestimo(Usuario usuario, Livro livro, DateTime dataEmprestimo, DateTime dataDevolucao)
    {
        Usuario = usuario;
        Livro = livro;
        DataEmprestimo = dataEmprestimo;
        DataDevolucao = dataDevolucao;
    }
}