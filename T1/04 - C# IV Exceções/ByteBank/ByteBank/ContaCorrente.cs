﻿//using _05_ByteBank;

using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        
        private double _saldo = 100;
        public static int TotalDeContasCriadas { get; private set; }
        public static double TaxaOperacao { get; private set; }

        public int Numero { get; }
        public int Agencia { get;  }
        public int ContSaqueNaoPermitidos { get; private set; }
        public int ContTransferenciasNaoPermitidos { get; private set; }

        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.",nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.",nameof(numero));
            }
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;

            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }


        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor invalido para saque ", nameof(valor));
            }

            if (_saldo < valor)
            {
                ContSaqueNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo,valor);

            }
            
            _saldo -= valor;
               
            
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
           
            if (valor < 0)
            {
                throw new ArgumentException("Valor invalido para transferencia. ", nameof(valor));
            }
            try
            {

                Sacar(valor);
            }
            catch(SaldoInsuficienteException e)
            {
                ContTransferenciasNaoPermitidos++;
                throw new OperaçãoFinanceiraException("Operação Não Realizada", e);
            }
            
            contaDestino.Depositar(valor);
            
        }
    }
}