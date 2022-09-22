using System;
using System.Globalization;
using ExercicioEstruturaSequencial.Entities;
using ExercicioEstruturaSequencial.Entities.Exceptions;


namespace ExercicioEstruturaSequencial
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserira os dados da conta");
            Console.Write("Número da conta: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Nome do titular: ");
            String holder = Console.ReadLine();
            Console.Write("Saldo inicial: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Limite de saque: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account acc = new Account(number, holder, balance, withdrawLimit);

            Console.Write("\nDigite o valor a ser sacado: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                acc.Withdraw(amount);
                Console.WriteLine("Saldo atual: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro ao sacar: " + e.Message);
            }
        }
    }
}
