

class Program
{
    static void Main()
    {
        bool continuar;

        do
        {
            // CRIANDO VARIAVES DO PROJETO
            string nome;
            int idade;
            double altura;
            double peso;

            //COLETANDO INFORMAÇÕES DO PACIENTE

            Console.Write("Digite o nome da pessoa: ");
            nome = Console.ReadLine();

            Console.Write("Digite a idade da pessoa: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Digite a altura da pessoa : ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Digite o peso da pessoa: ");
            peso = double.Parse(Console.ReadLine());

            //CALCULO DO IMC DO PACIENTE

            double imc = peso / (altura * altura);
            string IMC;
            string faixaEtaria;
            
            
            //CONFERINDO O PESO DO PACIENTE

            if (imc < 18.5)
                IMC = "Abaixo do peso";
            else if (imc < 24.9)
                IMC = "Normal";
            else if (imc < 29.9)
                IMC = "Sobrepeso";
            else
                IMC = "Obeso";

            //CONFERINDO A IDADE DO PACIENTE

            if (idade < 13)
                faixaEtaria = "Criança";
            else if (idade < 18)
                faixaEtaria = "Adolescente";
            else if (idade < 60)
                faixaEtaria = "Adulto";
            else
                faixaEtaria = "Idoso";

                // GERANDO RELATORIO DO PACIENTE

            Console.WriteLine("\nRelatório:");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine($"IMC: {imc:F2}");
            Console.WriteLine($"Categoria de IMC: {IMC}");
            Console.WriteLine($"Faixa Etária: {faixaEtaria}");

                // O PACIENTE GOSTARIA DE GERAR UM NOVO RELATORIO 

            Console.Write("\nDeseja gerar um novo relatório para outra pessoa? (S/N): ");
            continuar = Console.ReadLine().Trim().ToUpper() == "S";
            Console.WriteLine("ENCERRANDO O PROGRAMA...");
        } while (continuar);
    }
}
