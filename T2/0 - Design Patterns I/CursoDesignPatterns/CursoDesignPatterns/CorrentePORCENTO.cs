using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class CorrentePORCENTO : CorrenteArquivo
    {
        public CorrenteArquivo OutroResultado { get; set; }

        public CorrentePORCENTO(CorrenteArquivo outroResultado)
        {
            OutroResultado = outroResultado;
        }
        public CorrentePORCENTO()
        {
            OutroResultado = null;
        }


        public void Resultado(Requisicao req, Conta conta)
        {
           
            if (req.Formato == Formato.PORCENTO)
            {
                Console.WriteLine(conta.Nome + "%" + conta.Saldo);
            }
            else
            {
                OutroResultado.Resultado(req, conta);
            }
        }
    }

}
