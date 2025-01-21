namespace EX008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("digite um numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O numero é par");
            }
            else
            {
                Console.WriteLine("O numero é impar");
            }


        }
    }
}
