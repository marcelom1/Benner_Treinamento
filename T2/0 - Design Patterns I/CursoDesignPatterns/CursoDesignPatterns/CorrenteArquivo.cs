using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    interface CorrenteArquivo
    {
        void Resultado(Requisicao req, Conta conta);
        CorrenteArquivo OutroResultado { get; set; }
    }
}
