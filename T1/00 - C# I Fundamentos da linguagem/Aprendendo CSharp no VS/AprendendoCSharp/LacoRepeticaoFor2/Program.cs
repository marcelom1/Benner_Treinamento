using System;

namespace LacoRepeticaoFor2
{
    class Program
    {
        static void Main(string[] args)
        {
            //imprimindo uma matriz triangular

            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna <=linha; coluna++)
                {
                   
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
