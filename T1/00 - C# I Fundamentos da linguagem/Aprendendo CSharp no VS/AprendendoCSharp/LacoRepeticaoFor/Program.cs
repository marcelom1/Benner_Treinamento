using System;

namespace LacoRepeticaoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um for encadeado que imprima a tabuada de cada número

            for (int mult = 1; mult<=10;mult++)
            {
                for(int cont = 0; cont <= 10; cont++){
                    Console.WriteLine(mult + " * " + cont + " = " + mult * cont);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
