

 namespace Delegate{
    delegate double BinaryNumericOperation( double n1, double n2);

    class Program
    {


        class Calculadora
        {
            public static double Max( double X, double Y)
            {
                if ( X > Y)
                {
                    return X;

                }
                else {
                    return Y;
                }

            }
                public static double soma(double X, double Y )

                {
                    return X + Y;
                }
            }
            static void Main(string [] args)
            {
                double a = 10;
                double b = 30;

                BinaryNumericOperation operacao = Calculadora.soma;

                Console.WriteLine(operacao(a,b));
            }
        }
    }
 