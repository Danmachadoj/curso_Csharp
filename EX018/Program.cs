using System;

namespace EX018
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123";
            string senhaDigitada;

            do
            {
                Console.Write("Digite a senha: ");
                senhaDigitada = Console.ReadLine();

            } while (senhaDigitada != senha);

            Console.WriteLine("Senha correta");




        }
    }
}
