using System;

namespace questao_5
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine("Insira sua frase ou palavra para ser revertida: ");

        string str = Console.ReadLine();

        char[] chars = str.ToCharArray();  
        for (int i = 0, j = str.Length - 1; i < j; i++, j--) {  
        char c = chars[i];  
        chars[i] = chars[j];  
        chars[j] = c;  
        }

        Console.WriteLine(chars);
            
        }
        
    }
}
