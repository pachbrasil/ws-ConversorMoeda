using System;
using System.Globalization;

namespace Segundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotacao do dolar?");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar?");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.ValorReal(valor, cot);

            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
