using System;

namespace P13_ForEncadeado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Objetivo
            // *
            // **
            // ***
            // ****
            // *****
            // ******
            // *******
            // ********
            // *********
            // **********

            //Forma 1
            for (int contLinha = 0; contLinha < 10; contLinha++)
            {
                for (int contColuna = 0; contColuna<10; contColuna++)
                {
                    Console.Write('*');
                    if (contColuna >= contLinha)
                    {
                        break;
                    }


                }
                Console.WriteLine();
            }

            //Forma 2
          
            for (int contLinha = 0; contLinha < 10; contLinha++)
            {
                for (int contColuna = 0; contColuna <= contLinha; contColuna++)
                {
                    Console.Write('*');
                  

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
