using System;

namespace Lista21082017ex11
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            decimal salarioFixo, valorVendas, salarioTotal, valorAcima;

            Console.WriteLine("Digite o salário fixo do vendedor: ");
            salarioFixo = Convert.ToDecimal(Console.ReadLine());

			Console.WriteLine("Digite o valor total das vendas: ");
			valorVendas = Convert.ToDecimal(Console.ReadLine());

            if (valorVendas <= 1500m)
            {
                salarioTotal = salarioFixo + (valorVendas * 0.03m);
                Console.WriteLine("O salário total do vendedor é R$ {0:###,##0.00}", salarioTotal);
            } else {
                valorAcima = valorVendas - 1500m;
                salarioTotal = salarioFixo + (1500m * 0.03m) + (valorAcima * 0.05m);
                Console.WriteLine("O salário total do vendedor é R$ {0:###,##0.00}", salarioTotal);
            }

            Console.ReadKey();
        }
    }
}
