namespace ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o salário do funcionário: R$");
            double salario = Convert.ToDouble(Console.ReadLine());

            double aumento = 0;
            double novosalario = 0;

            if (salario > 2500)
            {
                aumento = salario * 0.05;
            }
            else if (salario > 1250)
            {
                aumento = salario * 0.10;

            }
            else 
            {
                aumento = salario * 0.15;
                    
            }
            novosalario = salario + aumento;

            Console.WriteLine($"O valor do aumento é: R${aumento:0}");
            Console.WriteLine($"O novo salário será: R${novosalario:0}");
        }  
                 


       
    }
}
