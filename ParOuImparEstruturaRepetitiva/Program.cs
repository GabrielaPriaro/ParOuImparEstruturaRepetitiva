//Problema "par_impar" (adaptado de URI 1074)
//Leia um valor inteiro N. Este valor será a quantidade de números inteiros que serão lidos em seguida.
//Para cada valor lido, mostre uma mensagem dizendo se este valor lido é PAR ou IMPAR, e também
//se é POSITIVO ou NEGATIVO. No caso do valor ser igual a zero (0), seu programa deverá imprimir apenas NULO. 

namespace ParOuImparEstruturaRepetitiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x;

            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                x = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    Console.WriteLine("NULO");
                }
                else if (x % 2 != 0)
                {
                    if (x < 0)
                    {
                        Console.WriteLine("IMPAR NEGATIVO");
                    }
                    else
                    {
                        Console.WriteLine("IMPAR POSITIVO");
                    }
                }
                else
                {
                    if (x > 0)
                    {
                        Console.WriteLine("PAR POSITIVO");
                    }
                    else
                    {
                        Console.WriteLine("PAR NEGATIVO");
                    }
                }
            }
        }
    }
}