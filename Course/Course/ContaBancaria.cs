using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            this.Titular = titular;
            this.NumeroConta = numero;
            //se não informado, o saldo eh inicializado com 0.0
        }

        public ContaBancaria(int numero, string titular, double saldo): this(numero, titular)
        {
            Deposito(saldo);
        }

        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

        public void Saque(double quantia)
        {
            // o saque possui taxa de 5 dinheiros
            if (quantia < 0)
            {
                Console.WriteLine("Entrada invalida!");
            }
            else if (quantia + 5.0 > this.Saldo)
            {
                Console.WriteLine("Você não tem saldo suficiente para realizar essa operação!");
            }
            else
            {
                this.Saldo -= quantia + 5;
            }
        }

        public void Deposito(double quantia)
        {
            this.Saldo += quantia;
        }
    }
}
