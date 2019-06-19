using System;
using System.Collections.Generic;

namespace Encapsulamento
{
    public class Fatura
    {
        public string Cliente { get; private set; }

        private IList<Pagamento> pagamentos;
        public double Valor { get; internal set; }
        public bool Pago { get; internal set; }

        public Fatura (string cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.pagamentos = new List<Pagamento>();
            this.Pago = false;
            
        }

        public void AdicionaPagamento(Pagamento pagamento)
        {
            this.pagamentos.Add(pagamento);
            
            if (valorTotalDosPagamentos() <= Valor)
            {
               
                this.Pago = true;
            }
        }

        private double valorTotalDosPagamentos()
        {
            double total = 0;
            foreach(Pagamento pag in pagamentos)
            {
                total += pag.Valor;
            }
            return total;

        }
    }
}