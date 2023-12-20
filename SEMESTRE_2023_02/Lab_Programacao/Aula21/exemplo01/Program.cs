PessoaFisica pessoaFisica = new();
pessoaFisica.Nome = "João";
pessoaFisica.Cpf = "01.002.003-45";
pessoaFisica.Salvar("Pessoa Fisica");


PessoaJuridica pessoaJuridica = new();
pessoaJuridica.Cnpj ="65432143465645";
pessoaJuridica.Salvar();
Console.WriteLine(pessoaJuridica.getNumeroConta);