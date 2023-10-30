public class Professor{

    protected readonly float salariomaximo;
    float salarioAtual;

    public Professor(float salarioMaximo )
    {
        salariomaximo = salarioMaximo;
    }

    protected float ModificarSalario (float Modf)
    {
        float novoSalario = salarioAtual + Modf;
        

        if(novoSalario < 0)
        {
            salarioAtual = 0;
        }
        else if ( novoSalario > salariomaximo)
        {
            salarioAtual = salariomaximo;
        }
        else {
            salarioAtual = novoSalario;
        }
        return salarioAtual;
    }

    public float AumentarSalario()
    {

    return ModificarSalario(+500);

    }   

    public float DiminuirSalario()
    {
        return ModificarSalario(-500);
    }

    public class Prof : Professor
    {
        public Prof() : base(1400)
        {

        }


    }

    public static void Main()
    {
        Console.WriteLine("Professor 1: ");
        Prof prof1 = new Prof();
        Console.WriteLine(prof1.AumentarSalario());
        Console.WriteLine(prof1.AumentarSalario());
    }

    }

  