class Usuario
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }

    public Usuario(string nome, string endereco, string telefone)
    {
        Nome = nome;
        Endereco = endereco;
        Telefone = telefone;
    }
}