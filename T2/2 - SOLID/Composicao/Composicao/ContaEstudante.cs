using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao
{
    public class ContaDeEstudante : ContaComum
    {
        private ManipuladorDeSaldo m;
        public int Milhas { get; private set; }

        public ContaDeEstudante()
        {
            m = new ManipuladorDeSaldo();
        }
        public override void Deposita(double valor)
        {
            m.Deposita(valor);
            this.Milhas += (int)valor;
        }
    }
}
