using System;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorInvestido = 1000.00;
            for (int cont=1;cont<=12; cont++)
            {
                valorInvestido *= 1.0036;
                Console.WriteLine("Após " + cont + " meses, você terá R$" + valorInvestido);
                
            }
            Console.ReadLine();
        }
    }
}
