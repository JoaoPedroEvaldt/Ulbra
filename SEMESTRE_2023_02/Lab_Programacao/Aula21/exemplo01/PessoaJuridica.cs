public class PessoaJuridica : Pessoa
{
    public string Cnpj { get; set; }

     public PessoaJuridica()
    {
        NumeroConta = 1111;
    }

    public int getNumeroConta()
    {
        
    }

    public override void Excluir()
    {
        Console.WriteLine("Excluindo Pessoa Juridica");
    }

    public void Salvar()
    {
        Console.WriteLine("Salvando Pessoa Juridica");
    }
}