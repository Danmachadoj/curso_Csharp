﻿namespace Ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final = 50;
            string resultado;

            if (nota_final >= 60)
            {
                resultado = "Aprovado";
            }
            else if (nota_final>= 40)
            {
                resultado = "Recuperação";
            }

            else
            {
                resultado = "reprovado";
            }

            Console.WriteLine("O aluno foi {0}.", resultado);
        }
    }
}
