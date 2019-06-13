using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class Negativa : EstadoDeUmaConta
    {
        public void Saca(Conta conta, double valor)
        {
            Console.WriteLine("Impossivel efetuar saque com a conta negativa!");
        }

        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if (conta.Saldo > 0)
            {
                conta.Estado = new Positiva();

            }
        }

        
    }
}
