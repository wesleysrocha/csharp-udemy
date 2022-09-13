using System;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIO 3 WHILE
            Console.WriteLine("telemarketing posto de gasolina, qual é o seu pedido?");
            Console.WriteLine("1 - digite alcool");
            Console.WriteLine("2 - digite gasolina");
            Console.WriteLine("3 - digite diesel");
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            int tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool++;
                }
                else if (tipo == 2)
                {
                    gasolina++;
                }
                else if (tipo == 3)
                {
                    diesel++;
                }
                Console.WriteLine("algo mais? Senão precione 4");
                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}