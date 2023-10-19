using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));


            Console.WriteLine("Area do triangulo X: " + areaX);
            Console.WriteLine("Area do triangulo Y: " + areaY);

            Pessoa primeiraPessoa = new Pessoa();
            Pessoa segundaPessoa = new Pessoa();

            Console.WriteLine("Inserir dados da primeira pessoa: ");
            Console.Write("Nome: ");
            primeiraPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            primeiraPessoa.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Inserir dados da segunda pessoa: ");
            Console.Write("Nome: ");
            segundaPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            segundaPessoa.Idade = int.Parse(Console.ReadLine());

            if (primeiraPessoa.Idade > segundaPessoa.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {primeiraPessoa.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {segundaPessoa.Nome}");
            }
            Console.WriteLine();*/

            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X: ");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();


            Console.WriteLine("Area do triangulo X: " + areaX);
            Console.WriteLine("Area do triangulo Y: " + areaY);
            Console.Read();
        }
    }
}