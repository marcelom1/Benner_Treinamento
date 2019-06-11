using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class RelatorioSimples : Relatorio
    {
        public override void cabecalho()
        {
            Console.WriteLine("Banco: PMG Bank "+" (47)3332-3333");
        }

        public override void corpo(IList<Conta> contas)
        {
            Console.WriteLine("\n\n");
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Nome + " - " + c.Saldo);
            }
            Console.WriteLine("\n\n");
        }

        public override void Impressao(IList<Conta> contas)
        {
            cabecalho();
            corpo(contas);
            rodape();
        }

        public override void rodape()
        {
            Console.WriteLine("Banco: PMG Bank " + " (47)3332-3333");
        }
    }
}
