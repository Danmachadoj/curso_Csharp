namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool mostrar = false;

            Console.WriteLine("Digite um número inteiro:");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Deseja ver o calculo? (s/n)");
            string resposta = Console.ReadLine().ToLower();
            Console.WriteLine();

            if (resposta == "s") { mostrar = true; }

            Console.WriteLine(fatorial(numero, mostrar));
        }

        static int fatorial(int n, bool show = false)
        {
            int f = 1;
            for (int i = n; i > 0; i--)
            {                
                if (show)
                {
                    Console.Write(i + " ");
                    if (i > 1)
                    {
                        Console.Write("x ");
                    }
                    else
                    {
                        Console.Write("= ");
                    }
                }
                f *= i;                
            }
            return f;
        }
    }
}






            
              

      
      
