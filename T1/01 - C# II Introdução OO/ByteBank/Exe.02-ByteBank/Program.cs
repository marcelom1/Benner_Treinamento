using System;

namespace Exe._02_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.titular = new Cliente();

            conta.titular.nome = "Gabriele";

            Console.WriteLine(conta.titular.nome);

            Console.ReadLine();
        }
    }
}
