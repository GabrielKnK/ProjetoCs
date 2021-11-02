using System;
using System.Collections.Generic;
using System.Linq;

namespace questao_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var valores = new List<int> 
            {20, 10, 50, 70, 100, 0, 0, 20, 10, 75, 10, 100, 0, 0, 30, 
            150, 30, 60, 25, 0, 0, 300, 10, 20, 20, 70, 0, 0, 95, 40};

            List<int> filtro = valores.FindAll(x => x > 0);

            int minimo = filtro.Min();

            Console.WriteLine("Aqui está o menor valor: " + minimo);

            int maximo = filtro.Max();

            Console.WriteLine("Aqui está o maior valor: " + maximo);

            double media = filtro.Average();

            Console.WriteLine("Aqui está a média dos valores: " + media);
            
        }
    }
}
