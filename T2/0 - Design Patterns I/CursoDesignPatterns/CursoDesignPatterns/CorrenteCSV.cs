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

        public CorrenteCSV(CorrenteArquivo outroResultado)
        {
            OutroResultado = outroResultado;
        }

        public CorrenteCSV()
        {
            OutroResultado = null;
        }

        public void Resultado(Requisicao req, Conta conta)
        {
            
            if (req.Formato == Formato.CSV)
            {
                Console.WriteLine(conta.Nome+";"+conta.Saldo);
            }
            else if (OutroResultado!=null)
            {
                OutroResultado.Resultado(req, conta);
            }
            else
            {
                Console.WriteLine("Tipo de Arquivo Não encontrato");
            }
        }
    }

}