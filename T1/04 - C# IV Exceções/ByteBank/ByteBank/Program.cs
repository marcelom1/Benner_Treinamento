using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.StackTrace);
                Console.WriteLine("Aconteceu um erro - Impossivel efetuar divisão por ZERO!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.ReadLine();
        }
        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            
                int resultado = Dividir(10, divisor);
                Console.WriteLine("Resultado da divisão de 10 por " + " é " + resultado);
           
        }

        private static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
                throw;
            }
        }
    }
}
