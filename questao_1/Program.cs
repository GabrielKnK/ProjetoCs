using System;

namespace questao_1
{
    class Program
    {
        static void Main(string[] args) 
        {

        int Indice = 13;
        float Soma = 0;
        float K = 0;

        while(K < Indice)
        {

            K = K + 1;
            Soma = Soma + K;
            Console.WriteLine("Aqui está o valor de sua soma: " + Soma);
        }

        }
    }
}
