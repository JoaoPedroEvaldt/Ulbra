public class PessoaFisica : Pessoa
{
    public string Cpf {get; set;}
    public int RG {get; set;}

    public PessoaFisica()
    {
        NumeroConta = 1111;
    }

    public int getNumeroConta()
    {

    }

    public void Salvar(string algum)
    {
        Console.WriteLine("Salvando + algum");
    }

    public override void Excluir()
    {
        Console.WriteLine("Excluindo pessoa Juridica");
    }
}