using System;

namespace Exe_03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            Cliente cliente  = new Cliente();

            cliente.Nome = "Marcelo";
            cliente.Cpf = "938.000.332-71";
            cliente.Profissao = "Estagiario";




            conta.Saldo = 10;

            Console.WriteLine(conta.Saldo);

            Console.ReadLine();
        }
    }
}
