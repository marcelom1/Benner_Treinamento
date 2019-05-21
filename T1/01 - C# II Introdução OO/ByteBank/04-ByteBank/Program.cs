using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente();
            contaBruno.titular = "Bruno";

            Console.WriteLine(contaBruno.saldo);

            bool resultado = contaBruno.Sacar(500);
            Console.WriteLine(contaBruno.saldo);
            Console.WriteLine(resultado);

            contaBruno.Depositar(500);
            Console.WriteLine(contaBruno.saldo);

            Console.ReadLine();
        }
    }
}
