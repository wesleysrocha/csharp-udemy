using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, soma;

            Console.WriteLine("Soma de dois valores \n");
            Console.Write("Digite o primeiro valor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;

            Console.WriteLine("\nA soma de " + n1 + " + " + n2 + " = " + soma);
        }
    }
}