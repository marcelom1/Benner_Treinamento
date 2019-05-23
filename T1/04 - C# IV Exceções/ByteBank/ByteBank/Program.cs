using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                ContaCorrente conta = new ContaCorrente(432, 1123);
                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(50);

                ContaCorrente conta2 = new ContaCorrente(421, 134);
                conta2.Transferir(-10, conta);
            }
            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(" catch (SaldoInsuficienteException )");
            }
            catch (ArgumentException e)
            {
                if (e.ParamName == "agencia")
                {
                    Console.WriteLine("Testando ParamName nas exceções");
                }
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(e.Message);
            }
            
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        

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
            TestaDivisao(2);
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
