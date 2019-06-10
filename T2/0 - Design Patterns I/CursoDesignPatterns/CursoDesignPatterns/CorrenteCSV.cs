using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class CorrenteCSV : CorrenteArquivo
    {
        public CorrenteArquivo OutroResultado { get; set; }

        public void Resultado(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Nome+"|"+conta.Saldo);
            }
            else
            {
                OutroResultado.Resultado(req, conta);
            }
        }
    }

}