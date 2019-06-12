using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public string Nome { get; private set; }

        public DateTime DataAbertura { get; private set; }

        public Conta(double saldo, string nome)
        {
            Saldo = saldo;
            Nome = nome;
            DataAbertura = DateTime.Now;
        }

        public Conta(double saldo)
        {
            Saldo = saldo;

        }

        public void Deposita(double valor)
        {
            this.Saldo += valor;
        }

    }
}
