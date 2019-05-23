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
            catch (DivideByZeroException erro)
            {
                Console.WriteLine(erro.StackTrace);
                Console.WriteLine("Aconteceu um erro - Impossivel efetuar divisão por ZERO!");
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
                Console.WriteLine(erro.StackTrace);
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
            ContaCorrente conta = null;
            Console.WriteLine(conta.Saldo);
            return numero / divisor;
        }
    }
}
