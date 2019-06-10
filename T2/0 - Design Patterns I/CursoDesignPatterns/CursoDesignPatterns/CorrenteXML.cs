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

        public void Resultado(Requisicao req, Conta conta)
        {
            if (req.Formato== Formato.XML) 
            {
                Console.WriteLine("Arquivo XML");
            }
            else
            {
                OutroResultado.Resultado(req, conta);
            }
        }
    }
    
}
