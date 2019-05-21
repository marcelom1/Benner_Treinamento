using System;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(333, 12345);
            
        
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Numero);

            Console.WriteLine("Quantidade de contas Criadas: " + ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
