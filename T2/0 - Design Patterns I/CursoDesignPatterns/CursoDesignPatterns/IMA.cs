using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    class IMA :Imposto
    {
        public IMA(Imposto outroImposto) : base(outroImposto) { }
        public IMA() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.20 + CalculoDoOutroImposto(orcamento);
        }
    }
}
