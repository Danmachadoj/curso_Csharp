namespace Areadotriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================");
            Console.WriteLine("Calculo de Area do Triangulo");
            Console.WriteLine("============================");
            Console.WriteLine();

            Console.WriteLine("Digite a base do triangulo(m): ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a altura do triangulo(m): ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            AreaTriangulo(b, h);

        }

        static void AreaTriangulo(double b, double h)
        {
            double a = (b * h) / 2;
            Console.WriteLine($"A área do triangulo é de {b}m x {h}m é de {a:F2}m² .");
        }
    }
}
