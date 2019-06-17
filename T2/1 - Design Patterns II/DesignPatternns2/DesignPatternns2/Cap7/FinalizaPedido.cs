using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternns2.Cap7
{
    public class FinalizaPedido : IComando
    {
        private Pedido pedido;

        public FinalizaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine("Finalizando o pedido do cliente {0}", pedido.Cliente);
            pedido.Finaliza();
        }
    }
}
