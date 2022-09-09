using System;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area, pi = 3.14159;

            Console.Write("Digite um raio para ser calculado: ");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = pi * raio * raio;

            Console.WriteLine("\nArea do circulo = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}