namespace CalculoArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============");
            Console.WriteLine("Controle de Terrenos");
            Console.WriteLine("=============");
            Console.WriteLine();

            Console.WriteLine("Digite a largura do terreno(m): ");
            double largura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite o comprimento do terreno(m): ");
            double comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            AreaTerreno(largura, comprimento);
        }
        static void AreaTerreno(double l, double c)
        {
            double a = l * c;
            Console.WriteLine($"A área do terreno é de {l}m x {c}m é de {a:F2}m² .");


        } 
    }
}
