using System;

namespace questao_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int numeroFibonacci;

            Console.WriteLine("Digite qualquer número:");
            numeroFibonacci = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(VerificaFibonacci(numeroFibonacci) ? numeroFibonacci + " é um número Fibonacci" : numeroFibonacci + " não é um número Fibonacci");
        }

        static bool RaizQuadrada(int x)
        {
            int z = (int)Math.Sqrt(x);
            return (z * z == x);
        }

        static bool VerificaFibonacci(int n)
        {
            return RaizQuadrada(5 * n * n + 4) || RaizQuadrada(5 * n * n - 4);
        }

    }
}
