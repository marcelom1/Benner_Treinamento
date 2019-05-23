﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class SaldoInsuficienteException : OperaçãoFinanceiraException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }
        public SaldoInsuficienteException()
        {

        }
        public SaldoInsuficienteException(double saldo, double valorSaque) : this("Tentativa de saque no valor de " + valorSaque + " em uma conta com saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInsuficienteException(string frase) : base(frase)
        {

        }

        public SaldoInsuficienteException(string frase, Exception excecaoInterna) : base(frase, excecaoInterna)
        {
        }
    }
}
