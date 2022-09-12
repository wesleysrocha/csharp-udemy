using System;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, diferenca;

            Console.WriteLine("Diferença do produto de quatro valores \n");

            Console.Write("Digite o primeiro valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            n3 = int.Parse(Console.ReadLine());
            Console.Write("Digite o quarto valor: ");
            n4 = int.Parse(Console.ReadLine());    
            
            diferenca = n1 * n2 - n3 * n4;

            Console.WriteLine("\nA diferença é: " + diferenca);            
        }
    }
}