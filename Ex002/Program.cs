namespace Ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 2;
            float num = 2.35f;
            char letra = 'c';
            string nome = "Daniela";

            Console.WriteLine("A número é {0}.",numero);
            Console.WriteLine("O valor é R${0}.",num);
            Console.WriteLine("A letra é {0}.",letra);
            Console.WriteLine("O seu nome é {0}.",nome);

            Console.WriteLine("O número é {0}, o valor é R${1}, a letra é {2} e o seu é {3}", numero, num, letra, nome);



        }
    }
}
