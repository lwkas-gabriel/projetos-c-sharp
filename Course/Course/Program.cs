using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contaNova;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá deposito inicial? (s/n)");
            char resp = char.Parse(Console.ReadLine());

            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Digite o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaNova = new ContaBancaria(numero, titular, depositoInicial);
            }
            else
            {
                contaNova = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(contaNova);

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);

            contaNova.Deposito(deposito);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaNova);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            contaNova.Saque(deposito);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(contaNova);

            Console.Read();

        }
    }
}