using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe._01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente primeiraContaCorrente = new ContaCorrente();
            primeiraContaCorrente.saldo = 200;
            Console.WriteLine(primeiraContaCorrente.saldo);

            primeiraContaCorrente.saldo += 100;
            Console.WriteLine(primeiraContaCorrente.saldo);

            ContaCorrente segundaContaCorrente = new ContaCorrente();
            segundaContaCorrente.saldo = 50;

            Console.WriteLine("Primeira conta tem " + primeiraContaCorrente.saldo);
            Console.WriteLine("Segunda conta tem " + segundaContaCorrente.saldo);

            Console.ReadLine();

        }
    }
}
