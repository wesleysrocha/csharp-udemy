using System;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, valorHorasDia;
            int numeroFuncionario, valorHoras;

            Console.Write("Digite o número do funcionário: ");
            numeroFuncionario = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de horas trabalhadas dia: ");
            valorHoras = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor que recebe por dia: ");
            valorHorasDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHorasDia * valorHoras;

            Console.WriteLine("Número do funcionário é " + numeroFuncionario);
            Console.WriteLine("Salário total mês é " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}