using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternns2.Cap6
{
    public class MensagemCliente : IMensagem
    {
        private string nome;

        public IEnviador Enviador { get; set; }

        public MensagemCliente(String nome)
        {
            this.nome = nome;
        }

        public string Formata()
        {
            return String.Format("Mensagem para o cliente {0}", nome);
        }

        public void Envia()
        {
            this.Enviador.Envia(this);
        }
    }
}
