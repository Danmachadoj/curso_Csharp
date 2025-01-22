namespace ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorCasa, salario, prestacaoMensal;
            int anosEmprestimo, mesesEmprestimo;

            Console.Write("Digite o valor da casa: R$");
            valorCasa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o salario do comprador: R$");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite anos de emprestimo:");
            anosEmprestimo = Convert.ToInt32(Console.ReadLine());

            mesesEmprestimo = anosEmprestimo * 12;
            prestacaoMensal = valorCasa / mesesEmprestimo;

            if (prestacaoMensal > salario * 0.30)
            {
                Console.WriteLine("emprestimo aceito");
                Console.WriteLine("parcelas: {0}", mesesEmprestimo);
                Console.WriteLine("valor: {0}", prestacaoMensal);

            }
            else
            {
                Console.WriteLine("emprestimo negado");
                Console.WriteLine("o valor da prestação excede 30% do salario");
            }
        }
    }
}
