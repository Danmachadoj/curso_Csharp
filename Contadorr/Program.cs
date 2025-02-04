using System.Reflection.PortableExecutable;

namespace Contadorr
{
    internal class Program
    {
        static void Contador(int inicio, int fim, int passo)
        {
            Escrever($Contagem de { inicio} até { fim } de { passo } em { passo });
            Thread.Sleep(2000);

            if (inicio< fim ) 
            {
                int cont = inicio;
                while (cont <= fim)
                {
                    Console.Write($"{cont} ");
                    Thread.Sleep(500);
                    cont += passo;
                }
                Console.WriteLine("Fim!");

            }
            else
            {
                int cont = inicio;
                while (cont >= fim)
                {
                    Console.Write($"{cont} ");
                    Thread.Sleep(500);
                    cont -= passo;
                }
                Console.WriteLine("Fim!");
            }


        }
}
