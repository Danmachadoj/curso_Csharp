using System.Diagnostics.CodeAnalysis;

namespace Ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            float num4, num5;

            Console.WriteLine("Digite um número");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número");
            num2 = Convert.ToInt32(Console.ReadLine()); ;
            
            num3 =num1 + num2;

            Console.WriteLine("A soma de {0} + {1} = {2}", num1, num2, num3);

            num3 = num1 - num2;

            Console.WriteLine("A subtração de {0} - {1} = {2}", num1, num2, num3);

            num3 = num1 * num2;

            Console.WriteLine("A multiplicação de {0} * {1} = {2}", num1, num2, num3);

            num3 = num1 / num2;

            Console.WriteLine("A divisão de {0} / {1} = {2}", num1, num2, num3);

            num3 = num1 % num2;

            Console.WriteLine("O resto da divisão de {0} % {1} = {2}", num1, num2, num3);

            num4 = 35f;

            num5 = num1 / num4;

            Console.WriteLine("A divisão de {0} / {1} = {2}", num1, num4, num5);



        }
    }
}
