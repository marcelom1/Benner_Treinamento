using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class ICCC : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.valor < 1000)
            {
                return orcamento.valor * 0.05;
            }
            else if(orcamento.valor<=3000)
            {
                return orcamento.valor * 0.07;
            }else
            {
                return orcamento.valor * 0.08 + 30;
            }
        }
    }
}
