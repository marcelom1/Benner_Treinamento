using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao
{
    public class ContaComum
    {
        private ManipuladorDeSaldo manipulador;

        public ContaComum()
        {
            this.manipulador = new ManipuladorDeSaldo();
        }

        public virtual void Deposita(double valor)
        {
            manipulador.Deposita(valor);

        }

        public void Saca(double valor)
        {
            manipulador.Saca(valor);
        }

        public void somaInvestimento()
        {
            this.manipulador.SomaInvestimento(1.1);
        }

        public double Saldo()
        {
            return manipulador.Saldo;
        }
    }
}
