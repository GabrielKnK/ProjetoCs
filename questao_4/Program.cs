using System;

namespace questao_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double SP = 67836.43;
            double MG = 36678.66;
            double ES = 29229.88;
            double Outros = 19849.53;

            double Total = SP + MG + ES + Outros;

            double PercentualSP = (SP / Total) * 100;
            double PercentualMG = (MG / Total) * 100;
            double PercentualES = (ES / Total) * 100;
            double PercentualOutros = (Outros / Total) * 100;

            Console.WriteLine("Aqui estão os percentuais de cada estado em relação ao valor total: ");
            Console.WriteLine("- São Paulo: " + PercentualSP);
            Console.WriteLine("- Minas Gerais: " + PercentualMG);
            Console.WriteLine("- Espírito Santo: " + PercentualES);
            Console.WriteLine("- Outros: " + PercentualOutros);
            

        }
    }
}
