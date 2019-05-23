using System;
using System.IO;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CarregarContas();
            }
            catch (Exception)
            {
                Console.WriteLine("CATCH NO METODO MAIN");
            }

            Console.ReadLine();
        }
        private static void CarregarContas()
        {

            using (LeitorDeArquivo leitor =new LeitorDeArquivo("teste.txt"))
            {
                leitor.LerProximaLinha();
            }


            //LeitorDeArquivo leitor = null;

            //try
            //{
            //    leitor = new LeitorDeArquivo("conta.txt");
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();
            //    leitor.LerProximaLinha();


                
            //}
            //catch(IOException)
            //{
                
            //    Console.WriteLine("Exceção do tipi IOException capturada e tratada");
            //}
            //finally
            //{
            //    if (leitor!=null)
            //        leitor.Fechar();
            //}
        }

        private static void TestaInnerException()
        {
            
            try
            {
                ContaCorrente conta = new ContaCorrente(432, 1123);
                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(50);

                ContaCorrente conta2 = new ContaCorrente(421, 134);
                conta2.Transferir(1000, conta);
                conta.Sacar(10000);
            }

            catch (SaldoInsuficienteException e)
            {
                Console.WriteLine(e.Saldo);
                Console.WriteLine(e.ValorSaque);

                Console.WriteLine(e.StackTrace);

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
            
            catch (OperaçãoFinanceiraException e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

               // Console.WriteLine("\nInformações do Inner Exception: \n");
              //  Console.WriteLine(e.InnerException.Message);
              //  Console.WriteLine(e.InnerException.StackTrace);

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
