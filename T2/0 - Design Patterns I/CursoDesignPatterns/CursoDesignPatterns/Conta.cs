using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Conta
    {
        public double Saldo { get;set; }
        public string Nome { get; private set; }

        public DateTime DataAbertura { get; private set; }
        internal EstadoDeUmaConta Estado { get; set; }

        public Conta(double saldo, string nome)
        {
            Saldo = saldo;
            Nome = nome;
            DataAbertura = DateTime.Now;
          
            Estado = new Positiva();
            
        }

        public Conta(double saldo)
        {
            Saldo = saldo;

        }

       

        public void Saca(double valor)
        {
            Estado.Saca(this, valor);
        }

        public void Deposita(double valor)
        {
            Estado.Deposita(this, valor);
        }

    }
}
