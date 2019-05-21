using System;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000.00;
            int cont = 1;
            while (cont <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + cont + " meses, você terá R$" + valorInvestido);
                cont++;
            }
            Console.ReadLine();
        }
    }
}
