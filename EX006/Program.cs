using System;

namespace EX006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double media, n1, n2;

            Console.Write("Digite a primeira nota:");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segundda nota:");
            n2 = Convert.ToDouble(Console.ReadLine());

            media = (n1 + n2) / 2;

            Console.Write("A média é: {0}", media);

        }
    }
    }