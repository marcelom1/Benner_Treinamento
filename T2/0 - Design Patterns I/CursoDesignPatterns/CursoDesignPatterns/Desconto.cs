using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    public interface Desconto
    {
        Desconto Proximo { get; set; }
        double Desconta(Orcamento orcamento);
    }
}
