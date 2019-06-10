using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class CorrenteXML : CorrenteArquivo
    {
        public CorrenteArquivo OutroResultado { get; set; }

        public CorrenteXML(CorrenteArquivo outroResultado)
        {
            OutroResultado = outroResultado;
        }

        public CorrenteXML()
        {
            OutroResultado = null;
        }

        public void Resultado(Requisicao req, Conta conta)
        {
            if (req.Formato== Formato.XML) 
            {
                Console.WriteLine("Arquivo XML");
            }
            else if (OutroResultado != null)
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
