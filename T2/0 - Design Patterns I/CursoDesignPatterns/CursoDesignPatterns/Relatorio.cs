using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public abstract class Relatorio
    {
        public abstract void cabecalho();
        public abstract void corpo(IList<Conta> contas);
        public abstract void rodape();

        public abstract void Impressao(IList<Conta> contas);
    }
}
