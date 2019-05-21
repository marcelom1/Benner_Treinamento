using System;

namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            conta.Saldo = 10;

            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
