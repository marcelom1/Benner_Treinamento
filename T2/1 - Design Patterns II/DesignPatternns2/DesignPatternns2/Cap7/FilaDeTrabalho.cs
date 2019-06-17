using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternns2.Cap7
{
    public class FilaDeTrabalho
    {
        private IList<IComando> comandos = new List<IComando>();

        public void Adiciona(IComando comando)
        {
            comandos.Add(comando);
        }

        public void Processa()
        {
            foreach (IComando comando in comandos)
            {
                comando.Executa();
            }
        }
    }
}
