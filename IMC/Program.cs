namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine($"Seu IMC é: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Você está abaixo do peso.");
            }
            else if (imc >= 18.5 && imc < 24.9)
            {
                Console.WriteLine("Você está com peso normal.");
            }
            else if (imc >= 25 && imc < 29.9)
            {
                Console.WriteLine("Você está com sobrepeso.");
            }
            else if (imc >= 30 && imc < 34.9)
            {
                Console.WriteLine("Você está com obesidade grau 1.");
            }
            else if (imc >= 35 && imc < 39.9)
            {
                Console.WriteLine("Você está com obesidade grau 2.");
            }
            else
            {
                Console.WriteLine("Você está com obesidade grau 3 (obesidade mórbida).");
            }
        }
    }
}
