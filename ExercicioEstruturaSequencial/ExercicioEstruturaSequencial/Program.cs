using System;
using System.Globalization;

namespace ExercicioEstruturaSequencial
{
    class Program
    {
        static void Main(string[] args)
        {
        //exercicio 1
            
            //int n1, n2, soma;

            //Console.WriteLine("Soma de dois valores \n");
            //Console.Write("Digite o primeiro valor: ");
            //n1 = int.Parse(Console.ReadLine());
            //Console.Write("Digite o segundo valor: ");
            //n2 = int.Parse(Console.ReadLine());

            //soma = n1 + n2;

            //Console.WriteLine("\nA soma de " + n1 + " + " + n2 + " = " + soma);
            

        //exercicio 2

            //double raio, area, pi = 3.14159;

            //Console.Write("Digite um raio para ser calculado: ");
            //raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //area = pi * raio * raio;

            //Console.WriteLine("\nArea do circulo = " + area.ToString("F4", CultureInfo.InvariantCulture));

        //exercicio 3

            // int n1, n2, n3, n4, diferenca;

            // Console.WriteLine("Diferença do produto de quatro valores \n");

            // Console.Write("Digite o primeiro valor: ");
            // n1 = int.Parse(Console.ReadLine());
            // Console.Write("Digite o segundo valor: ");
            // n2 = int.Parse(Console.ReadLine());
            // Console.Write("Digite o terceiro valor: ");
            // n3 = int.Parse(Console.ReadLine());
            // Console.Write("Digite o quarto valor: ");
            // n4 = int.Parse(Console.ReadLine());    

            // diferenca = n1 * n2 - n3 * n4;

            // Console.WriteLine("\nA diferença é: " + diferenca);

        //exercicio 4

            // double salario, valorHorasDia;
            // int numeroFuncionario, valorHoras;

            // Console.Write("Digite o número do funcionário: ");
            // numeroFuncionario = int.Parse(Console.ReadLine());

            // Console.Write("Digite o número de horas trabalhadas dia: ");
            // valorHoras = int.Parse(Console.ReadLine());

            // Console.Write("Digite o valor que recebe por dia: ");
            // valorHorasDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // salario = valorHorasDia * valorHoras;

            // Console.WriteLine("Número do funcionário é " + numeroFuncionario);
            // Console.WriteLine("Salário total mês é " + salario.ToString("F2", CultureInfo.InvariantCulture));


        //exercicio 5

            //int codigoPeca1, codigoPeca2, quantidadePeca1, quantidadePeca2;
            //double precoPeca1, precoPeca2, total;

            //Console.WriteLine("Digite o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1");
            //string[] valores = Console.ReadLine().Split(' ');
            //codigoPeca1 = int.Parse(valores[0]);
            //quantidadePeca1 = int.Parse(valores[1]);
            //precoPeca1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //Console.WriteLine("Digite o código de uma peça 2, o número de peças 2, o valor unitário de cada peça 2");
            //valores = Console.ReadLine().Split(' ');
            //codigoPeca2 = int.Parse(valores[0]);
            //quantidadePeca2 = int.Parse(valores[1]);
            //precoPeca2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //total = precoPeca1 * quantidadePeca1 + precoPeca2 * quantidadePeca2;

            //Console.WriteLine("total a pagar: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


        //exercicio 6

            // double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            // string[] valores = Console.ReadLine().Split(' ');
            // A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            // B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            // C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            // triangulo = A * C / 2.0;
            // circulo = 3.14159 * C * C;
            // trapezio = (A + B) / 2.0 * C;
            // quadrado = B * B;
            // retangulo = A * B;

            // Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            // Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            // Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            // Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            // Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));


        //EXERCICIO 6 condicional

            //Console.WriteLine("Digite um valor entre 0 e 100");

            //double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //if (numero < 0.0 || numero > 100.0)
            //{
            //    Console.WriteLine("Fora de intervalo");
            //}
            //else if (numero <= 25.0)
            //{
            //    Console.WriteLine("Intervalo [0,25]");
            //}
            //else if (numero <= 50.0)
            //{
            //    Console.WriteLine("Intervalo (25,50]");
            //}
            //else if (numero <= 75.0)
            //{
            //    Console.WriteLine("Intervalo (50,75]");
            //}
            //else
            //{
            //    Console.WriteLine("Intervalo (75,100]");


        //EXERCICIO 3 WHILE

            //Console.WriteLine("telemarketing posto de gasolina, qual é o seu pedido?");
            //Console.WriteLine("1 - digite alcool");
            //Console.WriteLine("2 - digite gasolina");
            //Console.WriteLine("3 - digite diesel");
            //int alcool = 0;
            //int gasolina = 0;
            //int diesel = 0;

            //int tipo = int.Parse(Console.ReadLine());

            //while (tipo != 4)
            //{
            //    if (tipo == 1)
            //    {
            //        alcool++;
            //    }
            //    else if (tipo == 2)
            //    {
            //        gasolina++;
            //    }
            //    else if (tipo == 3)
            //    {
            //        diesel++;
            //    }
            //    Console.WriteLine("algo mais? Senão precione 4");
            //    tipo = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("MUITO OBRIGADO");
            //Console.WriteLine("Alcool: " + alcool);
            //Console.WriteLine("Gasolina: " + gasolina);
            //Console.WriteLine("Diesel: " + diesel);


        //EXERCICIO 6 FOR

            Console.WriteLine("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Todos os divisores possíveis de " + n + ":");

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");

                }
            }
        }
    }
}