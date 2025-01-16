namespace Ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.WriteLine("Qual a média do aluno?");
            num1 = Convert.ToInt32(Console.ReadLine());

            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = (num1 + num2) / 2;
            
        }
    }
}
