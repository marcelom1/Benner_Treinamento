using System;

namespace P12_CalInvestLongPra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12");
            double valorInvestido = 1000.00;
            double fatorRendimento = 1.0036;

            for (int cont1 = 1; cont1 <= 5; cont1++)
            {
                for (int cont2 = 1; cont2 <= 12; cont2++)
                {
                    valorInvestido *= fatorRendimento;
               

                }
                fatorRendimento += 0.0010;
            }
            Console.WriteLine("Ao término do investimento, você terá R$" + valorInvestido);
            Console.ReadLine();
        }
    }
}
