namespace ex014
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma, quant;

            soma = quant = 0;

         
            for (int i = 0; i<=500; i++)
            {
                if(i % 3== 0)
                {
                    soma += i;
                    quant++;
                }
                
            }
            Console.Write("A soma dos valores informados é:{1}.", quant, soma);
        }
    }
}
