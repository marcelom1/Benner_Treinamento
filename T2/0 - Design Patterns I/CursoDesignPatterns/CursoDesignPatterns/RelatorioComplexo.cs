using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class RelatorioComplexo : Relatorio
    {
        public override void cabecalho()
        {
            Console.WriteLine("Banco: PMG Bank\n"+
                   "Rua, XI de Setembro 58, Centro - Blumenau-SC \n"+
                   "(47)3332-3333");
           
        }

        public override void corpo(IList<Conta> contas)
        {
            Console.WriteLine("\n\n");
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Nome + "5555" + "85454" + c.Saldo);
            }
            Console.WriteLine("\n\n");
        }

       

        public override void rodape()
        {
            Console.WriteLine ("atendimento@pmgbank.com.br - " +
                    DateTime.Now);

        }

        public override void Impressao(IList<Conta> contas)
        {
            cabecalho();
            corpo(contas);
            rodape();
        }


    }
}
